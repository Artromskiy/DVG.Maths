#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix2
    {

        public static fix2 Clamp(fix2 value, fix min, fix max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max));
        }

        public static fix Length(fix2 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static fix Distance(fix2 a, fix2 b)
        {
            return Length(a - b);
        }

        public static fix Dot(fix2 a, fix2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static fix2 Normalize(fix2 value)
        {
            return value / Length(value);
        }

        public static fix2 FaceForward(fix2 N, fix2 I, fix2 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static fix2 Reflect(fix2 I, fix2 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static fix2 Refract(fix2 I, fix2 N, fix eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static fix SqrLength(fix2 value)
        {
            return value.x * value.x + value.y * value.y;
        }

        public static fix SqrDistance(fix2 a, fix2 b)
        {
            return SqrLength(a - b);
        }

        public static fix2 ClampLength(fix2 value, fix maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static fix2 MoveTowards(fix2 current, fix2 target, fix maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static fix2 Abs(fix2 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y));
        }

        public static fix2 Sign(fix2 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y));
        }

        public static fix2 Lerp(fix2 a, fix2 b, fix t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t));
        }

        public static fix2 Lerp(fix2 a, fix2 b, fix2 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y));
        }

        public static fix2 Min(fix2 a, fix2 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y));
        }

        public static fix2 Max(fix2 a, fix2 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y));
        }

        public static fix2 InvLerp(fix2 edge0, fix2 edge1, fix2 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y));
        }

        public static fix2 InvLerp(fix2 edge0, fix2 edge1, fix value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value));
        }

        public static fix2 SmoothDamp(fix2 source, fix2 target, ref fix2 velocity, fix smoothTime, fix deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime));
        }
    }
}
