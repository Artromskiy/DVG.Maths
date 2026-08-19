extern alias mathsRuntime;

using Delta.Maths.VersionBenchmarks.Shared;
using DeltaMaths = mathsRuntime::Delta.Maths;

namespace Delta.Maths.VersionAdapter;

public sealed class MathsScenario : IMathsScenario
{
    private readonly MathsInputs _inputs;
    private readonly DeltaMaths.float2[] _float2A;
    private readonly DeltaMaths.float2[] _float2B;
    private readonly DeltaMaths.float3[] _float3A;
    private readonly DeltaMaths.float3[] _float3B;
    private readonly DeltaMaths.float3[] _points;
    private readonly DeltaMaths.float4[] _float4A;
    private readonly DeltaMaths.float4[] _float4B;
    private readonly DeltaMaths.quaternion[] _quaternionsA;
    private readonly DeltaMaths.quaternion[] _quaternionsB;
    private readonly DeltaMaths.float4x4[] _matricesA;
    private readonly DeltaMaths.float4x4[] _matricesB;
    private readonly DeltaMaths.float3[] _transformTranslations;
    private readonly DeltaMaths.float3[] _transformScales;
    private readonly DeltaMaths.float3[] _transformPoints;
    private readonly DeltaMaths.quaternion[] _transformRotations;
    private readonly DeltaMaths.float3[] _layoutFloat3;
    private readonly DeltaMaths.float4[] _layoutFloat4;
    private readonly DeltaMaths.float4x4[] _layoutMatrices;
    private readonly DeltaMaths.float3[] _layoutFloat3Destination;
    private readonly DeltaMaths.float4[] _layoutFloat4Destination;
    private readonly DeltaMaths.float4x4[] _layoutMatrixDestination;

    public MathsScenario(MathsInputs inputs)
    {
        _inputs = inputs;
        _float2A = new DeltaMaths.float2[inputs.Count];
        _float2B = new DeltaMaths.float2[inputs.Count];
        _float3A = new DeltaMaths.float3[inputs.Count];
        _float3B = new DeltaMaths.float3[inputs.Count];
        _points = new DeltaMaths.float3[inputs.Count];
        _float4A = new DeltaMaths.float4[inputs.Count];
        _float4B = new DeltaMaths.float4[inputs.Count];
        _quaternionsA = new DeltaMaths.quaternion[inputs.Count];
        _quaternionsB = new DeltaMaths.quaternion[inputs.Count];
        _matricesA = new DeltaMaths.float4x4[inputs.Count];
        _matricesB = new DeltaMaths.float4x4[inputs.Count];
        _transformTranslations = new DeltaMaths.float3[inputs.Count];
        _transformScales = new DeltaMaths.float3[inputs.Count];
        _transformPoints = new DeltaMaths.float3[inputs.Count];
        _transformRotations = new DeltaMaths.quaternion[inputs.Count];
        _layoutFloat3 = new DeltaMaths.float3[inputs.Count];
        _layoutFloat4 = new DeltaMaths.float4[inputs.Count];
        _layoutMatrices = new DeltaMaths.float4x4[inputs.Count];
        _layoutFloat3Destination = new DeltaMaths.float3[inputs.Count];
        _layoutFloat4Destination = new DeltaMaths.float4[inputs.Count];
        _layoutMatrixDestination = new DeltaMaths.float4x4[inputs.Count];

        for (var i = 0; i < inputs.Count; i++)
        {
            _float2A[i] = ToFloat2(inputs.Float2A[i]);
            _float2B[i] = ToFloat2(inputs.Float2B[i]);
            _float3A[i] = ToFloat3(inputs.Float3A[i]);
            _float3B[i] = ToFloat3(inputs.Float3B[i]);
            _points[i] = ToFloat3(inputs.Points[i]);
            _float4A[i] = ToFloat4(inputs.Float4A[i]);
            _float4B[i] = ToFloat4(inputs.Float4B[i]);
            _quaternionsA[i] = DeltaMaths.quaternion.CreateFromYawPitchRoll(inputs.YawA[i], inputs.PitchA[i], inputs.RollA[i]);
            _quaternionsB[i] = DeltaMaths.quaternion.CreateFromYawPitchRoll(inputs.YawB[i], inputs.PitchB[i], inputs.RollB[i]);
            _matricesA[i] = ToMatrix(inputs.MatrixA[i]);
            _matricesB[i] = ToMatrix(inputs.MatrixB[i]);
            _transformTranslations[i] = ToFloat3(inputs.TransformTranslations[i]);
            _transformScales[i] = ToFloat3(inputs.TransformScales[i]);
            _transformPoints[i] = ToFloat3(inputs.TransformPoints[i]);
            _transformRotations[i] = DeltaMaths.quaternion.CreateFromYawPitchRoll(
                inputs.TransformYaw[i], inputs.TransformPitch[i], inputs.TransformRoll[i]);
            _layoutFloat3[i] = ToFloat3(inputs.LayoutFloat3[i]);
            _layoutFloat4[i] = ToFloat4(inputs.LayoutFloat4[i]);
            _layoutMatrices[i] = ToMatrix(inputs.LayoutMatrices[i]);
        }
    }

    public float Run(MathsWorkload workload) => workload switch
    {
        MathsWorkload.Float2Add => Float2Add(),
        MathsWorkload.Float3Add => Float3Add(),
        MathsWorkload.Float4Add => Float4Add(),
        MathsWorkload.Float3Dot => Float3Dot(),
        MathsWorkload.Float3Cross => Float3Cross(),
        MathsWorkload.Float3Normalize => Float3Normalize(),
        MathsWorkload.QuaternionMultiply => QuaternionMultiply(),
        MathsWorkload.QuaternionRotate => QuaternionRotate(),
        MathsWorkload.QuaternionNormalize => QuaternionNormalize(),
        MathsWorkload.MatrixMultiply => MatrixMultiply(),
        MathsWorkload.MatrixVector => MatrixVector(),
        MathsWorkload.MatrixCreateTRS => MatrixCreateTRS(),
        MathsWorkload.MatrixTransformPoint => MatrixTransformPoint(),
        MathsWorkload.ScalarSin => ScalarSin(),
        MathsWorkload.ScalarCos => ScalarCos(),
        MathsWorkload.ScalarSqrt => ScalarSqrt(),
        MathsWorkload.ScalarInverseSqrt => ScalarInverseSqrt(),
        MathsWorkload.ScalarLerp => ScalarLerp(),
        MathsWorkload.ScalarClamp => ScalarClamp(),
        MathsWorkload.ScalarAtan2 => ScalarAtan2(),
        MathsWorkload.LayoutReadFloat3 => LayoutReadFloat3(),
        MathsWorkload.LayoutWriteFloat3 => LayoutWriteFloat3(),
        MathsWorkload.LayoutReadFloat4 => LayoutReadFloat4(),
        MathsWorkload.LayoutWriteFloat4 => LayoutWriteFloat4(),
        MathsWorkload.LayoutReadFloat4x4 => LayoutReadFloat4x4(),
        MathsWorkload.LayoutWriteFloat4x4 => LayoutWriteFloat4x4(),
        _ => throw new ArgumentOutOfRangeException(nameof(workload), workload, null)
    };

    private float Float2Add()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _float2A[i] + _float2B[i];
            sum += value.x + 3f * value.y;
        }
        return sum;
    }

    private float Float3Add()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _float3A[i] + _float3B[i];
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float Float4Add()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _float4A[i] + _float4B[i];
            sum += value.x + 3f * value.y + 7f * value.z + 11f * value.w;
        }
        return sum;
    }

    private float Float3Dot()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.float3.Dot(_float3A[i], _float3B[i]);
        return sum;
    }

    private float Float3Cross()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = DeltaMaths.float3.Cross(_float3A[i], _float3B[i]);
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float Float3Normalize()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = DeltaMaths.float3.Normalize(_float3A[i]);
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float QuaternionMultiply()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += QuaternionChecksum(_quaternionsA[i] * _quaternionsB[i]);
        return sum;
    }

    private float QuaternionRotate()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _quaternionsA[i] * _points[i];
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float QuaternionNormalize()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += QuaternionChecksum(DeltaMaths.quaternion.NormalizeSafe(_quaternionsA[i]));
        return sum;
    }

    private float MatrixMultiply()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += MatrixChecksum(_matricesA[i] * _matricesB[i]);
        return sum;
    }

    private float MatrixVector()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _matricesA[i] * new DeltaMaths.float4(_points[i], 1f);
            sum += value.x + 3f * value.y + 7f * value.z + 11f * value.w;
        }
        return sum;
    }

    private float MatrixCreateTRS()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = DeltaMaths.float4x4.CreateTRS(
                _transformTranslations[i], _transformRotations[i], _transformScales[i]);
            sum += MatrixChecksum(value);
        }
        return sum;
    }

    private float MatrixTransformPoint()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var matrix = DeltaMaths.float4x4.CreateTRS(
                _transformTranslations[i], _transformRotations[i], _transformScales[i]);
            var value = DeltaMaths.float4x4.TransformPoint(matrix, _transformPoints[i]);
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float ScalarSin()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.Sin(_inputs.ScalarA[i]);
        return sum;
    }

    private float ScalarCos()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.Cos(_inputs.ScalarA[i]);
        return sum;
    }

    private float ScalarSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.Sqrt(_inputs.Positive[i]);
        return sum;
    }

    private float ScalarInverseSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.InverseSqrt(_inputs.Positive[i]);
        return sum;
    }

    private float ScalarLerp()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.Lerp(_inputs.ScalarA[i], _inputs.ScalarB[i], 0.35f);
        return sum;
    }

    private float ScalarClamp()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.Clamp(_inputs.ScalarA[i], -0.25f, 0.25f);
        return sum;
    }

    private float ScalarAtan2()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += DeltaMaths.Maths.Atan2(_inputs.ScalarA[i], _inputs.ScalarB[i]);
        return sum;
    }

    private float LayoutReadFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _layoutFloat3[i];
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    private float LayoutWriteFloat3()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _layoutFloat3[i];
            _layoutFloat3Destination[i] = value;
            sum += value.x + value.y + value.z;
        }
        return sum;
    }

    private float LayoutReadFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _layoutFloat4[i];
            sum += value.x + 3f * value.y + 7f * value.z + 11f * value.w;
        }
        return sum;
    }

    private float LayoutWriteFloat4()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _layoutFloat4[i];
            _layoutFloat4Destination[i] = value;
            sum += value.x + 3f * value.y + 7f * value.z + 11f * value.w;
        }
        return sum;
    }

    private float LayoutReadFloat4x4()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += MatrixChecksum(_layoutMatrices[i]);
        return sum;
    }

    private float LayoutWriteFloat4x4()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = _layoutMatrices[i];
            _layoutMatrixDestination[i] = value;
            sum += MatrixChecksum(value);
        }
        return sum;
    }

    private static DeltaMaths.float2 ToFloat2(InputFloat2 value) => new(value.X, value.Y);
    private static DeltaMaths.float3 ToFloat3(InputFloat3 value) => new(value.X, value.Y, value.Z);
    private static DeltaMaths.float4 ToFloat4(InputFloat4 value) => new(value.X, value.Y, value.Z, value.W);

    private static DeltaMaths.float4x4 ToMatrix(InputMatrix4x4 value) => new(
        value.M11, value.M12, value.M13, value.M14,
        value.M21, value.M22, value.M23, value.M24,
        value.M31, value.M32, value.M33, value.M34,
        value.M41, value.M42, value.M43, value.M44);

    private static float QuaternionChecksum(DeltaMaths.quaternion value) =>
        value.x + 3f * value.y + 7f * value.z + 11f * value.w;

    private static float MatrixChecksum(DeltaMaths.float4x4 value) =>
        value.M11 + 2f * value.M12 + 3f * value.M13 + 5f * value.M14
        + 7f * value.M21 + 11f * value.M22 + 13f * value.M23 + 17f * value.M24
        + 19f * value.M31 + 23f * value.M32 + 29f * value.M33 + 31f * value.M34
        + 37f * value.M41 + 41f * value.M42 + 43f * value.M43 + 47f * value.M44;
}
