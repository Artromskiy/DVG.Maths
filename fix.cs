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
    [Serializable]
    public partial struct fix : IEquatable<fix>, IComparable<fix>
    {
        [DataMember(Order = 0)]
        public int raw;

        public static readonly fix One = new(RawOne);
        public static readonly fix Zero = new(0);
        public static readonly fix MinValue = new(int.MinValue);
        public static readonly fix MaxValue = new(int.MaxValue);

        public static readonly fix Pi = new(205887);
        public static readonly fix E = new(178145);

        private const int RawOne = 0x00010000;

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
            return new fix(checked(a << 16));
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
        public static explicit operator int(fix a) => (a.raw + ((a.raw >> 31) & 0xFFFF)) >> 16;

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
        public static fix operator +(fix x, fix y) => new(checked(x.raw + y.raw));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator -(fix x, fix y) => new(checked(x.raw - y.raw));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator *(int x, fix y) => new(checked(x * y.raw));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator *(fix x, int y) => new(checked(x.raw * y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator *(fix x, fix y)
        {
            long product = (long)x.raw * y.raw;
            long upper = product >> 47;
            if (upper != 0 && upper != -1)
                throw new OverflowException();
            product += (product >> 63) | 0x8000L;
            return new fix((int)(product >> 16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator /(fix x, fix y)
        {
            if (0 == y.raw)
                throw new InvalidOperationException();

            long scaled = ((long)x.raw << 16);
            long result = scaled / y.raw;

            if (result > MaxValue.raw || result < MinValue.raw)
                throw new OverflowException();

            return new fix((int)result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator %(fix x, fix y) => new(x.raw % y.raw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator >>(fix x, int shift) => new(x.raw >> shift);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator <<(fix x, int shift) => new(x.raw << shift);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator -(fix x) => new(-x.raw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(fix x, fix y) => x.raw > y.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(fix x, fix y) => x.raw < y.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(fix x, fix y) => x.raw >= y.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(fix x, fix y) => x.raw <= y.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(fix x, fix y) => x.raw == y.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(fix x, fix y) => x.raw != y.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator ++(fix x) => new(x.raw + RawOne);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix operator --(fix x) => new(x.raw - RawOne);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(fix other) => this == other;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(fix other) => raw.CompareTo(other.raw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object obj) => obj is fix other && Equals(other);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => raw;

        public static fix Parse(string value) => (fix)decimal.Parse(value);
        public static fix Parse(string value, IFormatProvider formatProvider) => (fix)decimal.Parse(value, formatProvider);

        // Using Decimal.ToString() instead of float or double because decimal is 
        // also implemented in software. This guarantees a consistent string representation.
        public override readonly string ToString() => ((decimal)this).ToString(CultureInfo.InvariantCulture);

    }
}