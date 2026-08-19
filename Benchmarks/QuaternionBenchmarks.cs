using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class QuaternionBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private quaternion[] _left = null!;
    private quaternion[] _right = null!;
    private quaternion[] _rotations = null!;
    private float3[] _vectors = null!;

    [GlobalSetup]
    public void Setup()
    {
        _left = new quaternion[Count];
        _right = new quaternion[Count];
        _rotations = new quaternion[Count];
        _vectors = new float3[Count];

        var random = new Random(29);
        for (var i = 0; i < Count; i++)
        {
            _left[i] = NextRotation(random);
            _right[i] = NextRotation(random);
            _rotations[i] = NextRotation(random);
            _vectors[i] = new float3(
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f,
                random.NextSingle() * 20f - 10f);
        }
    }

    [Benchmark]
    [BenchmarkCategory("Quaternion.Multiply")]
    public float Multiply()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _left[i] * _right[i];
            sum += value.x + value.y + value.z + value.w;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Quaternion.Rotate")]
    public float Rotate()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _rotations[i] * _vectors[i];
            sum += value.x + value.y + value.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Quaternion.Normalize")]
    public float NormalizeSafe()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.NormalizeSafe(_left[i]);
            sum += value.x + value.y + value.z + value.w;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Quaternion.Slerp")]
    public float Slerp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.Slerp(_left[i], _right[i], 0.35f);
            sum += value.x + value.y + value.z + value.w;
        }

        return sum;
    }

    private static quaternion NextRotation(Random random) => quaternion.CreateFromYawPitchRoll(
        random.NextSingle() * 2f - 1f,
        random.NextSingle() * 2f - 1f,
        random.NextSingle() * 2f - 1f);
}
