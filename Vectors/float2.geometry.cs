#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct float2
    {

        public static float2 Clamp(float2 value, float min, float max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max));
        }

        public static float Length(float2 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static float Distance(float2 a, float2 b)
        {
            return Length(a - b);
        }

        public static float Dot(float2 a, float2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static float2 Normalize(float2 value)
        {
            return value / Length(value);
        }

        public static float2 FaceForward(float2 N, float2 I, float2 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static float2 Reflect(float2 I, float2 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static float2 Refract(float2 I, float2 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static float SqrLength(float2 value)
        {
            return value.x * value.x + value.y * value.y;
        }

        public static float SqrDistance(float2 a, float2 b)
        {
            return SqrLength(a - b);
        }

        public static float2 ClampLength(float2 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static float2 MoveTowards(float2 current, float2 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static float2 Abs(float2 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y));
        }

        public static float2 Sign(float2 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y));
        }

        public static float2 Lerp(float2 a, float2 b, float t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t));
        }

        public static float2 Lerp(float2 a, float2 b, float2 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y));
        }

        public static float2 Min(float2 a, float2 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y));
        }

        public static float2 Max(float2 a, float2 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y));
        }

        public static float2 InvLerp(float2 edge0, float2 edge1, float2 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y));
        }

        public static float2 InvLerp(float2 edge0, float2 edge1, float value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value));
        }

        public static float2 SmoothDamp(float2 source, float2 target, ref float2 velocity, float smoothTime, float deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime));
        }

        public static float2 Pow(float2 a, float2 b)
        {
            return new(Maths.Pow(a.x, b.x), Maths.Pow(a.y, b.y));
        }

        public static float2 Exp(float2 value)
        {
            return new(Maths.Exp(value.x), Maths.Exp(value.y));
        }

        public static float2 Log(float2 value)
        {
            return new(Maths.Log(value.x), Maths.Log(value.y));
        }

        public static float2 Exp2(float2 value)
        {
            return new(Maths.Exp2(value.x), Maths.Exp2(value.y));
        }

        public static float2 Log2(float2 value)
        {
            return new(Maths.Log2(value.x), Maths.Log2(value.y));
        }

        public static float2 Sqrt(float2 value)
        {
            return new(Maths.Sqrt(value.x), Maths.Sqrt(value.y));
        }

        public static float2 InverseSqrt(float2 value)
        {
            return new(Maths.InverseSqrt(value.x), Maths.InverseSqrt(value.y));
        }
    }
}
