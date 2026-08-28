extern alias baselineAdapter;
extern alias candidateAdapter;

using BenchmarkDotNet.Attributes;
using Delta.Maths.VersionBenchmarks.Shared;

using BaselineDeltaMathsScenario = baselineAdapter::Delta.Maths.VersionAdapter.DeltaMathsScenario;
using CandidateDeltaMathsScenario = candidateAdapter::Delta.Maths.VersionAdapter.DeltaMathsScenario;

namespace Delta.Maths.VersionBenchmarks;

public abstract class VersionBenchmarkBase
{
    private IDeltaMathsScenario? _baseline;
    private IDeltaMathsScenario? _candidate;

    protected IDeltaMathsScenario Baseline => _baseline ?? throw new InvalidOperationException("Baseline scenario was not initialized.");
    protected IDeltaMathsScenario Candidate => _candidate ?? throw new InvalidOperationException("Candidate scenario was not initialized.");

    protected void Initialize(int count, DeltaMathsWorkload workload)
    {
        var inputs = DeltaMathsInputs.Create(count);
        _baseline = new BaselineDeltaMathsScenario(inputs.Clone());
        _candidate = new CandidateDeltaMathsScenario(inputs.Clone());
        VersionBenchmarkSmoke.RequireEquivalent(Baseline, Candidate, workload);
    }
}

[MemoryDiagnoser]
public class VersionBenchmarkSmokeBenchmarks : VersionBenchmarkBase
{
    [GlobalSetup]
    public void Setup() => Initialize(256, DeltaMathsWorkload.Float2Add);

    [Benchmark(Baseline = true)]
    public float BaselineVersion() => Baseline.Run(DeltaMathsWorkload.Float2Add);

    [Benchmark]
    public float CandidateVersion() => Candidate.Run(DeltaMathsWorkload.Float2Add);
}

[MemoryDiagnoser]
public class VectorArithmeticVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(DeltaMathsWorkload.Float2Add, DeltaMathsWorkload.Float3Add, DeltaMathsWorkload.Float4Add)]
    public DeltaMathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class VectorGeometryVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(DeltaMathsWorkload.Float3Dot, DeltaMathsWorkload.Float3Cross, DeltaMathsWorkload.Float3Normalize)]
    public DeltaMathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class QuaternionVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(DeltaMathsWorkload.QuaternionMultiply, DeltaMathsWorkload.QuaternionRotate, DeltaMathsWorkload.QuaternionNormalize)]
    public DeltaMathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class MatrixVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(
        DeltaMathsWorkload.MatrixMultiply,
        DeltaMathsWorkload.MatrixVector,
        DeltaMathsWorkload.MatrixCreateTRS,
        DeltaMathsWorkload.MatrixTransformPoint)]
    public DeltaMathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class ScalarVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(
        DeltaMathsWorkload.ScalarSin,
        DeltaMathsWorkload.ScalarCos,
        DeltaMathsWorkload.ScalarSqrt,
        DeltaMathsWorkload.ScalarInverseSqrt,
        DeltaMathsWorkload.ScalarLerp,
        DeltaMathsWorkload.ScalarClamp,
        DeltaMathsWorkload.ScalarAtan2)]
    public DeltaMathsWorkload Workload { get; set; }

    [GlobalSetup] public void Setup() => Initialize(Count, Workload);
    [Benchmark(Baseline = true)] public float BaselineVersion() => Baseline.Run(Workload);
    [Benchmark] public float CandidateVersion() => Candidate.Run(Workload);
}

[MemoryDiagnoser]
public class LayoutVersionBenchmarks : VersionBenchmarkBase
{
    [Params(256, 4096, 65536)] public int Count { get; set; }
    [Params(
        DeltaMathsWorkload.LayoutReadFloat3,
        DeltaMathsWorkload.LayoutWriteFloat3,
        DeltaMathsWorkload.LayoutReadFloat4,
        DeltaMathsWorkload.LayoutWriteFloat4,
        DeltaMathsWorkload.LayoutReadFloat4x4,
        DeltaMathsWorkload.LayoutWriteFloat4x4)]
    public DeltaMathsWorkload Workload { get; set; }

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
