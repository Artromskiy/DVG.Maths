using System;

namespace Delta.Maths.Tests
{
    internal static class Program
    {
        private static int Main()
        {
            var tests = new (string Name, Action Run)[]
            {
                ("all vector families expose a complete core API", VectorStructureTests.CoreApi),
                ("capabilities expose the expected vector functions", VectorStructureTests.CapabilityApi),
                ("constructors and swizzles compose components", VectorBehaviorTests.ConstructorsAndSwizzles),
                ("arithmetic, masks, and conversions are component-wise", VectorBehaviorTests.OperatorsAndConversions),
                ("parsing and formatting round-trip invariantly", VectorBehaviorTests.ParsingAndFormatting),
                ("common component-wise maths works", VectorBehaviorTests.CommonMaths),
                ("geometry matches established vector cases", VectorBehaviorTests.Geometry),
                ("normalization handles zero and tiny inputs", VectorBehaviorTests.Normalization),
                ("lowercase maths forwards scalar and vector APIs", VectorBehaviorTests.ShaderStyleFacade),
                ("fixed-point vectors participate in maths", VectorBehaviorTests.FixedPoint),
                ("scalar regressions stay fixed", VectorBehaviorTests.ScalarRegressions),
                ("matrix and quaternion layout is stable", MatrixQuaternionTests.Layout),
                ("matrix algebra and decomposition are safe", MatrixQuaternionTests.MatrixAlgebra),
                ("matrix-vector and matrix composition semantics", MatrixQuaternionTests.MatrixVectorSemantics),
                ("quaternion algebra and conversions are stable", MatrixQuaternionTests.QuaternionAlgebra),
                ("matrix look/projection conventions", MatrixQuaternionTests.MatrixLookProjectionSemantics),
                ("shader contract manifest metadata", MatrixQuaternionTests.ShaderContractManifest),
            };

            var failures = 0;
            foreach (var test in tests)
            {
                try
                {
                    test.Run();
                    Console.WriteLine("PASS " + test.Name);
                }
                catch (Exception exception)
                {
                    failures++;
                    Console.Error.WriteLine("FAIL " + test.Name);
                    Console.Error.WriteLine(exception);
                }
            }

            Console.WriteLine($"{tests.Length - failures}/{tests.Length} tests passed.");
            return failures == 0 ? 0 : 1;
        }
    }
}
