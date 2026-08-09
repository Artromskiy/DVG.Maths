#pragma warning disable IDE1006
#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace KibiHex
{

    /// <summary>
    /// A vector of type uint with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct uint4 : IEquatable<uint4>, IComparable<uint4>
    {

        #region Fields

        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public uint x;

        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public uint y;

        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public uint z;

        /// <summary>
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public uint w;

        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly uint4 zero = new uint4(0u, 0u, 0u, 0u);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0u;
            this.w = 0u;
        }

        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0u;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint2 v, uint z, uint w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0u;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint3 v, uint w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a float4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(uint4 v) => new float4((float)v.x, (float)v.y, (float)v.z, (float)v.w);

        /// <summary>
        /// Implicitly converts this to a double4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(uint4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);

        #endregion


        #region Indexer

        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public uint this[int index]
        {
            get
            {
                if ((uint)index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return Unsafe.Add(ref x, index);
            }
            set
            {
                if ((uint)index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                Unsafe.Add(ref x, index) = value;
            }
        }

        #endregion


        #region Properties

        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count
        {
            get => 4;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(uint4 lhs, uint4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(uint4 lhs, uint4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

        #endregion


        #region Functions

        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(uint4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(uint4 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is uint4 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns a uint4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Clamp(uint4 v, uint min, uint max) => new uint4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Parse(string value)
        {
            var values = value.Split(", ");
            return new uint4(uint.Parse(values[0]), uint.Parse(values[1]), uint.Parse(values[2]), uint.Parse(values[3]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new uint4(uint.Parse(values[0], format), uint.Parse(values[1], format), uint.Parse(values[2], format), uint.Parse(values[3], format));
        }

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a uint4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator +(uint4 lhs, uint4 rhs) => new uint4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator +(uint4 lhs, uint rhs) => new uint4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator +(uint lhs, uint4 rhs) => new uint4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator -(uint4 lhs, uint4 rhs) => new uint4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator -(uint4 lhs, uint rhs) => new uint4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator -(uint lhs, uint4 rhs) => new uint4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator *(uint4 lhs, uint4 rhs) => new uint4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator *(uint4 lhs, uint rhs) => new uint4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator *(uint lhs, uint4 rhs) => new uint4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator /(uint4 lhs, uint4 rhs) => new uint4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator /(uint4 lhs, uint rhs) => new uint4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator /(uint lhs, uint4 rhs) => new uint4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator %(uint4 lhs, uint4 rhs) => new uint4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator %(uint4 lhs, uint rhs) => new uint4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator %(uint lhs, uint4 rhs) => new uint4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator ^(uint4 lhs, uint4 rhs) => new uint4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator ^(uint4 lhs, uint rhs) => new uint4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator ^(uint lhs, uint4 rhs) => new uint4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator |(uint4 lhs, uint4 rhs) => new uint4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator |(uint4 lhs, uint rhs) => new uint4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator |(uint lhs, uint4 rhs) => new uint4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator &(uint4 lhs, uint4 rhs) => new uint4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator &(uint4 lhs, uint rhs) => new uint4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator &(uint lhs, uint4 rhs) => new uint4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator~ (~v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator ~(uint4 v) => new uint4(~v.x, ~v.y, ~v.z, ~v.w);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator <<(uint4 lhs, int rhs) => new uint4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);

        /// <summary>
        /// Returns a uint4 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator >>(uint4 lhs, int rhs) => new uint4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);

        #endregion

    }
}
