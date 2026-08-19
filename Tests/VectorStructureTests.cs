using System;
using System.Linq;
using System.Reflection;

namespace Delta.Maths.Tests
{
    internal static class VectorStructureTests
    {
        private static readonly string[] Scalars = ["bool", "int", "uint", "float", "double", "fix"];
        private static readonly string[] Components = ["x", "y", "z", "w"];

        public static void CoreApi()
        {
            foreach (var scalarName in Scalars)
            foreach (var dimension in new[] { 2, 3, 4 })
            {
                var type = VectorType(scalarName, dimension);
                var scalar = ScalarType(scalarName);
                for (var index = 0; index < dimension; index++)
                    AssertEx.Equal(scalar, type.GetField(Components[index])?.FieldType, $"Missing {type.Name}.{Components[index]}.");

                AssertEx.Equal(type, type.GetField("zero")?.FieldType);
                AssertEx.True(type.GetConstructor(Enumerable.Repeat(scalar, dimension).ToArray()) != null);
                AssertEx.True(type.GetConstructor([scalar]) != null);
                AssertEx.True(type.GetProperty("Item") != null);
                AssertEx.True(type.GetProperty("Count") != null);
                AssertEx.True(type.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static, [typeof(string)]) != null);
                AssertEx.True(type.GetProperty("xy") != null);
                AssertEx.True(type.GetProperty("yx")?.CanWrite == true);
                AssertEx.True(type.GetProperty("xx")?.CanWrite == false);
                ValidateSwizzles(type, scalarName, dimension);

                var operators = type.GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .Where(method => method.IsSpecialName).Select(method => method.Name).ToArray();
                AssertEx.True(operators.Contains("op_Equality"));
                AssertEx.True(operators.Contains("op_Inequality"));
            }
        }

        private static void ValidateSwizzles(Type type, string scalarName, int dimension)
        {
            var swizzles = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(property => property.Name is not "Count" and not "Item").ToArray();
            var expectedCount = 2 * dimension;
            foreach (var length in new[] { 2, 3, 4 })
                expectedCount += 3 * ((int)Math.Pow(dimension + 1, length) - 1);
            AssertEx.Equal(expectedCount, swizzles.Length, $"Unexpected swizzle count on {type.Name}.");

            foreach (var property in swizzles)
            {
                if (property.Name.Length == 1)
                {
                    AssertEx.Equal(ScalarType(scalarName), property.PropertyType);
                    AssertEx.True(property.CanWrite, $"Alias {type.Name}.{property.Name} should be writable.");
                    continue;
                }

                AssertEx.Equal(VectorType(scalarName, property.Name.Length), property.PropertyType);
                var writable = !property.Name.Contains('_') && property.Name.Distinct().Count() == property.Name.Length;
                AssertEx.Equal(writable, property.CanWrite, $"Unexpected setter on {type.Name}.{property.Name}.");
            }
        }

        public static void CapabilityApi()
        {
            foreach (var scalarName in Scalars)
            foreach (var dimension in new[] { 2, 3, 4 })
            {
                var type = VectorType(scalarName, dimension);
                Require(type, "Select", "Equal", "NotEqual");

                if (scalarName == "bool")
                    Require(type, "Any", "All");
                else
                {
                    Require(type, "Min", "Max", "Clamp", "LessThan", "GreaterThan");
                    Require(type, "Dot", "SqrLength", "Sum");
                }

                if (scalarName is "int" or "float" or "double" or "fix")
                    Require(type, "Abs", "Sign");

                if (scalarName is "float" or "double" or "fix")
                    Require(type, "Length", "Distance", "Normalize", "NormalizeSafe", "Reflect", "Refract", "ProjectSafe");

                if (scalarName is "float" or "double")
                    Require(type, "Sin", "Atan2", "Exp", "Log10", "IsNaN", "IsFinite");

                if (scalarName == "fix")
                    Require(type, "Sin", "Atan2", "Sqrt", "InverseSqrt", "Fract");

                if (dimension == 3 && scalarName is "float" or "double" or "fix")
                    Require(type, "Cross");
            }

            var mathsMethods = typeof(maths).GetMethods(BindingFlags.Public | BindingFlags.Static);
            foreach (var type in Scalars.SelectMany(scalar => new[] { 2, 3, 4 }.Select(dimension => VectorType(scalar, dimension))))
                AssertEx.True(mathsMethods.Any(method => method.Name == "select" && method.GetParameters().FirstOrDefault()?.ParameterType == type),
                    $"Missing maths.select overload for {type.Name}.");
        }

        private static void Require(Type type, params string[] names)
        {
            var available = type.GetMethods(BindingFlags.Public | BindingFlags.Static).Select(method => method.Name).ToHashSet();
            foreach (var name in names)
                AssertEx.True(available.Contains(name), $"Missing {type.Name}.{name}.");
        }

        private static Type VectorType(string scalar, int dimension) =>
            typeof(float2).Assembly.GetType("Delta.Maths." + scalar + dimension, throwOnError: true)!;

        private static Type ScalarType(string scalar) => scalar switch
        {
            "bool" => typeof(bool),
            "int" => typeof(int),
            "uint" => typeof(uint),
            "float" => typeof(float),
            "double" => typeof(double),
            "fix" => typeof(fix),
            _ => throw new ArgumentOutOfRangeException(nameof(scalar)),
        };
    }
}
