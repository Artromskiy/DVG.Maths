#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct uint3
    {

        public static bool operator ==(uint3 left, uint3 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z;
        }

        public static bool operator !=(uint3 left, uint3 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z;
        }

        public static uint3 operator +(uint3 left, uint3 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static uint3 operator -(uint3 left, uint3 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z);
        }

        public static uint3 operator *(uint3 left, uint3 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z);
        }

        public static uint3 operator /(uint3 left, uint3 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z);
        }

        public static uint3 operator +(uint3 left, uint right)
        {
            return new(left.x + right, left.y + right, left.z + right);
        }

        public static uint3 operator +(uint left, uint3 right)
        {
            return new(left + right.x, left + right.y, left + right.z);
        }

        public static uint3 operator -(uint3 left, uint right)
        {
            return new(left.x - right, left.y - right, left.z - right);
        }

        public static uint3 operator -(uint left, uint3 right)
        {
            return new(left - right.x, left - right.y, left - right.z);
        }

        public static uint3 operator *(uint3 left, uint right)
        {
            return new(left.x * right, left.y * right, left.z * right);
        }

        public static uint3 operator *(uint left, uint3 right)
        {
            return new(left * right.x, left * right.y, left * right.z);
        }

        public static uint3 operator /(uint3 left, uint right)
        {
            return new(left.x / right, left.y / right, left.z / right);
        }

        public static uint3 operator /(uint left, uint3 right)
        {
            return new(left / right.x, left / right.y, left / right.z);
        }

        public static uint3 operator %(uint3 left, uint3 right)
        {
            return new(left.x % right.x, left.y % right.y, left.z % right.z);
        }

        public static uint3 operator %(uint3 left, uint right)
        {
            return new(left.x % right, left.y % right, left.z % right);
        }

        public static uint3 operator %(uint left, uint3 right)
        {
            return new(left % right.x, left % right.y, left % right.z);
        }

        public static uint3 operator ^(uint3 left, uint3 right)
        {
            return new(left.x ^ right.x, left.y ^ right.y, left.z ^ right.z);
        }

        public static uint3 operator ^(uint3 left, uint right)
        {
            return new(left.x ^ right, left.y ^ right, left.z ^ right);
        }

        public static uint3 operator ^(uint left, uint3 right)
        {
            return new(left ^ right.x, left ^ right.y, left ^ right.z);
        }

        public static uint3 operator |(uint3 left, uint3 right)
        {
            return new(left.x | right.x, left.y | right.y, left.z | right.z);
        }

        public static uint3 operator |(uint3 left, uint right)
        {
            return new(left.x | right, left.y | right, left.z | right);
        }

        public static uint3 operator |(uint left, uint3 right)
        {
            return new(left | right.x, left | right.y, left | right.z);
        }

        public static uint3 operator &(uint3 left, uint3 right)
        {
            return new(left.x & right.x, left.y & right.y, left.z & right.z);
        }

        public static uint3 operator &(uint3 left, uint right)
        {
            return new(left.x & right, left.y & right, left.z & right);
        }

        public static uint3 operator &(uint left, uint3 right)
        {
            return new(left & right.x, left & right.y, left & right.z);
        }

        public static uint3 operator <<(uint3 left, int right)
        {
            return new(left.x << right, left.y << right, left.z << right);
        }

        public static uint3 operator >>(uint3 left, int right)
        {
            return new(left.x >> right, left.y >> right, left.z >> right);
        }

        public static uint3 operator ~(uint3 value)
        {
            return new(~value.x, ~value.y, ~value.z);
        }

        public static implicit operator float3(uint3 value)
        {
            return new float3(value.x, value.y, value.z);
        }

        public static implicit operator double3(uint3 value)
        {
            return new double3(value.x, value.y, value.z);
        }
    }
}
