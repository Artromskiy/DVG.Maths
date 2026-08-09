#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix4
    {

        public static bool operator ==(fix4 left, fix4 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;
        }

        public static bool operator !=(fix4 left, fix4 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;
        }

        public static fix4 operator -(fix4 value)
        {
            return new(-value.x, -value.y, -value.z, -value.w);
        }

        public static fix4 operator +(fix4 left, fix4 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }

        public static fix4 operator -(fix4 left, fix4 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }

        public static fix4 operator *(fix4 left, fix4 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);
        }

        public static fix4 operator /(fix4 left, fix4 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);
        }

        public static fix4 operator +(fix4 left, fix right)
        {
            return new(left.x + right, left.y + right, left.z + right, left.w + right);
        }

        public static fix4 operator +(fix left, fix4 right)
        {
            return new(left + right.x, left + right.y, left + right.z, left + right.w);
        }

        public static fix4 operator -(fix4 left, fix right)
        {
            return new(left.x - right, left.y - right, left.z - right, left.w - right);
        }

        public static fix4 operator -(fix left, fix4 right)
        {
            return new(left - right.x, left - right.y, left - right.z, left - right.w);
        }

        public static fix4 operator *(fix4 left, fix right)
        {
            return new(left.x * right, left.y * right, left.z * right, left.w * right);
        }

        public static fix4 operator *(fix left, fix4 right)
        {
            return new(left * right.x, left * right.y, left * right.z, left * right.w);
        }

        public static fix4 operator /(fix4 left, fix right)
        {
            return new(left.x / right, left.y / right, left.z / right, left.w / right);
        }

        public static fix4 operator /(fix left, fix4 right)
        {
            return new(left / right.x, left / right.y, left / right.z, left / right.w);
        }
    }
}
