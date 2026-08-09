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
    /// A vector of type int with 2 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct int2 : IEquatable<int2>, IComparable<int2>
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
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly int2 zero = new int2(0, 0);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a uint2.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(int2 v) => new uint2((uint)v.x, (uint)v.y);

        /// <summary>
        /// Implicitly converts this to a float2.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(int2 v) => new float2((float)v.x, (float)v.y);

        /// <summary>
        /// Implicitly converts this to a double2.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(int2 v) => new double2((double)v.x, (double)v.y);

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
        /// Returns the number of components (2).
        /// </summary>
        public int Count
        {
            get => 2;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(int2 lhs, int2 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(int2 lhs, int2 rhs) => lhs.x != rhs.x||lhs.y != rhs.y;

        #endregion


        #region Functions

        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(int2 other) => Comparison.Combine(x, y, other.x, other.y);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(int2 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is int2 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns a int2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 Clamp(int2 v, int min, int max) => new int2(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 Parse(string value)
        {
            var values = value.Split(", ");
            return new int2(int.Parse(values[0]), int.Parse(values[1]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new int2(int.Parse(values[0], format), int.Parse(values[1], format));
        }

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a int2 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -(int2 v) => new int2(-v.x, -v.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator +(int2 lhs, int2 rhs) => new int2(lhs.x + rhs.x, lhs.y + rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator +(int2 lhs, int rhs) => new int2(lhs.x + rhs, lhs.y + rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator +(int lhs, int2 rhs) => new int2(lhs + rhs.x, lhs + rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -(int2 lhs, int2 rhs) => new int2(lhs.x - rhs.x, lhs.y - rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -(int2 lhs, int rhs) => new int2(lhs.x - rhs, lhs.y - rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -(int lhs, int2 rhs) => new int2(lhs - rhs.x, lhs - rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int2 lhs, int2 rhs) => new int2(lhs.x * rhs.x, lhs.y * rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int2 lhs, int rhs) => new int2(lhs.x * rhs, lhs.y * rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int lhs, int2 rhs) => new int2(lhs * rhs.x, lhs * rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int2 lhs, int2 rhs) => new int2(lhs.x / rhs.x, lhs.y / rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int2 lhs, int rhs) => new int2(lhs.x / rhs, lhs.y / rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int lhs, int2 rhs) => new int2(lhs / rhs.x, lhs / rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator %(int2 lhs, int2 rhs) => new int2(lhs.x % rhs.x, lhs.y % rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator %(int2 lhs, int rhs) => new int2(lhs.x % rhs, lhs.y % rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator %(int lhs, int2 rhs) => new int2(lhs % rhs.x, lhs % rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^(int2 lhs, int2 rhs) => new int2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^(int2 lhs, int rhs) => new int2(lhs.x ^ rhs, lhs.y ^ rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^(int lhs, int2 rhs) => new int2(lhs ^ rhs.x, lhs ^ rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator |(int2 lhs, int2 rhs) => new int2(lhs.x | rhs.x, lhs.y | rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator |(int2 lhs, int rhs) => new int2(lhs.x | rhs, lhs.y | rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator |(int lhs, int2 rhs) => new int2(lhs | rhs.x, lhs | rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator &(int2 lhs, int2 rhs) => new int2(lhs.x & rhs.x, lhs.y & rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator &(int2 lhs, int rhs) => new int2(lhs.x & rhs, lhs.y & rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator &(int lhs, int2 rhs) => new int2(lhs & rhs.x, lhs & rhs.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator~ (~v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ~(int2 v) => new int2(~v.x, ~v.y);

        /// <summary>
        /// Returns a int2 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator <<(int2 lhs, int rhs) => new int2(lhs.x << rhs, lhs.y << rhs);

        /// <summary>
        /// Returns a int2 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator >>(int2 lhs, int rhs) => new int2(lhs.x >> rhs, lhs.y >> rhs);

        #endregion

    }
}
