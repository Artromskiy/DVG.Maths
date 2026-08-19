using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class MatrixBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float3[] _translations = null!;
    private quaternion[] _rotations = null!;
    private float3[] _scales = null!;
    private float3[] _points = null!;
    private float4x4[] _matrices = null!;
    private float4x4[] _rightMatrices = null!;

    [GlobalSetup]
    public void Setup()
    {
        _translations = new float3[Count];
        _rotations = new quaternion[Count];
        _scales = new float3[Count];
        _points = new float3[Count];
        _matrices = new float4x4[Count];
        _rightMatrices = new float4x4[Count];

        var random = new Random(23);
        for (var i = 0; i < Count; i++)
        {
            _translations[i] = NextVector(random, 10f);
            _rotations[i] = quaternion.CreateFromYawPitchRoll(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _scales[i] = new float3(
                random.NextSingle() * 2f + 0.5f,
                random.NextSingle() * 2f + 0.5f,
                random.NextSingle() * 2f + 0.5f);
            _points[i] = NextVector(random, 10f);
            _matrices[i] = float4x4.CreateTRS(_translations[i], _rotations[i], _scales[i]);
            _rightMatrices[i] = float4x4.CreateTRS(NextVector(random, 10f), _rotations[i], _scales[i]);
        }
    }

    [Benchmark]
    [BenchmarkCategory("Matrix.CreateTRS")]
    public float CreateTRS()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = float4x4.CreateTRS(_translations[i], _rotations[i], _scales[i]);
            sum += matrix.M11 + matrix.M22 + matrix.M33 + matrix.M14 + matrix.M24 + matrix.M34;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Matrix.Multiply")]
    public float Multiply()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = _matrices[i] * _rightMatrices[i];
            sum += matrix.M11 + matrix.M22 + matrix.M33 + matrix.M14 + matrix.M24 + matrix.M34;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Matrix.TransformPoint")]
    public float TransformPoint()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var point = float4x4.TransformPoint(_matrices[i], _points[i]);
            sum += point.x + point.y + point.z;
        }

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Matrix.Inverse")]
    public float TryInverse()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            if (!float4x4.TryInverse(_matrices[i], out var inverse))
                continue;
            sum += inverse.M11 + inverse.M22 + inverse.M33 + inverse.M14 + inverse.M24 + inverse.M34;
        }

        return sum;
    }

    private static float3 NextVector(Random random, float range) => new(
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range);
}
