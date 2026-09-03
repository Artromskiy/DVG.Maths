using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Delta
{
    public static partial class DeltaMaths
    {
        private const int FloatExponentBias = 127;
        private const uint FloatMantissaMask = 0x007fffffu;

        [StructLayout(LayoutKind.Explicit)]
        private struct FloatBits
        {
            [FieldOffset(0)]
            public float Single;

            [FieldOffset(0)]
            public int Integer;
        }

        /// <summary>Returns the fractional part and stores the truncated part.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Modf(float value, out float integerPart)
        {
            if (float.IsNaN(value))
            {
                integerPart = value;
                return value;
            }

            if (float.IsInfinity(value))
            {
                integerPart = value;
                return IntBitsToFloat(FloatBitsToInt(value) & int.MinValue);
            }

            if (value == 0f)
            {
                integerPart = value;
                return value;
            }

            integerPart = Truncate(value);
            return value - integerPart;
        }

        /// <summary>Splits a finite value into a signed mantissa in [0.5, 1) and a power-of-two exponent.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Frexp(float value, out int exponent)
        {
            var bits = FloatBitsToInt(value);
            var absoluteBits = unchecked((uint)bits) & 0x7fffffffu;
            var exponentBits = (int)(absoluteBits >> 23);
            if (absoluteBits == 0 || exponentBits == 0xff)
            {
                exponent = 0;
                return value;
            }

            if (exponentBits == 0)
            {
                var normalized = value * 16777216f;
                var normalizedBits = unchecked((uint)FloatBitsToInt(normalized));
                var normalizedExponent = (int)(normalizedBits >> 23) - FloatExponentBias + 1;
                exponent = normalizedExponent - 24;
                return normalized / PowerOfTwo(normalizedExponent);
            }

            exponent = exponentBits - FloatExponentBias + 1;
            return IntBitsToFloat((bits & int.MinValue) | (126 << 23) | (int)(absoluteBits & FloatMantissaMask));
        }

        /// <summary>Scales a value by an integral power of two.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ldexp(float value, int exponent) => value * MathF.Pow(2f, exponent);

        /// <summary>Returns the IEEE-754 bits of a single-precision value as a signed integer.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FloatBitsToInt(float value) => new FloatBits { Single = value }.Integer;

        /// <summary>Returns the IEEE-754 bits of a single-precision value as an unsigned integer.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint FloatBitsToUint(float value) => unchecked((uint)FloatBitsToInt(value));

        /// <summary>Reinterprets a signed integer as IEEE-754 single-precision bits.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float IntBitsToFloat(int value) => new FloatBits { Integer = value }.Single;

        /// <summary>Reinterprets an unsigned integer as IEEE-754 single-precision bits.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float UintBitsToFloat(uint value) => IntBitsToFloat(unchecked((int)value));

        /// <summary>Combines the low and high 32-bit words into an IEEE-754 double.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double PackDouble2x32(uint2 value)
        {
            var bits = ((ulong)value.y << 32) | value.x;
            return BitConverter.Int64BitsToDouble(unchecked((long)bits));
        }

        /// <summary>Splits an IEEE-754 double into its low and high 32-bit words.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 UnpackDouble2x32(double value)
        {
            var bits = unchecked((ulong)BitConverter.DoubleToInt64Bits(value));
            return new((uint)bits, (uint)(bits >> 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float PowerOfTwo(int exponent) =>
            IntBitsToFloat((exponent + 127) << 23);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint PackHalf(float value) => new half(value).raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static float UnpackHalf(uint value) => new half((ushort)value).ToSingle();
    }
}
