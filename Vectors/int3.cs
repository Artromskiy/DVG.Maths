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
    /// A vector of type int with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct int3 : IEquatable<int3>, IComparable<int3>
    {

        #region Fields

        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public int x;

        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public int y;

        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public int z;

        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly int3 zero = new int3(0, 0, 0);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int2 v, int z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a uint3.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3(int3 v) => new uint3((uint)v.x, (uint)v.y, (uint)v.z);

        /// <summary>
        /// Implicitly converts this to a float3.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(int3 v) => new float3((float)v.x, (float)v.y, (float)v.z);

        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(int3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

        #endregion


        #region Indexer

        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public int this[int index]
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
        public static bool operator==(int3 lhs, int3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(int3 lhs, int3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

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
        public readonly int CompareTo(int3 other) => Comparison.Combine(x, y, z, other.x, other.y, other.z);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(int3 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is int3 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Clamp(int3 v, int min, int max) => new int3(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Parse(string value)
        {
            var values = value.Split(", ");
            return new int3(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new int3(int.Parse(values[0], format), int.Parse(values[1], format), int.Parse(values[2], format));
        }

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a int3 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator -(int3 v) => new int3(-v.x, -v.y, -v.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator +(int3 lhs, int3 rhs) => new int3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator +(int3 lhs, int rhs) => new int3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator +(int lhs, int3 rhs) => new int3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator -(int3 lhs, int3 rhs) => new int3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator -(int3 lhs, int rhs) => new int3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator -(int lhs, int3 rhs) => new int3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator *(int3 lhs, int3 rhs) => new int3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator *(int3 lhs, int rhs) => new int3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator *(int lhs, int3 rhs) => new int3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator /(int3 lhs, int3 rhs) => new int3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator /(int3 lhs, int rhs) => new int3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator /(int lhs, int3 rhs) => new int3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator %(int3 lhs, int3 rhs) => new int3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator %(int3 lhs, int rhs) => new int3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator %(int lhs, int3 rhs) => new int3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^(int3 lhs, int3 rhs) => new int3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^(int3 lhs, int rhs) => new int3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^(int lhs, int3 rhs) => new int3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator |(int3 lhs, int3 rhs) => new int3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator |(int3 lhs, int rhs) => new int3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator |(int lhs, int3 rhs) => new int3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator &(int3 lhs, int3 rhs) => new int3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator &(int3 lhs, int rhs) => new int3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator &(int lhs, int3 rhs) => new int3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator~ (~v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ~(int3 v) => new int3(~v.x, ~v.y, ~v.z);

        /// <summary>
        /// Returns a int3 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator <<(int3 lhs, int rhs) => new int3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);

        /// <summary>
        /// Returns a int3 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator >>(int3 lhs, int rhs) => new int3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);

        #endregion

    }
}
