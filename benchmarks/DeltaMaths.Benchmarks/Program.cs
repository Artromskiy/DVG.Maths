using BenchmarkDotNet.Running;
using Delta.Maths.Benchmarks;

BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(BenchmarkSettings.Configure(args));
