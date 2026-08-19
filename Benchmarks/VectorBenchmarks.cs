using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class VectorBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float3[] _left = null!;
    private float3[] _right = null!;
    private float3[] _values = null!;

    [GlobalSetup]
    public void Setup()
    {
        _left = new float3[Count];
        _right = new float3[Count];
        _values = new float3[Count];

        var random = new Random(17);
        for (var i = 0; i < Count; i++)
        {
            _left[i] = NextVector(random);
            _right[i] = NextVector(random);
            _values[i] = NextVector(random);
        }
    }

    [Benchmark]
    [BenchmarkCategory("Vector.Add")]
    public float Add()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _left[i] + _right[i];
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Vector.Dot")]
    public float Dot()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += float3.Dot(_left[i], _right[i]);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Vector.Cross")]
    public float Cross()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.Cross(_left[i], _right[i]);
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Vector.Normalize")]
    public float Normalize()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.Normalize(_values[i]);
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Vector.Lerp")]
    public float Lerp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.Lerp(_left[i], _right[i], 0.35f);
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    private static float3 NextVector(Random random) => new(
        random.NextSingle() * 20f - 10f,
        random.NextSingle() * 20f - 10f,
        random.NextSingle() * 20f - 10f);
}
