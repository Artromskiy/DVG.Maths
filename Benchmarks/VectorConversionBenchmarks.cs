using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class VectorConversionBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float[] _values = null!;
    private float2[] _float2Values = null!;
    private float3[] _float3Values = null!;
    private float4[] _float4Values = null!;

    [GlobalSetup]
    public void Setup()
    {
        _values = new float[Count];
        _float2Values = new float2[Count];
        _float3Values = new float3[Count];
        _float4Values = new float4[Count];

        var random = new Random(47);
        for (var i = 0; i < Count; i++)
        {
            _values[i] = random.NextSingle() * 20f - 10f;
            _float2Values[i] = new float2(
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f);
            _float3Values[i] = new float3(
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f);
            _float4Values[i] = new float4(
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f);
        }
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float2FromFloat3")]
    public float Float2FromFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float2(_float3Values[i]);
            sum += value.x + value.y;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float3FromFloat2")]
    public float Float3FromFloat2()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float3(_float2Values[i], _values[i]);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float4FromFloat3")]
    public float Float4FromFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float4(_float3Values[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float3FromFloat4")]
    public float Float3FromFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float3(_float4Values[i]);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float4FromFloat2AndFloat2")]
    public float Float4FromFloat2AndFloat2()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var next = (i + 1) % Count;
            var value = new float4(_float2Values[i], _float2Values[next]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float4FromFloat3AndFloat")]
    public float Float4FromFloat3AndScalar()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float4(_float3Values[i], _values[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.ScalarToFloat2")]
    public float ScalarToFloat2()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float2(_values[i]);
            sum += value.x + value.y;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.ScalarToFloat3")]
    public float ScalarToFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float3(_values[i]);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float2ToFloat4")]
    public float Float2ToFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float4(_float2Values[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.ScalarToFloat4")]
    public float ScalarToFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float4(_values[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.IndexerRead")]
    public float IndexerRead()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i];
            sum += value[0] + value[1] + value[2] + value[3];
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.IndexerWrite")]
    public float IndexerWrite()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i];
            value[0] = _values[i];
            value[1] = _values[(i + 1) % Count];
            value[2] = _values[(i + 2) % Count];
            value[3] = _values[(i + 3) % Count];
            sum += value[0] + value[1] + value[2] + value[3];
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("VectorConversion.Float2ToFloat3")]
    public float Float2ToFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = new float3(_values[i], _float2Values[i]);
            sum += value.x + value.y + value.z;
        }
        return sum;
    }
}
