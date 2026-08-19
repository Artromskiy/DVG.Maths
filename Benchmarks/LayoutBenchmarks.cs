using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class LayoutBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float3[] _float3Values = null!;
    private float3[] _float3Destination = null!;
    private float4[] _float4Values = null!;
    private float4[] _float4Destination = null!;
    private float4x4[] _matrixValues = null!;
    private float4x4[] _matrixDestination = null!;

    [GlobalSetup]
    public void Setup()
    {
        _float3Values = new float3[Count];
        _float3Destination = new float3[Count];
        _float4Values = new float4[Count];
        _float4Destination = new float4[Count];
        _matrixValues = new float4x4[Count];
        _matrixDestination = new float4x4[Count];

        var random = new Random(73);
        for (var i = 0; i < Count; i++)
        {
            _float3Values[i] = new float3(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _float4Values[i] = new float4(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _matrixValues[i] = new float4x4(
                random.NextSingle(), random.NextSingle(), random.NextSingle(), random.NextSingle(),
                random.NextSingle(), random.NextSingle(), random.NextSingle(), random.NextSingle(),
                random.NextSingle(), random.NextSingle(), random.NextSingle(), random.NextSingle(),
                random.NextSingle(), random.NextSingle(), random.NextSingle(), random.NextSingle());
        }
    }

    [Benchmark]
    [BenchmarkCategory("Layout.Read.Float3")]
    public float ReadFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float3Values[i];
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Layout.Write.Float3")]
    public float WriteFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float3Values[i];
            _float3Destination[i] = value;
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Layout.Read.Float4")]
    public float ReadFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i];
            sum += value.x + value.y + value.z + value.w;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Layout.Write.Float4")]
    public float WriteFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _float4Values[i];
            _float4Destination[i] = value;
            sum += value.x + value.y + value.z + value.w;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Layout.Read.Float4x4")]
    public float ReadFloat4x4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _matrixValues[i];
            sum += value.c0.x + value.c0.y + value.c0.z + value.c0.w
                + value.c1.x + value.c1.y + value.c1.z + value.c1.w
                + value.c2.x + value.c2.y + value.c2.z + value.c2.w
                + value.c3.x + value.c3.y + value.c3.z + value.c3.w;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Layout.Write.Float4x4")]
    public float WriteFloat4x4()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _matrixValues[i];
            _matrixDestination[i] = value;
            sum += value.c0.x + value.c1.y + value.c2.z + value.c3.w;
        }

        return sum;
    }
}
