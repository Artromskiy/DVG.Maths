#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix3
    {

        public static bool operator ==(fix3 left, fix3 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z;
        }

        public static bool operator !=(fix3 left, fix3 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z;
        }

        public static fix3 operator -(fix3 value)
        {
            return new(-value.x, -value.y, -value.z);
        }

        public static fix3 operator +(fix3 left, fix3 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static fix3 operator -(fix3 left, fix3 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z);
        }

        public static fix3 operator *(fix3 left, fix3 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z);
        }

        public static fix3 operator /(fix3 left, fix3 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z);
        }

        public static fix3 operator +(fix3 left, fix right)
        {
            return new(left.x + right, left.y + right, left.z + right);
        }

        public static fix3 operator +(fix left, fix3 right)
        {
            return new(left + right.x, left + right.y, left + right.z);
        }

        public static fix3 operator -(fix3 left, fix right)
        {
            return new(left.x - right, left.y - right, left.z - right);
        }

        public static fix3 operator -(fix left, fix3 right)
        {
            return new(left - right.x, left - right.y, left - right.z);
        }

        public static fix3 operator *(fix3 left, fix right)
        {
            return new(left.x * right, left.y * right, left.z * right);
        }

        public static fix3 operator *(fix left, fix3 right)
        {
            return new(left * right.x, left * right.y, left * right.z);
        }

        public static fix3 operator /(fix3 left, fix right)
        {
            return new(left.x / right, left.y / right, left.z / right);
        }

        public static fix3 operator /(fix left, fix3 right)
        {
            return new(left / right.x, left / right.y, left / right.z);
        }
    }
}
