using BenchmarkDotNet.Attributes;

namespace Delta.Benchmarks;

[MemoryDiagnoser]
public class VectorBenchmarks
{
    public int Count { get; set; } = BenchmarkSettings.Count;

    private float3[] _left = [];
    private float3[] _right = [];
    private float3[] _values = [];

    [GlobalSetup]
    public void Setup()
    {
        _left = new float3[Count];
        _right = new float3[Count];
        _values = new float3[Count];

        var random = new DeterministicRandom(17);
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
        {
            sum += float3.Dot(_left[i], _right[i]);
        }

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

    private static float3 NextVector(DeterministicRandom random) => new(
        random.NextSingle() * 20f - 10f,
        random.NextSingle() * 20f - 10f,
        random.NextSingle() * 20f - 10f);
}
