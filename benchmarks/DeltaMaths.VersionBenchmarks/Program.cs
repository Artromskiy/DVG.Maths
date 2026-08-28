extern alias baselineAdapter;
extern alias candidateAdapter;

using System.Reflection;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Delta.Maths.VersionBenchmarks.Shared;

using BaselineDeltaMathsScenario = baselineAdapter::Delta.Maths.VersionAdapter.DeltaMathsScenario;
using CandidateDeltaMathsScenario = candidateAdapter::Delta.Maths.VersionAdapter.DeltaMathsScenario;

namespace Delta.Maths.VersionBenchmarks;

public static class Program
{
    public static void Main(string[] args)
    {
        var baselineRoot = ResolveVersionRoot("BASELINE_ROOT", "DeltaMaths.BaselineRoot");
        var candidateRoot = ResolveVersionRoot("CANDIDATE_ROOT", "DeltaMaths.CandidateRoot");

        VersionBenchmarkSmoke.Run();
        if (args.Length > 0 && string.Equals(args[0], "smoke", StringComparison.OrdinalIgnoreCase))
            return;

        if (args.Length > 0 && string.Equals(args[0], "benchmark-smoke", StringComparison.OrdinalIgnoreCase))
        {
            var smokeConfig = CreateConfig(baselineRoot, candidateRoot);
            smokeConfig.AddJob(Job.Default
                .WithWarmupCount(1)
                .WithIterationCount(1)
                .WithLaunchCount(1)
                .WithInvocationCount(16)
                .AsMutator());
            BenchmarkSwitcher.FromTypes([typeof(VersionBenchmarkSmokeBenchmarks)])
                .Run(args.Skip(1).ToArray(), smokeConfig);
            return;
        }

        var config = CreateConfig(baselineRoot, candidateRoot);
        BenchmarkSwitcher.FromTypes(VersionBenchmarkCatalog.Types).Run(args, config);
    }

    private static ManualConfig CreateConfig(string baselineRoot, string candidateRoot)
    {
        var config = ManualConfig.Create(DefaultConfig.Instance);
        config.AddJob(Job.Default
            .WithArguments(
            [
                new MsBuildArgument($"/p:BaselineRoot={baselineRoot}"),
                new MsBuildArgument($"/p:CandidateRoot={candidateRoot}")
            ])
            .AsMutator());
        return config;
    }

    private static string ResolveVersionRoot(string environmentName, string metadataName)
    {
        var environmentValue = Environment.GetEnvironmentVariable(environmentName);
        if (!string.IsNullOrWhiteSpace(environmentValue))
            return Path.GetFullPath(environmentValue);

        var metadataValue = typeof(Program).Assembly
            .GetCustomAttributes<AssemblyMetadataAttribute>()
            .FirstOrDefault(attribute => string.Equals(attribute.Key, metadataName, StringComparison.Ordinal))
            ?.Value;
        if (!string.IsNullOrWhiteSpace(metadataValue))
            return Path.GetFullPath(metadataValue);

        throw new InvalidOperationException(
            $"Version root is unavailable. Set {environmentName} or rebuild the version suite with its matching MSBuild root property.");
    }
}

internal static class VersionBenchmarkSmoke
{
    public static void Run()
    {
        var inputs = DeltaMathsInputs.Create(32);
        var baseline = new BaselineDeltaMathsScenario(inputs.Clone());
        var candidate = new CandidateDeltaMathsScenario(inputs.Clone());

        foreach (var workload in Enum.GetValues<DeltaMathsWorkload>())
            RequireEquivalent(baseline.Run(workload), candidate.Run(workload), workload);

        Console.WriteLine($"Version comparison smoke passed: {Enum.GetValues<DeltaMathsWorkload>().Length} DeltaMaths workloads.");
    }

    public static void RequireEquivalent(IDeltaMathsScenario baseline, IDeltaMathsScenario candidate, DeltaMathsWorkload workload)
    {
        RequireEquivalent(baseline.Run(workload), candidate.Run(workload), workload);
    }

    private static void RequireEquivalent(float baseline, float candidate, DeltaMathsWorkload workload)
    {
        var difference = MathF.Abs(baseline - candidate);
        var scale = MathF.Max(1f, MathF.Max(MathF.Abs(baseline), MathF.Abs(candidate)));
        if (float.IsNaN(baseline) || float.IsNaN(candidate) || difference > 0.0001f * scale)
        {
            throw new InvalidOperationException(
                $"{workload} checksum mismatch: baseline={baseline:R}, candidate={candidate:R}, difference={difference:R}.");
        }
    }
}
