using BenchmarkDotNet.Attributes;
using Delta.Maths;

namespace Delta.Maths.Benchmarks;

[MemoryDiagnoser]
public class FixedPointBenchmarks
{
    [Params(256, 4096, 65536)]
    public int Count { get; set; }

    private fix[] _left = null!;
    private fix[] _right = null!;
    private fix[] _positive = null!;
    private fix2[] _left2 = null!;
    private fix2[] _right2 = null!;
    private fix3[] _left3 = null!;
    private fix3[] _right3 = null!;
    private fix4[] _left4 = null!;
    private fix4[] _right4 = null!;

    [GlobalSetup]
    public void Setup()
    {
        _left = new fix[Count];
        _right = new fix[Count];
        _positive = new fix[Count];
        _left2 = new fix2[Count];
        _right2 = new fix2[Count];
        _left3 = new fix3[Count];
        _right3 = new fix3[Count];
        _left4 = new fix4[Count];
        _right4 = new fix4[Count];

        var random = new Random(67);
        for (var i = 0; i < Count; i++)
        {
            _left[i] = NextScalar(random);
            _right[i] = NextNonZeroScalar(random);
            _positive[i] = Maths.Abs(_left[i]) + (fix)0.01f;
            _left2[i] = new fix2(NextScalar(random), NextScalar(random));
            _right2[i] = new fix2(NextScalar(random), NextScalar(random));
            _left3[i] = new fix3(NextScalar(random), NextScalar(random), NextScalar(random));
            _right3[i] = new fix3(NextScalar(random), NextScalar(random), NextScalar(random));
            _left4[i] = new fix4(NextScalar(random), NextScalar(random), NextScalar(random), NextScalar(random));
            _right4[i] = new fix4(NextScalar(random), NextScalar(random), NextScalar(random), NextScalar(random));
        }
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.Add")]
    public float ScalarAdd()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)(_left[i] + _right[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.Subtract")]
    public float ScalarSubtract()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)(_left[i] - _right[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.Multiply")]
    public float ScalarMultiply()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)(_left[i] * _right[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.Divide")]
    public float ScalarDivide()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)(_left[i] / _right[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.Abs")]
    public float ScalarAbs()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)Maths.Abs(_left[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.Sqrt")]
    public float ScalarSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)Maths.Sqrt(_positive[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Scalar.InverseSqrt")]
    public float ScalarInverseSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)Maths.InverseSqrt(_positive[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix2.Add")]
    public float Fix2Add()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _left2[i] + _right2[i];
            sum += (float)(value.x + value.y);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix2.Dot")]
    public float Fix2Dot()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)fix2.Dot(_left2[i], _right2[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix2.Length")]
    public float Fix2Length()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)fix2.Length(_left2[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix3.Add")]
    public float Fix3Add()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _left3[i] + _right3[i];
            sum += (float)(value.x + value.y + value.z);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix3.Cross")]
    public float Fix3Cross()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = fix3.Cross(_left3[i], _right3[i]);
            sum += (float)(value.x + value.y + value.z);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix3.Length")]
    public float Fix3Length()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)fix3.Length(_left3[i]);
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix4.Add")]
    public float Fix4Add()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = _left4[i] + _right4[i];
            sum += (float)(value.x + value.y + value.z + value.w);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix4.Lerp")]
    public float Fix4Lerp()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
        {
            var value = fix4.Lerp(_left4[i], _right4[i], (fix)0.5f);
            sum += (float)(value.x + value.y + value.z + value.w);
        }
        return sum;
    }

    [Benchmark]
    [BenchmarkCategory("FixedPoint.Fix4.Length")]
    public float Fix4Length()
    {
        var sum = 0f;
        for (var i = 0; i < Count; i++)
            sum += (float)fix4.Length(_left4[i]);
        return sum;
    }

    private static fix NextScalar(Random random) => (fix)(random.NextSingle() * 10f - 5f);

    private static fix NextNonZeroScalar(Random random)
    {
        var value = NextScalar(random);
        return Maths.Abs(value) < (fix)0.25f ? (fix)0.25f : value;
    }
}
