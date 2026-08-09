#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct double4
    {

        public static bool operator ==(double4 left, double4 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;
        }

        public static bool operator !=(double4 left, double4 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z || left.w != right.w;
        }

        public static double4 operator -(double4 value)
        {
            return new(-value.x, -value.y, -value.z, -value.w);
        }

        public static double4 operator +(double4 left, double4 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }

        public static double4 operator -(double4 left, double4 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }

        public static double4 operator *(double4 left, double4 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z, left.w * right.w);
        }

        public static double4 operator /(double4 left, double4 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z, left.w / right.w);
        }

        public static double4 operator +(double4 left, double right)
        {
            return new(left.x + right, left.y + right, left.z + right, left.w + right);
        }

        public static double4 operator +(double left, double4 right)
        {
            return new(left + right.x, left + right.y, left + right.z, left + right.w);
        }

        public static double4 operator -(double4 left, double right)
        {
            return new(left.x - right, left.y - right, left.z - right, left.w - right);
        }

        public static double4 operator -(double left, double4 right)
        {
            return new(left - right.x, left - right.y, left - right.z, left - right.w);
        }

        public static double4 operator *(double4 left, double right)
        {
            return new(left.x * right, left.y * right, left.z * right, left.w * right);
        }

        public static double4 operator *(double left, double4 right)
        {
            return new(left * right.x, left * right.y, left * right.z, left * right.w);
        }

        public static double4 operator /(double4 left, double right)
        {
            return new(left.x / right, left.y / right, left.z / right, left.w / right);
        }

        public static double4 operator /(double left, double4 right)
        {
            return new(left / right.x, left / right.y, left / right.z, left / right.w);
        }
    }
}
