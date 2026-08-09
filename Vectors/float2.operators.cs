#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct float2
    {

        public static bool operator ==(float2 left, float2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(float2 left, float2 right)
        {
            return left.x != right.x || left.y != right.y;
        }

        public static float2 operator -(float2 value)
        {
            return new(-value.x, -value.y);
        }

        public static float2 operator +(float2 left, float2 right)
        {
            return new(left.x + right.x, left.y + right.y);
        }

        public static float2 operator -(float2 left, float2 right)
        {
            return new(left.x - right.x, left.y - right.y);
        }

        public static float2 operator *(float2 left, float2 right)
        {
            return new(left.x * right.x, left.y * right.y);
        }

        public static float2 operator /(float2 left, float2 right)
        {
            return new(left.x / right.x, left.y / right.y);
        }

        public static float2 operator +(float2 left, float right)
        {
            return new(left.x + right, left.y + right);
        }

        public static float2 operator +(float left, float2 right)
        {
            return new(left + right.x, left + right.y);
        }

        public static float2 operator -(float2 left, float right)
        {
            return new(left.x - right, left.y - right);
        }

        public static float2 operator -(float left, float2 right)
        {
            return new(left - right.x, left - right.y);
        }

        public static float2 operator *(float2 left, float right)
        {
            return new(left.x * right, left.y * right);
        }

        public static float2 operator *(float left, float2 right)
        {
            return new(left * right.x, left * right.y);
        }

        public static float2 operator /(float2 left, float right)
        {
            return new(left.x / right, left.y / right);
        }

        public static float2 operator /(float left, float2 right)
        {
            return new(left / right.x, left / right.y);
        }

        public static implicit operator double2(float2 value)
        {
            return new double2(value.x, value.y);
        }
    }
}
