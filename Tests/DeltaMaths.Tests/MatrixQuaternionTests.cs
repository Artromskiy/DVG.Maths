using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace Delta.Maths.Tests
{
    internal static class MatrixQuaternionTests
    {
        private static readonly string[] AllShaderStages = ["vertex", "fragment", "compute"];
        private static readonly string[] Float3Parameters = ["float", "float", "float"];

        public static void Layout()
        {
            AssertEx.Equal(64, Marshal.SizeOf<float4x4>());
            AssertEx.Equal(16, Marshal.SizeOf<quaternion>());
            AssertEx.Equal((IntPtr)0, Marshal.OffsetOf<float4x4>(nameof(float4x4.c0)));
            AssertEx.Equal((IntPtr)16, Marshal.OffsetOf<float4x4>(nameof(float4x4.c1)));
            AssertEx.Equal((IntPtr)32, Marshal.OffsetOf<float4x4>(nameof(float4x4.c2)));
            AssertEx.Equal((IntPtr)48, Marshal.OffsetOf<float4x4>(nameof(float4x4.c3)));
            AssertEx.Equal(16, Marshal.SizeOf<float2x2>());
            AssertEx.Equal(32, Marshal.SizeOf<float2x3>());
            AssertEx.Equal((IntPtr)16, Marshal.OffsetOf<float2x3>(nameof(float2x3.c1)));
            AssertEx.Equal(32, Marshal.SizeOf<float2x4>());
            AssertEx.Equal(24, Marshal.SizeOf<float3x2>());
            AssertEx.Equal((IntPtr)8, Marshal.OffsetOf<float3x2>(nameof(float3x2.c1)));
            AssertEx.Equal(48, Marshal.SizeOf<float3x3>());
            AssertEx.Equal((IntPtr)16, Marshal.OffsetOf<float3x3>(nameof(float3x3.c1)));
            AssertEx.Equal(48, Marshal.SizeOf<float3x4>());
            AssertEx.Equal(32, Marshal.SizeOf<float4x2>());
            AssertEx.Equal(64, Marshal.SizeOf<float4x3>());
            AssertEx.Equal((IntPtr)16, Marshal.OffsetOf<float4x3>(nameof(float4x3.c1)));
            AssertEx.Equal((IntPtr)0, Marshal.OffsetOf<quaternion>(nameof(quaternion.x)));
            AssertEx.Equal((IntPtr)4, Marshal.OffsetOf<quaternion>(nameof(quaternion.y)));
            AssertEx.Equal((IntPtr)8, Marshal.OffsetOf<quaternion>(nameof(quaternion.z)));
            AssertEx.Equal((IntPtr)12, Marshal.OffsetOf<quaternion>(nameof(quaternion.w)));

            AssertEx.Equal(32, Marshal.SizeOf<double3>());
            AssertEx.Equal(32, Marshal.SizeOf<double4>());
            AssertEx.Equal(32, Marshal.SizeOf<double2x2>());
            AssertEx.Equal(64, Marshal.SizeOf<double2x3>());
            AssertEx.Equal((IntPtr)32, Marshal.OffsetOf<double2x3>(nameof(double2x3.c1)));
            AssertEx.Equal(64, Marshal.SizeOf<double2x4>());
            AssertEx.Equal(48, Marshal.SizeOf<double3x2>());
            AssertEx.Equal((IntPtr)16, Marshal.OffsetOf<double3x2>(nameof(double3x2.c1)));
            AssertEx.Equal(96, Marshal.SizeOf<double3x3>());
            AssertEx.Equal((IntPtr)32, Marshal.OffsetOf<double3x3>(nameof(double3x3.c1)));
            AssertEx.Equal(96, Marshal.SizeOf<double3x4>());
            AssertEx.Equal(64, Marshal.SizeOf<double4x2>());
            AssertEx.Equal(128, Marshal.SizeOf<double4x3>());
            AssertEx.Equal((IntPtr)32, Marshal.OffsetOf<double4x3>(nameof(double4x3.c1)));
            AssertEx.Equal(128, Marshal.SizeOf<double4x4>());

            AssertEx.Equal(typeof(float4), typeof(float4x4).GetField(nameof(float4x4.c0))?.FieldType);
            AssertEx.True(typeof(float4x4).GetProperty(nameof(float4x4.M14))?.CanWrite == true);
            AssertEx.True(typeof(quaternion).GetProperty(nameof(quaternion.X))?.CanWrite == true);
        }

        public static void MatrixAlgebra()
        {
            var translation = new float3(4f, -2f, 7f);
            var rotation = quaternion.CreateFromAxisAngle(new float3(0f, 1f, 0f), DeltaMaths.Radians(90f));
            var scale = new float3(2f, 3f, 4f);
            var matrix = float4x4.CreateTRS(translation, rotation, scale);

            AssertEx.Near(translation.x, matrix.M14);
            AssertEx.Near(translation.y, matrix.M24);
            AssertEx.Near(translation.z, matrix.M34);
            AssertEx.Near(24f, float4x4.Determinant(matrix));
            AssertEx.Near(new float3(4f, -2f, 9f), float4x4.TransformPoint(matrix, new float3(1f, 0f, 0f)));
            AssertEx.Near(new float3(0f, 0f, 2f), float4x4.TransformDirection(matrix, new float3(1f, 0f, 0f)));

            AssertEx.True(float4x4.TryInverse(matrix, out var inverse));
            AssertMatrixNear(float4x4.identity, matrix * inverse, 0.0002f);
            AssertEx.True(!float4x4.TryInverse(float4x4.zero, out _));

            AssertEx.True(float4x4.Decompose(matrix, out var decomposedScale, out var decomposedRotation, out var decomposedTranslation));
            AssertEx.Near(scale, decomposedScale, 0.0002f);
            AssertEx.Near(translation, decomposedTranslation, 0.0002f);
            AssertQuaternionEquivalent(rotation, decomposedRotation, 0.0002f);

            var arbitraryRotation = quaternion.CreateFromAxisAngle(
                float3.NormalizeSafe(new float3(0.37f, 0.81f, -0.44f)), 0.73f);
            var arbitraryScale = new float3(1.7f, 2.3f, 0.6f);
            var arbitrary = float4x4.CreateTRS(new float3(-3.2f, 5.1f, 1.4f), arbitraryRotation, arbitraryScale);
            AssertEx.True(float4x4.Decompose(arbitrary, out var arbitraryDecomposedScale,
                out var arbitraryDecomposedRotation, out var arbitraryDecomposedTranslation));
            AssertEx.Near(arbitraryScale, arbitraryDecomposedScale, 0.0002f);
            AssertEx.Near(new float3(-3.2f, 5.1f, 1.4f), arbitraryDecomposedTranslation, 0.0002f);
            AssertQuaternionEquivalent(arbitraryRotation, arbitraryDecomposedRotation, 0.0002f);
        }

        public static void RectangularMatrices()
        {
            var matrix = new float2x3(
                new float3(1f, 2f, 3f),
                new float3(4f, 5f, 6f));
            AssertEx.Near(new float3(9f, 12f, 15f), matrix * new float2(1f, 2f));
            var transpose = float2x3.Transpose(matrix);
            AssertEx.Near(new float2(1f, 4f), transpose.GetColumn(0));
            AssertEx.Near(new float2(2f, 5f), transpose.GetColumn(1));
            AssertEx.Near(new float2(3f, 6f), transpose.GetColumn(2));
            AssertEx.Equal(new float2x3(
                new float3(1f, 4f, 9f),
                new float3(16f, 25f, 36f)),
                float2x3.MatrixCompMult(matrix, matrix));
            AssertEx.Equal(new float2x3(
                new float3(4f, 8f, 12f),
                new float3(5f, 10f, 15f)),
                float2x3.OuterProduct(new float3(1f, 2f, 3f), new float2(4f, 5f)));

            var right = new float3x2(
                new float2(1f, 2f),
                new float2(3f, 4f),
                new float2(5f, 6f));
            var product = matrix * right;
            AssertEx.Near(new float3(9f, 12f, 15f), product.GetColumn(0));
            AssertEx.Near(new float3(19f, 26f, 33f), product.GetColumn(1));
            AssertEx.Near(new float3(29f, 40f, 51f), product.GetColumn(2));

            var rowMajor = new float2x3(1f, 2f, 3f, 4f, 5f, 6f);
            AssertEx.Near(1f, rowMajor.M11);
            AssertEx.Near(2f, rowMajor.M12);
            AssertEx.Near(5f, rowMajor.M31);
            AssertEx.Near(6f, rowMajor.M32);

            var source = new float2x2(1f, 2f, 3f, 4f);
            var converted = new float3x4(source);
            AssertEx.Near(1f, converted.M11);
            AssertEx.Near(2f, converted.M12);
            AssertEx.Near(4f, converted.M22);
            AssertEx.Near(1f, converted.M33);
        }

        public static void MatrixVectorSemantics()
        {
            var matrix = new float4x4(
                1f, 2f, 3f, 4f,
                5f, 6f, 7f, 8f,
                9f, 10f, 11f, 12f,
                13f, 14f, 15f, 16f);
            var input = new float4(1f, 2f, 3f, 1f);
            var vectorProduct = matrix * input;
            var expected = new float4(18f, 46f, 74f, 102f);
            AssertEx.Near(expected, vectorProduct);

            var translated = float4x4.CreateTranslation(new float3(1f, -2f, 3f));
            var scaled = float4x4.CreateScale(new float3(2f, 3f, 4f));
            var composed = translated * scaled;
            var point = new float3(3f, 1f, 2f);
            AssertEx.Near(float4x4.TransformPoint(translated, float4x4.TransformPoint(scaled, point)),
                Float4ToPoint(composed * new float4(point, 1f)));
        }

        public static void QuaternionAlgebra()
        {
            var axis = new float3(0f, 1f, 0f);
            var rotation = quaternion.CreateFromAxisAngle(axis, DeltaMaths.Radians(90f));
            AssertEx.Near(new float3(0f, 0f, 1f), rotation * new float3(1f, 0f, 0f), 0.0002f);
            AssertEx.Equal(quaternion.identity, quaternion.NormalizeSafe(new quaternion(0f, 0f, 0f, 0f)));
            AssertEx.True(!quaternion.TryInverse(new quaternion(0f, 0f, 0f, 0f), out _));
            AssertQuaternionEquivalent(quaternion.identity, rotation * quaternion.Inverse(rotation), 0.0002f);
            AssertQuaternionEquivalent(rotation, quaternion.CreateFromRotationMatrix(quaternion.ToRotationMatrix(rotation)), 0.0002f);

            quaternion.ToAxisAngle(rotation, out var recoveredAxis, out var recoveredAngle);
            var axisSign = float3.Dot(recoveredAxis, axis) < 0f ? -1f : 1f;
            AssertEx.Near(axis, recoveredAxis * axisSign, 0.0002f);
            AssertEx.Near(DeltaMaths.Radians(90f), recoveredAngle * axisSign, 0.0002f);
            AssertQuaternionEquivalent(rotation, quaternion.CreateFromAxisAngle(recoveredAxis, recoveredAngle), 0.0002f);
        }

        public static void MatrixLookProjectionSemantics()
        {
            var eye = new float3(1f, 2f, 3f);
            var lookTo = float4x4.CreateLookTo(eye, new float3(0f, 0f, 1f), new float3(0f, 1f, 0f));
            AssertEx.Near(1f, lookTo.M11);
            AssertEx.Near(0f, lookTo.M12);
            AssertEx.Near(0f, lookTo.M13);
            AssertEx.Near(-1f, lookTo.M14);
            AssertEx.Near(0f, lookTo.M21);
            AssertEx.Near(1f, lookTo.M22);
            AssertEx.Near(0f, lookTo.M23);
            AssertEx.Near(-2f, lookTo.M24);
            AssertEx.Near(0f, lookTo.M31);
            AssertEx.Near(0f, lookTo.M32);
            AssertEx.Near(1f, lookTo.M33);
            AssertEx.Near(-3f, lookTo.M34);
            AssertEx.Near(0f, lookTo.M41);
            AssertEx.Near(0f, lookTo.M42);
            AssertEx.Near(0f, lookTo.M43);
            AssertEx.Near(1f, lookTo.M44);

            var projection = float4x4.CreatePerspectiveFieldOfViewLeftHanded(DeltaMaths.Radians(60f), 1.6f, 0.1f, 100f);
            var near = 0.1f;
            var far = 100f;
            var range = far / (far - near);
            AssertEx.Near(range, projection.M33);
            AssertEx.Near(-near * range, projection.M34);
            AssertEx.Near(1f, projection.M43);
            AssertEx.True(projection.M22 > 0f);

            var nearHomogeneous = projection * new float4(2f, 3f, near, 1f);
            AssertEx.Near(0f, nearHomogeneous.z);
            AssertEx.Near(nearHomogeneous.w, near);
            var farHomogeneous = projection * new float4(-1f, 1f, far, 1f);
            AssertEx.Near(farHomogeneous.z, farHomogeneous.w);
        }

        public static void ShaderContractManifest()
        {
            using var document = JsonDocument.Parse(File.ReadAllText(FindShaderContractManifestPath()));
            var root = document.RootElement;
            AssertEx.Equal("1.1.0", root.GetProperty("schemaVersion").GetString());
            AssertEx.Equal("Delta.Maths", root.GetProperty("namespace").GetString());

            var types = root.GetProperty("types").EnumerateArray().ToArray();
            AssertVectorType(types, "float2", "vec2", 8);
            AssertVectorType(types, "float3", "vec3", 16);
            AssertVectorType(types, "float4", "vec4", 16);
            AssertVectorType(types, "int2", "ivec2", 8);
            AssertVectorType(types, "int3", "ivec3", 16);
            AssertVectorType(types, "int4", "ivec4", 16);
            AssertVectorType(types, "uint2", "uvec2", 8);
            AssertVectorType(types, "uint3", "uvec3", 16);
            AssertVectorType(types, "uint4", "uvec4", 16);
            AssertVectorType(types, "bool2", "bvec2", 8);
            AssertVectorType(types, "bool3", "bvec3", 16);
            AssertVectorType(types, "bool4", "bvec4", 16);
            AssertDoubleVectorType(types, "double2", "dvec2", 16, 16);
            AssertDoubleVectorType(types, "double3", "dvec3", 32, 32);
            AssertDoubleVectorType(types, "double4", "dvec4", 32, 32);

            var matrixType = types.Single(type => type.GetProperty("clrName").GetString() == "float4x4");
            AssertEx.Equal("mat4", matrixType.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", matrixType.GetProperty("mapping").GetString());
            AssertEx.True(matrixType.GetProperty("columnMajor").GetBoolean());
            AssertEx.Equal(16, matrixType.GetProperty("alignment").GetInt32());
            AssertEx.Equal(16, matrixType.GetProperty("matrixStride").GetInt32());
            AssertEx.Equal(4, matrixType.GetProperty("matrixColumns").GetInt32());
            AssertEx.Equal(4, matrixType.GetProperty("matrixRows").GetInt32());
            AssertEx.Equal("float", matrixType.GetProperty("elementGlslType").GetString());
            AssertEx.Equal(64, matrixType.GetProperty("size").GetInt32());
            AssertEx.Equal("std430", matrixType.GetProperty("requiredCapability").GetString());

            AssertMatrixType(types, "float2x2", "mat2", 2, 2, 8, 8, 16);
            AssertMatrixType(types, "float2x3", "mat2x3", 2, 3, 16, 16, 32);
            AssertMatrixType(types, "float2x4", "mat2x4", 2, 4, 16, 16, 32);
            AssertMatrixType(types, "float3x2", "mat3x2", 3, 2, 8, 8, 24);
            AssertMatrixType(types, "float3x3", "mat3", 3, 3, 16, 16, 48);
            AssertMatrixType(types, "float3x4", "mat3x4", 3, 4, 16, 16, 48);
            AssertMatrixType(types, "float4x2", "mat4x2", 4, 2, 8, 8, 32);
            AssertMatrixType(types, "float4x3", "mat4x3", 4, 3, 16, 16, 64);
            AssertMatrixType(types, "double2x2", "dmat2", 2, 2, 16, 16, 32, "double", "float64");
            AssertMatrixType(types, "double2x3", "dmat2x3", 2, 3, 32, 32, 64, "double", "float64");
            AssertMatrixType(types, "double2x4", "dmat2x4", 2, 4, 32, 32, 64, "double", "float64");
            AssertMatrixType(types, "double3x2", "dmat3x2", 3, 2, 16, 16, 48, "double", "float64");
            AssertMatrixType(types, "double3x3", "dmat3", 3, 3, 32, 32, 96, "double", "float64");
            AssertMatrixType(types, "double3x4", "dmat3x4", 3, 4, 32, 32, 96, "double", "float64");
            AssertMatrixType(types, "double4x2", "dmat4x2", 4, 2, 16, 16, 64, "double", "float64");
            AssertMatrixType(types, "double4x3", "dmat4x3", 4, 3, 32, 32, 128, "double", "float64");
            AssertMatrixType(types, "double4x4", "dmat4", 4, 4, 32, 32, 128, "double", "float64");
            foreach (var type in types.Where(type => type.GetProperty("clrName").GetString() is { } name
                && (name.StartsWith("float", StringComparison.Ordinal)
                    || name.StartsWith("double", StringComparison.Ordinal))
                && name.Contains('x', StringComparison.Ordinal)))
            {
                AssertMatrixConstructors(type);
            }

            var quaternionType = types.Single(type => type.GetProperty("clrName").GetString() == "quaternion");
            AssertEx.Equal("vec4", quaternionType.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", quaternionType.GetProperty("mapping").GetString());
            AssertEx.Equal(16, quaternionType.GetProperty("alignment").GetInt32());
            AssertEx.Equal("std430", quaternionType.GetProperty("requiredCapability").GetString());

            AssertEx.True(types.Where(type => type.GetProperty("mapping").GetString() != "Unsupported").All(type => type.GetProperty("stages").EnumerateArray().Select(stage => stage.GetString())
                .SequenceEqual(AllShaderStages)));
            AssertEx.True(types.Where(type => type.GetProperty("mapping").GetString() != "Unsupported").All(type =>
                !string.IsNullOrWhiteSpace(type.GetProperty("shaderZone").GetString())
                && !string.IsNullOrWhiteSpace(type.GetProperty("glslName").GetString())
                && type.GetProperty("requiredCapability").GetString() is "std430" or "float16" or "float64"
                && type.GetProperty("alignment").ValueKind == JsonValueKind.Number));
            var knownCapabilities = new HashSet<string>(StringComparer.Ordinal)
            {
                "std430",
                "vector",
                "matrix",
                "quaternion",
                "scalar",
                "float16",
                "float64",
            };
            AssertEx.True(types.All(type => type.GetProperty("requiredCapability").ValueKind == JsonValueKind.Null
                || type.GetProperty("requiredCapability").GetString() is { } capability
                && knownCapabilities.Contains(capability)));
            AssertEx.True(types.All(type => type.GetProperty("shaderZone").ValueKind == JsonValueKind.Null
                || type.GetProperty("shaderZone").GetString() == "DeltaMaths"));
            AssertEx.Equal(16, types.Single(type => type.GetProperty("clrName").GetString() == "float3")
                .GetProperty("alignment").GetInt32());
            AssertEx.Equal(16, types.Single(type => type.GetProperty("clrName").GetString() == "float4")
                .GetProperty("alignment").GetInt32());
            AssertEx.Equal(16, types.Single(type => type.GetProperty("clrName").GetString() == "int3")
                .GetProperty("alignment").GetInt32());
            AssertEx.Equal(16, types.Single(type => type.GetProperty("clrName").GetString() == "uint3")
                .GetProperty("alignment").GetInt32());
            AssertEx.Equal(16, types.Single(type => type.GetProperty("clrName").GetString() == "bool3")
                .GetProperty("alignment").GetInt32());
            AssertHalfVectorType(types, "half2", "f16vec2", 4, 4);
            AssertHalfVectorType(types, "half3", "f16vec3", 8, 8);
            AssertHalfVectorType(types, "half4", "f16vec4", 8, 8);
            var float3Type = types.Single(type => type.GetProperty("clrName").GetString() == "float3");
            var float3Constructors = float3Type.GetProperty("constructors").EnumerateArray().ToArray();
            AssertEx.True(float3Constructors.Any(constructor =>
                constructor.GetProperty("parameterClrNames").EnumerateArray().Select(parameter => parameter.GetString())
                    .SequenceEqual(Float3Parameters)));
            var float3Swizzles = float3Type.GetProperty("swizzles").EnumerateArray().ToArray();
            var xySwizzle = float3Swizzles.Single(swizzle => swizzle.GetProperty("name").GetString() == "xy");
            AssertEx.Equal("float2", xySwizzle.GetProperty("clrTypeName").GetString());
            AssertEx.True(xySwizzle.GetProperty("writable").GetBoolean());

            var functions = root.GetProperty("functions").EnumerateArray().ToArray();
            AssertFunction(functions, "float2x3", "Transpose", "transpose", "Builtin", "float2x3");
            AssertShaderSignature(functions, "float2x3", "Transpose", ["mat2x3"], "mat3x2", "float2x3");
            AssertFunction(functions, "float2x3", "MatrixCompMult", "matrixCompMult", "Builtin", "float2x3", "float2x3");
            AssertFunction(functions, "float2x3", "OuterProduct", "outerProduct", "Builtin", "float3", "float2");
            AssertShaderSignature(functions, "float2x3", "OuterProduct", ["vec3", "vec2"], "mat2x3", "float3", "float2");
            AssertFunction(functions, "maths", "matrixCompMult", "matrixCompMult", "Builtin", "float2x3", "float2x3");
            AssertFunction(functions, "maths", "transpose", "transpose", "Builtin", "float2x3");
            AssertFunction(functions, "maths", "outerProduct", "outerProduct", "Builtin", "float3", "float2");
            for (var columns = 2; columns <= 4; columns++)
            {
                for (var rows = 2; rows <= 4; rows++)
                {
                    var matrixName = $"float{columns}x{rows}";
                    var transposedName = $"float{rows}x{columns}";
                    var transposeFunction = FindFunction(functions, matrixName, "Transpose", matrixName);
                    AssertEx.Equal(transposedName, transposeFunction.GetProperty("returnClrName").GetString());
                    AssertEx.Equal("transpose", transposeFunction.GetProperty("glslName").GetString());

                    var vectorMultiply = FindFunction(functions, matrixName, "op_Multiply", matrixName, "float" + columns);
                    AssertEx.Equal("float" + rows, vectorMultiply.GetProperty("returnClrName").GetString());
                    var rowVectorMultiply = FindFunction(functions, matrixName, "op_Multiply", "float" + rows, matrixName);
                    AssertEx.Equal("float" + columns, rowVectorMultiply.GetProperty("returnClrName").GetString());
                    for (var rightColumns = 2; rightColumns <= 4; rightColumns++)
                    {
                        var rightName = $"float{rightColumns}x{columns}";
                        var resultName = $"float{rightColumns}x{rows}";
                        var rectangularMatrixMultiply = FindFunction(functions, matrixName, "op_Multiply", matrixName, rightName);
                        AssertEx.Equal(resultName, rectangularMatrixMultiply.GetProperty("returnClrName").GetString());
                        AssertEx.Equal("*", rectangularMatrixMultiply.GetProperty("glslName").GetString());
                    }
                }
            }
            for (var columns = 2; columns <= 4; columns++)
            {
                for (var rows = 2; rows <= 4; rows++)
                {
                    var matrixName = $"double{columns}x{rows}";
                    var transposedName = $"double{rows}x{columns}";
                    var transposeFunction = FindFunction(functions, matrixName, "Transpose", matrixName);
                    AssertEx.Equal(transposedName, transposeFunction.GetProperty("returnClrName").GetString());
                    AssertEx.Equal("transpose", transposeFunction.GetProperty("glslName").GetString());
                    AssertEx.Equal("float64", transposeFunction.GetProperty("requiredCapability").GetString());
                    AssertShaderSignature(functions, matrixName, "Transpose",
                        [DoubleMatrixGlslName(columns, rows)], DoubleMatrixGlslName(rows, columns), matrixName);

                    var vectorMultiply = FindFunction(functions, matrixName, "op_Multiply", matrixName, "double" + columns);
                    AssertEx.Equal("double" + rows, vectorMultiply.GetProperty("returnClrName").GetString());
                    AssertEx.Equal("float64", vectorMultiply.GetProperty("requiredCapability").GetString());
                    AssertShaderSignature(functions, matrixName, "op_Multiply",
                        [DoubleMatrixGlslName(columns, rows), $"dvec{columns}"], $"dvec{rows}", matrixName, "double" + columns);
                    var rowVectorMultiply = FindFunction(functions, matrixName, "op_Multiply", "double" + rows, matrixName);
                    AssertEx.Equal("double" + columns, rowVectorMultiply.GetProperty("returnClrName").GetString());
                    AssertShaderSignature(functions, matrixName, "op_Multiply",
                        [$"dvec{rows}", DoubleMatrixGlslName(columns, rows)], $"dvec{columns}", "double" + rows, matrixName);
                    for (var rightColumns = 2; rightColumns <= 4; rightColumns++)
                    {
                        var rightName = $"double{rightColumns}x{columns}";
                        var resultName = $"double{rightColumns}x{rows}";
                        var rectangularMatrixMultiply = FindFunction(functions, matrixName, "op_Multiply", matrixName, rightName);
                        AssertEx.Equal(resultName, rectangularMatrixMultiply.GetProperty("returnClrName").GetString());
                        AssertEx.Equal("*", rectangularMatrixMultiply.GetProperty("glslName").GetString());
                        AssertShaderSignature(functions, matrixName, "op_Multiply",
                            [DoubleMatrixGlslName(columns, rows), DoubleMatrixGlslName(rightColumns, columns)],
                            DoubleMatrixGlslName(rightColumns, rows), matrixName, rightName);
                    }
                }
            }
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("typeClrName").GetString())));
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("clrName").GetString())));
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("mathsName").GetString())));
            AssertEx.True(functions.All(function => function.TryGetProperty("parameterClrNames", out var parameters)
                && parameters.ValueKind == JsonValueKind.Array));
            AssertEx.True(functions.All(function => function.TryGetProperty("parameterModifiers", out var modifiers)
                && modifiers.ValueKind == JsonValueKind.Array
                && modifiers.GetArrayLength() == function.GetProperty("parameterClrNames").GetArrayLength()));
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("returnClrName").GetString())));
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("identity").GetString())));
            var identities = functions.Select(function =>
                $"{function.GetProperty("typeClrName").GetString()}.{function.GetProperty("clrName").GetString()}({string.Join(",", function.GetProperty("parameterClrNames").EnumerateArray().Select(parameter => parameter.GetString()))}):{function.GetProperty("returnClrName").GetString()}").ToArray();
            AssertEx.Equal(identities.Length, identities.Distinct(StringComparer.Ordinal).Count());
            AssertEx.True(functions.All(function =>
            {
                var mapping = function.GetProperty("mapping").GetString();
                var stages = function.GetProperty("stages").EnumerateArray().ToArray();
                if (mapping == "Unsupported")
                {
                    return stages.Length == 0 && function.GetProperty("shaderZone").ValueKind == JsonValueKind.Null;
                }

                return !string.IsNullOrWhiteSpace(function.GetProperty("glslName").GetString())
                    && function.GetProperty("shaderZone").GetString() == "DeltaMaths"
                    && stages.Length == 3
                    && function.GetProperty("parameterGlslTypes").GetArrayLength()
                        == function.GetProperty("parameterClrNames").GetArrayLength()
                    && function.GetProperty("parameterGlslTypes").EnumerateArray()
                        .All(parameter => !string.IsNullOrWhiteSpace(parameter.GetString()))
                    && !string.IsNullOrWhiteSpace(function.GetProperty("returnGlslType").GetString())
                    && mapping is "Builtin" or "Helper";
            }));
            AssertEx.True(functions.All(function =>
                function.GetProperty("identity").GetString() ==
                $"{function.GetProperty("typeClrName").GetString()}.{function.GetProperty("clrName").GetString()}({string.Join(",", function.GetProperty("parameterClrNames").EnumerateArray().Select(parameter => parameter.GetString()))}):{function.GetProperty("returnClrName").GetString()}"));
            AssertEx.True(functions.All(function => function.GetProperty("glslName").ValueKind != JsonValueKind.String
                || function.GetProperty("glslName").GetString() != "fwidth"));

            var createTrs = functions.FirstOrDefault(
                function => function.GetProperty("typeClrName").GetString() == "float4x4"
                    && function.GetProperty("clrName").GetString() == "CreateTRS");
            AssertEx.True(createTrs.ValueKind != JsonValueKind.Undefined);
            AssertEx.Equal("Helper", createTrs.GetProperty("mapping").GetString());
            AssertEx.Equal("matrix", createTrs.GetProperty("requiredCapability").GetString());

            var transformPoint = functions.FirstOrDefault(
                function => function.GetProperty("typeClrName").GetString() == "float4x4"
                    && function.GetProperty("clrName").GetString() == "TransformPoint");
            AssertEx.True(transformPoint.ValueKind != JsonValueKind.Undefined);
            AssertEx.Equal("delta_transformPoint", transformPoint.GetProperty("glslName").GetString());
            AssertEx.Equal("Helper", transformPoint.GetProperty("mapping").GetString());

            var matrixMultiply = FindFunction(functions, "float4x4", "op_Multiply", "float4x4", "float4x4");
            AssertEx.Equal("*", matrixMultiply.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", matrixMultiply.GetProperty("mapping").GetString());
            AssertEx.Equal("matrix", matrixMultiply.GetProperty("requiredCapability").GetString());
            AssertEx.True(!HasFunction(functions, "float4x4", "Multiply", "float4x4", "float4x4"));
            AssertEx.True(!HasFunction(functions, "maths", "multiply", "float4x4", "float4x4"));
            AssertEx.True(!typeof(float4x4).GetMethods().Any(method =>
            {
                if (method.Name != "Multiply")
                {
                    return false;
                }

                var parameters = method.GetParameters();
                return parameters.Length == 2
                    && parameters[0].ParameterType == typeof(float4x4)
                    && parameters[1].ParameterType == typeof(float4x4);
            }));

            var matrixVectorMultiply = FindFunction(functions, "float4x4", "op_Multiply", "float4x4", "float4");
            AssertEx.Equal("*", matrixVectorMultiply.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", matrixVectorMultiply.GetProperty("mapping").GetString());

            var quaternionMultiply = FindFunction(functions, "quaternion", "op_Multiply", "quaternion", "quaternion");
            AssertEx.Equal("delta_quaternionMultiply", quaternionMultiply.GetProperty("glslName").GetString());
            AssertEx.Equal("Helper", quaternionMultiply.GetProperty("mapping").GetString());

            var quaternionRotate = FindFunction(functions, "quaternion", "Rotate", "quaternion", "float3");
            AssertEx.Equal("delta_quaternionRotate", quaternionRotate.GetProperty("glslName").GetString());
            AssertEx.Equal("Helper", quaternionRotate.GetProperty("mapping").GetString());

            var quaternionNormalize = FindFunction(functions, "quaternion", "Normalize", "quaternion");
            AssertEx.Equal("delta_quaternionNormalize", quaternionNormalize.GetProperty("glslName").GetString());
            AssertEx.Equal("Helper", quaternionNormalize.GetProperty("mapping").GetString());

            AssertFunction(functions, "float3", "Min", "min", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "Max", "max", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "Clamp", "clamp", "Builtin", "float3", "float", "float");
            AssertFunction(functions, "float3", "Lerp", "mix", "Builtin", "float3", "float3", "float");
            AssertFunction(functions, "float3", "Smoothstep", "smoothstep", "Builtin", "float", "float", "float3");
            AssertFunction(functions, "float3", "Step", "step", "Builtin", "float", "float3");
            AssertFunction(functions, "float3", "Dot", "dot", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "Length", "length", "Builtin", "float3");
            AssertFunction(functions, "float3", "Normalize", "normalize", "Builtin", "float3");
            AssertFunction(functions, "float3", "Select", "delta_select", "Helper", "float3", "float3", "bool3");
            AssertFunction(functions, "float3", "LessThan", "lessThan", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "LessThanOrEqual", "lessThanEqual", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "GreaterThan", "greaterThan", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "GreaterThanOrEqual", "greaterThanEqual", "Builtin", "float3", "float3");
            AssertFunction(functions, "bool3", "Not", "not", "Builtin", "bool3");

            AssertFunction(functions, "float3", "Fract", "fract", "Builtin", "float3");
            AssertFunction(functions, "float3", "InverseSqrt", "inversesqrt", "Builtin", "float3");
            AssertFunction(functions, "float3", "Radians", "radians", "Builtin", "float3");
            AssertFunction(functions, "float3", "Degrees", "degrees", "Builtin", "float3");
            AssertFunction(functions, "float3", "Atan2", "atan", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "Atan2", "atan", "Builtin", "float3", "float");
            AssertUnsupportedFunction(functions, "float3", "Atan2", "float", "float3");
            AssertFunction(functions, "float3", "Reflect", "reflect", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "Refract", "refract", "Builtin", "float3", "float3", "float");
            AssertFunction(functions, "float3", "FaceForward", "faceforward", "Builtin", "float3", "float3", "float3");
            AssertFunction(functions, "float3", "Clamp", "clamp", "Builtin", "float3", "float3", "float3");
            AssertFunction(functions, "float3", "Min", "min", "Builtin", "float3", "float");
            AssertFunction(functions, "float3", "Max", "max", "Builtin", "float3", "float");
            AssertUnsupportedFunction(functions, "float3", "Min", "float", "float3");
            AssertUnsupportedFunction(functions, "float3", "Max", "float", "float3");
            AssertFunction(functions, "float3", "Truncate", "trunc", "Builtin", "float3");
            AssertFunction(functions, "float3", "Round", "roundEven", "Builtin", "float3");
            AssertFunction(functions, "float3", "RoundEven", "roundEven", "Builtin", "float3");
            AssertFunction(functions, "float3", "Modf", "modf", "Builtin", "float3", "float3");
            AssertFunction(functions, "float3", "Frexp", "frexp", "Builtin", "float3", "int3");
            AssertFunction(functions, "float3", "Ldexp", "ldexp", "Builtin", "float3", "int3");
            AssertFunction(functions, "float3", "FloatBitsToInt", "floatBitsToInt", "Builtin", "float3");
            AssertFunction(functions, "float3", "FloatBitsToUint", "floatBitsToUint", "Builtin", "float3");
            AssertFunction(functions, "float3", "IntBitsToFloat", "intBitsToFloat", "Builtin", "int3");
            AssertFunction(functions, "float3", "UintBitsToFloat", "uintBitsToFloat", "Builtin", "uint3");
            AssertShaderSignature(functions, "float3", "Modf", ["vec3", "vec3"], "vec3", "float3", "float3");
            AssertShaderSignature(functions, "float3", "Frexp", ["vec3", "ivec3"], "vec3", "float3", "int3");
            AssertParameterModifiers(functions, "float3", "Modf", ["none", "out"], "float3", "float3");
            AssertParameterModifiers(functions, "float3", "Frexp", ["none", "out"], "float3", "int3");
            AssertFunction(functions, "float2", "PackHalf2x16", "packHalf2x16", "Builtin", "float2");
            AssertFunction(functions, "float2", "UnpackHalf2x16", "unpackHalf2x16", "Builtin", "uint");

            AssertFunction(functions, "maths", "fract", "fract", "Builtin", "float");
            AssertFunction(functions, "maths", "sin", "sin", "Builtin", "float");
            AssertFunction(functions, "maths", "cos", "cos", "Builtin", "float");
            AssertFunction(functions, "maths", "sqrt", "sqrt", "Builtin", "float");
            AssertFunction(functions, "maths", "inverseSqrt", "inversesqrt", "Builtin", "float");
            AssertFunction(functions, "maths", "radians", "radians", "Builtin", "float");
            AssertFunction(functions, "maths", "degrees", "degrees", "Builtin", "float");
            AssertFunction(functions, "maths", "atan2", "atan", "Builtin", "float", "float");
            AssertFunction(functions, "maths", "round", "roundEven", "Builtin", "float");
            AssertFunction(functions, "maths", "roundEven", "roundEven", "Builtin", "float");
            AssertFunction(functions, "maths", "truncate", "trunc", "Builtin", "float");
            AssertFunction(functions, "maths", "modf", "modf", "Builtin", "float", "float");
            AssertFunction(functions, "maths", "frexp", "frexp", "Builtin", "float", "int");
            AssertFunction(functions, "maths", "ldexp", "ldexp", "Builtin", "float", "int");
            AssertFunction(functions, "maths", "floatBitsToInt", "floatBitsToInt", "Builtin", "float");
            AssertFunction(functions, "maths", "floatBitsToUint", "floatBitsToUint", "Builtin", "float");
            AssertFunction(functions, "maths", "intBitsToFloat", "intBitsToFloat", "Builtin", "int");
            AssertFunction(functions, "maths", "uintBitsToFloat", "uintBitsToFloat", "Builtin", "uint");
            AssertParameterModifiers(functions, "maths", "modf", ["none", "out"], "float", "float");
            AssertParameterModifiers(functions, "maths", "frexp", ["none", "out"], "float", "int");

            AssertFunction(functions, "maths", "sin", "sin", "Builtin", "double");
            AssertFunction(functions, "maths", "sqrt", "sqrt", "Builtin", "double");
            AssertFunction(functions, "maths", "atan2", "atan", "Builtin", "double", "double");
            AssertFunction(functions, "maths", "round", "roundEven", "Builtin", "double");
            AssertFunction(functions, "maths", "mod", "mod", "Builtin", "double", "double");
            AssertShaderSignature(functions, "maths", "sin", ["double"], "double", "double");
            AssertShaderSignature(functions, "maths", "atan2", ["double", "double"], "double", "double", "double");

            foreach (var vectorName in new[] { "float2", "float3", "float4" })
            {
                AssertFunction(functions, vectorName, "Sin", "sin", "Builtin", vectorName);
                AssertFunction(functions, vectorName, "Cos", "cos", "Builtin", vectorName);
                AssertFunction(functions, vectorName, "Sqrt", "sqrt", "Builtin", vectorName);
                AssertFunction(functions, "maths", "sin", "sin", "Builtin", vectorName);
                AssertFunction(functions, "maths", "cos", "cos", "Builtin", vectorName);
                AssertFunction(functions, "maths", "sqrt", "sqrt", "Builtin", vectorName);
                AssertFunction(functions, "maths", "atan2", "atan", "Builtin", vectorName, "float");
                AssertFunction(functions, "maths", "atan2", "atan", "Builtin", vectorName, vectorName);
                AssertFunction(functions, "maths", "round", "roundEven", "Builtin", vectorName);
                var glslVector = "vec" + vectorName[^1];
                AssertShaderSignature(functions, "maths", "atan2", new[] { glslVector, "float" }, glslVector,
                    vectorName, "float");
                AssertShaderSignature(functions, "maths", "select", new[] { glslVector, glslVector, "bvec" + vectorName[^1] }, glslVector,
                    vectorName, vectorName, "bool" + vectorName[^1]);
            }

            foreach (var vectorName in new[] { "double2", "double3", "double4" })
            {
                AssertFunction(functions, vectorName, "Sin", "sin", "Builtin", vectorName);
                AssertFunction(functions, vectorName, "Normalize", "normalize", "Builtin", vectorName);
                AssertFunction(functions, "maths", "sin", "sin", "Builtin", vectorName);
                AssertFunction(functions, "maths", "select", "delta_select", "Helper",
                    vectorName, vectorName, "bool" + vectorName[^1]);
                var glslVector = "dvec" + vectorName[^1];
                AssertShaderSignature(functions, "maths", "sin", [glslVector], glslVector, vectorName);
                AssertShaderSignature(functions, "maths", "select",
                    new[] { glslVector, glslVector, "bvec" + vectorName[^1] }, glslVector,
                    vectorName, vectorName, "bool" + vectorName[^1]);
                AssertEx.Equal("float64", FindFunction(functions, vectorName, "Sin", vectorName)
                    .GetProperty("requiredCapability").GetString());
            }

            foreach (var dimension in new[] { 2, 3, 4 })
            {
                var vectorName = "half" + dimension;
                var glslVector = "f16vec" + dimension;
                AssertFunction(functions, vectorName, "Sin", "sin", "Builtin", vectorName);
                AssertFunction(functions, vectorName, "Normalize", "normalize", "Builtin", vectorName);
                AssertFunction(functions, "maths", "sin", "sin", "Builtin", vectorName);
                AssertFunction(functions, "maths", "select", "delta_select", "Helper",
                    vectorName, vectorName, "bool" + dimension);
                AssertShaderSignature(functions, "maths", "sin", new[] { glslVector }, glslVector, vectorName);
                AssertShaderSignature(functions, "maths", "select",
                    new[] { glslVector, glslVector, "bvec" + dimension }, glslVector,
                    vectorName, vectorName, "bool" + dimension);
                AssertEx.Equal("float16", FindFunction(functions, vectorName, "Sin", vectorName)
                    .GetProperty("requiredCapability").GetString());
            }

            AssertFunction(functions, "maths", "sin", "sin", "Builtin", "half");
            AssertShaderSignature(functions, "maths", "sin", ["float16_t"], "float16_t", "half");
            AssertFunction(functions, "maths", "atan2", "atan", "Builtin", "half", "half");
            AssertShaderSignature(functions, "maths", "atan2", ["float16_t", "float16_t"], "float16_t", "half", "half");

            foreach (var vectorName in new[] { "float2", "float4" })
            {
                foreach (var functionName in new[]
                {
                    "PackUnorm2x16", "UnpackUnorm2x16", "PackSnorm2x16", "UnpackSnorm2x16",
                    "PackHalf2x16", "UnpackHalf2x16",
                    "PackUnorm4x8", "UnpackUnorm4x8", "PackSnorm4x8", "UnpackSnorm4x8",
                })
                {
                    if (functionName.EndsWith(vectorName[^1] + "16", StringComparison.Ordinal)
                        || functionName.EndsWith(vectorName[^1] + "8", StringComparison.Ordinal))
                    {
                        AssertPackingFunction(functions, vectorName, functionName);
                    }
                }
            }

            foreach (var valueType in new[] { "float", "int", "uint", "half", "double" })
            {
                foreach (var dimension in new[] { 2, 3, 4 })
                {
                    var vectorName = valueType + dimension;
                    var maskName = "bool" + dimension;
                    AssertFunction(functions, vectorName, "Select", "delta_select", "Helper",
                        vectorName, vectorName, maskName);
                    AssertFunction(functions, "maths", "select", "delta_select", "Helper",
                        vectorName, vectorName, maskName);
                }
            }

            foreach (var valueType in new[] { "float", "int", "uint", "double" })
            {
                foreach (var dimension in new[] { 2, 3, 4 })
                {
                    var vectorName = valueType + dimension;
                    var glslVector = valueType == "float"
                        ? "vec" + dimension
                        : valueType == "double"
                            ? "dvec" + dimension
                            : (valueType == "int" ? "ivec" : "uvec") + dimension;
                    foreach (var relation in new[] { "LessThan", "LessThanOrEqual", "GreaterThan", "GreaterThanOrEqual" })
                    {
                        var glslName = relation switch
                        {
                            "LessThanOrEqual" => "lessThanEqual",
                            "GreaterThanOrEqual" => "greaterThanEqual",
                            _ => char.ToLowerInvariant(relation[0]) + relation[1..],
                        };
                        AssertFunction(functions, vectorName, relation, glslName, "Builtin", vectorName, vectorName);
                        AssertShaderSignature(functions, vectorName, relation,
                            new[] { glslVector, glslVector }, "bvec" + dimension, vectorName, vectorName);
                        AssertFunction(functions, "maths", char.ToLowerInvariant(relation[0]) + relation[1..],
                            glslName, "Builtin", vectorName, vectorName);
                    }
                }
            }

            var scalarMod = FindFunction(functions, "maths", "mod", "float", "float");
            AssertEx.Equal("maths.mod(float,float):float", scalarMod.GetProperty("identity").GetString());
            AssertEx.Equal("mod", scalarMod.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", scalarMod.GetProperty("mapping").GetString());
            AssertEx.Equal("scalar", scalarMod.GetProperty("requiredCapability").GetString());

            AssertFunction(functions, "maths", "uaddCarry", "uaddCarry", "Builtin", "uint", "uint", "uint");
            AssertShaderSignature(functions, "maths", "uaddCarry", ["uint", "uint", "uint"], "uint", "uint", "uint", "uint");
            var scalarCarry = FindFunction(functions, "maths", "uaddCarry", "uint", "uint", "uint");
            AssertEx.True(scalarCarry.GetProperty("parameterModifiers").EnumerateArray().Select(value => value.GetString())
                .SequenceEqual(["none", "none", "out"]));
            AssertFunction(functions, "maths", "usubBorrow", "usubBorrow", "Builtin", "uint", "uint", "uint");
            AssertFunction(functions, "maths", "umulExtended", "umulExtended", "Builtin", "uint", "uint", "uint", "uint");
            AssertShaderSignature(functions, "maths", "umulExtended", ["uint", "uint", "uint", "uint"], "void", "uint", "uint", "uint", "uint");
            AssertFunction(functions, "maths", "imulExtended", "imulExtended", "Builtin", "int", "int", "int", "int");
            AssertFunction(functions, "maths", "bitCount", "bitCount", "Builtin", "uint");
            AssertFunction(functions, "maths", "bitCount", "bitCount", "Builtin", "int");
            AssertFunction(functions, "maths", "findLSB", "findLSB", "Builtin", "uint");
            AssertFunction(functions, "maths", "findMSB", "findMSB", "Builtin", "int");
            AssertFunction(functions, "maths", "bitfieldExtract", "bitfieldExtract", "Builtin", "uint", "int", "int");
            AssertFunction(functions, "maths", "bitfieldInsert", "bitfieldInsert", "Builtin", "int", "int", "int", "int");

            foreach (var valueType in new[] { "int", "uint" })
            {
                foreach (var dimension in new[] { 2, 3, 4 })
                {
                    var vectorName = valueType + dimension;
                    var glslVector = (valueType == "int" ? "ivec" : "uvec") + dimension;
                    var intGlslVector = "ivec" + dimension;
                    AssertFunction(functions, vectorName, "BitCount", "bitCount", "Builtin", vectorName);
                    AssertShaderSignature(functions, vectorName, "BitCount", [glslVector], intGlslVector, vectorName);
                    AssertFunction(functions, "maths", "bitCount", "bitCount", "Builtin", vectorName);
                    AssertFunction(functions, vectorName, "BitfieldExtract", "bitfieldExtract", "Builtin", vectorName, "int", "int");
                    AssertFunction(functions, vectorName, "BitfieldInsert", "bitfieldInsert", "Builtin", vectorName, vectorName, "int", "int");
                    AssertIntegerOperator(functions, vectorName);
                }
            }

            foreach (var vectorName in new[] { "float2", "float3", "float4", "double2", "double3", "double4" })
            {
                AssertFunction(functions, vectorName, "Mod", "mod", "Builtin", vectorName, vectorName);
                var scalarName = vectorName.StartsWith("double", StringComparison.Ordinal) ? "double" : "float";
                AssertFunction(functions, vectorName, "Mod", "mod", "Builtin", vectorName, scalarName);
                AssertFunction(functions, "maths", "mod", "mod", "Builtin", vectorName, vectorName);
                AssertFunction(functions, "maths", "mod", "mod", "Builtin", vectorName, scalarName);
                foreach (var parameters in new[]
                {
                    new[] { vectorName, vectorName },
                    new[] { vectorName, scalarName },
                    new[] { scalarName, vectorName },
                })
                {
                    var scalarLeftModulus = FindFunction(functions, vectorName, "op_Modulus", parameters);
                    AssertEx.Equal("Unsupported", scalarLeftModulus.GetProperty("mapping").GetString());
                    AssertEx.True(scalarLeftModulus.GetProperty("glslName").ValueKind == JsonValueKind.Null);
                }
            }
        }

        private static void AssertIntegerOperator(JsonElement[] functions, string vectorName)
        {
            AssertFunction(functions, vectorName, "op_Modulus", "%", "Builtin", vectorName, vectorName);
            AssertFunction(functions, vectorName, "op_OnesComplement", "~", "Builtin", vectorName);
            AssertFunction(functions, vectorName, "op_LeftShift", "<<", "Builtin", vectorName, "int");
            AssertFunction(functions, vectorName, "op_RightShift", ">>", "Builtin", vectorName, "int");
            AssertFunction(functions, vectorName, "op_BitwiseAnd", "&", "Builtin", vectorName, vectorName);
            AssertFunction(functions, vectorName, "op_BitwiseOr", "|", "Builtin", vectorName, vectorName);
            AssertFunction(functions, vectorName, "op_ExclusiveOr", "^", "Builtin", vectorName, vectorName);
        }

        private static void AssertFunction(JsonElement[] functions, string typeName, string clrName,
            string glslName, string mapping, params string[] parameterNames)
        {
            var function = FindFunction(functions, typeName, clrName, parameterNames);
            AssertEx.Equal(glslName, function.GetProperty("glslName").GetString());
            AssertEx.Equal(mapping, function.GetProperty("mapping").GetString());
        }

        private static void AssertPackingFunction(JsonElement[] functions, string vectorName, string clrName)
        {
            var parameterType = clrName.StartsWith("Pack", StringComparison.Ordinal) ? vectorName : "uint";
            var returnType = parameterType == "uint" ? vectorName : "uint";
            var glslVector = "vec" + vectorName[^1];
            var glslParameter = parameterType == "uint" ? "uint" : glslVector;
            var glslReturn = returnType == "uint" ? "uint" : glslVector;
            var mathsName = char.ToLowerInvariant(clrName[0]) + clrName[1..];

            AssertFunction(functions, vectorName, clrName, mathsName, "Builtin", parameterType);
            AssertShaderSignature(functions, vectorName, clrName, new[] { glslParameter }, glslReturn, parameterType);
            AssertFunction(functions, "maths", mathsName, mathsName, "Builtin", parameterType);
            AssertShaderSignature(functions, "maths", mathsName, new[] { glslParameter }, glslReturn, parameterType);
        }

        private static void AssertShaderSignature(JsonElement[] functions, string typeName, string clrName,
            string[] parameterTypes, string returnType, params string[] parameterNames)
        {
            var function = FindFunction(functions, typeName, clrName, parameterNames);
            AssertEx.True(function.GetProperty("parameterGlslTypes").EnumerateArray()
                .Select(parameter => parameter.GetString())
                .SequenceEqual(parameterTypes));
            AssertEx.Equal(returnType, function.GetProperty("returnGlslType").GetString());
        }

        private static void AssertParameterModifiers(JsonElement[] functions, string typeName, string clrName,
            string[] modifiers, params string[] parameterNames)
        {
            var function = FindFunction(functions, typeName, clrName, parameterNames);
            AssertEx.True(function.GetProperty("parameterModifiers").EnumerateArray()
                .Select(parameter => parameter.GetString())
                .SequenceEqual(modifiers));
        }

        private static void AssertUnsupportedFunction(JsonElement[] functions, string typeName, string clrName,
            params string[] parameterNames)
        {
            var function = FindFunction(functions, typeName, clrName, parameterNames);
            AssertEx.Equal("Unsupported", function.GetProperty("mapping").GetString());
            AssertEx.True(function.GetProperty("glslName").ValueKind == JsonValueKind.Null);
        }

        private static JsonElement FindFunction(JsonElement[] functions, string typeName, string clrName, params string[] parameterNames)
        {
            return functions.Single(function => function.GetProperty("typeClrName").GetString() == typeName
                && function.GetProperty("clrName").GetString() == clrName
                && function.GetProperty("parameterClrNames").EnumerateArray().Select(parameter => parameter.GetString()).SequenceEqual(parameterNames));
        }

        private static bool HasFunction(JsonElement[] functions, string typeName, string clrName, params string[] parameterNames)
        {
            return functions.Any(function => function.GetProperty("typeClrName").GetString() == typeName
                && function.GetProperty("clrName").GetString() == clrName
                && function.GetProperty("parameterClrNames").EnumerateArray().Select(parameter => parameter.GetString()).SequenceEqual(parameterNames));
        }

        private static void AssertVectorType(JsonElement[] types, string clrName, string glslName, int alignment)
        {
            var type = types.Single(item => item.GetProperty("clrName").GetString() == clrName);
            AssertEx.Equal(glslName, type.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", type.GetProperty("mapping").GetString());
            AssertEx.Equal(alignment, type.GetProperty("alignment").GetInt32());
            AssertEx.Equal("std430", type.GetProperty("requiredCapability").GetString());
        }

        private static void AssertHalfVectorType(JsonElement[] types, string clrName, string glslName, int alignment, int size)
        {
            var type = types.Single(item => item.GetProperty("clrName").GetString() == clrName);
            AssertEx.Equal(glslName, type.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", type.GetProperty("mapping").GetString());
            AssertEx.Equal(alignment, type.GetProperty("alignment").GetInt32());
            AssertEx.Equal(size, type.GetProperty("size").GetInt32());
            AssertEx.Equal("float16_t", type.GetProperty("elementGlslType").GetString());
            AssertEx.Equal("float16", type.GetProperty("requiredCapability").GetString());
        }

        private static void AssertDoubleVectorType(JsonElement[] types, string clrName, string glslName, int alignment, int size)
        {
            var type = types.Single(item => item.GetProperty("clrName").GetString() == clrName);
            AssertEx.Equal(glslName, type.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", type.GetProperty("mapping").GetString());
            AssertEx.Equal(alignment, type.GetProperty("alignment").GetInt32());
            AssertEx.Equal(size, type.GetProperty("size").GetInt32());
            AssertEx.Equal("double", type.GetProperty("elementGlslType").GetString());
            AssertEx.Equal("float64", type.GetProperty("requiredCapability").GetString());
        }

        private static void AssertMatrixType(JsonElement[] types, string clrName, string glslName,
            int columns, int rows, int alignment, int stride, int size,
            string elementGlslType = "float", string requiredCapability = "std430")
        {
            var type = types.Single(item => item.GetProperty("clrName").GetString() == clrName);
            AssertEx.Equal(glslName, type.GetProperty("glslName").GetString());
            AssertEx.Equal("Builtin", type.GetProperty("mapping").GetString());
            AssertEx.True(type.GetProperty("columnMajor").GetBoolean());
            AssertEx.Equal(columns, type.GetProperty("matrixColumns").GetInt32());
            AssertEx.Equal(rows, type.GetProperty("matrixRows").GetInt32());
            AssertEx.Equal(elementGlslType, type.GetProperty("elementGlslType").GetString());
            AssertEx.Equal(alignment, type.GetProperty("alignment").GetInt32());
            AssertEx.Equal(stride, type.GetProperty("matrixStride").GetInt32());
            AssertEx.Equal(size, type.GetProperty("size").GetInt32());
            AssertEx.Equal(requiredCapability, type.GetProperty("requiredCapability").GetString());
        }

        private static void AssertMatrixConstructors(JsonElement type)
        {
            var constructors = type.GetProperty("constructors").EnumerateArray().ToArray();
            AssertEx.Equal(21, constructors.Length, type.GetProperty("clrName").GetString());
            for (var columns = 2; columns <= 4; columns++)
            {
                for (var rows = 2; rows <= 4; rows++)
                {
                    foreach (var scalar in new[] { "mat", "dmat" })
                    {
                        var glslName = columns == rows ? $"{scalar}{columns}" : $"{scalar}{columns}x{rows}";
                        AssertEx.True(constructors.Any(constructor => constructor.GetProperty("parameterGlslTypes")
                            .EnumerateArray()
                            .Select(parameter => parameter.GetString())
                            .SequenceEqual([glslName])));
                    }
                }
            }
        }

        private static string DoubleMatrixGlslName(int columns, int rows) => columns == rows
            ? $"dmat{columns}"
            : $"dmat{columns}x{rows}";

        public static void Glsl460Conformance()
        {
            // GLSL's mat4 * vec4 uses four column vectors and a column vector operand.
            var matrix = new float4x4(
                new float4(1f, 2f, 3f, 4f),
                new float4(5f, 6f, 7f, 8f),
                new float4(9f, 10f, 11f, 12f),
                new float4(13f, 14f, 15f, 16f));
            var vector = new float4(1f, 2f, 3f, 1f);

            AssertEx.Near(new float4(51f, 58f, 65f, 72f), matrix * vector);
            AssertEx.Near(new float3(5f, 7f, 9f), new float3(1f, 2f, 3f) + new float3(4f, 5f, 6f));
            AssertEx.Near(matrix.c0, matrix.GetColumn(0));
            AssertEx.Near(matrix.c3, matrix.GetColumn(3));

            var translation = float4x4.CreateTranslation(new float3(4f, -2f, 7f));
            AssertEx.Near(new float4(5f, 0f, 10f, 1f), translation * new float4(1f, 2f, 3f, 1f));
            AssertEx.Near(new float4(2f, 4f, 6f, 0f), translation * new float4(2f, 4f, 6f, 0f));

            var doubleMatrix = new double2x2(
                new double2(1d, 2d),
                new double2(3d, 4d));
            AssertEx.Near(new double2(23d, 34d), doubleMatrix * new double2(5d, 6d));
            var doubleProduct = doubleMatrix * doubleMatrix;
            AssertEx.Near(new double2(7d, 10d), doubleProduct.c0);
            AssertEx.Near(new double2(15d, 22d), doubleProduct.c1);
        }

        private static string FindShaderContractManifestPath()
        {
            var directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory is not null)
            {
                var candidates = new[]
                {
                    Path.Combine(
                        directory.FullName,
                        "src",
                        "DeltaMaths",
                        "Vectors",
                        "shader-contract.json"),
                };
                foreach (var candidate in candidates)
                {
                    if (File.Exists(candidate))
                    {
                        return candidate;
                    }
                }

                directory = directory.Parent;
            }
            throw new FileNotFoundException("shader-contract.json was not found near the repository.");
        }

        private static void AssertMatrixNear(float4x4 expected, float4x4 actual, float tolerance)
        {
            AssertEx.Near(expected.M11, actual.M11, tolerance);
            AssertEx.Near(expected.M12, actual.M12, tolerance);
            AssertEx.Near(expected.M13, actual.M13, tolerance);
            AssertEx.Near(expected.M14, actual.M14, tolerance);
            AssertEx.Near(expected.M21, actual.M21, tolerance);
            AssertEx.Near(expected.M22, actual.M22, tolerance);
            AssertEx.Near(expected.M23, actual.M23, tolerance);
            AssertEx.Near(expected.M24, actual.M24, tolerance);
            AssertEx.Near(expected.M31, actual.M31, tolerance);
            AssertEx.Near(expected.M32, actual.M32, tolerance);
            AssertEx.Near(expected.M33, actual.M33, tolerance);
            AssertEx.Near(expected.M34, actual.M34, tolerance);
            AssertEx.Near(expected.M41, actual.M41, tolerance);
            AssertEx.Near(expected.M42, actual.M42, tolerance);
            AssertEx.Near(expected.M43, actual.M43, tolerance);
            AssertEx.Near(expected.M44, actual.M44, tolerance);
        }

        private static void AssertQuaternionEquivalent(quaternion expected, quaternion actual, float tolerance)
        {
            var dot = quaternion.Dot(expected, actual);
            AssertEx.True(DeltaMaths.Abs(DeltaMaths.Abs(dot) - 1f) <= tolerance, $"Expected equivalent rotations, dot={dot}.");
        }

        private static float3 Float4ToPoint(float4 point)
        {
            return point.w == 0f
                ? point.xyz
                : point.xyz / point.w;
        }
    }
}
