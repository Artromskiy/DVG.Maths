using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class QuaternionGeometryBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private quaternion[] _quaternions = null!;
    private quaternion[] _otherQuaternions = null!;
    private float3[] _axes = null!;
    private float[] _angles = null!;
    private float4x4[] _rotationMatrices = null!;
    private float[] _yaws = null!;
    private float[] _pitches = null!;
    private float[] _rolls = null!;

    [GlobalSetup]
    public void Setup()
    {
        _quaternions = new quaternion[Count];
        _otherQuaternions = new quaternion[Count];
        _axes = new float3[Count];
        _angles = new float[Count];
        _rotationMatrices = new float4x4[Count];
        _yaws = new float[Count];
        _pitches = new float[Count];
        _rolls = new float[Count];

        var random = new Random(59);
        for (var i = 0; i < Count; i++)
        {
            _axes[i] = float3.NormalizeSafe(NextVector(random, 1f));
            _angles[i] = random.NextSingle() * MathF.PI;
            _yaws[i] = random.NextSingle() * 2f - 1f;
            _pitches[i] = random.NextSingle() * 2f - 1f;
            _rolls[i] = random.NextSingle() * 2f - 1f;
            _quaternions[i] = quaternion.CreateFromYawPitchRoll(_yaws[i], _pitches[i], _rolls[i]);
            _otherQuaternions[i] = quaternion.CreateFromAxisAngle(_axes[(i + 1) % Count], MathF.PI - _angles[i] * 0.5f);
            _rotationMatrices[i] = quaternion.ToRotationMatrix(_quaternions[i]);
        }
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.CreateFromAxisAngle")]
    public float CreateFromAxisAngle()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.CreateFromAxisAngle(_axes[i], _angles[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.CreateFromYawPitchRoll")]
    public float CreateFromYawPitchRoll()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.CreateFromYawPitchRoll(_yaws[i], _pitches[i], _rolls[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.CreateFromRotationMatrix")]
    public float CreateFromRotationMatrix()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.CreateFromRotationMatrix(_rotationMatrices[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.ToRotationMatrix")]
    public float ToRotationMatrix()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += quaternion.ToRotationMatrix(_quaternions[i]).M44;
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.Conjugate")]
    public float Conjugate()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.Conjugate(_quaternions[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.Inverse")]
    public float Inverse()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.Inverse(_quaternions[i]);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("QuaternionGeometry.Lerp")]
    public float Lerp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = quaternion.Lerp(_quaternions[i], _otherQuaternions[i], 0.35f);
            sum += value.x + value.y + value.z + value.w;
        }
        return sum;
    }

    private static float3 NextVector(Random random, float range) => new(
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range);
}
