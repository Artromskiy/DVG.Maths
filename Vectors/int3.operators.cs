#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct int3
    {

        public static bool operator ==(int3 left, int3 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z;
        }

        public static bool operator !=(int3 left, int3 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z;
        }

        public static int3 operator -(int3 value)
        {
            return new(-value.x, -value.y, -value.z);
        }

        public static int3 operator +(int3 left, int3 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static int3 operator -(int3 left, int3 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z);
        }

        public static int3 operator *(int3 left, int3 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z);
        }

        public static int3 operator /(int3 left, int3 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z);
        }

        public static int3 operator +(int3 left, int right)
        {
            return new(left.x + right, left.y + right, left.z + right);
        }

        public static int3 operator +(int left, int3 right)
        {
            return new(left + right.x, left + right.y, left + right.z);
        }

        public static int3 operator -(int3 left, int right)
        {
            return new(left.x - right, left.y - right, left.z - right);
        }

        public static int3 operator -(int left, int3 right)
        {
            return new(left - right.x, left - right.y, left - right.z);
        }

        public static int3 operator *(int3 left, int right)
        {
            return new(left.x * right, left.y * right, left.z * right);
        }

        public static int3 operator *(int left, int3 right)
        {
            return new(left * right.x, left * right.y, left * right.z);
        }

        public static int3 operator /(int3 left, int right)
        {
            return new(left.x / right, left.y / right, left.z / right);
        }

        public static int3 operator /(int left, int3 right)
        {
            return new(left / right.x, left / right.y, left / right.z);
        }

        public static int3 operator %(int3 left, int3 right)
        {
            return new(left.x % right.x, left.y % right.y, left.z % right.z);
        }

        public static int3 operator %(int3 left, int right)
        {
            return new(left.x % right, left.y % right, left.z % right);
        }

        public static int3 operator %(int left, int3 right)
        {
            return new(left % right.x, left % right.y, left % right.z);
        }

        public static int3 operator ^(int3 left, int3 right)
        {
            return new(left.x ^ right.x, left.y ^ right.y, left.z ^ right.z);
        }

        public static int3 operator ^(int3 left, int right)
        {
            return new(left.x ^ right, left.y ^ right, left.z ^ right);
        }

        public static int3 operator ^(int left, int3 right)
        {
            return new(left ^ right.x, left ^ right.y, left ^ right.z);
        }

        public static int3 operator |(int3 left, int3 right)
        {
            return new(left.x | right.x, left.y | right.y, left.z | right.z);
        }

        public static int3 operator |(int3 left, int right)
        {
            return new(left.x | right, left.y | right, left.z | right);
        }

        public static int3 operator |(int left, int3 right)
        {
            return new(left | right.x, left | right.y, left | right.z);
        }

        public static int3 operator &(int3 left, int3 right)
        {
            return new(left.x & right.x, left.y & right.y, left.z & right.z);
        }

        public static int3 operator &(int3 left, int right)
        {
            return new(left.x & right, left.y & right, left.z & right);
        }

        public static int3 operator &(int left, int3 right)
        {
            return new(left & right.x, left & right.y, left & right.z);
        }

        public static int3 operator <<(int3 left, int right)
        {
            return new(left.x << right, left.y << right, left.z << right);
        }

        public static int3 operator >>(int3 left, int right)
        {
            return new(left.x >> right, left.y >> right, left.z >> right);
        }

        public static int3 operator ~(int3 value)
        {
            return new(~value.x, ~value.y, ~value.z);
        }

        public static implicit operator uint3(int3 value)
        {
            return new uint3((uint)value.x, (uint)value.y, (uint)value.z);
        }

        public static implicit operator float3(int3 value)
        {
            return new float3(value.x, value.y, value.z);
        }

        public static implicit operator double3(int3 value)
        {
            return new double3(value.x, value.y, value.z);
        }
    }
}
