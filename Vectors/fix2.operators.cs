#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix2
    {

        public static bool operator ==(fix2 left, fix2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(fix2 left, fix2 right)
        {
            return left.x != right.x || left.y != right.y;
        }

        public static fix2 operator -(fix2 value)
        {
            return new(-value.x, -value.y);
        }

        public static fix2 operator +(fix2 left, fix2 right)
        {
            return new(left.x + right.x, left.y + right.y);
        }

        public static fix2 operator -(fix2 left, fix2 right)
        {
            return new(left.x - right.x, left.y - right.y);
        }

        public static fix2 operator *(fix2 left, fix2 right)
        {
            return new(left.x * right.x, left.y * right.y);
        }

        public static fix2 operator /(fix2 left, fix2 right)
        {
            return new(left.x / right.x, left.y / right.y);
        }

        public static fix2 operator +(fix2 left, fix right)
        {
            return new(left.x + right, left.y + right);
        }

        public static fix2 operator +(fix left, fix2 right)
        {
            return new(left + right.x, left + right.y);
        }

        public static fix2 operator -(fix2 left, fix right)
        {
            return new(left.x - right, left.y - right);
        }

        public static fix2 operator -(fix left, fix2 right)
        {
            return new(left - right.x, left - right.y);
        }

        public static fix2 operator *(fix2 left, fix right)
        {
            return new(left.x * right, left.y * right);
        }

        public static fix2 operator *(fix left, fix2 right)
        {
            return new(left * right.x, left * right.y);
        }

        public static fix2 operator /(fix2 left, fix right)
        {
            return new(left.x / right, left.y / right);
        }

        public static fix2 operator /(fix left, fix2 right)
        {
            return new(left / right.x, left / right.y);
        }
    }
}
