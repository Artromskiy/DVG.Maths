#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix4
    {

        public static fix4 Clamp(fix4 value, fix min, fix max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max), Maths.Clamp(value.w, min, max));
        }

        public static fix Length(fix4 value)
        {
            return Maths.Sqrt(SqrLength(value));
        }

        public static fix Distance(fix4 a, fix4 b)
        {
            return Length(a - b);
        }

        public static fix Dot(fix4 a, fix4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        public static fix4 Normalize(fix4 value)
        {
            return value / Length(value);
        }

        public static fix4 FaceForward(fix4 N, fix4 I, fix4 Nref)
        {
            return Dot(Nref, I) < 0 ? N : -N;
        }

        public static fix4 Reflect(fix4 I, fix4 N)
        {
            return I - 2 * Dot(N, I) * N;
        }

        public static fix4 Refract(fix4 I, fix4 N, fix eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new();
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        public static fix SqrLength(fix4 value)
        {
            return value.x * value.x + value.y * value.y + value.z * value.z + value.w * value.w;
        }

        public static fix SqrDistance(fix4 a, fix4 b)
        {
            return SqrLength(a - b);
        }

        public static fix4 ClampLength(fix4 value, fix maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                var ratio = maxLength * Maths.InverseSqrt(sqrLength);
                return value * ratio;
            }
            return value;
        }

        public static fix4 MoveTowards(fix4 current, fix4 target, fix maxDelta)
        {
            var delta = target - current;
            var sqrDistance = SqrLength(delta);
            return sqrDistance <= maxDelta * maxDelta ? target : current + delta * maxDelta * Maths.InverseSqrt(sqrDistance);
        }

        public static fix4 Abs(fix4 value)
        {
            return new(Maths.Abs(value.x), Maths.Abs(value.y), Maths.Abs(value.z), Maths.Abs(value.w));
        }

        public static fix4 Sign(fix4 value)
        {
            return new(Maths.Sign(value.x), Maths.Sign(value.y), Maths.Sign(value.z), Maths.Sign(value.w));
        }

        public static fix4 Lerp(fix4 a, fix4 b, fix t)
        {
            return new(Maths.Lerp(a.x, b.x, t), Maths.Lerp(a.y, b.y, t), Maths.Lerp(a.z, b.z, t), Maths.Lerp(a.w, b.w, t));
        }

        public static fix4 Lerp(fix4 a, fix4 b, fix4 t)
        {
            return new(Maths.Lerp(a.x, b.x, t.x), Maths.Lerp(a.y, b.y, t.y), Maths.Lerp(a.z, b.z, t.z), Maths.Lerp(a.w, b.w, t.w));
        }

        public static fix4 Min(fix4 a, fix4 b)
        {
            return new(Maths.Min(a.x, b.x), Maths.Min(a.y, b.y), Maths.Min(a.z, b.z), Maths.Min(a.w, b.w));
        }

        public static fix4 Max(fix4 a, fix4 b)
        {
            return new(Maths.Max(a.x, b.x), Maths.Max(a.y, b.y), Maths.Max(a.z, b.z), Maths.Max(a.w, b.w));
        }

        public static fix4 InvLerp(fix4 edge0, fix4 edge1, fix4 value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value.x), Maths.InvLerp(edge0.y, edge1.y, value.y), Maths.InvLerp(edge0.z, edge1.z, value.z), Maths.InvLerp(edge0.w, edge1.w, value.w));
        }

        public static fix4 InvLerp(fix4 edge0, fix4 edge1, fix value)
        {
            return new(Maths.InvLerp(edge0.x, edge1.x, value), Maths.InvLerp(edge0.y, edge1.y, value), Maths.InvLerp(edge0.z, edge1.z, value), Maths.InvLerp(edge0.w, edge1.w, value));
        }

        public static fix4 SmoothDamp(fix4 source, fix4 target, ref fix4 velocity, fix smoothTime, fix deltaTime)
        {
            return new(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime), Maths.SmoothDamp(source.w, target.w, ref velocity.w, smoothTime, deltaTime));
        }
    }
}
