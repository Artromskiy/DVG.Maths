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
    /// A vector of type uint with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct uint3 : IEquatable<uint3>, IComparable<uint3>
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
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly uint3 zero = new uint3(0u, 0u, 0u);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0u;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a float3.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(uint3 v) => new float3((float)v.x, (float)v.y, (float)v.z);

        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(uint3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

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
        /// Returns the number of components (3).
        /// </summary>
        public int Count
        {
            get => 3;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(uint3 lhs, uint3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(uint3 lhs, uint3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

        #endregion


        #region Functions

        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(uint3 other) => Comparison.Combine(x, y, z, other.x, other.y, other.z);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(uint3 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is uint3 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Clamp(uint3 v, uint min, uint max) => new uint3(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Parse(string value)
        {
            var values = value.Split(", ");
            return new uint3(uint.Parse(values[0]), uint.Parse(values[1]), uint.Parse(values[2]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new uint3(uint.Parse(values[0], format), uint.Parse(values[1], format), uint.Parse(values[2], format));
        }

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator +(uint3 lhs, uint3 rhs) => new uint3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator +(uint3 lhs, uint rhs) => new uint3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator +(uint lhs, uint3 rhs) => new uint3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator -(uint3 lhs, uint3 rhs) => new uint3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator -(uint3 lhs, uint rhs) => new uint3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator -(uint lhs, uint3 rhs) => new uint3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator *(uint3 lhs, uint3 rhs) => new uint3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator *(uint3 lhs, uint rhs) => new uint3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator *(uint lhs, uint3 rhs) => new uint3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator /(uint3 lhs, uint3 rhs) => new uint3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator /(uint3 lhs, uint rhs) => new uint3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator /(uint lhs, uint3 rhs) => new uint3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator %(uint3 lhs, uint3 rhs) => new uint3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator %(uint3 lhs, uint rhs) => new uint3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator %(uint lhs, uint3 rhs) => new uint3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator ^(uint3 lhs, uint3 rhs) => new uint3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator ^(uint3 lhs, uint rhs) => new uint3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator ^(uint lhs, uint3 rhs) => new uint3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator |(uint3 lhs, uint3 rhs) => new uint3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator |(uint3 lhs, uint rhs) => new uint3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator |(uint lhs, uint3 rhs) => new uint3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator &(uint3 lhs, uint3 rhs) => new uint3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator &(uint3 lhs, uint rhs) => new uint3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator &(uint lhs, uint3 rhs) => new uint3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator~ (~v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator ~(uint3 v) => new uint3(~v.x, ~v.y, ~v.z);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator <<(uint3 lhs, int rhs) => new uint3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);

        /// <summary>
        /// Returns a uint3 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator >>(uint3 lhs, int rhs) => new uint3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);

        #endregion

    }
}
