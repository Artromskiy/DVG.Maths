using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace Delta.Maths.Tests
{
    internal static class MatrixQuaternionTests
    {
        public static void Layout()
        {
            AssertEx.Equal(64, Marshal.SizeOf<float4x4>());
            AssertEx.Equal(16, Marshal.SizeOf<quaternion>());
            AssertEx.Equal((IntPtr)0, Marshal.OffsetOf<float4x4>(nameof(float4x4.c0)));
            AssertEx.Equal((IntPtr)16, Marshal.OffsetOf<float4x4>(nameof(float4x4.c1)));
            AssertEx.Equal((IntPtr)32, Marshal.OffsetOf<float4x4>(nameof(float4x4.c2)));
            AssertEx.Equal((IntPtr)48, Marshal.OffsetOf<float4x4>(nameof(float4x4.c3)));
            AssertEx.Equal((IntPtr)0, Marshal.OffsetOf<quaternion>(nameof(quaternion.x)));
            AssertEx.Equal((IntPtr)4, Marshal.OffsetOf<quaternion>(nameof(quaternion.y)));
            AssertEx.Equal((IntPtr)8, Marshal.OffsetOf<quaternion>(nameof(quaternion.z)));
            AssertEx.Equal((IntPtr)12, Marshal.OffsetOf<quaternion>(nameof(quaternion.w)));

            AssertEx.Equal(typeof(float4), typeof(float4x4).GetField(nameof(float4x4.c0))?.FieldType);
            AssertEx.True(typeof(float4x4).GetProperty(nameof(float4x4.M14))?.CanWrite == true);
            AssertEx.True(typeof(quaternion).GetProperty(nameof(quaternion.X))?.CanWrite == true);
        }

        public static void MatrixAlgebra()
        {
            var translation = new float3(4f, -2f, 7f);
            var rotation = quaternion.CreateFromAxisAngle(new float3(0f, 1f, 0f), Maths.Radians(90f));
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
            var rotation = quaternion.CreateFromAxisAngle(axis, Maths.Radians(90f));
            AssertEx.Near(new float3(0f, 0f, 1f), rotation * new float3(1f, 0f, 0f), 0.0002f);
            AssertEx.Equal(quaternion.identity, quaternion.NormalizeSafe(new quaternion(0f, 0f, 0f, 0f)));
            AssertEx.True(!quaternion.TryInverse(new quaternion(0f, 0f, 0f, 0f), out _));
            AssertQuaternionEquivalent(quaternion.identity, rotation * quaternion.Inverse(rotation), 0.0002f);
            AssertQuaternionEquivalent(rotation, quaternion.CreateFromRotationMatrix(quaternion.ToRotationMatrix(rotation)), 0.0002f);

            quaternion.ToAxisAngle(rotation, out var recoveredAxis, out var recoveredAngle);
            var axisSign = float3.Dot(recoveredAxis, axis) < 0f ? -1f : 1f;
            AssertEx.Near(axis, recoveredAxis * axisSign, 0.0002f);
            AssertEx.Near(Maths.Radians(90f), recoveredAngle * axisSign, 0.0002f);
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

            var projection = float4x4.CreatePerspectiveFieldOfViewLeftHanded(Maths.Radians(60f), 1.6f, 0.1f, 100f);
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

            var types = root.GetProperty("types").EnumerateArray().ToArray();
            AssertEx.True(types.Any(type => type.GetProperty("clrName").GetString() == "float4x4"));
            AssertEx.True(types.Any(type => type.GetProperty("clrName").GetString() == "quaternion"));
            AssertEx.True(types.Any(type => type.GetProperty("glslName").GetString() == "mat4"));

            var functions = root.GetProperty("functions").EnumerateArray().ToArray();
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("typeClrName").GetString())));
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("clrName").GetString())));
            AssertEx.True(functions.All(function => !string.IsNullOrWhiteSpace(function.GetProperty("mathsName").GetString())));
            var createTrs = functions.FirstOrDefault(
                function => function.GetProperty("typeClrName").GetString() == "float4x4"
                    && function.GetProperty("clrName").GetString() == "CreateTRS");
            AssertEx.True(createTrs.ValueKind != JsonValueKind.Undefined);
            AssertEx.Equal("Helper", createTrs.GetProperty("mapping").GetString());
            AssertEx.Equal("matrix", createTrs.GetProperty("requiredCapability").GetString());
        }

        private static string FindShaderContractManifestPath()
        {
            var directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory is not null)
            {
                var candidate = Path.Combine(directory.FullName, "Maths", "Vectors", "shader-contract.json");
                if (File.Exists(candidate))
                    return candidate;
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
            AssertEx.True(Maths.Abs(Maths.Abs(dot) - 1f) <= tolerance, $"Expected equivalent rotations, dot={dot}.");
        }

        private static float3 Float4ToPoint(float4 point)
        {
            return point.w == 0f
                ? point.xyz
                : point.xyz / point.w;
        }
    }
}
