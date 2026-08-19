using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class VectorGeometryBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float3[] _left = null!;
    private float3[] _right = null!;
    private float3[] _onto = null!;
    private float3[] _source = null!;
    private float3[] _target = null!;

    [GlobalSetup]
    public void Setup()
    {
        _left = new float3[Count];
        _right = new float3[Count];
        _onto = new float3[Count];
        _source = new float3[Count];
        _target = new float3[Count];

        var random = new Random(41);
        for (var i = 0; i < Count; i++)
        {
            _left[i] = NextVector(random, 10f);
            _right[i] = NextVector(random, 10f);
            _onto[i] = NextVector(random, 1f) + new float3(0.1f, 0.1f, 0.1f);
            _source[i] = NextVector(random, 20f);
            _target[i] = NextVector(random, 20f);
        }
    }

    [Benchmark]
    [BenchmarkCategory("Float3.Length")]
    public float Length()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += float3.Length(_left[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Float3.Distance")]
    public float Distance()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += float3.Distance(_left[i], _right[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Float3.Project")]
    public float Project()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.Project(_source[i], _onto[i]);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Float3.Reflect")]
    public float Reflect()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.Reflect(_source[i], _onto[i]);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Float3.Refract")]
    public float Refract()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.Refract(_source[i], _onto[i], 0.85f);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Float3.MoveTowards")]
    public float MoveTowards()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float3.MoveTowards(_source[i], _target[i], 0.25f);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Float3.SmoothDamp")]
    public float SmoothDamp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var velocity = float3.zero;
            var value = float3.SmoothDamp(_source[i], _target[i], ref velocity, 0.2f, 0.016f);
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    private static float3 NextVector(Random random, float range) => new(
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range);
}
