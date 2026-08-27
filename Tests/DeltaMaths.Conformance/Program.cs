namespace Delta.Maths.Conformance;

internal static class Program
{
    private static int Main()
    {
        try
        {
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
