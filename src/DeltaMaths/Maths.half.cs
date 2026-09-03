#pragma warning disable IDE1006
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Delta
{
    /// <summary>
    /// A binary16 value with the same IEEE-754 representation as <see cref="System.Half"/>.
    /// </summary>
    /// <remarks>
    /// The public <see cref="raw"/> field is an intentional ABI and serialization escape hatch.
    /// It contains the binary16 bits, not a numeric integer value. On modern target frameworks
    /// conversions use <see cref="System.Half"/>; netstandard targets use the same deterministic
    /// IEEE-754 conversion in this type because System.Half is not part of those reference packs.
    /// </remarks>
    [DataContract]
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct half : IEquatable<half>, IComparable<half>
    {
        /// <summary>The IEEE-754 binary16 representation.</summary>
        [DataMember(Order = 0)]
        public readonly ushort raw;

        /// <summary>Creates a half value from its IEEE-754 binary16 bits.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public half(ushort rawBits)
        {
            raw = rawBits;
        }

        /// <summary>Converts a single-precision value using round-to-nearest-even.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public half(float value)
        {
            raw = SingleToBits(value);
        }

        /// <summary>Converts a double-precision value using round-to-nearest-even.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public half(double value)
            : this((float)value)
        {
        }

        public static readonly half Zero = new(0x0000);
        public static readonly half One = new(0x3c00);
        public static readonly half MinValue = new(0xfbff);
        public static readonly half MaxValue = new(0x7bff);
        public static readonly half Epsilon = new(0x0001);
        public static readonly half NaN = new(0x7e00);
        public static readonly half PositiveInfinity = new(0x7c00);
        public static readonly half NegativeInfinity = new(0xfc00);

        /// <summary>Converts this value to single precision.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float ToSingle() => BitsToSingle(raw);

        public bool IsNaN => (raw & 0x7c00) == 0x7c00 && (raw & 0x03ff) != 0;
        public bool IsInfinity => (raw & 0x7fff) == 0x7c00;
        public bool IsFinite => (raw & 0x7c00) != 0x7c00;
        public bool IsNegative => (raw & 0x8000) != 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(float value) => new(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(double value) => new(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half(int value) => new(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(half value) => value.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(half value) => value.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(half value) => (int)value.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator +(half left, half right) => new(left.ToSingle() + right.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator -(half left, half right) => new(left.ToSingle() - right.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator *(half left, half right) => new(left.ToSingle() * right.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator /(half left, half right) => new(left.ToSingle() / right.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator %(half left, half right) => new(left.ToSingle() % right.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator -(half value) => new(-value.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator +(half value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator ++(half value) => new(value.ToSingle() + 1f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half operator --(half value) => new(value.ToSingle() - 1f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(half left, half right) => left.ToSingle() < right.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(half left, half right) => left.ToSingle() > right.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(half left, half right) => left.ToSingle() <= right.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(half left, half right) => left.ToSingle() >= right.ToSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(half left, half right) => left.raw == right.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(half left, half right) => left.raw != right.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(half other) => raw == other.raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(half other) => ToSingle().CompareTo(other.ToSingle());

        public override bool Equals(object? obj) => obj is half other && Equals(other);

        public override int GetHashCode() => raw;

        public override string ToString() => ToSingle().ToString(CultureInfo.InvariantCulture);

        private static ushort SingleToBits(float value)
        {
#if NET8_0_OR_GREATER
            return BitConverter.HalfToUInt16Bits((System.Half)value);
#else
            var bits = FloatToBits(value);
            var sign = (bits >> 16) & 0x8000u;
            var absoluteBits = bits & 0x7fffffffu;
            if (absoluteBits >= 0x7f800000u)
            {
                return (ushort)(sign | (absoluteBits == 0x7f800000u ? 0x7c00u : 0x7e00u));
            }

            var exponent = (int)(absoluteBits >> 23) - 127;
            var halfExponent = exponent + 15;
            var mantissa = (absoluteBits & 0x007fffffu) | 0x00800000u;
            if (halfExponent <= 0)
            {
                if (halfExponent < -10)
                {
                    return (ushort)sign;
                }

                var subnormal = RoundShift(mantissa, 14 - halfExponent);
                return (ushort)(sign | (subnormal >= 0x400u ? 0x400u : subnormal));
            }

            var roundedMantissa = RoundShift(mantissa, 13);
            if (roundedMantissa >= 0x800u)
            {
                roundedMantissa = 0;
                halfExponent++;
            }
            else
            {
                roundedMantissa -= 0x400u;
            }

            return (ushort)(halfExponent >= 31
                ? sign | 0x7c00u
                : sign | ((uint)halfExponent << 10) | roundedMantissa);
#endif
        }

        private static float BitsToSingle(ushort bits)
        {
#if NET8_0_OR_GREATER
            return (float)BitConverter.UInt16BitsToHalf(bits);
#else
            var sign = ((uint)bits & 0x8000u) << 16;
            var exponent = ((uint)bits >> 10) & 0x1fu;
            var mantissa = (uint)bits & 0x3ffu;
            if (exponent == 0)
            {
                if (mantissa == 0)
                {
                    return BitsToFloat(sign);
                }

                var unbiasedExponent = -14;
                while ((mantissa & 0x400u) == 0)
                {
                    mantissa <<= 1;
                    unbiasedExponent--;
                }

                mantissa &= 0x3ffu;
                return BitsToFloat(sign
                    | (uint)(unbiasedExponent + 127) << 23
                    | mantissa << 13);
            }

            if (exponent == 0x1f)
            {
                return BitsToFloat(sign | 0x7f800000u | (mantissa << 13));
            }

            return BitsToFloat(sign
                | (exponent + 127u - 15u) << 23
                | mantissa << 13);
#endif
        }

#if !NET8_0_OR_GREATER
        [StructLayout(LayoutKind.Explicit)]
        private struct FloatBits
        {
            [FieldOffset(0)]
            public float Single;

            [FieldOffset(0)]
            public uint Bits;
        }

        private static uint FloatToBits(float value) => new FloatBits { Single = value }.Bits;

        private static float BitsToFloat(uint bits) => new FloatBits { Bits = bits }.Single;

        private static uint RoundShift(uint value, int shift)
        {
            var truncated = value >> shift;
            var remainderMask = (1u << shift) - 1u;
            var remainder = value & remainderMask;
            var halfway = 1u << (shift - 1);
            if (remainder > halfway || remainder == halfway && (truncated & 1u) != 0)
            {
                truncated++;
            }

            return truncated;
        }
#endif

        public static half Parse(string value) => new(float.Parse(value, CultureInfo.InvariantCulture));

        public static half Parse(string value, IFormatProvider formatProvider) => new(float.Parse(value, formatProvider));
    }

    public static partial class DeltaMaths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Abs(half value) => new(MathF.Abs(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Acos(half value) => new(MathF.Acos(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Acosh(half value) => new(MathF.Acosh(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Asin(half value) => new(MathF.Asin(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Asinh(half value) => new(MathF.Asinh(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Atan(half value) => new(MathF.Atan(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Atan2(half y, half x) => new(MathF.Atan2(y.ToSingle(), x.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Atanh(half value) => new(MathF.Atanh(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Ceil(half value) => new(MathF.Ceiling(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Clamp(half value, half min, half max) => Min(Max(value, min), max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Cos(half value) => new(MathF.Cos(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Cosh(half value) => new(MathF.Cosh(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Cbrt(half value) => new(MathF.Cbrt(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Degrees(half value) => new(Degrees(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Exp(half value) => new(MathF.Exp(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Exp2(half value) => new(Exp2(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Fma(half a, half b, half c) => new(a.ToSingle() * b.ToSingle() + c.ToSingle());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Floor(half value) => new(MathF.Floor(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Fract(half value) => new(Fract(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half InverseSqrt(half value) => new(InverseSqrt(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Ldexp(half value, int exponent) => new(Ldexp(value.ToSingle(), exponent));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Lerp(half edge0, half edge1, half value) => new(Lerp(edge0.ToSingle(), edge1.ToSingle(), value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half InvLerp(half edge0, half edge1, half value) => new((value.ToSingle() - edge0.ToSingle()) / (edge1.ToSingle() - edge0.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Remap(half source, half sourceFrom, half sourceTo, half targetFrom, half targetTo) =>
            new(targetFrom.ToSingle() + ((source.ToSingle() - sourceFrom.ToSingle()) *
                (targetTo.ToSingle() - targetFrom.ToSingle()) / (sourceTo.ToSingle() - sourceFrom.ToSingle())));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Log(half value) => new(MathF.Log(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Log(half value, half newBase) => new(MathF.Log(value.ToSingle(), newBase.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Log2(half value) => new(Log2(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Log10(half value) => new(MathF.Log10(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Max(half left, half right) => new(Max(left.ToSingle(), right.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Min(half left, half right) => new(Min(left.ToSingle(), right.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Mod(half x, half y) => new(Mod(x.ToSingle(), y.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Modf(half value, out half integerPart)
        {
            var fractional = Modf(value.ToSingle(), out var integer);
            integerPart = new half(integer);
            return new half(fractional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Frexp(half value, out int exponent) => new(Frexp(value.ToSingle(), out exponent));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Pow(half x, half y) => new(Pow(x.ToSingle(), y.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Radians(half value) => new(Radians(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Round(half value) => new(MathF.Round(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half RoundEven(half value) => new(MathF.Round(value.ToSingle(), MidpointRounding.ToEven));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Sin(half value) => new(MathF.Sin(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Sinh(half value) => new(MathF.Sinh(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Sqrt(half value) => new(MathF.Sqrt(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Step(half edge, half value) => value < edge ? half.Zero : half.One;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Saturate(half value) => Clamp(value, half.Zero, half.One);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Smoothstep(half edge0, half edge1, half value) => new(Smoothstep(edge0.ToSingle(), edge1.ToSingle(), value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half SmoothDamp(half current, half target, ref half velocity, half smoothTime, half deltaTime)
        {
            var velocityValue = velocity.ToSingle();
            var result = SmoothDamp(
                current.ToSingle(),
                target.ToSingle(),
                ref velocityValue,
                smoothTime.ToSingle(),
                deltaTime.ToSingle());
            velocity = new half(velocityValue);
            return new half(result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Tan(half value) => new(MathF.Tan(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Tanh(half value) => new(MathF.Tanh(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Truncate(half value) => new(MathF.Truncate(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half Sign(half value) => new(MathF.Sign(value.ToSingle()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(half value) => value.IsNaN;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(half value) => value.IsInfinity;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(half value) => value.IsFinite;

    }
}
