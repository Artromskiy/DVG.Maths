#pragma warning disable IDE1006
using System;
using System.Globalization;

namespace DVG
{
    public readonly partial struct fix : IEquatable<fix>, IComparable<fix>
    {
        internal readonly int _raw;

        public static readonly fix MaxValue = new fix(int.MaxValue);
        public static readonly fix MinValue = new fix(int.MinValue);

        public static readonly fix Pi = new fix(205887);
        public static readonly fix E = new fix(178145);
        public static readonly fix One = new fix(0x00010000);
        public static readonly fix Zero = new fix(0);

        public static implicit operator fix(int a)
        {
            return new fix(a * One._raw);
        }

        public static implicit operator float(fix a)
        {
            return (float)a._raw / One._raw;
        }

        public static explicit operator double(fix a)
        {
            return (double)a._raw / One._raw;
        }

        public static explicit operator decimal(fix a)
        {
            return (decimal)a._raw / One._raw;
        }

        public static explicit operator int(fix a)
        {
            return a._raw >> 16;
        }

        public static explicit operator fix(float a)
        {
            var temp = a * One._raw;
            temp += (temp >= 0) ? 0.5f : -0.5f;
            return new fix((int)temp);
        }

        public static explicit operator fix(double a)
        {
            var temp = a * One._raw;
            temp += (temp >= 0) ? 0.5f : -0.5f;
            return new fix((int)temp);
        }

        public static fix operator +(fix x, fix y)
        {
            var sum = x._raw + y._raw;
            // Overflow can only happen if sign of a == sign of b, and then
            // it causes sign of sum != sign of a.
            if ((((x._raw ^ y._raw) & int.MinValue) == 0) && (((x._raw ^ sum) & 0x80000000) != 0))
                throw new OverflowException();

            return new fix(sum);
        }

        public static fix operator -(fix x, fix y)
        {
            var diff = x._raw - y._raw;
            // Overflow can only happen if sign of a != sign of b, and then
            // it causes sign of sum != sign of a.
            if ((((x._raw ^ y._raw) & int.MinValue) != 0) && (((x._raw ^ diff) & 0x80000000) != 0))
                throw new OverflowException();

            return new fix(diff);
        }

        public static fix operator *(fix x, fix y)
        {

            var product = (long)x._raw * y._raw;

            // The upper 17 bits should all be the same (the sign).
            var upper = (uint)(product >> 47);

            if (product < 0)
            {
                if (~upper != 0)
                    throw new OverflowException();

                product--;
            }
            else
            {
                if (upper != 0)
                    throw new OverflowException();
            }

            var result = product >> 16;
            result += (product & 0x8000) >> 15;

            return new fix((int)result);
        }

        private static byte Clz(uint x)
        {
            byte result = 0;
            if (x == 0)
                return 32;
            while ((x & 0xF0000000) == 0)
            {
                result += 4;
                x <<= 4;
            }
            while ((x & 0x80000000) == 0)
            {
                result += 1;
                x <<= 1;
            }
            return result;
        }

        public static fix operator /(fix x, fix y)
        {
            // This uses a hardware 32/32 bit division multiple times, until we have
            // computed all the bits in (a<<17)/b. Usually this takes 1-3 iterations.
            var a = x._raw;
            var b = y._raw;

            if (b == 0)
            {
                return MinValue;
            }

            var remainder = (uint)((a >= 0) ? a : (-a));
            var divider = (uint)((b >= 0) ? b : (-b));
            var quotient = 0U;
            var bitPos = 17;

            // Kick-start the division a bit.
            // This improves speed in the worst-case scenarios where N and D are large
            // It gets a lower estimate for the result by N/(D >> 17 + 1).
            if ((divider & 0xFFF00000) != 0)
            {
                var shiftedDiv = ((divider >> 17) + 1);
                quotient = remainder / shiftedDiv;
                remainder -= (uint)(((ulong)quotient * divider) >> 17);
            }

            // If the divider is divisible by 2^n, take advantage of it.
            while ((divider & 0xF) == 0 && bitPos >= 4)
            {
                divider >>= 4;
                bitPos -= 4;
            }

            while (remainder != 0 && bitPos >= 0)
            {
                // Shift remainder as much as we can without overflowing
                int shift = Clz(remainder);
                if (shift > bitPos) shift = bitPos;
                remainder <<= shift;
                bitPos -= shift;

                var div = remainder / divider;
                remainder = remainder % divider;
                quotient += div << bitPos;

                if ((div & ~(0xFFFFFFFF >> bitPos)) != 0)
                {
                    throw new OverflowException();
                }

                remainder <<= 1;
                bitPos--;
            }

            // Quotient is always positive so rounding is easy
            quotient++;

            var result = (int)(quotient >> 1);

            // Figure out the sign of the result
            if (((a ^ b) & 0x80000000) != 0)
            {
                if (result == MinValue._raw)
                {
                    throw new OverflowException();
                }
                result = -result;
            }

            return new fix(result);
        }

        public static fix operator %(fix x, fix y)
        {
            return new fix(x._raw % y._raw);
        }

        public static fix operator >>(fix x, int shift)
        {
            return new fix(x._raw >> shift);
        }

        public static fix operator <<(fix x, int shift)
        {
            return new fix(x._raw << shift);
        }

        public static fix operator -(fix x)
        {
            return new fix(-x._raw);
        }

        public static bool operator >(fix x, fix y)
        {
            return x._raw > y._raw;
        }

        public static bool operator <(fix x, fix y)
        {
            return x._raw < y._raw;
        }

        public static bool operator >=(fix x, fix y)
        {
            return x._raw >= y._raw;
        }

        public static bool operator <=(fix x, fix y)
        {
            return x._raw <= y._raw;
        }

        public static bool operator ==(fix x, fix y)
        {
            return x._raw == y._raw;
        }

        public static bool operator !=(fix x, fix y)
        {
            return !(x == y);
        }

        public static fix operator ++(fix x)
        {
            return x + One;
        }

        public static fix operator --(fix x)
        {
            return x - One;
        }

        public static fix Raw(int i)
        {
            return new fix(i);
        }
        public static fix Raw(uint i)
        {
            return new fix((int)i);
        }

        private fix(int rawValue)
        {
            _raw = rawValue;
        }

        public bool Equals(fix other)
        {
            return this == other;
        }

        public int CompareTo(fix other)
        {
            return _raw.CompareTo(other._raw);
        }

        public override bool Equals(object obj)
        {
            return obj is fix other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _raw;
        }

        public override string ToString()
        {
            // Using Decimal.ToString() instead of float or double because decimal is 
            // also implemented in software. This guarantees a consistent string representation.
            return ((decimal)this).ToString(CultureInfo.InvariantCulture);
        }

    }
}