namespace Delta.Maths.Conformance;

internal static class Program
{
    private static int Main(string[] args)
    {
        try
        {
            if (args.Length == 2 && string.Equals(args[0], "--write-bundle", StringComparison.Ordinal))
            {
                ShaderContractConformance.Run();
                var summary = ShaderContractBundle.Write(args[1]);
                Console.WriteLine(
                    $"CPU case bundle: {summary.Path} ({summary.Coverage.CaseCount} cases, "
                    + $"{summary.Coverage.ExcludedCount} excluded, "
                    + $"{summary.Coverage.UnsupportedManifestCount} unsupported manifest functions)");
                return 0;
            }

            if (args.Length != 0)
            {
                Console.Error.WriteLine("Usage: [--write-bundle <path>]");
                return 2;
            }

            MathConformanceTests.Run();
            Console.WriteLine("CPU conformance: PASS");
            return 0;
        }
        catch (InvalidOperationException exception)
        {
            Console.Error.WriteLine("CPU conformance: FAIL");
            Console.Error.WriteLine(exception.Message);
            return 1;
        }
    }
}
