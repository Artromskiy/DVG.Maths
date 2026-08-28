using System.Reflection;
using System.Text.Json;

namespace Delta.Maths.Conformance;

internal static class ShaderContractConformance
{
    private const string ManifestFileName = "shader-contract.json";

    public static void Run()
    {
        var manifest = LoadContractManifest();
        ValidateCaseCoverage(manifest.SupportedFunctions);

        var runner = new ContractCaseRunner(manifest.SupportedFunctions, typeof(float2).Assembly);
        GeneratedShaderContractCases.RunAll(runner);

        if (runner.ExecutedCount != manifest.SupportedFunctions.Count)
        {
            throw new InvalidOperationException(
                $"Contract execution count mismatch: expected {manifest.SupportedFunctions.Count}, got {runner.ExecutedCount}.");
        }
    }

    internal static ContractManifest LoadContractManifest()
    {
        using var document = JsonDocument.Parse(LoadManifest());
        var functions = ReadSupportedFunctions(document.RootElement);
        var allFunctions = document.RootElement.GetProperty("functions");
        var unsupportedCount = 0;

        foreach (var function in allFunctions.EnumerateArray())
        {
            if (string.Equals(function.GetProperty("mapping").GetString(), "Unsupported", StringComparison.Ordinal))
            {
                unsupportedCount++;
            }
        }

        return new ContractManifest(
            document.RootElement.GetProperty("schemaVersion").GetString()
                ?? throw new InvalidOperationException("The contract has no schema version."),
            document.RootElement.GetProperty("namespace").GetString()
                ?? throw new InvalidOperationException("The contract has no namespace."),
            allFunctions.GetArrayLength(),
            unsupportedCount,
            functions);
    }

    private static string LoadManifest()
    {
        var outputPath = Path.Combine(AppContext.BaseDirectory, ManifestFileName);
        if (File.Exists(outputPath))
        {
            return File.ReadAllText(outputPath);
        }

        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            var repositoryPath = Path.Combine(directory.FullName, "Vectors", ManifestFileName);
            if (File.Exists(repositoryPath))
            {
                return File.ReadAllText(repositoryPath);
            }

            directory = directory.Parent;
        }

        throw new FileNotFoundException($"Could not locate {ManifestFileName}.");
    }

    private static List<ContractFunction> ReadSupportedFunctions(JsonElement root)
    {
        var functions = new List<ContractFunction>();
        foreach (var element in root.GetProperty("functions").EnumerateArray())
        {
            var mapping = element.GetProperty("mapping").GetString();
            if (string.Equals(mapping, "Unsupported", StringComparison.Ordinal))
            {
                continue;
            }

            functions.Add(
                new ContractFunction(
                    element.GetProperty("identity").GetString()
                        ?? throw new InvalidOperationException("A contract function has no identity."),
                    element.GetProperty("typeClrName").GetString()
                        ?? throw new InvalidOperationException("A contract function has no owner type."),
                    element.GetProperty("clrName").GetString()
                        ?? throw new InvalidOperationException("A contract function has no CLR name."),
                    ReadStrings(element.GetProperty("parameterClrNames")),
                    element.GetProperty("returnClrName").GetString()
                        ?? throw new InvalidOperationException("A contract function has no return type."),
                    mapping
                        ?? throw new InvalidOperationException("A contract function has no mapping."),
                    element.TryGetProperty("requiredCapability", out var capabilityElement)
                        ? capabilityElement.GetString()
                        : null,
                    element.TryGetProperty("stages", out var stagesElement)
                        ? ReadStrings(stagesElement)
                        : Array.Empty<string>()));
        }

        return functions;
    }

    private static string[] ReadStrings(JsonElement element)
    {
        var values = new string[element.GetArrayLength()];
        var index = 0;
        foreach (var value in element.EnumerateArray())
        {
            values[index++] = value.GetString()
                ?? throw new InvalidOperationException("A contract type name is null.");
        }

        return values;
    }

    private static void ValidateCaseCoverage(IReadOnlyList<ContractFunction> functions)
    {
        if (GeneratedShaderContractCases.Count != GeneratedShaderContractCases.Identities.Length)
        {
            throw new InvalidOperationException("Generated contract case count is inconsistent.");
        }

        var manifestIdentities = new HashSet<string>(StringComparer.Ordinal);
        foreach (var function in functions)
        {
            if (!manifestIdentities.Add(function.Identity))
            {
                throw new InvalidOperationException($"Duplicate supported manifest identity: {function.Identity}");
            }
        }

        var caseIdentities = new HashSet<string>(StringComparer.Ordinal);
        foreach (var identity in GeneratedShaderContractCases.Identities)
        {
            if (!caseIdentities.Add(identity))
            {
                throw new InvalidOperationException($"Duplicate generated conformance case: {identity}");
            }
        }

        var missing = manifestIdentities.Except(caseIdentities, StringComparer.Ordinal).ToArray();
        if (missing.Length != 0)
        {
            throw new InvalidOperationException(
                $"Supported manifest overloads without conformance cases: {string.Join(", ", missing)}");
        }

        var extra = caseIdentities.Except(manifestIdentities, StringComparer.Ordinal).ToArray();
        if (extra.Length != 0)
        {
            throw new InvalidOperationException(
                $"Conformance cases not present as supported manifest overloads: {string.Join(", ", extra)}");
        }
    }
}

internal sealed record ContractFunction(
    string Identity,
    string OwnerTypeName,
    string MethodName,
    string[] ParameterTypeNames,
    string ReturnTypeName,
    string Mapping,
    string? RequiredCapability,
    string[] Stages);

internal sealed record ContractManifest(
    string SchemaVersion,
    string Namespace,
    int TotalFunctionCount,
    int UnsupportedFunctionCount,
    IReadOnlyList<ContractFunction> SupportedFunctions);

internal sealed record ContractInvocation(
    ContractFunction Function,
    MethodInfo Method,
    ParameterInfo[] Parameters,
    object?[] InputArguments,
    object?[] Arguments,
    object? Result);

internal sealed class ContractCaseRunner
{
    private readonly Dictionary<string, ContractFunction> _functions;
    private readonly Assembly _mathAssembly;

    public ContractCaseRunner(IReadOnlyList<ContractFunction> functions, Assembly mathAssembly)
    {
        _functions = functions.ToDictionary(function => function.Identity, StringComparer.Ordinal);
        _mathAssembly = mathAssembly;
    }

    public int ExecutedCount { get; private set; }

    public void Run(string identity)
    {
        var invocation = Evaluate(identity);
        ContractCaseRunner.ValidateResult(invocation.Function, invocation.Result);
        ExecutedCount++;
    }

    internal ContractInvocation Evaluate(string identity)
    {
        if (!_functions.TryGetValue(identity, out var function))
        {
            throw new InvalidOperationException($"Conformance case is not supported by the manifest: {identity}");
        }

        return Evaluate(function);
    }

    internal ContractInvocation Evaluate(ContractFunction function)
    {
        var method = ResolveMethod(function);
        var parameters = method.GetParameters();
        var arguments = CreateArguments(function, parameters);
        var inputArguments = (object?[])arguments.Clone();
        var result = Invoke(function, method, arguments);

        return new ContractInvocation(function, method, parameters, inputArguments, arguments, result);
    }

    internal MethodInfo ResolveMethod(ContractFunction function)
    {
        var owner = _mathAssembly.GetType($"Delta.Maths.{function.OwnerTypeName}")
            ?? throw new InvalidOperationException(
                $"Contract owner type '{function.OwnerTypeName}' for '{function.Identity}' was not found.");

        var candidates = owner
            .GetMethods(BindingFlags.Public | BindingFlags.Static)
            .Where(method => method.Name == function.MethodName)
            .Where(method => method.GetParameters().Length == function.ParameterTypeNames.Length)
            .Where(method => MatchesSignature(method, function))
            .ToArray();

        if (candidates.Length != 1)
        {
            throw new InvalidOperationException(
                $"Expected one CLR overload for '{function.Identity}', found {candidates.Length}.");
        }

        return candidates[0];
    }

    private static bool MatchesSignature(MethodInfo method, ContractFunction function)
    {
        if (!string.Equals(TypeName(method.ReturnType), function.ReturnTypeName, StringComparison.Ordinal))
        {
            return false;
        }

        var parameters = method.GetParameters();
        for (var index = 0; index < parameters.Length; index++)
        {
            var parameterType = parameters[index].ParameterType;
            if (parameterType.IsByRef)
            {
                parameterType = parameterType.GetElementType()
                    ?? throw new InvalidOperationException("A by-ref parameter has no element type.");
            }

            if (!string.Equals(TypeName(parameterType), function.ParameterTypeNames[index], StringComparison.Ordinal))
            {
                return false;
            }
        }

        return true;
    }

    internal static string TypeName(Type type)
    {
        if (type == typeof(bool))
        {
            return "bool";
        }

        if (type == typeof(float))
        {
            return "float";
        }

        if (type == typeof(double))
        {
            return "double";
        }

        if (type == typeof(int))
        {
            return "int";
        }

        if (type == typeof(uint))
        {
            return "uint";
        }

        return type.Name;
    }

    internal static object?[] CreateArguments(ContractFunction function, ParameterInfo[] parameters)
    {
        var arguments = new object?[parameters.Length];
        for (var index = 0; index < parameters.Length; index++)
        {
            var parameterType = parameters[index].ParameterType;
            if (parameterType.IsByRef)
            {
                parameterType = parameterType.GetElementType()
                    ?? throw new InvalidOperationException("A by-ref parameter has no element type.");
            }

            arguments[index] = CreateValue(parameterType, function, index);
        }

        return arguments;
    }

    private static object CreateValue(Type type, ContractFunction function, int parameterIndex)
    {
        if (type == typeof(bool))
        {
            return parameterIndex % 2 == 0;
        }

        if (type == typeof(float))
        {
            return ScalarFloat(function, parameterIndex);
        }

        if (type == typeof(double))
        {
            return ScalarDouble(function, parameterIndex);
        }

        if (type == typeof(int))
        {
            return 2;
        }

        if (type == typeof(uint))
        {
            return 2u;
        }

        if (type == typeof(bool2))
        {
            return new bool2(true, false);
        }

        if (type == typeof(bool3))
        {
            return new bool3(true, false, true);
        }

        if (type == typeof(bool4))
        {
            return new bool4(true, false, true, false);
        }

        if (type == typeof(float2))
        {
            return CreateFloat2(function);
        }

        if (type == typeof(float3))
        {
            return CreateFloat3(function, parameterIndex);
        }

        if (type == typeof(float4))
        {
            return CreateFloat4(function);
        }

        if (type == typeof(int2))
        {
            return new int2(2, -3);
        }

        if (type == typeof(int3))
        {
            return new int3(2, -3, 4);
        }

        if (type == typeof(int4))
        {
            return new int4(2, -3, 4, -5);
        }

        if (type == typeof(uint2))
        {
            return new uint2(2u, 3u);
        }

        if (type == typeof(uint3))
        {
            return new uint3(2u, 3u, 4u);
        }

        if (type == typeof(uint4))
        {
            return new uint4(2u, 3u, 4u, 5u);
        }

        if (type == typeof(float4x4))
        {
            return float4x4.identity;
        }

        if (type == typeof(quaternion))
        {
            return quaternion.identity;
        }

        throw new InvalidOperationException(
            $"No deterministic conformance value for CLR type '{type.FullName}' in '{function.Identity}'.");
    }

    private static float ScalarFloat(ContractFunction function, int parameterIndex)
    {
        if (function.MethodName.Contains("PerspectiveFieldOfView", StringComparison.Ordinal))
        {
            return parameterIndex switch
            {
                0 => 1.0f,
                1 => 1.5f,
                2 => 0.1f,
                _ => 100.0f,
            };
        }

        if (function.MethodName.Contains("SmoothStep", StringComparison.Ordinal))
        {
            return parameterIndex switch
            {
                0 => 0.0f,
                1 => 1.0f,
                _ => 0.5f,
            };
        }

        if (function.MethodName.Contains("Lerp", StringComparison.Ordinal))
        {
            return parameterIndex == 2 ? 0.25f : 0.75f;
        }

        if (function.MethodName.Contains("Step", StringComparison.Ordinal))
        {
            return parameterIndex == 0 ? 0.5f : 0.75f;
        }

        if (function.MethodName.Contains("Refract", StringComparison.Ordinal))
        {
            return 0.5f;
        }

        return 0.75f;
    }

    private static double ScalarDouble(ContractFunction function, int parameterIndex)
    {
        return ScalarFloat(function, parameterIndex);
    }

    private static float3 CreateFloat3(ContractFunction function, int parameterIndex)
    {
        if (function.MethodName.Contains("CreateLookTo", StringComparison.OrdinalIgnoreCase))
        {
            return parameterIndex switch
            {
                0 => new float3(0f, 0f, 0f),
                1 => new float3(0f, 0f, 1f),
                _ => new float3(0f, 1f, 0f),
            };
        }

        if (function.MethodName.Contains("CreateTRS", StringComparison.OrdinalIgnoreCase))
        {
            return parameterIndex == 2 ? new float3(1f, 2f, 3f) : new float3(1f, 2f, 3f);
        }

        if (RequiresPositiveFloatComponents(function))
        {
            return new float3(0.75f, 0.5f, 1.25f);
        }

        return new float3(0.75f, -0.5f, 1.25f);
    }

    private static float2 CreateFloat2(ContractFunction function)
    {
        return RequiresPositiveFloatComponents(function)
            ? new float2(0.75f, 0.5f)
            : new float2(0.75f, -0.5f);
    }

    private static float4 CreateFloat4(ContractFunction function)
    {
        return RequiresPositiveFloatComponents(function)
            ? new float4(0.75f, 0.5f, 1.25f, 2.0f)
            : new float4(0.75f, -0.5f, 1.25f, 2.0f);
    }

    private static bool RequiresPositiveFloatComponents(ContractFunction function)
    {
        return function.MethodName.Contains("InverseSqrt", StringComparison.OrdinalIgnoreCase)
            || function.MethodName.Contains("Log", StringComparison.OrdinalIgnoreCase);
    }

    internal object? Invoke(ContractFunction function, MethodInfo method, object?[] arguments)
    {
        try
        {
            var result = method.Invoke(null, arguments);
            if (method.ReturnType == typeof(void))
            {
                throw new InvalidOperationException($"Void contract function is not a calculation: {function.Identity}");
            }

            return result;
        }
        catch (TargetInvocationException exception) when (exception.InnerException is not null)
        {
            throw new InvalidOperationException(
                $"Contract case '{function.Identity}' threw {exception.InnerException.GetType().Name}: "
                + exception.InnerException.Message,
                exception.InnerException);
        }
    }

    internal static void ValidateResult(ContractFunction function, object? result)
    {
        if (result is null)
        {
            throw new InvalidOperationException($"Contract case '{function.Identity}' returned null.");
        }

        ValidateFinite(result, function.Identity, new HashSet<object>(ReferenceEqualityComparer.Instance));
    }

    private static void ValidateFinite(object value, string identity, HashSet<object> visited)
    {
        var type = value.GetType();
        if (type == typeof(float))
        {
            var number = (float)value;
            if (float.IsNaN(number) || float.IsInfinity(number))
            {
                throw new InvalidOperationException($"Contract case '{identity}' returned non-finite float.");
            }

            return;
        }

        if (type == typeof(double))
        {
            var number = (double)value;
            if (double.IsNaN(number) || double.IsInfinity(number))
            {
                throw new InvalidOperationException($"Contract case '{identity}' returned non-finite double.");
            }

            return;
        }

        if (!type.IsValueType && !visited.Add(value))
        {
            return;
        }

        foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            if (field.GetValue(value) is { } fieldValue)
            {
                ValidateFinite(fieldValue, identity, visited);
            }
        }
    }
}
