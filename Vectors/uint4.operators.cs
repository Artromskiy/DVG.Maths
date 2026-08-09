#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct uint4
    {

        public static bool operator ==(uint4 left, uint4 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;
        }

        public static bool operator !=(uint4 left, uint4 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;
        }

        public static uint4 operator +(uint4 left, uint4 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }

        public static uint4 operator -(uint4 left, uint4 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }

        public static uint4 operator *(uint4 left, uint4 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);
        }

        public static uint4 operator /(uint4 left, uint4 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);
        }

        public static uint4 operator +(uint4 left, uint right)
        {
            return new(left.x + right, left.y + right, left.z + right, left.w + right);
        }

        public static uint4 operator +(uint left, uint4 right)
        {
            return new(left + right.x, left + right.y, left + right.z, left + right.w);
        }

        public static uint4 operator -(uint4 left, uint right)
        {
            return new(left.x - right, left.y - right, left.z - right, left.w - right);
        }

        public static uint4 operator -(uint left, uint4 right)
        {
            return new(left - right.x, left - right.y, left - right.z, left - right.w);
        }

        public static uint4 operator *(uint4 left, uint right)
        {
            return new(left.x * right, left.y * right, left.z * right, left.w * right);
        }

        public static uint4 operator *(uint left, uint4 right)
        {
            return new(left * right.x, left * right.y, left * right.z, left * right.w);
        }

        public static uint4 operator /(uint4 left, uint right)
        {
            return new(left.x / right, left.y / right, left.z / right, left.w / right);
        }

        public static uint4 operator /(uint left, uint4 right)
        {
            return new(left / right.x, left / right.y, left / right.z, left / right.w);
        }

        public static uint4 operator %(uint4 left, uint4 right)
        {
            return new(left.x % right.x, left.y % right.y, left.z % right.z, left.w % right.w);
        }

        public static uint4 operator %(uint4 left, uint right)
        {
            return new(left.x % right, left.y % right, left.z % right, left.w % right);
        }

        public static uint4 operator %(uint left, uint4 right)
        {
            return new(left % right.x, left % right.y, left % right.z, left % right.w);
        }

        public static uint4 operator ^(uint4 left, uint4 right)
        {
            return new(left.x ^ right.x, left.y ^ right.y, left.z ^ right.z, left.w ^ right.w);
        }

        public static uint4 operator ^(uint4 left, uint right)
        {
            return new(left.x ^ right, left.y ^ right, left.z ^ right, left.w ^ right);
        }

        public static uint4 operator ^(uint left, uint4 right)
        {
            return new(left ^ right.x, left ^ right.y, left ^ right.z, left ^ right.w);
        }

        public static uint4 operator |(uint4 left, uint4 right)
        {
            return new(left.x | right.x, left.y | right.y, left.z | right.z, left.w | right.w);
        }

        public static uint4 operator |(uint4 left, uint right)
        {
            return new(left.x | right, left.y | right, left.z | right, left.w | right);
        }

        public static uint4 operator |(uint left, uint4 right)
        {
            return new(left | right.x, left | right.y, left | right.z, left | right.w);
        }

        public static uint4 operator &(uint4 left, uint4 right)
        {
            return new(left.x & right.x, left.y & right.y, left.z & right.z, left.w & right.w);
        }

        public static uint4 operator &(uint4 left, uint right)
        {
            return new(left.x & right, left.y & right, left.z & right, left.w & right);
        }

        public static uint4 operator &(uint left, uint4 right)
        {
            return new(left & right.x, left & right.y, left & right.z, left & right.w);
        }

        public static uint4 operator <<(uint4 left, int right)
        {
            return new(left.x << right, left.y << right, left.z << right, left.w << right);
        }

        public static uint4 operator >>(uint4 left, int right)
        {
            return new(left.x >> right, left.y >> right, left.z >> right, left.w >> right);
        }

        public static uint4 operator ~(uint4 value)
        {
            return new(~value.x, ~value.y, ~value.z, ~value.w);
        }

        public static implicit operator float4(uint4 value)
        {
            return new float4(value.x, value.y, value.z, value.w);
        }

        public static implicit operator double4(uint4 value)
        {
            return new double4(value.x, value.y, value.z, value.w);
        }
    }
}
