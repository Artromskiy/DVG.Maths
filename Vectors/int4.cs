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
    /// A vector of type int with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct int4 : IEquatable<int4>, IComparable<int4>
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
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public int w;

        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly int4 zero = new int4(0, 0, 0, 0);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int x, int y, int z, int w)
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
        public int4(int v)
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
        public int4(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0;
            this.w = 0;
        }

        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int2 v, int z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int2 v, int z, int w)
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
        public int4(int3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int3 v, int w)
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
        public int4(int4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a uint4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(int4 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);

        /// <summary>
        /// Implicitly converts this to a float4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(int4 v) => new float4((float)v.x, (float)v.y, (float)v.z, (float)v.w);

        /// <summary>
        /// Implicitly converts this to a double4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(int4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);

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
        /// Returns the number of components (4).
        /// </summary>
        public int Count
        {
            get => 4;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(int4 lhs, int4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(int4 lhs, int4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

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
        public readonly int CompareTo(int4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(int4 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is int4 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns a int4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Clamp(int4 v, int min, int max) => new int4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Parse(string value)
        {
            var values = value.Split(", ");
            return new int4(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new int4(int.Parse(values[0], format), int.Parse(values[1], format), int.Parse(values[2], format), int.Parse(values[3], format));
        }

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a int4 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator -(int4 v) => new int4(-v.x, -v.y, -v.z, -v.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator +(int4 lhs, int4 rhs) => new int4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator +(int4 lhs, int rhs) => new int4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator +(int lhs, int4 rhs) => new int4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator -(int4 lhs, int4 rhs) => new int4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator -(int4 lhs, int rhs) => new int4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator -(int lhs, int4 rhs) => new int4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator *(int4 lhs, int4 rhs) => new int4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator *(int4 lhs, int rhs) => new int4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator *(int lhs, int4 rhs) => new int4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator /(int4 lhs, int4 rhs) => new int4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator /(int4 lhs, int rhs) => new int4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator /(int lhs, int4 rhs) => new int4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator %(int4 lhs, int4 rhs) => new int4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator %(int4 lhs, int rhs) => new int4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator %(int lhs, int4 rhs) => new int4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator ^(int4 lhs, int4 rhs) => new int4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator ^(int4 lhs, int rhs) => new int4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator ^(int lhs, int4 rhs) => new int4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator |(int4 lhs, int4 rhs) => new int4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator |(int4 lhs, int rhs) => new int4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator |(int lhs, int4 rhs) => new int4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator &(int4 lhs, int4 rhs) => new int4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator &(int4 lhs, int rhs) => new int4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator &(int lhs, int4 rhs) => new int4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator~ (~v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator ~(int4 v) => new int4(~v.x, ~v.y, ~v.z, ~v.w);

        /// <summary>
        /// Returns a int4 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator <<(int4 lhs, int rhs) => new int4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);

        /// <summary>
        /// Returns a int4 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator >>(int4 lhs, int rhs) => new int4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);

        #endregion

    }
}
