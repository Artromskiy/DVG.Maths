namespace Delta.Benchmarks;

internal static class BenchmarkSettings
{
    public const int DefaultCount = 256;

    public static int Count { get; private set; } = DefaultCount;

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

            remaining.Add(args[i]);
        }

        return remaining.ToArray();
    }
}
