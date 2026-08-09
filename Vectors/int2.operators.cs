#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct int2
    {

        public static bool operator ==(int2 left, int2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(int2 left, int2 right)
        {
            return left.x != right.x || left.y != right.y;
        }

        public static int2 operator -(int2 value)
        {
            return new(-value.x, -value.y);
        }

        public static int2 operator +(int2 left, int2 right)
        {
            return new(left.x + right.x, left.y + right.y);
        }

        public static int2 operator -(int2 left, int2 right)
        {
            return new(left.x - right.x, left.y - right.y);
        }

        public static int2 operator *(int2 left, int2 right)
        {
            return new(left.x * right.x, left.y * right.y);
        }

        public static int2 operator /(int2 left, int2 right)
        {
            return new(left.x / right.x, left.y / right.y);
        }

        public static int2 operator +(int2 left, int right)
        {
            return new(left.x + right, left.y + right);
        }

        public static int2 operator +(int left, int2 right)
        {
            return new(left + right.x, left + right.y);
        }

        public static int2 operator -(int2 left, int right)
        {
            return new(left.x - right, left.y - right);
        }

        public static int2 operator -(int left, int2 right)
        {
            return new(left - right.x, left - right.y);
        }

        public static int2 operator *(int2 left, int right)
        {
            return new(left.x * right, left.y * right);
        }

        public static int2 operator *(int left, int2 right)
        {
            return new(left * right.x, left * right.y);
        }

        public static int2 operator /(int2 left, int right)
        {
            return new(left.x / right, left.y / right);
        }

        public static int2 operator /(int left, int2 right)
        {
            return new(left / right.x, left / right.y);
        }

        public static int2 operator %(int2 left, int2 right)
        {
            return new(left.x % right.x, left.y % right.y);
        }

        public static int2 operator %(int2 left, int right)
        {
            return new(left.x % right, left.y % right);
        }

        public static int2 operator %(int left, int2 right)
        {
            return new(left % right.x, left % right.y);
        }

        public static int2 operator ^(int2 left, int2 right)
        {
            return new(left.x ^ right.x, left.y ^ right.y);
        }

        public static int2 operator ^(int2 left, int right)
        {
            return new(left.x ^ right, left.y ^ right);
        }

        public static int2 operator ^(int left, int2 right)
        {
            return new(left ^ right.x, left ^ right.y);
        }

        public static int2 operator |(int2 left, int2 right)
        {
            return new(left.x | right.x, left.y | right.y);
        }

        public static int2 operator |(int2 left, int right)
        {
            return new(left.x | right, left.y | right);
        }

        public static int2 operator |(int left, int2 right)
        {
            return new(left | right.x, left | right.y);
        }

        public static int2 operator &(int2 left, int2 right)
        {
            return new(left.x & right.x, left.y & right.y);
        }

        public static int2 operator &(int2 left, int right)
        {
            return new(left.x & right, left.y & right);
        }

        public static int2 operator &(int left, int2 right)
        {
            return new(left & right.x, left & right.y);
        }

        public static int2 operator <<(int2 left, int right)
        {
            return new(left.x << right, left.y << right);
        }

        public static int2 operator >>(int2 left, int right)
        {
            return new(left.x >> right, left.y >> right);
        }

        public static int2 operator ~(int2 value)
        {
            return new(~value.x, ~value.y);
        }

        public static implicit operator uint2(int2 value)
        {
            return new uint2((uint)value.x, (uint)value.y);
        }

        public static implicit operator float2(int2 value)
        {
            return new float2(value.x, value.y);
        }

        public static implicit operator double2(int2 value)
        {
            return new double2(value.x, value.y);
        }
    }
}
