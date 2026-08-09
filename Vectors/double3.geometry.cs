#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct double3
    {

        public static double3 Clamp(double3 value, double min, double max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max));
        }

        public static double Length(double3 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static double Distance(double3 a, double3 b)
        {
            return Length(a - b);
        }

        public static double Dot(double3 a, double3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public static double3 Cross(double3 a, double3 b)
        {
            return new(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        }

        public static double3 Normalize(double3 value)
        {
            return value / Length(value);
        }

        public static double3 FaceForward(double3 N, double3 I, double3 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static double3 Reflect(double3 I, double3 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static double3 Refract(double3 I, double3 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static double SqrLength(double3 value)
        {
            return value.x * value.x + value.y * value.y + value.z * value.z;
        }

        public static double SqrDistance(double3 a, double3 b)
        {
            return SqrLength(a - b);
        }

        public static double3 ClampLength(double3 value, double maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static double3 MoveTowards(double3 current, double3 target, double maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static double3 Abs(double3 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y), Maths.Abs(value.z));
        }

        public static double3 Sign(double3 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y), Maths.Sign(value.z));
        }

        public static double3 Lerp(double3 a, double3 b, double t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t), Maths.Lerp(a.z, b.z, t));
        }

        public static double3 Lerp(double3 a, double3 b, double3 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y), Maths.Lerp(a.z, b.z, t.z));
        }

        public static double3 Min(double3 a, double3 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y), Maths.Min(a.z, b.z));
        }

        public static double3 Max(double3 a, double3 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y), Maths.Max(a.z, b.z));
        }

        public static double3 InvLerp(double3 edge0, double3 edge1, double3 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y), Maths.InvLerp(edge0.z, edge1.z, value.z));
        }

        public static double3 InvLerp(double3 edge0, double3 edge1, double value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value), Maths.InvLerp(edge0.z, edge1.z, value));
        }

        public static double3 SmoothDamp(double3 source, double3 target, ref double3 velocity, double smoothTime, double deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime));
        }

        public static double3 Sqrt(double3 value)
        {
            return new(Maths.Sqrt(value.x), Maths.Sqrt(value.y), Maths.Sqrt(value.z));
        }

        public static double3 InverseSqrt(double3 value)
        {
            return new(Maths.InverseSqrt(value.x), Maths.InverseSqrt(value.y), Maths.InverseSqrt(value.z));
        }
    }
}
