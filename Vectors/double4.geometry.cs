#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct double4
    {

        public static double4 Clamp(double4 value, double min, double max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max), Maths.Clamp(value.w, min, max));
        }

        public static double Length(double4 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static double Distance(double4 a, double4 b)
        {
            return Length(a - b);
        }

        public static double Dot(double4 a, double4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        public static double4 Normalize(double4 value)
        {
            return value / Length(value);
        }

        public static double4 FaceForward(double4 N, double4 I, double4 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static double4 Reflect(double4 I, double4 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static double4 Refract(double4 I, double4 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static double SqrLength(double4 value)
        {
            return value.x * value.x + value.y * value.y + value.z * value.z + value.w * value.w;
        }

        public static double SqrDistance(double4 a, double4 b)
        {
            return SqrLength(a - b);
        }

        public static double4 ClampLength(double4 value, double maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static double4 MoveTowards(double4 current, double4 target, double maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static double4 Abs(double4 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y), Maths.Abs(value.z), Maths.Abs(value.w));
        }

        public static double4 Sign(double4 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y), Maths.Sign(value.z), Maths.Sign(value.w));
        }

        public static double4 Lerp(double4 a, double4 b, double t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t), Maths.Lerp(a.z, b.z, t), Maths.Lerp(a.w, b.w, t));
        }

        public static double4 Lerp(double4 a, double4 b, double4 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y), Maths.Lerp(a.z, b.z, t.z), Maths.Lerp(a.w, b.w, t.w));
        }

        public static double4 Min(double4 a, double4 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y), Maths.Min(a.z, b.z), Maths.Min(a.w, b.w));
        }

        public static double4 Max(double4 a, double4 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y), Maths.Max(a.z, b.z), Maths.Max(a.w, b.w));
        }

        public static double4 InvLerp(double4 edge0, double4 edge1, double4 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y), Maths.InvLerp(edge0.z, edge1.z, value.z), Maths.InvLerp(edge0.w, edge1.w, value.w));
        }

        public static double4 InvLerp(double4 edge0, double4 edge1, double value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value), Maths.InvLerp(edge0.z, edge1.z, value), Maths.InvLerp(edge0.w, edge1.w, value));
        }

        public static double4 SmoothDamp(double4 source, double4 target, ref double4 velocity, double smoothTime, double deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime), Maths.SmoothDamp(source.w, target.w, ref velocity.w, smoothTime, deltaTime));
        }

        public static double4 Sqrt(double4 value)
        {
            return new(Maths.Sqrt(value.x), Maths.Sqrt(value.y), Maths.Sqrt(value.z), Maths.Sqrt(value.w));
        }

        public static double4 InverseSqrt(double4 value)
        {
            return new(Maths.InverseSqrt(value.x), Maths.InverseSqrt(value.y), Maths.InverseSqrt(value.z), Maths.InverseSqrt(value.w));
        }
    }
}
