#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct uint2
    {

        public static bool operator ==(uint2 left, uint2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(uint2 left, uint2 right)
        {
            return left.x != right.x || left.y != right.y;
        }

        public static uint2 operator +(uint2 left, uint2 right)
        {
            return new(left.x + right.x, left.y + right.y);
        }

        public static uint2 operator -(uint2 left, uint2 right)
        {
            return new(left.x - right.x, left.y - right.y);
        }

        public static uint2 operator *(uint2 left, uint2 right)
        {
            return new(left.x * right.x, left.y * right.y);
        }

        public static uint2 operator /(uint2 left, uint2 right)
        {
            return new(left.x / right.x, left.y / right.y);
        }

        public static uint2 operator +(uint2 left, uint right)
        {
            return new(left.x + right, left.y + right);
        }

        public static uint2 operator +(uint left, uint2 right)
        {
            return new(left + right.x, left + right.y);
        }

        public static uint2 operator -(uint2 left, uint right)
        {
            return new(left.x - right, left.y - right);
        }

        public static uint2 operator -(uint left, uint2 right)
        {
            return new(left - right.x, left - right.y);
        }

        public static uint2 operator *(uint2 left, uint right)
        {
            return new(left.x * right, left.y * right);
        }

        public static uint2 operator *(uint left, uint2 right)
        {
            return new(left * right.x, left * right.y);
        }

        public static uint2 operator /(uint2 left, uint right)
        {
            return new(left.x / right, left.y / right);
        }

        public static uint2 operator /(uint left, uint2 right)
        {
            return new(left / right.x, left / right.y);
        }

        public static uint2 operator %(uint2 left, uint2 right)
        {
            return new(left.x % right.x, left.y % right.y);
        }

        public static uint2 operator %(uint2 left, uint right)
        {
            return new(left.x % right, left.y % right);
        }

        public static uint2 operator %(uint left, uint2 right)
        {
            return new(left % right.x, left % right.y);
        }

        public static uint2 operator ^(uint2 left, uint2 right)
        {
            return new(left.x ^ right.x, left.y ^ right.y);
        }

        public static uint2 operator ^(uint2 left, uint right)
        {
            return new(left.x ^ right, left.y ^ right);
        }

        public static uint2 operator ^(uint left, uint2 right)
        {
            return new(left ^ right.x, left ^ right.y);
        }

        public static uint2 operator |(uint2 left, uint2 right)
        {
            return new(left.x | right.x, left.y | right.y);
        }

        public static uint2 operator |(uint2 left, uint right)
        {
            return new(left.x | right, left.y | right);
        }

        public static uint2 operator |(uint left, uint2 right)
        {
            return new(left | right.x, left | right.y);
        }

        public static uint2 operator &(uint2 left, uint2 right)
        {
            return new(left.x & right.x, left.y & right.y);
        }

        public static uint2 operator &(uint2 left, uint right)
        {
            return new(left.x & right, left.y & right);
        }

        public static uint2 operator &(uint left, uint2 right)
        {
            return new(left & right.x, left & right.y);
        }

        public static uint2 operator <<(uint2 left, int right)
        {
            return new(left.x << right, left.y << right);
        }

        public static uint2 operator >>(uint2 left, int right)
        {
            return new(left.x >> right, left.y >> right);
        }

        public static uint2 operator ~(uint2 value)
        {
            return new(~value.x, ~value.y);
        }

        public static implicit operator float2(uint2 value)
        {
            return new float2(value.x, value.y);
        }

        public static implicit operator double2(uint2 value)
        {
            return new double2(value.x, value.y);
        }
    }
}
