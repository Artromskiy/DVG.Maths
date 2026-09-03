extern alias mathsRuntime;

using Delta.VersionBenchmarks.Shared;
using RuntimeMaths = mathsRuntime::Delta;

namespace Delta.VersionAdapter;

public sealed class DeltaMathsScenario : IDeltaMathsScenario
{
    private readonly DeltaMathsInputs _inputs;
    private readonly RuntimeMaths.float2[] _float2A;
    private readonly RuntimeMaths.float2[] _float2B;
    private readonly RuntimeMaths.float3[] _float3A;
    private readonly RuntimeMaths.float3[] _float3B;
    private readonly RuntimeMaths.float3[] _points;
    private readonly RuntimeMaths.float4[] _float4A;
    private readonly RuntimeMaths.float4[] _float4B;
    private readonly RuntimeMaths.quaternion[] _quaternionsA;
    private readonly RuntimeMaths.quaternion[] _quaternionsB;
    private readonly RuntimeMaths.float4x4[] _matricesA;
    private readonly RuntimeMaths.float4x4[] _matricesB;
    private readonly RuntimeMaths.float3[] _transformTranslations;
    private readonly RuntimeMaths.float3[] _transformScales;
    private readonly RuntimeMaths.float3[] _transformPoints;
    private readonly RuntimeMaths.quaternion[] _transformRotations;
    private readonly RuntimeMaths.float3[] _layoutFloat3;
    private readonly RuntimeMaths.float4[] _layoutFloat4;
    private readonly RuntimeMaths.float4x4[] _layoutMatrices;
    private readonly RuntimeMaths.float3[] _layoutFloat3Destination;
    private readonly RuntimeMaths.float4[] _layoutFloat4Destination;
    private readonly RuntimeMaths.float4x4[] _layoutMatrixDestination;

    public DeltaMathsScenario(DeltaMathsInputs inputs)
    {
        _inputs = inputs;
        _float2A = new RuntimeMaths.float2[inputs.Count];
        _float2B = new RuntimeMaths.float2[inputs.Count];
        _float3A = new RuntimeMaths.float3[inputs.Count];
        _float3B = new RuntimeMaths.float3[inputs.Count];
        _points = new RuntimeMaths.float3[inputs.Count];
        _float4A = new RuntimeMaths.float4[inputs.Count];
        _float4B = new RuntimeMaths.float4[inputs.Count];
        _quaternionsA = new RuntimeMaths.quaternion[inputs.Count];
        _quaternionsB = new RuntimeMaths.quaternion[inputs.Count];
        _matricesA = new RuntimeMaths.float4x4[inputs.Count];
        _matricesB = new RuntimeMaths.float4x4[inputs.Count];
        _transformTranslations = new RuntimeMaths.float3[inputs.Count];
        _transformScales = new RuntimeMaths.float3[inputs.Count];
        _transformPoints = new RuntimeMaths.float3[inputs.Count];
        _transformRotations = new RuntimeMaths.quaternion[inputs.Count];
        _layoutFloat3 = new RuntimeMaths.float3[inputs.Count];
        _layoutFloat4 = new RuntimeMaths.float4[inputs.Count];
        _layoutMatrices = new RuntimeMaths.float4x4[inputs.Count];
        _layoutFloat3Destination = new RuntimeMaths.float3[inputs.Count];
        _layoutFloat4Destination = new RuntimeMaths.float4[inputs.Count];
        _layoutMatrixDestination = new RuntimeMaths.float4x4[inputs.Count];

        for (var i = 0; i < inputs.Count; i++)
        {
            _float2A[i] = ToFloat2(inputs.Float2A[i]);
            _float2B[i] = ToFloat2(inputs.Float2B[i]);
            _float3A[i] = ToFloat3(inputs.Float3A[i]);
            _float3B[i] = ToFloat3(inputs.Float3B[i]);
            _points[i] = ToFloat3(inputs.Points[i]);
            _float4A[i] = ToFloat4(inputs.Float4A[i]);
            _float4B[i] = ToFloat4(inputs.Float4B[i]);
            _quaternionsA[i] = RuntimeMaths.quaternion.CreateFromYawPitchRoll(inputs.YawA[i], inputs.PitchA[i], inputs.RollA[i]);
            _quaternionsB[i] = RuntimeMaths.quaternion.CreateFromYawPitchRoll(inputs.YawB[i], inputs.PitchB[i], inputs.RollB[i]);
            _matricesA[i] = ToMatrix(inputs.MatrixA[i]);
            _matricesB[i] = ToMatrix(inputs.MatrixB[i]);
            _transformTranslations[i] = ToFloat3(inputs.TransformTranslations[i]);
            _transformScales[i] = ToFloat3(inputs.TransformScales[i]);
            _transformPoints[i] = ToFloat3(inputs.TransformPoints[i]);
            _transformRotations[i] = RuntimeMaths.quaternion.CreateFromYawPitchRoll(
                inputs.TransformYaw[i], inputs.TransformPitch[i], inputs.TransformRoll[i]);
            _layoutFloat3[i] = ToFloat3(inputs.LayoutFloat3[i]);
            _layoutFloat4[i] = ToFloat4(inputs.LayoutFloat4[i]);
            _layoutMatrices[i] = ToMatrix(inputs.LayoutMatrices[i]);
        }
    }

    public float Run(DeltaMathsWorkload workload) => workload switch
    {
        DeltaMathsWorkload.Float2Add => Float2Add(),
        DeltaMathsWorkload.Float3Add => Float3Add(),
        DeltaMathsWorkload.Float4Add => Float4Add(),
        DeltaMathsWorkload.Float3Dot => Float3Dot(),
        DeltaMathsWorkload.Float3Cross => Float3Cross(),
        DeltaMathsWorkload.Float3Normalize => Float3Normalize(),
        DeltaMathsWorkload.QuaternionMultiply => QuaternionMultiply(),
        DeltaMathsWorkload.QuaternionRotate => QuaternionRotate(),
        DeltaMathsWorkload.QuaternionNormalize => QuaternionNormalize(),
        DeltaMathsWorkload.MatrixMultiply => MatrixMultiply(),
        DeltaMathsWorkload.MatrixVector => MatrixVector(),
        DeltaMathsWorkload.MatrixCreateTRS => MatrixCreateTRS(),
        DeltaMathsWorkload.MatrixTransformPoint => MatrixTransformPoint(),
        DeltaMathsWorkload.ScalarSin => ScalarSin(),
        DeltaMathsWorkload.ScalarCos => ScalarCos(),
        DeltaMathsWorkload.ScalarSqrt => ScalarSqrt(),
        DeltaMathsWorkload.ScalarInverseSqrt => ScalarInverseSqrt(),
        DeltaMathsWorkload.ScalarLerp => ScalarLerp(),
        DeltaMathsWorkload.ScalarClamp => ScalarClamp(),
        DeltaMathsWorkload.ScalarAtan2 => ScalarAtan2(),
        DeltaMathsWorkload.LayoutReadFloat3 => LayoutReadFloat3(),
        DeltaMathsWorkload.LayoutWriteFloat3 => LayoutWriteFloat3(),
        DeltaMathsWorkload.LayoutReadFloat4 => LayoutReadFloat4(),
        DeltaMathsWorkload.LayoutWriteFloat4 => LayoutWriteFloat4(),
        DeltaMathsWorkload.LayoutReadFloat4x4 => LayoutReadFloat4x4(),
        DeltaMathsWorkload.LayoutWriteFloat4x4 => LayoutWriteFloat4x4(),
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
            sum += RuntimeMaths.float3.Dot(_float3A[i], _float3B[i]);
        return sum;
    }

    private float Float3Cross()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = RuntimeMaths.float3.Cross(_float3A[i], _float3B[i]);
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float Float3Normalize()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = RuntimeMaths.float3.Normalize(_float3A[i]);
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
            sum += QuaternionChecksum(RuntimeMaths.quaternion.NormalizeSafe(_quaternionsA[i]));
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
            var value = _matricesA[i] * new RuntimeMaths.float4(_points[i], 1f);
            sum += value.x + 3f * value.y + 7f * value.z + 11f * value.w;
        }
        return sum;
    }

    private float MatrixCreateTRS()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
        {
            var value = RuntimeMaths.float4x4.CreateTRS(
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
            var matrix = RuntimeMaths.float4x4.CreateTRS(
                _transformTranslations[i], _transformRotations[i], _transformScales[i]);
            var value = RuntimeMaths.float4x4.TransformPoint(matrix, _transformPoints[i]);
            sum += value.x + 3f * value.y + 7f * value.z;
        }
        return sum;
    }

    private float ScalarSin()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.Sin(_inputs.ScalarA[i]);
        return sum;
    }

    private float ScalarCos()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.Cos(_inputs.ScalarA[i]);
        return sum;
    }

    private float ScalarSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.Sqrt(_inputs.Positive[i]);
        return sum;
    }

    private float ScalarInverseSqrt()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.InverseSqrt(_inputs.Positive[i]);
        return sum;
    }

    private float ScalarLerp()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.Lerp(_inputs.ScalarA[i], _inputs.ScalarB[i], 0.35f);
        return sum;
    }

    private float ScalarClamp()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.Clamp(_inputs.ScalarA[i], -0.25f, 0.25f);
        return sum;
    }

    private float ScalarAtan2()
    {
        var sum = 0f;
        for (var i = 0; i < _inputs.Count; i++)
            sum += RuntimeMaths.DeltaMaths.Atan2(_inputs.ScalarA[i], _inputs.ScalarB[i]);
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

    private static RuntimeMaths.float2 ToFloat2(InputFloat2 value) => new(value.X, value.Y);
    private static RuntimeMaths.float3 ToFloat3(InputFloat3 value) => new(value.X, value.Y, value.Z);
    private static RuntimeMaths.float4 ToFloat4(InputFloat4 value) => new(value.X, value.Y, value.Z, value.W);

    private static RuntimeMaths.float4x4 ToMatrix(InputMatrix4x4 value) => new(
        value.M11, value.M12, value.M13, value.M14,
        value.M21, value.M22, value.M23, value.M24,
        value.M31, value.M32, value.M33, value.M34,
        value.M41, value.M42, value.M43, value.M44);

    private static float QuaternionChecksum(RuntimeMaths.quaternion value) =>
        value.x + 3f * value.y + 7f * value.z + 11f * value.w;

    private static float MatrixChecksum(RuntimeMaths.float4x4 value) =>
        value.M11 + 2f * value.M12 + 3f * value.M13 + 5f * value.M14
        + 7f * value.M21 + 11f * value.M22 + 13f * value.M23 + 17f * value.M24
        + 19f * value.M31 + 23f * value.M32 + 29f * value.M33 + 31f * value.M34
        + 37f * value.M41 + 41f * value.M42 + 43f * value.M43 + 47f * value.M44;
}
