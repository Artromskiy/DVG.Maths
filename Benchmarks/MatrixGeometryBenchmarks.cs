using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class MatrixGeometryBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float3[] _translations = null!;
    private float3[] _scales = null!;
    private float3[] _directions = null!;
    private float3[] _ups = null!;
    private float3[] _lookAt = null!;
    private quaternion[] _rotations = null!;
    private float4x4[] _matrices = null!;

    [GlobalSetup]
    public void Setup()
    {
        _translations = new float3[Count];
        _scales = new float3[Count];
        _directions = new float3[Count];
        _ups = new float3[Count];
        _lookAt = new float3[Count];
        _rotations = new quaternion[Count];
        _matrices = new float4x4[Count];

        var random = new Random(53);
        for (var i = 0; i < Count; i++)
        {
            _translations[i] = NextVector(random, 10f);
            _scales[i] = new float3(
                random.NextSingle() * 2f + 0.5f,
                random.NextSingle() * 2f + 0.5f,
                random.NextSingle() * 2f + 0.5f);
            _rotations[i] = quaternion.CreateFromYawPitchRoll(
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f,
                random.NextSingle() * 2f - 1f);
            _lookAt[i] = NextVector(random, 1f);
            _directions[i] = NextVector(random, 1f);
            _ups[i] = new float3(0f, 1f, 0f);
            _matrices[i] = float4x4.CreateTRS(_translations[i], _rotations[i], _scales[i]);
        }
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.CreateTranslation")]
    public float CreateTranslation()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = float4x4.CreateTranslation(_translations[i]);
            sum += matrix.M14 + matrix.M24 + matrix.M34;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.CreateScale")]
    public float CreateScale()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = float4x4.CreateScale(_scales[i]);
            sum += matrix.M11 + matrix.M22 + matrix.M33 + matrix.M44;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.CreateFromQuaternion")]
    public float CreateFromQuaternion()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = float4x4.CreateFromQuaternion(_rotations[i]);
            sum += matrix.M11 + matrix.M22 + matrix.M33 + matrix.M44;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.Transpose")]
    public float Transpose()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = float4x4.Transpose(_matrices[i]);
            sum += value.M11 + value.M22 + value.M33 + value.M44;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.Determinant")]
    public float Determinant()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += float4x4.Determinant(_matrices[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.Decompose")]
    public float Decompose()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            if (float4x4.Decompose(_matrices[i], out var scale, out var rotation, out var translation))
                sum += scale.x + scale.y + scale.z + rotation.x + translation.x;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.LookTo")]
    public float CreateLookTo()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = float4x4.CreateLookTo(_lookAt[i], _directions[i], _ups[i]);
            sum += matrix.M11 + matrix.M22 + matrix.M33 + matrix.M44;
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("MatrixGeometry.Projection")]
    public float CreatePerspective()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var matrix = float4x4.CreatePerspectiveFieldOfViewLeftHanded(1f, 16f / 9f, 0.01f, 100f);
            sum += matrix.M33 + matrix.M34 + matrix.M44;
        }
        return sum;
    }

    private static float3 NextVector(Random random, float range) => new(
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range,
        random.NextSingle() * range * 2f - range);
}
