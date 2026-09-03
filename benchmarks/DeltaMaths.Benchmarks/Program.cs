using BenchmarkDotNet.Running;
using Delta.Benchmarks;

BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(BenchmarkSettings.Configure(args));
