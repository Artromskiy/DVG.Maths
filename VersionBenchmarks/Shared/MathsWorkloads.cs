namespace Delta.Maths.VersionBenchmarks.Shared;

public enum MathsWorkload
{
    Float2Add,
    Float3Add,
    Float4Add,
    Float3Dot,
    Float3Cross,
    Float3Normalize,
    QuaternionMultiply,
    QuaternionRotate,
    QuaternionNormalize,
    MatrixMultiply,
    MatrixVector,
    MatrixCreateTRS,
    MatrixTransformPoint,
    ScalarSin,
    ScalarCos,
    ScalarSqrt,
    ScalarInverseSqrt,
    ScalarLerp,
    ScalarClamp,
    ScalarAtan2,
    LayoutReadFloat3,
    LayoutWriteFloat3,
    LayoutReadFloat4,
    LayoutWriteFloat4,
    LayoutReadFloat4x4,
    LayoutWriteFloat4x4
}

public interface IMathsScenario
{
    float Run(MathsWorkload workload);
}
