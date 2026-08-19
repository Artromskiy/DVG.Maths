using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class ScalarBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private float[] _values = null!;
    private float[] _otherValues = null!;
    private float[] _positiveValues = null!;
    private float[] _atanDenominators = null!;

    [GlobalSetup]
    public void Setup()
    {
        _values = new float[Count];
        _otherValues = new float[Count];
        _positiveValues = new float[Count];
        _atanDenominators = new float[Count];

        var random = new Random(31);
        for (var i = 0; i < Count; i++)
        {
            _values[i] = random.NextSingle() * 2f - 1f;
            _otherValues[i] = random.NextSingle() * 2f - 1f;
            _positiveValues[i] = random.NextSingle() + 0.0001f;
            _atanDenominators[i] = random.NextSingle() * 2f - 1f;
            if (MathF.Abs(_atanDenominators[i]) < 0.0001f)
                _atanDenominators[i] = 0.0001f;
        }
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.Sin")]
    public float Sin()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.Sin(_values[i]);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.Cos")]
    public float Cos()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.Cos(_values[i]);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.Sqrt")]
    public float Sqrt()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.Sqrt(_positiveValues[i]);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.InverseSqrt")]
    public float InverseSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.InverseSqrt(_positiveValues[i]);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.Lerp")]
    public float Lerp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.Lerp(_values[i], _otherValues[i], 0.35f);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.Clamp")]
    public float Clamp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.Clamp(_values[i], -0.25f, 0.25f);

        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("Scalar.Atan2")]
    public float Atan2()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += Maths.Atan2(_values[i], _atanDenominators[i]);

        return sum;
    }
}
