using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class MaskBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private bool3[] _bool3A = null!;
    private bool3[] _bool3B = null!;
    private bool3[] _bool3Mask = null!;
    private bool4[] _bool4A = null!;
    private bool4[] _bool4B = null!;
    private bool4[] _bool4Mask = null!;
    private float3[] _float3A = null!;
    private float3[] _float3B = null!;
    private float4[] _float4A = null!;
    private float4[] _float4B = null!;

    [GlobalSetup]
    public void Setup()
    {
        _bool3A = new bool3[Count];
        _bool3B = new bool3[Count];
        _bool3Mask = new bool3[Count];
        _bool4A = new bool4[Count];
        _bool4B = new bool4[Count];
        _bool4Mask = new bool4[Count];
        _float3A = new float3[Count];
        _float3B = new float3[Count];
        _float4A = new float4[Count];
        _float4B = new float4[Count];

        var random = new Random(61);
        for (var i = 0; i < Count; i++)
        {
            _bool3A[i] = new bool3(RandomBoolean(random), RandomBoolean(random), RandomBoolean(random));
            _bool3B[i] = new bool3(RandomBoolean(random), RandomBoolean(random), RandomBoolean(random));
            _bool3Mask[i] = new bool3(RandomBoolean(random), RandomBoolean(random), RandomBoolean(random));
            _float3A[i] = new float3(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _float3B[i] = new float3(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _bool4A[i] = new bool4(
                RandomBoolean(random),
                RandomBoolean(random),
                RandomBoolean(random),
                RandomBoolean(random));
            _bool4B[i] = new bool4(
                RandomBoolean(random),
                RandomBoolean(random),
                RandomBoolean(random),
                RandomBoolean(random));
            _bool4Mask[i] = new bool4(
                RandomBoolean(random),
                RandomBoolean(random),
                RandomBoolean(random),
                RandomBoolean(random));
            _float4A[i] = new float4(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _float4B[i] = new float4(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
        }
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool3.Comparisons")]
    public float Bool3Comparisons()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var mask = float3.GreaterThan(_float3A[i], _float3B[i]);
            sum += (mask.x ? 1f : 0f) + (mask.y ? 1f : 0f) + (mask.z ? 1f : 0f);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool4.Comparisons")]
    public float Bool4Comparisons()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var mask = float4.GreaterThan(_float4A[i], _float4B[i]);
            sum += (mask.x ? 1f : 0f) + (mask.y ? 1f : 0f) + (mask.z ? 1f : 0f) + (mask.w ? 1f : 0f);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool3.Select")]
    public float Bool3Select()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = bool3.Select(_bool3A[i], _bool3B[i], _bool3Mask[i]);
            sum += (value.x ? 1f : 0f) + (value.y ? 1f : 0f) + (value.z ? 1f : 0f);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool4.Select")]
    public float Bool4Select()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = bool4.Select(_bool4A[i], _bool4B[i], _bool4Mask[i]);
            sum += (value.x ? 1f : 0f) + (value.y ? 1f : 0f) + (value.z ? 1f : 0f) + (value.w ? 1f : 0f);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool3.Any")]
    public float Bool3Any()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += bool3.Any(_bool3A[i]) ? 1f : 0f;
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool3.All")]
    public float Bool3All()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += bool3.All(_bool3A[i]) ? 1f : 0f;
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool4.Any")]
    public float Bool4Any()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += bool4.Any(_bool4A[i]) ? 1f : 0f;
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Mask.Bool4.All")]
    public float Bool4All()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += bool4.All(_bool4A[i]) ? 1f : 0f;
        return sum;
    }

    private static bool RandomBoolean(Random random) => random.Next(0, 2) == 1;
}
