#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct double2
    {

        public static bool operator ==(double2 left, double2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(double2 left, double2 right)
        {
            return left.x != right.x || left.y != right.y;
        }

        public static double2 operator -(double2 value)
        {
            return new(-value.x, -value.y);
        }

        public static double2 operator +(double2 left, double2 right)
        {
            return new(left.x + right.x, left.y + right.y);
        }

        public static double2 operator -(double2 left, double2 right)
        {
            return new(left.x - right.x, left.y - right.y);
        }

        public static double2 operator *(double2 left, double2 right)
        {
            return new(left.x * right.x, left.y * right.y);
        }

        public static double2 operator /(double2 left, double2 right)
        {
            return new(left.x / right.x, left.y / right.y);
        }

        public static double2 operator +(double2 left, double right)
        {
            return new(left.x + right, left.y + right);
        }

        public static double2 operator +(double left, double2 right)
        {
            return new(left + right.x, left + right.y);
        }

        public static double2 operator -(double2 left, double right)
        {
            return new(left.x - right, left.y - right);
        }

        public static double2 operator -(double left, double2 right)
        {
            return new(left - right.x, left - right.y);
        }

        public static double2 operator *(double2 left, double right)
        {
            return new(left.x * right, left.y * right);
        }

        public static double2 operator *(double left, double2 right)
        {
            return new(left * right.x, left * right.y);
        }

        public static double2 operator /(double2 left, double right)
        {
            return new(left.x / right, left.y / right);
        }

        public static double2 operator /(double left, double2 right)
        {
            return new(left / right.x, left / right.y);
        }
    }
}
