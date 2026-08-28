using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Delta.Maths.Conformance;

internal static class ShaderContractBundle
{
    private const int SchemaVersion = 1;
    private const string Protocol = "math-cpu-gpu-conformance-v0.1";
    private const string Checkpoint = "ea92fad";
    private const string ManifestPath = "Vectors/shader-contract.json";
    private const string NominalCaseSuffix = "::nominal-0";

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    };

    internal static BundleSummary Write(string outputPath)
    {
        var manifest = ShaderContractConformance.LoadContractManifest();
        var runner = new ContractCaseRunner(manifest.SupportedFunctions, typeof(float2).Assembly);
        var cases = new List<CpuCase>(manifest.SupportedFunctions.Count);

        foreach (var function in manifest.SupportedFunctions)
        {
            var invocation = runner.Evaluate(function);
            ContractCaseRunner.ValidateResult(function, invocation.Result);
            cases.Add(CreateCase(invocation));
        }

        var bundle = new CpuCaseBundle(
            SchemaVersion,
            Protocol,
            Checkpoint,
            manifest.SchemaVersion,
            ManifestPath,
            new BundleCoverage(
                manifest.TotalFunctionCount,
                manifest.SupportedFunctions.Count,
                cases.Count,
                0,
                manifest.UnsupportedFunctionCount),
            cases,
            new List<ExcludedCase>());

        var fullPath = Path.GetFullPath(outputPath);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath) ?? throw new InvalidOperationException("Bundle path has no directory."));
        File.WriteAllText(fullPath, JsonSerializer.Serialize(bundle, JsonOptions));
        return new BundleSummary(fullPath, bundle.Coverage);
    }

    internal static CpuCase CreateCase(ContractInvocation invocation)
    {
        var parameters = invocation.Parameters;
        var inputs = new List<CanonicalValue>(parameters.Length);
        var outputs = new List<CanonicalValue>();

        for (var index = 0; index < parameters.Length; index++)
        {
            var parameterType = GetElementType(parameters[index].ParameterType);
            inputs.Add(CanonicalValueEncoder.Encode(parameterType, invocation.InputArguments[index]));
            if (parameters[index].ParameterType.IsByRef)
            {
                outputs.Add(CanonicalValueEncoder.Encode(parameterType, invocation.Arguments[index]));
            }
        }

        return new CpuCase(
            invocation.Function.Identity + NominalCaseSuffix,
            new ContractOperation(
                invocation.Function.Identity,
                invocation.Function.OwnerTypeName,
                invocation.Function.MethodName,
                invocation.Function.ParameterTypeNames,
                invocation.Function.ReturnTypeName,
                invocation.Function.Mapping),
            inputs,
            CanonicalValueEncoder.Encode(invocation.Method.ReturnType, invocation.Result),
            ComparisonProfile.For(invocation.Function),
            invocation.Function.RequiredCapability is null
                ? Array.Empty<string>()
                : new[] { invocation.Function.RequiredCapability },
            invocation.Function.Stages,
            new CaseDisposition("ready", "pending", "pending"),
            outputs.Count == 0 ? null : outputs);
    }

    internal static Type GetElementType(Type type)
    {
        return type.IsByRef
            ? type.GetElementType() ?? throw new InvalidOperationException("A by-ref value has no element type.")
            : type;
    }

    internal static JsonSerializerOptions CreateJsonOptions() => JsonOptions;
}

internal static class ShaderContractBundleConformance
{
    private const string BundleFileName = "shader-conformance.json";

    internal static void Run()
    {
        var bundle = LoadBundle();
        var manifest = ShaderContractConformance.LoadContractManifest();
        ValidateMetadata(bundle, manifest);

        var functions = manifest.SupportedFunctions.ToDictionary(function => function.Identity, StringComparer.Ordinal);
        var runner = new ContractCaseRunner(manifest.SupportedFunctions, typeof(float2).Assembly);
        var caseIdentities = new HashSet<string>(StringComparer.Ordinal);

        foreach (var item in bundle.Cases)
        {
            if (!caseIdentities.Add(item.Operation.Identity))
            {
                throw new InvalidOperationException($"Duplicate bundle operation: {item.Operation.Identity}");
            }

            if (!functions.TryGetValue(item.Operation.Identity, out var function))
            {
                throw new InvalidOperationException(
                    $"Bundle operation is not a supported manifest function: {item.Operation.Identity}");
            }

            ValidateCase(item, function, runner);
        }

        var missing = functions.Keys.Except(caseIdentities, StringComparer.Ordinal).ToArray();
        var excluded = bundle.Excluded.Select(item => item.Identity).ToHashSet(StringComparer.Ordinal);
        missing = missing.Except(excluded, StringComparer.Ordinal).ToArray();
        if (missing.Length != 0)
        {
            throw new InvalidOperationException(
                $"Manifest functions missing from bundle cases/exclusions: {string.Join(", ", missing)}");
        }
    }

    private static CpuCaseBundle LoadBundle()
    {
        var outputPath = Path.Combine(AppContext.BaseDirectory, BundleFileName);
        if (File.Exists(outputPath))
        {
            return Deserialize(outputPath);
        }

        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            var projectPath = Path.Combine(directory.FullName, "Tests", "DeltaMaths.Conformance", BundleFileName);
            if (File.Exists(projectPath))
            {
                return Deserialize(projectPath);
            }

            directory = directory.Parent;
        }

        throw new FileNotFoundException($"Could not locate {BundleFileName}.");
    }

    private static CpuCaseBundle Deserialize(string path)
    {
        return JsonSerializer.Deserialize<CpuCaseBundle>(
                File.ReadAllText(path),
                ShaderContractBundle.CreateJsonOptions())
            ?? throw new InvalidOperationException($"Bundle '{path}' is empty.");
    }

    private static void ValidateMetadata(CpuCaseBundle bundle, ContractManifest manifest)
    {
        if (bundle.SchemaVersion != 1)
        {
            throw new InvalidOperationException($"Unsupported case bundle schema: {bundle.SchemaVersion}.");
        }

        if (!string.Equals(bundle.Protocol, "math-cpu-gpu-conformance-v0.1", StringComparison.Ordinal))
        {
            throw new InvalidOperationException($"Unexpected case bundle protocol: {bundle.Protocol}.");
        }

        if (!string.Equals(bundle.MathsCheckpoint, "ea92fad", StringComparison.Ordinal))
        {
            throw new InvalidOperationException($"Unexpected case bundle checkpoint: {bundle.MathsCheckpoint}.");
        }

        if (!string.Equals(bundle.ManifestSchemaVersion, manifest.SchemaVersion, StringComparison.Ordinal))
        {
            throw new InvalidOperationException("Bundle and manifest schema versions differ.");
        }

        var coverage = bundle.Coverage;
        if (coverage.ManifestFunctionCount != manifest.TotalFunctionCount
            || coverage.SupportedCount != manifest.SupportedFunctions.Count
            || coverage.UnsupportedManifestCount != manifest.UnsupportedFunctionCount
            || coverage.CaseCount != bundle.Cases.Count
            || coverage.ExcludedCount != bundle.Excluded.Count
            || coverage.CaseCount + coverage.ExcludedCount != coverage.SupportedCount)
        {
            throw new InvalidOperationException("Bundle coverage accounting is inconsistent with the manifest.");
        }
    }

    private static void ValidateCase(
        CpuCase item,
        ContractFunction function,
        ContractCaseRunner runner)
    {
        if (!string.Equals(item.Id, function.Identity + "::nominal-0", StringComparison.Ordinal))
        {
            throw new InvalidOperationException($"Unexpected case id for {function.Identity}: {item.Id}");
        }

        var operation = item.Operation;
        if (!string.Equals(operation.Identity, function.Identity, StringComparison.Ordinal)
            || !string.Equals(operation.OwnerTypeName, function.OwnerTypeName, StringComparison.Ordinal)
            || !string.Equals(operation.MethodName, function.MethodName, StringComparison.Ordinal)
            || !string.Equals(operation.ReturnTypeName, function.ReturnTypeName, StringComparison.Ordinal)
            || !string.Equals(operation.Mapping, function.Mapping, StringComparison.Ordinal)
            || !operation.ParameterTypeNames.SequenceEqual(function.ParameterTypeNames, StringComparer.Ordinal))
        {
            throw new InvalidOperationException($"Bundle operation identity differs from the manifest: {function.Identity}");
        }

        var invocation = runner.Evaluate(function);
        ContractCaseRunner.ValidateResult(function, invocation.Result);
        var expectedInputs = new List<CanonicalValue>(invocation.Parameters.Length);
        var expectedOutputs = new List<CanonicalValue>();
        for (var index = 0; index < invocation.Parameters.Length; index++)
        {
            var type = ShaderContractBundle.GetElementType(invocation.Parameters[index].ParameterType);
            expectedInputs.Add(CanonicalValueEncoder.Encode(type, invocation.InputArguments[index]));
            if (invocation.Parameters[index].ParameterType.IsByRef)
            {
                expectedOutputs.Add(CanonicalValueEncoder.Encode(type, invocation.Arguments[index]));
            }
        }

        CompareValues(item.Inputs, expectedInputs, function.Identity + " inputs");
        CompareValue(
            item.Expected,
            CanonicalValueEncoder.Encode(invocation.Method.ReturnType, invocation.Result),
            function.Identity + " expected");

        if (!item.RequiredCapabilities.SequenceEqual(
                function.RequiredCapability is null
                    ? Array.Empty<string>()
                    : new[] { function.RequiredCapability },
                StringComparer.Ordinal)
            || !item.Stages.SequenceEqual(function.Stages, StringComparer.Ordinal))
        {
            throw new InvalidOperationException($"Bundle capabilities differ from the manifest: {function.Identity}");
        }

        var expectedComparison = ComparisonProfile.For(function);
        if (item.Comparison != expectedComparison)
        {
            throw new InvalidOperationException($"Bundle comparison profile differs from the expected profile: {function.Identity}");
        }

        if (item.Disposition != new CaseDisposition("ready", "pending", "pending"))
        {
            throw new InvalidOperationException($"Unexpected case disposition: {function.Identity}");
        }

        if (item.Outputs is not null)
        {
            CompareValues(item.Outputs, expectedOutputs, function.Identity + " outputs");
        }
        else if (expectedOutputs.Count != 0)
        {
            throw new InvalidOperationException($"Bundle has no by-ref outputs for {function.Identity}.");
        }
    }

    private static void CompareValues(
        List<CanonicalValue> actual,
        List<CanonicalValue> expected,
        string label)
    {
        if (actual.Count != expected.Count)
        {
            throw new InvalidOperationException($"{label}: expected {expected.Count} values, got {actual.Count}.");
        }

        for (var index = 0; index < actual.Count; index++)
        {
            CompareValue(actual[index], expected[index], $"{label}[{index}]");
        }
    }

    private static void CompareValue(CanonicalValue actual, CanonicalValue expected, string label)
    {
        if (!string.Equals(actual.Type, expected.Type, StringComparison.Ordinal)
            || !actual.Words.SequenceEqual(expected.Words, StringComparer.Ordinal))
        {
            throw new InvalidOperationException($"{label}: canonical value differs from the CLR result.");
        }
    }
}

internal static class CanonicalValueEncoder
{
    internal static CanonicalValue Encode(Type type, object? value)
    {
        if (value is null)
        {
            throw new InvalidOperationException($"Cannot encode a null value of type '{type.FullName}'.");
        }

        if (type == typeof(bool))
        {
            return new CanonicalValue("bool", new[] { value is true ? "00000001" : "00000000" });
        }

        if (type == typeof(float))
        {
            return new CanonicalValue("float", new[] { Hex(unchecked((uint)BitConverter.SingleToInt32Bits((float)value))) });
        }

        if (type == typeof(double))
        {
            var bits = unchecked((ulong)BitConverter.DoubleToInt64Bits((double)value));
            return new CanonicalValue("double", new[] { Hex((uint)bits), Hex((uint)(bits >> 32)) });
        }

        if (type == typeof(int))
        {
            return new CanonicalValue("int", new[] { Hex(unchecked((uint)(int)value)) });
        }

        if (type == typeof(uint))
        {
            return new CanonicalValue("uint", new[] { Hex((uint)value) });
        }

        return type == typeof(bool2) ? EncodeBool2((bool2)value)
            : type == typeof(bool3) ? EncodeBool3((bool3)value)
            : type == typeof(bool4) ? EncodeBool4((bool4)value)
            : type == typeof(float2) ? EncodeFloat2((float2)value)
            : type == typeof(float3) ? EncodeFloat3((float3)value)
            : type == typeof(float4) ? EncodeFloat4((float4)value)
            : type == typeof(int2) ? EncodeInt2((int2)value)
            : type == typeof(int3) ? EncodeInt3((int3)value)
            : type == typeof(int4) ? EncodeInt4((int4)value)
            : type == typeof(uint2) ? EncodeUInt2((uint2)value)
            : type == typeof(uint3) ? EncodeUInt3((uint3)value)
            : type == typeof(uint4) ? EncodeUInt4((uint4)value)
            : type == typeof(float4x4) ? EncodeMatrix((float4x4)value)
            : type == typeof(quaternion) ? EncodeQuaternion((quaternion)value)
            : throw new InvalidOperationException($"No canonical encoder for CLR type '{type.FullName}'.");
    }

    private static CanonicalValue EncodeBool2(bool2 value) =>
        new("bool2", new[] { BoolWord(value.x), BoolWord(value.y) });

    private static CanonicalValue EncodeBool3(bool3 value) =>
        new("bool3", new[] { BoolWord(value.x), BoolWord(value.y), BoolWord(value.z) });

    private static CanonicalValue EncodeBool4(bool4 value) =>
        new("bool4", new[] { BoolWord(value.x), BoolWord(value.y), BoolWord(value.z), BoolWord(value.w) });

    private static CanonicalValue EncodeFloat2(float2 value) =>
        new("float2", new[] { FloatWord(value.x), FloatWord(value.y) });

    private static CanonicalValue EncodeFloat3(float3 value) =>
        new("float3", new[] { FloatWord(value.x), FloatWord(value.y), FloatWord(value.z) });

    private static CanonicalValue EncodeFloat4(float4 value) =>
        new("float4", new[] { FloatWord(value.x), FloatWord(value.y), FloatWord(value.z), FloatWord(value.w) });

    private static CanonicalValue EncodeInt2(int2 value) =>
        new("int2", new[] { IntWord(value.x), IntWord(value.y) });

    private static CanonicalValue EncodeInt3(int3 value) =>
        new("int3", new[] { IntWord(value.x), IntWord(value.y), IntWord(value.z) });

    private static CanonicalValue EncodeInt4(int4 value) =>
        new("int4", new[] { IntWord(value.x), IntWord(value.y), IntWord(value.z), IntWord(value.w) });

    private static CanonicalValue EncodeUInt2(uint2 value) =>
        new("uint2", new[] { UIntWord(value.x), UIntWord(value.y) });

    private static CanonicalValue EncodeUInt3(uint3 value) =>
        new("uint3", new[] { UIntWord(value.x), UIntWord(value.y), UIntWord(value.z) });

    private static CanonicalValue EncodeUInt4(uint4 value) =>
        new("uint4", new[] { UIntWord(value.x), UIntWord(value.y), UIntWord(value.z), UIntWord(value.w) });

    private static CanonicalValue EncodeMatrix(float4x4 value) =>
        new(
            "float4x4",
            new[]
            {
                FloatWord(value.c0.x), FloatWord(value.c0.y), FloatWord(value.c0.z), FloatWord(value.c0.w),
                FloatWord(value.c1.x), FloatWord(value.c1.y), FloatWord(value.c1.z), FloatWord(value.c1.w),
                FloatWord(value.c2.x), FloatWord(value.c2.y), FloatWord(value.c2.z), FloatWord(value.c2.w),
                FloatWord(value.c3.x), FloatWord(value.c3.y), FloatWord(value.c3.z), FloatWord(value.c3.w),
            });

    private static CanonicalValue EncodeQuaternion(quaternion value) =>
        new("quaternion", new[] { FloatWord(value.x), FloatWord(value.y), FloatWord(value.z), FloatWord(value.w) });

    private static string BoolWord(bool value) => value ? "00000001" : "00000000";

    private static string FloatWord(float value) => Hex(unchecked((uint)BitConverter.SingleToInt32Bits(value)));

    private static string IntWord(int value) => Hex(unchecked((uint)value));

    private static string UIntWord(uint value) => Hex(value);

    private static string Hex(uint value) => value.ToString("x8", CultureInfo.InvariantCulture);
}

internal static class ComparisonProfile
{
    internal static ComparisonProfileValue For(ContractFunction function)
    {
        if (IsQuaternion(function.ReturnTypeName))
        {
            return new ComparisonProfileValue("QuaternionEquivalent", 0.00002, 0.00002, 8);
        }

        if (IsExact(function.ReturnTypeName))
        {
            return new ComparisonProfileValue("Exact", 0, 0, 0);
        }

        if (IsDiscrete(function.MethodName))
        {
            return new ComparisonProfileValue("FloatDiscrete", 0.00001, 0.00001, 2);
        }

        if (IsTranscendental(function.MethodName))
        {
            return new ComparisonProfileValue("FloatTranscendental", 0.00002, 0.00002, 8);
        }

        return new ComparisonProfileValue("FloatBasic", 0.00001, 0.00001, 4);
    }

    private static bool IsQuaternion(string typeName) =>
        string.Equals(typeName, "quaternion", StringComparison.Ordinal);

    private static bool IsExact(string typeName) =>
        typeName.StartsWith("bool", StringComparison.Ordinal)
        || typeName.StartsWith("int", StringComparison.Ordinal)
        || typeName.StartsWith("uint", StringComparison.Ordinal);

    private static bool IsDiscrete(string methodName) =>
        ContainsAny(methodName, "Equal", "NotEqual", "Less", "Greater", "Floor", "Ceil", "Round", "Truncate", "Step");

    private static bool IsTranscendental(string methodName) =>
        ContainsAny(methodName, "Sin", "Cos", "Tan", "Asin", "Acos", "Atan", "Exp", "Log", "Sqrt", "Cbrt", "InverseSqrt", "Pow");

    private static bool ContainsAny(string value, params string[] candidates)
    {
        foreach (var candidate in candidates)
        {
            if (value.Contains(candidate, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}

internal sealed record CpuCaseBundle(
    int SchemaVersion,
    string Protocol,
    string MathsCheckpoint,
    string ManifestSchemaVersion,
    string ShaderContract,
    BundleCoverage Coverage,
    List<CpuCase> Cases,
    List<ExcludedCase> Excluded);

internal sealed record BundleCoverage(
    int ManifestFunctionCount,
    int SupportedCount,
    int CaseCount,
    int ExcludedCount,
    int UnsupportedManifestCount);

internal sealed record CpuCase(
    string Id,
    ContractOperation Operation,
    List<CanonicalValue> Inputs,
    CanonicalValue Expected,
    ComparisonProfileValue Comparison,
    string[] RequiredCapabilities,
    string[] Stages,
    CaseDisposition Disposition,
    List<CanonicalValue>? Outputs);

internal sealed record ContractOperation(
    string Identity,
    string OwnerTypeName,
    string MethodName,
    string[] ParameterTypeNames,
    string ReturnTypeName,
    string Mapping);

internal sealed record CanonicalValue(string Type, string[] Words);

internal sealed record ComparisonProfileValue(
    string Name,
    double AbsoluteTolerance,
    double RelativeTolerance,
    int MaxUlps);

internal sealed record CaseDisposition(string Cpu, string Shader, string Render);

internal sealed record ExcludedCase(string Identity, string Reason);

internal sealed record BundleSummary(string Path, BundleCoverage Coverage);
