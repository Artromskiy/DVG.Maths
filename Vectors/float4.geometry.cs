#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct float4
    {

        public static float4 Clamp(float4 value, float min, float max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max), Maths.Clamp(value.w, min, max));
        }

        public static float Length(float4 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static float Distance(float4 a, float4 b)
        {
            return Length(a - b);
        }

        public static float Dot(float4 a, float4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        public static float4 Normalize(float4 value)
        {
            return value / Length(value);
        }

        public static float4 FaceForward(float4 N, float4 I, float4 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static float4 Reflect(float4 I, float4 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static float4 Refract(float4 I, float4 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static float SqrLength(float4 value)
        {
            return value.x * value.x + value.y * value.y + value.z * value.z + value.w * value.w;
        }

        public static float SqrDistance(float4 a, float4 b)
        {
            return SqrLength(a - b);
        }

        public static float4 ClampLength(float4 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static float4 MoveTowards(float4 current, float4 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static float4 Abs(float4 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y), Maths.Abs(value.z), Maths.Abs(value.w));
        }

        public static float4 Sign(float4 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y), Maths.Sign(value.z), Maths.Sign(value.w));
        }

        public static float4 Lerp(float4 a, float4 b, float t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t), Maths.Lerp(a.z, b.z, t), Maths.Lerp(a.w, b.w, t));
        }

        public static float4 Lerp(float4 a, float4 b, float4 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y), Maths.Lerp(a.z, b.z, t.z), Maths.Lerp(a.w, b.w, t.w));
        }

        public static float4 Min(float4 a, float4 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y), Maths.Min(a.z, b.z), Maths.Min(a.w, b.w));
        }

        public static float4 Max(float4 a, float4 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y), Maths.Max(a.z, b.z), Maths.Max(a.w, b.w));
        }

        public static float4 InvLerp(float4 edge0, float4 edge1, float4 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y), Maths.InvLerp(edge0.z, edge1.z, value.z), Maths.InvLerp(edge0.w, edge1.w, value.w));
        }

        public static float4 InvLerp(float4 edge0, float4 edge1, float value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value), Maths.InvLerp(edge0.z, edge1.z, value), Maths.InvLerp(edge0.w, edge1.w, value));
        }

        public static float4 SmoothDamp(float4 source, float4 target, ref float4 velocity, float smoothTime, float deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime), Maths.SmoothDamp(source.w, target.w, ref velocity.w, smoothTime, deltaTime));
        }

        public static float4 Pow(float4 a, float4 b)
        {
            return new(Maths.Pow(a.x, b.x), Maths.Pow(a.y, b.y), Maths.Pow(a.z, b.z), Maths.Pow(a.w, b.w));
        }

        public static float4 Exp(float4 value)
        {
            return new(Maths.Exp(value.x), Maths.Exp(value.y), Maths.Exp(value.z), Maths.Exp(value.w));
        }

        public static float4 Log(float4 value)
        {
            return new(Maths.Log(value.x), Maths.Log(value.y), Maths.Log(value.z), Maths.Log(value.w));
        }

        public static float4 Exp2(float4 value)
        {
            return new(Maths.Exp2(value.x), Maths.Exp2(value.y), Maths.Exp2(value.z), Maths.Exp2(value.w));
        }

        public static float4 Log2(float4 value)
        {
            return new(Maths.Log2(value.x), Maths.Log2(value.y), Maths.Log2(value.z), Maths.Log2(value.w));
        }

        public static float4 Sqrt(float4 value)
        {
            return new(Maths.Sqrt(value.x), Maths.Sqrt(value.y), Maths.Sqrt(value.z), Maths.Sqrt(value.w));
        }

        public static float4 InverseSqrt(float4 value)
        {
            return new(Maths.InverseSqrt(value.x), Maths.InverseSqrt(value.y), Maths.InverseSqrt(value.z), Maths.InverseSqrt(value.w));
        }
    }
}
