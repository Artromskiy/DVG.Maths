#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct float4
    {

        public static bool operator ==(float4 left, float4 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;
        }

        public static bool operator !=(float4 left, float4 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;
        }

        public static float4 operator -(float4 value)
        {
            return new(-value.x, -value.y, -value.z, -value.w);
        }

        public static float4 operator +(float4 left, float4 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }

        public static float4 operator -(float4 left, float4 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }

        public static float4 operator *(float4 left, float4 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);
        }

        public static float4 operator /(float4 left, float4 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);
        }

        public static float4 operator +(float4 left, float right)
        {
            return new(left.x + right, left.y + right, left.z + right, left.w + right);
        }

        public static float4 operator +(float left, float4 right)
        {
            return new(left + right.x, left + right.y, left + right.z, left + right.w);
        }

        public static float4 operator -(float4 left, float right)
        {
            return new(left.x - right, left.y - right, left.z - right, left.w - right);
        }

        public static float4 operator -(float left, float4 right)
        {
            return new(left - right.x, left - right.y, left - right.z, left - right.w);
        }

        public static float4 operator *(float4 left, float right)
        {
            return new(left.x * right, left.y * right, left.z * right, left.w * right);
        }

        public static float4 operator *(float left, float4 right)
        {
            return new(left * right.x, left * right.y, left * right.z, left * right.w);
        }

        public static float4 operator /(float4 left, float right)
        {
            return new(left.x / right, left.y / right, left.z / right, left.w / right);
        }

        public static float4 operator /(float left, float4 right)
        {
            return new(left / right.x, left / right.y, left / right.z, left / right.w);
        }

        public static implicit operator double4(float4 value)
        {
            return new double4(value.x, value.y, value.z, value.w);
        }
    }
}
