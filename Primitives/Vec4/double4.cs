#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace DVG
{
    
    /// <summary>
    /// A vector of type double with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct double4 : IEquatable<double4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public double w;
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public const int Count = 4;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double x, double y, double z, double w)
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
        public double4(double v)
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
        public double4(double2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double2 v, double z, double w)
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
        public double4(double3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double3 v, double w)
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
        public double4(double4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public double this[int index]
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
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 xy
        {
            get
            {
                return new double2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 xz
        {
            get
            {
                return new double2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 yz
        {
            get
            {
                return new double2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 xyz
        {
            get
            {
                return new double3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 xw
        {
            get
            {
                return new double2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 yw
        {
            get
            {
                return new double2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 xyw
        {
            get
            {
                return new double3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 zw
        {
            get
            {
                return new double2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 xzw
        {
            get
            {
                return new double3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 yzw
        {
            get
            {
                return new double3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double4 xyzw
        {
            get
            {
                return new double4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 rg
        {
            get
            {
                return new double2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 rb
        {
            get
            {
                return new double2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 gb
        {
            get
            {
                return new double2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 rgb
        {
            get
            {
                return new double3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 ra
        {
            get
            {
                return new double2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 ga
        {
            get
            {
                return new double2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 rga
        {
            get
            {
                return new double3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double2 ba
        {
            get
            {
                return new double2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 rba
        {
            get
            {
                return new double3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double3 gba
        {
            get
            {
                return new double3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public double4 rgba
        {
            get
            {
                return new double4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public double r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public double g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public double b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public double a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(double4 lhs, double4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(double4 lhs, double4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => x + ", " + y + ", " + z + ", " + w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(double4 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is double4 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Length(double4 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Distance(double4 lhs, double4 rhs) => double4.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Dot(double4 lhs, double4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Normalize(double4 v) => v / double4.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 FaceForward(double4 N, double4 I, double4 Nref) => double4.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Reflect(double4 I, double4 N) => I - 2 * double4.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Refract(double4 I, double4 N, double eta)
        {
            var dNI = double4.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new double4((double)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Clamp(double4 v, double min, double max) => new double4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SqrLength(double4 v) => v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w;
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SqrDistance(double4 lhs, double4 rhs) => double4.SqrLength(lhs - rhs);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Sqrt(double4 v) => new double4(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z), Maths.Sqrt(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 InverseSqrt(double4 v) => new double4(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z), Maths.InverseSqrt(v.w));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 LesserThan(double4 lhs, double4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 LesserThanEqual(double4 lhs, double4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 GreaterThan(double4 lhs, double4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 GreaterThanEqual(double4 lhs, double4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Equal(double4 lhs, double4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 NotEqual(double4 lhs, double4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Abs(double4 v) => new double4(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z), Maths.Abs(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Sign(double4 v) => new double4(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z), Maths.Sign(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Floor(double4 v) => new double4(Maths.Floor(v.x), Maths.Floor(v.y), Maths.Floor(v.z), Maths.Floor(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Truncate(double4 v) => new double4(Maths.Truncate(v.x), Maths.Truncate(v.y), Maths.Truncate(v.z), Maths.Truncate(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Round(double4 v) => new double4(Maths.Round(v.x), Maths.Round(v.y), Maths.Round(v.z), Maths.Round(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 RoundEven(double4 v) => new double4(Maths.RoundEven(v.x), Maths.RoundEven(v.y), Maths.RoundEven(v.z), Maths.RoundEven(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ceiling(double4 v) => new double4(Maths.Ceiling(v.x), Maths.Ceiling(v.y), Maths.Ceiling(v.z), Maths.Ceiling(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Fract(double4 v) => new double4(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y), v.z - Maths.Floor(v.z), v.w - Maths.Floor(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Mod(double4 lhs, double4 rhs) => new double4(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y), lhs.z - rhs.z * Maths.Floor(lhs.z / rhs.z), lhs.w - rhs.w * Maths.Floor(lhs.w / rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Mod(double4 lhs, double rhs) => new double4(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs), lhs.z - rhs * Maths.Floor(lhs.z / rhs), lhs.w - rhs * Maths.Floor(lhs.w / rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Lerp(double4 edge0, double4 edge1, double4 v) => new double4(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z), Maths.Lerp(edge0.w, edge1.w, v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Lerp(double4 edge0, double4 edge1, double v) => new double4(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v), Maths.Lerp(edge0.w, edge1.w, v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Step(double4 edge, double4 x) => new double4(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1, x.z < edge.z ? 0 : 1, x.w < edge.w ? 0 : 1);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Step(double edge, double4 x) => new double4(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1, x.z < edge ? 0 : 1, x.w < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Smoothstep(double4 edge0, double4 edge1, double4 v) => new double4(Maths.SmoothStep(Maths.Clamp((v.x - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.y - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.z - edge0.z) / (edge1.z - edge0.z), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.w - edge0.w) / (edge1.w - edge0.w), 0, 1)));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Smoothstep(double4 edge0, double4 edge1, double v) => new double4(Maths.SmoothStep(Maths.Clamp((v - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.z) / (edge1.z - edge0.z), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.w) / (edge1.w - edge0.w), 0, 1)));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 IsNaN(double4 v) => new bool4(double.IsNaN(v.x), double.IsNaN(v.y), double.IsNaN(v.z), double.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 IsInfinity(double4 v) => new bool4(double.IsInfinity(v.x), double.IsInfinity(v.y), double.IsInfinity(v.z), double.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Fma(double4 a, double4 b, double4 c) => new double4(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y), Maths.Fma(a.z, b.z, c.z), Maths.Fma(a.w, b.w, c.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Min(double4 lhs, double4 rhs) => new double4(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z), Maths.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Min(double4 lhs, double rhs) => new double4(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs), Maths.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Max(double4 lhs, double4 rhs) => new double4(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z), Maths.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Max(double4 lhs, double rhs) => new double4(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs), Maths.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Clamp(double4 v, double4 min, double4 max) => new double4(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z), Maths.Clamp(v.w, min.w, max.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Mix(double4 x, double4 y, bool4 a) => new double4(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z, a.w ? y.w : x.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 InvLerp(double4 edge0, double4 edge1, double4 v) => new double4(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y), Maths.InvLerp(edge0.z, edge1.z, v.z), Maths.InvLerp(edge0.w, edge1.w, v.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 InvLerp(double4 edge0, double4 edge1, double v) => new double4(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v), Maths.InvLerp(edge0.z, edge1.z, v), Maths.InvLerp(edge0.w, edge1.w, v));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator-(double4 v) => new double4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator+(double4 lhs, double4 rhs) => new double4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator+(double4 lhs, double rhs) => new double4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator+(double lhs, double4 rhs) => new double4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator-(double4 lhs, double4 rhs) => new double4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator-(double4 lhs, double rhs) => new double4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator-(double lhs, double4 rhs) => new double4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator*(double4 lhs, double4 rhs) => new double4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator*(double4 lhs, double rhs) => new double4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator*(double lhs, double4 rhs) => new double4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator/(double4 lhs, double4 rhs) => new double4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator/(double4 lhs, double rhs) => new double4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator/(double lhs, double4 rhs) => new double4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        #endregion

    }
}
