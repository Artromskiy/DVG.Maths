#pragma warning disable IDE1006
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace DVG
{
    [DebuggerDisplay("Value = {ToString()}")]
    [DataContract]
    public readonly struct fix : IEquatable<fix>, IComparable<fix>
    {
        [DataMember(Order = 0)]
        public readonly int raw;

        public static readonly fix One = new fix(0x00010000);
        public static readonly fix Zero = new fix(0);
        public static readonly fix MinValue = new fix(int.MinValue);
        public static readonly fix MaxValue = new fix(int.MaxValue);

        public static readonly fix Pi = new fix(205887);
        public static readonly fix E = new fix(178145);

        /// <summary>
        /// Creates fixed point number from raw integer representation
        /// </summary>
        /// <param name="rawValue"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix(int rawValue)
        {
            raw = rawValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator fix(int a)
        {
            if(a < MinValue.raw || a > MaxValue.raw)
                throw new OverflowException();
            return new fix(a << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(fix a)
        {
            return (float)a.raw / One.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(fix a)
        {
            return (double)a.raw / One.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(fix a)
        {
            return (decimal)a.raw / One.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(fix a)
        {
            return a.raw >> 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fix(float a)
        {
            var temp = a * One.raw;
            temp += (temp >= 0) ? 0.5f : -0.5f;
            return new fix((int)temp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fix(double a)
        {
            var temp = a * One.raw;
            temp += (temp >= 0) ? 0.5 : -0.5;
            return new fix((int)temp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fix(decimal a)
        {
            var temp = a * One.raw;
            temp += (temp >= 0) ? 0.5m : -0.5m;
            return new fix((int)temp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator +(fix x, fix y)
        {
            int a = x.raw;
            int b = y.raw;

            var sum = checked (a + b);

            return new fix(sum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator -(fix x, fix y)
        {
            int a = x.raw;
            int b = y.raw;

            var diff = checked(a - b);

            return new fix(diff);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator *(fix x, fix y)
        {
            long product = (long)x.raw * y.raw;
            long upper = product >> 47;
            if (upper != 0 && upper != -1)
                throw new OverflowException();
            product += 0x8000L * Maths.Sign(product);
            return new fix((int)(product >> 16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator /(fix x, fix y)
        {
            var a = x.raw;
            var b = y.raw;

            if (b == 0)
                throw new InvalidOperationException();

            long scaled = ((long)a << 16);
            long result = scaled / b;

            if (result > MaxValue.raw || result < MinValue.raw)
                throw new OverflowException();

            return new fix((int)result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator %(fix x, fix y)
        {
            return new fix(x.raw % y.raw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator >>(fix x, int shift)
        {
            return new fix(x.raw >> shift);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator <<(fix x, int shift)
        {
            return new fix(x.raw << shift);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator -(fix x)
        {
            return new fix(-x.raw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(fix x, fix y)
        {
            return x.raw > y.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(fix x, fix y)
        {
            return x.raw < y.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(fix x, fix y)
        {
            return x.raw >= y.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(fix x, fix y)
        {
            return x.raw <= y.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(fix x, fix y)
        {
            return x.raw == y.raw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(fix x, fix y)
        {
            return !(x == y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator ++(fix x)
        {
            return x + One;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator --(fix x)
        {
            return x - One;
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(fix other)
        {
            return this == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(fix other)
        {
            return raw.CompareTo(other.raw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is fix other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return raw;
        }

        public override string ToString()
        {
            // Using Decimal.ToString() instead of float or double because decimal is 
            // also implemented in software. This guarantees a consistent string representation.
            return ((decimal)this).ToString(CultureInfo.InvariantCulture);
        }

    }
}