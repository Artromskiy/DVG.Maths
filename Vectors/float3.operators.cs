#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct float3
    {

        public static bool operator ==(float3 left, float3 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z;
        }

        public static bool operator !=(float3 left, float3 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z;
        }

        public static float3 operator -(float3 value)
        {
            return new(-value.x, -value.y, -value.z);
        }

        public static float3 operator +(float3 left, float3 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static float3 operator -(float3 left, float3 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z);
        }

        public static float3 operator *(float3 left, float3 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z);
        }

        public static float3 operator /(float3 left, float3 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z);
        }

        public static float3 operator +(float3 left, float right)
        {
            return new(left.x + right, left.y + right, left.z + right);
        }

        public static float3 operator +(float left, float3 right)
        {
            return new(left + right.x, left + right.y, left + right.z);
        }

        public static float3 operator -(float3 left, float right)
        {
            return new(left.x - right, left.y - right, left.z - right);
        }

        public static float3 operator -(float left, float3 right)
        {
            return new(left - right.x, left - right.y, left - right.z);
        }

        public static float3 operator *(float3 left, float right)
        {
            return new(left.x * right, left.y * right, left.z * right);
        }

        public static float3 operator *(float left, float3 right)
        {
            return new(left * right.x, left * right.y, left * right.z);
        }

        public static float3 operator /(float3 left, float right)
        {
            return new(left.x / right, left.y / right, left.z / right);
        }

        public static float3 operator /(float left, float3 right)
        {
            return new(left / right.x, left / right.y, left / right.z);
        }

        public static implicit operator double3(float3 value)
        {
            return new double3(value.x, value.y, value.z);
        }
    }
}
