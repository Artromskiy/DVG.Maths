using System.Runtime.CompilerServices;

namespace Delta
{
    public static partial class DeltaMaths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UaddCarry(uint x, uint y, out uint carry)
        {
            var sum = (ulong)x + y;
            carry = (uint)(sum >> 32);
            return (uint)sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UsubBorrow(uint x, uint y, out uint borrow)
        {
            borrow = x < y ? 1u : 0u;
            return x - y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UmulExtended(uint x, uint y, out uint msb, out uint lsb)
        {
            var product = (ulong)x * y;
            msb = (uint)(product >> 32);
            lsb = (uint)product;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImulExtended(int x, int y, out int msb, out int lsb)
        {
            var product = (long)x * y;
            msb = unchecked((int)(product >> 32));
            lsb = unchecked((int)product);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitCount(int value) => BitCount(unchecked((uint)value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitCount(uint value)
        {
            value -= (value >> 1) & 0x55555555u;
            value = (value & 0x33333333u) + ((value >> 2) & 0x33333333u);
            return (int)(((value + (value >> 4)) & 0x0f0f0f0fu) * 0x01010101u >> 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FindLSB(int value) => FindLSB(unchecked((uint)value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FindLSB(uint value)
        {
            if (value == 0)
            {
                return -1;
            }

            var index = 0;
            while ((value & 1u) == 0)
            {
                value >>= 1;
                index++;
            }

            return index;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FindMSB(int value)
        {
            if (value == 0 || value == -1)
            {
                return -1;
            }

            return value < 0
                ? FindMSB(~unchecked((uint)value))
                : FindMSB(unchecked((uint)value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FindMSB(uint value)
        {
            for (var index = 31; index >= 0; index--)
            {
                if ((value & (1u << index)) != 0)
                {
                    return index;
                }
            }

            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitfieldReverse(int value) => unchecked((int)BitfieldReverse(unchecked((uint)value)));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint BitfieldReverse(uint value)
        {
            value = ((value >> 1) & 0x55555555u) | ((value & 0x55555555u) << 1);
            value = ((value >> 2) & 0x33333333u) | ((value & 0x33333333u) << 2);
            value = ((value >> 4) & 0x0f0f0f0fu) | ((value & 0x0f0f0f0fu) << 4);
            value = ((value >> 8) & 0x00ff00ffu) | ((value & 0x00ff00ffu) << 8);
            return (value >> 16) | (value << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitfieldExtract(int value, int offset, int bits)
        {
            var unsigned = BitfieldExtract(unchecked((uint)value), offset, bits);
            if (bits <= 0 || offset < 0 || offset >= 32)
            {
                return 0;
            }

            var width = bits > 32 - offset ? 32 - offset : bits;
            var signBit = 1u << (width - 1);
            if (width < 32 && (unsigned & signBit) != 0)
            {
                unsigned |= uint.MaxValue << width;
            }

            return unchecked((int)unsigned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint BitfieldExtract(uint value, int offset, int bits)
        {
            if (bits <= 0 || offset < 0 || offset >= 32)
            {
                return 0;
            }

            var width = bits > 32 - offset ? 32 - offset : bits;
            return (value >> offset) & BitMask(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitfieldInsert(int baseValue, int insert, int offset, int bits) =>
            unchecked((int)BitfieldInsert(unchecked((uint)baseValue), unchecked((uint)insert), offset, bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint BitfieldInsert(uint baseValue, uint insert, int offset, int bits)
        {
            if (bits <= 0 || offset < 0 || offset >= 32)
            {
                return baseValue;
            }

            var width = bits > 32 - offset ? 32 - offset : bits;
            var mask = BitMask(width) << offset;
            return (baseValue & ~mask) | ((insert << offset) & mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint BitMask(int bits) => bits == 32 ? uint.MaxValue : (1u << bits) - 1u;
    }
}
