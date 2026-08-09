#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct double2
    {

        public static double2 Clamp(double2 value, double min, double max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max));
        }

        public static double Length(double2 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static double Distance(double2 a, double2 b)
        {
            return Length(a - b);
        }

        public static double Dot(double2 a, double2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static double2 Normalize(double2 value)
        {
            return value / Length(value);
        }

        public static double2 FaceForward(double2 N, double2 I, double2 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static double2 Reflect(double2 I, double2 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static double2 Refract(double2 I, double2 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static double SqrLength(double2 value)
        {
            return value.x * value.x + value.y * value.y;
        }

        public static double SqrDistance(double2 a, double2 b)
        {
            return SqrLength(a - b);
        }

        public static double2 ClampLength(double2 value, double maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static double2 MoveTowards(double2 current, double2 target, double maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static double2 Abs(double2 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y));
        }

        public static double2 Sign(double2 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y));
        }

        public static double2 Lerp(double2 a, double2 b, double t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t));
        }

        public static double2 Lerp(double2 a, double2 b, double2 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y));
        }

        public static double2 Min(double2 a, double2 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y));
        }

        public static double2 Max(double2 a, double2 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y));
        }

        public static double2 InvLerp(double2 edge0, double2 edge1, double2 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y));
        }

        public static double2 InvLerp(double2 edge0, double2 edge1, double value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value));
        }

        public static double2 SmoothDamp(double2 source, double2 target, ref double2 velocity, double smoothTime, double deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime));
        }

        public static double2 Sqrt(double2 value)
        {
            return new(Maths.Sqrt(value.x), Maths.Sqrt(value.y));
        }

        public static double2 InverseSqrt(double2 value)
        {
            return new(Maths.InverseSqrt(value.x), Maths.InverseSqrt(value.y));
        }
    }
}
