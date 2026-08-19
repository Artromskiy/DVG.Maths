namespace Delta.Maths.VersionBenchmarks.Shared;

public readonly struct InputFloat2
{
    public InputFloat2(float x, float y) => (X, Y) = (x, y);
    public float X { get; }
    public float Y { get; }
}

public readonly struct InputFloat3
{
    public InputFloat3(float x, float y, float z) => (X, Y, Z) = (x, y, z);
    public float X { get; }
    public float Y { get; }
    public float Z { get; }
}

public readonly struct InputFloat4
{
    public InputFloat4(float x, float y, float z, float w) => (X, Y, Z, W) = (x, y, z, w);
    public float X { get; }
    public float Y { get; }
    public float Z { get; }
    public float W { get; }
}

public readonly struct InputMatrix4x4
{
    public InputMatrix4x4(
        float m11, float m12, float m13, float m14,
        float m21, float m22, float m23, float m24,
        float m31, float m32, float m33, float m34,
        float m41, float m42, float m43, float m44)
    {
        M11 = m11; M12 = m12; M13 = m13; M14 = m14;
        M21 = m21; M22 = m22; M23 = m23; M24 = m24;
        M31 = m31; M32 = m32; M33 = m33; M34 = m34;
        M41 = m41; M42 = m42; M43 = m43; M44 = m44;
    }

    public float M11 { get; }
    public float M12 { get; }
    public float M13 { get; }
    public float M14 { get; }
    public float M21 { get; }
    public float M22 { get; }
    public float M23 { get; }
    public float M24 { get; }
    public float M31 { get; }
    public float M32 { get; }
    public float M33 { get; }
    public float M34 { get; }
    public float M41 { get; }
    public float M42 { get; }
    public float M43 { get; }
    public float M44 { get; }
}

public sealed class MathsInputs
{
    private MathsInputs(int count)
    {
        Count = count;
        ScalarA = new float[count];
        ScalarB = new float[count];
        Positive = new float[count];
        Float2A = new InputFloat2[count];
        Float2B = new InputFloat2[count];
        Float3A = new InputFloat3[count];
        Float3B = new InputFloat3[count];
        Points = new InputFloat3[count];
        Float4A = new InputFloat4[count];
        Float4B = new InputFloat4[count];
        YawA = new float[count];
        PitchA = new float[count];
        RollA = new float[count];
        YawB = new float[count];
        PitchB = new float[count];
        RollB = new float[count];
        TransformTranslations = new InputFloat3[count];
        TransformScales = new InputFloat3[count];
        TransformPoints = new InputFloat3[count];
        TransformYaw = new float[count];
        TransformPitch = new float[count];
        TransformRoll = new float[count];
        MatrixA = new InputMatrix4x4[count];
        MatrixB = new InputMatrix4x4[count];
        LayoutFloat3 = new InputFloat3[count];
        LayoutFloat4 = new InputFloat4[count];
        LayoutMatrices = new InputMatrix4x4[count];
    }

    public int Count { get; }
    public float[] ScalarA { get; }
    public float[] ScalarB { get; }
    public float[] Positive { get; }
    public InputFloat2[] Float2A { get; }
    public InputFloat2[] Float2B { get; }
    public InputFloat3[] Float3A { get; }
    public InputFloat3[] Float3B { get; }
    public InputFloat3[] Points { get; }
    public InputFloat4[] Float4A { get; }
    public InputFloat4[] Float4B { get; }
    public float[] YawA { get; }
    public float[] PitchA { get; }
    public float[] RollA { get; }
    public float[] YawB { get; }
    public float[] PitchB { get; }
    public float[] RollB { get; }
    public InputFloat3[] TransformTranslations { get; }
    public InputFloat3[] TransformScales { get; }
    public InputFloat3[] TransformPoints { get; }
    public float[] TransformYaw { get; }
    public float[] TransformPitch { get; }
    public float[] TransformRoll { get; }
    public InputMatrix4x4[] MatrixA { get; }
    public InputMatrix4x4[] MatrixB { get; }
    public InputFloat3[] LayoutFloat3 { get; }
    public InputFloat4[] LayoutFloat4 { get; }
    public InputMatrix4x4[] LayoutMatrices { get; }

    public static MathsInputs Create(int count, int seed = 101)
    {
        var inputs = new MathsInputs(count);
        var random = new Random(seed);
        for (var i = 0; i < count; i++)
        {
            inputs.ScalarA[i] = Next(random, 1f);
            inputs.ScalarB[i] = Next(random, 1f);
            inputs.Positive[i] = random.NextSingle() + 0.001f;

            inputs.Float2A[i] = NextFloat2(random, 10f);
            inputs.Float2B[i] = NextFloat2(random, 10f);
            inputs.Float3A[i] = NextFloat3(random, 10f);
            inputs.Float3B[i] = NextFloat3(random, 10f);
            inputs.Points[i] = NextFloat3(random, 10f);
            inputs.Float4A[i] = NextFloat4(random, 10f);
            inputs.Float4B[i] = NextFloat4(random, 10f);

            inputs.YawA[i] = Next(random, 1f);
            inputs.PitchA[i] = Next(random, 1f);
            inputs.RollA[i] = Next(random, 1f);
            inputs.YawB[i] = Next(random, 1f);
            inputs.PitchB[i] = Next(random, 1f);
            inputs.RollB[i] = Next(random, 1f);

            inputs.TransformTranslations[i] = NextFloat3(random, 10f);
            inputs.TransformScales[i] = new InputFloat3(
                random.NextSingle() * 2f + 0.5f,
                random.NextSingle() * 2f + 0.5f,
                random.NextSingle() * 2f + 0.5f);
            inputs.TransformPoints[i] = NextFloat3(random, 10f);
            inputs.TransformYaw[i] = Next(random, 1f);
            inputs.TransformPitch[i] = Next(random, 1f);
            inputs.TransformRoll[i] = Next(random, 1f);

            inputs.MatrixA[i] = NextMatrix(random);
            inputs.MatrixB[i] = NextMatrix(random);
            inputs.LayoutFloat3[i] = NextFloat3(random, 1f);
            inputs.LayoutFloat4[i] = NextFloat4(random, 1f);
            inputs.LayoutMatrices[i] = NextMatrix(random);
        }

        return inputs;
    }

    public MathsInputs Clone()
    {
        var clone = new MathsInputs(Count);
        Array.Copy(ScalarA, clone.ScalarA, Count);
        Array.Copy(ScalarB, clone.ScalarB, Count);
        Array.Copy(Positive, clone.Positive, Count);
        Array.Copy(Float2A, clone.Float2A, Count);
        Array.Copy(Float2B, clone.Float2B, Count);
        Array.Copy(Float3A, clone.Float3A, Count);
        Array.Copy(Float3B, clone.Float3B, Count);
        Array.Copy(Points, clone.Points, Count);
        Array.Copy(Float4A, clone.Float4A, Count);
        Array.Copy(Float4B, clone.Float4B, Count);
        Array.Copy(YawA, clone.YawA, Count);
        Array.Copy(PitchA, clone.PitchA, Count);
        Array.Copy(RollA, clone.RollA, Count);
        Array.Copy(YawB, clone.YawB, Count);
        Array.Copy(PitchB, clone.PitchB, Count);
        Array.Copy(RollB, clone.RollB, Count);
        Array.Copy(TransformTranslations, clone.TransformTranslations, Count);
        Array.Copy(TransformScales, clone.TransformScales, Count);
        Array.Copy(TransformPoints, clone.TransformPoints, Count);
        Array.Copy(TransformYaw, clone.TransformYaw, Count);
        Array.Copy(TransformPitch, clone.TransformPitch, Count);
        Array.Copy(TransformRoll, clone.TransformRoll, Count);
        Array.Copy(MatrixA, clone.MatrixA, Count);
        Array.Copy(MatrixB, clone.MatrixB, Count);
        Array.Copy(LayoutFloat3, clone.LayoutFloat3, Count);
        Array.Copy(LayoutFloat4, clone.LayoutFloat4, Count);
        Array.Copy(LayoutMatrices, clone.LayoutMatrices, Count);
        return clone;
    }

    private static float Next(Random random, float range) => random.NextSingle() * range * 2f - range;

    private static InputFloat2 NextFloat2(Random random, float range) =>
        new(Next(random, range), Next(random, range));

    private static InputFloat3 NextFloat3(Random random, float range) =>
        new(Next(random, range), Next(random, range), Next(random, range));

    private static InputFloat4 NextFloat4(Random random, float range) =>
        new(Next(random, range), Next(random, range), Next(random, range), Next(random, range));

    private static InputMatrix4x4 NextMatrix(Random random) => new(
        Next(random, 1f), Next(random, 1f), Next(random, 1f), Next(random, 1f),
        Next(random, 1f), Next(random, 1f), Next(random, 1f), Next(random, 1f),
        Next(random, 1f), Next(random, 1f), Next(random, 1f), Next(random, 1f),
        Next(random, 1f), Next(random, 1f), Next(random, 1f), Next(random, 1f));
}
