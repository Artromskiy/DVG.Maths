using Delta.Maths.VersionBenchmarks.Shared;

namespace Delta.Maths.VersionBenchmarks;

internal static class BenchmarkSettings
{
    public const int DefaultCount = 256;

    public static int Count { get; private set; } = DefaultCount;

    public static DeltaMathsWorkload? Workload { get; private set; }

    public static DeltaMathsWorkload ForFamily(DeltaMathsWorkload defaultWorkload, params DeltaMathsWorkload[] supported)
    {
        if (Workload is not { } selected)
            return defaultWorkload;

        if (Array.IndexOf(supported, selected) >= 0)
            return selected;

        throw new ArgumentException(
            $"Workload '{selected}' is not supported by this benchmark family. " +
            $"Supported values: {string.Join(", ", supported)}.");
    }

    public static string[] Configure(string[] args)
    {
        var remaining = new List<string>(args.Length);
        for (var i = 0; i < args.Length; i++)
        {
            if (args[i] == "--count" && i + 1 < args.Length
                && int.TryParse(args[++i], out var count)
                && count is 256 or 4096 or 65536)
            {
                Count = count;
                continue;
            }

            if (args[i] == "--workload" && i + 1 < args.Length
                && Enum.TryParse(args[++i], true, out DeltaMathsWorkload workload))
            {
                Workload = workload;
                continue;
            }

            remaining.Add(args[i]);
        }

        return remaining.ToArray();
    }
}
