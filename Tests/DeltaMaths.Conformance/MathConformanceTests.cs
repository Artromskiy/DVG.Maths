namespace Delta.Maths.Conformance;

internal static class MathConformanceTests
{
    public static void Run()
    {
        VectorOperations();
        VectorFunctions();
        MatrixSemantics();
        QuaternionSemantics();
        ShaderContractConformance.Run();
    }

    private static void VectorOperations()
    {
        var left = new float3(1f, 2f, 3f);
        var right = new float3(4f, 5f, 6f);

        ConformanceAssert.Equal(32f, float3.Dot(left, right), "float3.Dot");
        ConformanceAssert.Equal(new float3(-3f, 6f, -3f), float3.Cross(left, right), "float3.Cross");
        ConformanceAssert.Near(new float3(0.6f, 0.8f, 0f), float3.NormalizeSafe(new float3(3f, 4f, 0f)), 0.0002f, "float3.NormalizeSafe");
    }

    private static void VectorFunctions()
    {
        ConformanceAssert.Equal(new float3(0f, 0.5f, 1f), float3.Saturate(new float3(-2f, 0.5f, 3f)), "float3.Saturate");
        ConformanceAssert.Equal(new float3(0.25f, 0.75f, 0f), float3.Fract(new float3(1.25f, -1.25f, 2f)), "float3.Fract");
        ConformanceAssert.Equal(new float3(0f, 1f, 1f), float3.Step(new float3(1f, 1f, 1f), new float3(0f, 1f, 2f)), "float3.Step");
        ConformanceAssert.Near(MathF.PI, DeltaMaths.Radians(180f), 0.00001f, "Radians");
    }

    private static void MatrixSemantics()
    {
        var translated = float4x4.CreateTranslation(new float3(1f, -2f, 3f));
        var scaled = float4x4.CreateScale(new float3(2f, 3f, 4f));
        var composed = translated * scaled;
        var point = new float3(3f, 1f, 2f);

        var expected = float4x4.TransformPoint(translated, float4x4.TransformPoint(scaled, point));
        var actualHomogeneous = composed * new float4(point, 1f);
        var actual = new float3(actualHomogeneous.x, actualHomogeneous.y, actualHomogeneous.z);
        ConformanceAssert.Near(expected, actual, 0.0002f, "column-vector matrix composition");
    }

    private static void QuaternionSemantics()
    {
        var rotation = quaternion.CreateFromAxisAngle(new float3(0f, 1f, 0f), DeltaMaths.Radians(90f));
        var rotated = rotation * new float3(1f, 0f, 0f);

        ConformanceAssert.Near(new float3(0f, 0f, 1f), rotated, 0.0002f, "quaternion rotation");
    }
}

internal static class ConformanceAssert
{
    public static void Equal<T>(T expected, T actual, string name)
    {
        if (!Equals(expected, actual))
        {
            throw new InvalidOperationException($"{name}: expected '{expected}', got '{actual}'.");
        }
    }

    public static void Near(float expected, float actual, float tolerance, string name)
    {
        if (float.IsNaN(actual) || MathF.Abs(expected - actual) > tolerance)
        {
            throw new InvalidOperationException($"{name}: expected {expected} +/- {tolerance}, got {actual}.");
        }
    }

    public static void Near(float3 expected, float3 actual, float tolerance, string name)
    {
        Near(expected.x, actual.x, tolerance, name + ".x");
        Near(expected.y, actual.y, tolerance, name + ".y");
        Near(expected.z, actual.z, tolerance, name + ".z");
    }
}
