using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class SwizzleBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float3[] _float3Values = null!;
    private float4[] _float4Values = null!;

    [GlobalSetup]
    public void Setup()
    {
        _float3Values = new float3[Count];
        _float4Values = new float4[Count];

        var random = new Random(43);
        for (var i = 0; i < Count; i++)
        {
            _float3Values[i] = NextVector3(random, 20f);
            _float4Values[i] = new float4(NextVector3(random, 20f), random.NextSingle() * 20f - 10f);
        }
    }

    [Benchmark]
    [BenchmarkCategory("Swizzle.ReadXY")]
    public float ReadXY()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float3Values[i].xy;
            sum += value.x + value.y;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Swizzle.ReadXYZ")]
    public float ReadXYZ()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float3Values[i].xyz;
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Swizzle.ReadRGBA")]
    public float ReadRGBA()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i].rgba;
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Swizzle.WriteXY")]
    public float WriteXY()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i];
            value.xy = new float2(value.z, value.w);
            sum += value.x + value.y;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Swizzle.WriteRGBA")]
    public float WriteRGBA()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i];
            value.rgba = new float4(1f - value.x, 2f - value.y, 3f - value.z, 4f - value.w);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    private static float3 NextVector3(Random random, float range) => new(
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range);
}
