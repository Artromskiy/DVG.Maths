#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix3
    {

        public static fix3 Clamp(fix3 value, fix min, fix max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max));
        }

        public static fix Length(fix3 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static fix Distance(fix3 a, fix3 b)
        {
            return Length(a - b);
        }

        public static fix Dot(fix3 a, fix3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public static fix3 Cross(fix3 a, fix3 b)
        {
            return new(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        }

        public static fix3 Normalize(fix3 value)
        {
            return value / Length(value);
        }

        public static fix3 FaceForward(fix3 N, fix3 I, fix3 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static fix3 Reflect(fix3 I, fix3 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static fix3 Refract(fix3 I, fix3 N, fix eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static fix SqrLength(fix3 value)
        {
            return value.x * value.x + value.y * value.y + value.z * value.z;
        }

        public static fix SqrDistance(fix3 a, fix3 b)
        {
            return SqrLength(a - b);
        }

        public static fix3 ClampLength(fix3 value, fix maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static fix3 MoveTowards(fix3 current, fix3 target, fix maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static fix3 Abs(fix3 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y), Maths.Abs(value.z));
        }

        public static fix3 Sign(fix3 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y), Maths.Sign(value.z));
        }

        public static fix3 Lerp(fix3 a, fix3 b, fix t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t), Maths.Lerp(a.z, b.z, t));
        }

        public static fix3 Lerp(fix3 a, fix3 b, fix3 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y), Maths.Lerp(a.z, b.z, t.z));
        }

        public static fix3 Min(fix3 a, fix3 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y), Maths.Min(a.z, b.z));
        }

        public static fix3 Max(fix3 a, fix3 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y), Maths.Max(a.z, b.z));
        }

        public static fix3 InvLerp(fix3 edge0, fix3 edge1, fix3 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y), Maths.InvLerp(edge0.z, edge1.z, value.z));
        }

        public static fix3 InvLerp(fix3 edge0, fix3 edge1, fix value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value), Maths.InvLerp(edge0.z, edge1.z, value));
        }

        public static fix3 SmoothDamp(fix3 source, fix3 target, ref fix3 velocity, fix smoothTime, fix deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime));
        }
    }
}
