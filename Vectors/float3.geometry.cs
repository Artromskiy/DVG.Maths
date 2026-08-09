#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct float3
    {

        public static float3 Clamp(float3 value, float min, float max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max));
        }

        public static float Length(float3 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static float Distance(float3 a, float3 b)
        {
            return Length(a - b);
        }

        public static float Dot(float3 a, float3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public static float3 Cross(float3 a, float3 b)
        {
            return new(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        }

        public static float3 Normalize(float3 value)
        {
            return value / Length(value);
        }

        public static float3 FaceForward(float3 N, float3 I, float3 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static float3 Reflect(float3 I, float3 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static float3 Refract(float3 I, float3 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static float SqrLength(float3 value)
        {
            return value.x * value.x + value.y * value.y + value.z * value.z;
        }

        public static float SqrDistance(float3 a, float3 b)
        {
            return SqrLength(a - b);
        }

        public static float3 ClampLength(float3 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static float3 MoveTowards(float3 current, float3 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static float3 Abs(float3 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y), Maths.Abs(value.z));
        }

        public static float3 Sign(float3 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y), Maths.Sign(value.z));
        }

        public static float3 Lerp(float3 a, float3 b, float t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t), Maths.Lerp(a.z, b.z, t));
        }

        public static float3 Lerp(float3 a, float3 b, float3 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y), Maths.Lerp(a.z, b.z, t.z));
        }

        public static float3 Min(float3 a, float3 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y), Maths.Min(a.z, b.z));
        }

        public static float3 Max(float3 a, float3 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y), Maths.Max(a.z, b.z));
        }

        public static float3 InvLerp(float3 edge0, float3 edge1, float3 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y), Maths.InvLerp(edge0.z, edge1.z, value.z));
        }

        public static float3 InvLerp(float3 edge0, float3 edge1, float value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value), Maths.InvLerp(edge0.z, edge1.z, value));
        }

        public static float3 SmoothDamp(float3 source, float3 target, ref float3 velocity, float smoothTime, float deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime));
        }

        public static float3 Pow(float3 a, float3 b)
        {
            return new(Maths.Pow(a.x, b.x), Maths.Pow(a.y, b.y), Maths.Pow(a.z, b.z));
        }

        public static float3 Exp(float3 value)
        {
            return new(Maths.Exp(value.x), Maths.Exp(value.y), Maths.Exp(value.z));
        }

        public static float3 Log(float3 value)
        {
            return new(Maths.Log(value.x), Maths.Log(value.y), Maths.Log(value.z));
        }

        public static float3 Exp2(float3 value)
        {
            return new(Maths.Exp2(value.x), Maths.Exp2(value.y), Maths.Exp2(value.z));
        }

        public static float3 Log2(float3 value)
        {
            return new(Maths.Log2(value.x), Maths.Log2(value.y), Maths.Log2(value.z));
        }

        public static float3 Sqrt(float3 value)
        {
            return new(Maths.Sqrt(value.x), Maths.Sqrt(value.y), Maths.Sqrt(value.z));
        }

        public static float3 InverseSqrt(float3 value)
        {
            return new(Maths.InverseSqrt(value.x), Maths.InverseSqrt(value.y), Maths.InverseSqrt(value.z));
        }
    }
}
