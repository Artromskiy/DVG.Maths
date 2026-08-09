#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct double3
    {

        public static bool operator ==(double3 left, double3 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z;
        }

        public static bool operator !=(double3 left, double3 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z;
        }

        public static double3 operator -(double3 value)
        {
            return new(-value.x, -value.y, -value.z);
        }

        public static double3 operator +(double3 left, double3 right)
        {
            return new(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static double3 operator -(double3 left, double3 right)
        {
            return new(left.x - right.x, left.y - right.y, left.z - right.z);
        }

        public static double3 operator *(double3 left, double3 right)
        {
            return new(left.x * right.x, left.y * right.y, left.z * right.z);
        }

        public static double3 operator /(double3 left, double3 right)
        {
            return new(left.x / right.x, left.y / right.y, left.z / right.z);
        }

        public static double3 operator +(double3 left, double right)
        {
            return new(left.x + right, left.y + right, left.z + right);
        }

        public static double3 operator +(double left, double3 right)
        {
            return new(left + right.x, left + right.y, left + right.z);
        }

        public static double3 operator -(double3 left, double right)
        {
            return new(left.x - right, left.y - right, left.z - right);
        }

        public static double3 operator -(double left, double3 right)
        {
            return new(left - right.x, left - right.y, left - right.z);
        }

        public static double3 operator *(double3 left, double right)
        {
            return new(left.x * right, left.y * right, left.z * right);
        }

        public static double3 operator *(double left, double3 right)
        {
            return new(left * right.x, left * right.y, left * right.z);
        }

        public static double3 operator /(double3 left, double right)
        {
            return new(left.x / right, left.y / right, left.z / right);
        }

        public static double3 operator /(double left, double3 right)
        {
            return new(left / right.x, left / right.y, left / right.z);
        }
    }
}
