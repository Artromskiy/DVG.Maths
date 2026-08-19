extern alias baselineAdapter;
extern alias candidateAdapter;

using BenchmarkDotNet.Attributes;
using Delta.Maths.VersionBenchmarks.Shared;

using BaselineMathsScenario = baselineAdapter::Delta.Maths.VersionAdapter.MathsScenario;
using CandidateMathsScenario = candidateAdapter::Delta.Maths.VersionAdapter.MathsScenario;

namespace Delta.Maths.VersionBenchmarks;

public abstract class VersionBenchmarkBase
{
    protected IMathsScenario Baseline = null!;
    protected IMathsScenario Candidate = null!;

    protected void Initialize(int count, MathsWorkload workload)
    {
        var inputs = MathsInputs.Create(count);
        Baseline = new BaselineMathsScenario(inputs.Clone());
        Candidate = new CandidateMathsScenario(inputs.Clone());
        VersionBenchmarkSmoke.RequireEquivalent(Baseline, Candidate, workload);
    }
}

[MemoryDiagnoser]
public class VersionBenchmarkSmokeBenchmarks : VersionBenchmarkBase
{
    [GlobalSetup]
    public void Setup() => Initialize(256, MathsWorkload.Float2Add);

    [Benchmark(Baseline = true)]
    public float BaselineVersion() => Baseline.Run(MathsWorkload.Float2Add);

    [Benchmark]
    public float CandidateVersion() => Candidate.Run(MathsWorkload.Float2Add);
}

[MemoryDiagnoser]
public class VectorArithmeticVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(MathsWorkload.Float2Add, MathsWorkload.Float3Add, MathsWorkload.Float4Add)]
    public MathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class VectorGeometryVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(MathsWorkload.Float3Dot, MathsWorkload.Float3Cross, MathsWorkload.Float3Normalize)]
    public MathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class QuaternionVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(MathsWorkload.QuaternionMultiply, MathsWorkload.QuaternionRotate, MathsWorkload.QuaternionNormalize)]
    public MathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class MatrixVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(
        MathsWorkload.MatrixMultiply,
        MathsWorkload.MatrixVector,
        MathsWorkload.MatrixCreateTRS,
        MathsWorkload.MatrixTransformPoint)]
    public MathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class ScalarVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(
        MathsWorkload.ScalarSin,
        MathsWorkload.ScalarCos,
        MathsWorkload.ScalarSqrt,
        MathsWorkload.ScalarInverseSqrt,
        MathsWorkload.ScalarLerp,
        MathsWorkload.ScalarClamp,
        MathsWorkload.ScalarAtan2)]
    public MathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class LayoutVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(
        MathsWorkload.LayoutReadFloat3,
        MathsWorkload.LayoutWriteFloat3,
        MathsWorkload.LayoutReadFloat4,
        MathsWorkload.LayoutWriteFloat4,
        MathsWorkload.LayoutReadFloat4x4,
        MathsWorkload.LayoutWriteFloat4x4)]
    public MathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

internal static class VersionBenchmarkCatalog
{
    public static readonly Type[] Types =
    [
        typeof(VectorArithmeticVersionBenchmarks),
        typeof(VectorGeometryVersionBenchmarks),
        typeof(QuaternionVersionBenchmarks),
        typeof(MatrixVersionBenchmarks),
        typeof(ScalarVersionBenchmarks),
        typeof(LayoutVersionBenchmarks)
    ];
}
