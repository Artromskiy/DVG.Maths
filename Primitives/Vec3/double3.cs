#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace DVG
{
    
    /// <summary>
    /// A vector of type double with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct double3 : IEquatable<double3>
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
        /// Returns the number of components (3).
        /// </summary>
        public const int Count = 3;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public double3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public double3(double v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public double3(double2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public double3(double2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public double3(double3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public double3(double4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
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

        #endregion


        #region Operators
        
        public static bool operator==(double3 lhs, double3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;
        
        public static bool operator!=(double3 lhs, double3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public override readonly string ToString() => x + ", " + y + ", " + z;
        
        public readonly bool Equals(double3 other) => other == this;
        
        public override readonly bool Equals(object? obj) => obj is double3 other && Equals(other);
        
        public readonly double SqrLength() => x * x + y * y + z * z;

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(double3 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(double3 lhs, double3 rhs) => double3.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(double3 lhs, double3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static double3 Cross(double3 lhs, double3 rhs) => new double3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static double3 Normalize(double3 v) => v / double3.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static double3 FaceForward(double3 N, double3 I, double3 Nref) => double3.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double3 Reflect(double3 I, double3 N) => I - 2 * double3.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double3 Refract(double3 I, double3 N, double eta)
        {
            var dNI = double3.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new double3((double)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a double3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static double3 Clamp(double3 v, double min, double max) => new double3(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a double3 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        public static double3 Sqrt(double3 v) => new double3(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        public static double3 InverseSqrt(double3 v) => new double3(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(double3 lhs, double3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(double3 lhs, double3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(double3 lhs, double3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(double3 lhs, double3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(double3 lhs, double3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(double3 lhs, double3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static double3 Abs(double3 v) => new double3(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static double3 Sign(double3 v) => new double3(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        public static double3 Floor(double3 v) => new double3(Maths.Floor(v.x), Maths.Floor(v.y), Maths.Floor(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        public static double3 Truncate(double3 v) => new double3(Maths.Truncate(v.x), Maths.Truncate(v.y), Maths.Truncate(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        public static double3 Round(double3 v) => new double3(Maths.Round(v.x), Maths.Round(v.y), Maths.Round(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        public static double3 RoundEven(double3 v) => new double3(Maths.RoundEven(v.x), Maths.RoundEven(v.y), Maths.RoundEven(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        public static double3 Ceiling(double3 v) => new double3(Maths.Ceiling(v.x), Maths.Ceiling(v.y), Maths.Ceiling(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        public static double3 Fract(double3 v) => new double3(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y), v.z - Maths.Floor(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static double3 Mod(double3 lhs, double3 rhs) => new double3(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y), lhs.z - rhs.z * Maths.Floor(lhs.z / rhs.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static double3 Mod(double3 lhs, double rhs) => new double3(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs), lhs.z - rhs * Maths.Floor(lhs.z / rhs));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static double3 Lerp(double3 edge0, double3 edge1, double3 v) => new double3(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static double3 Lerp(double3 edge0, double3 edge1, double v) => new double3(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static double3 Step(double3 edge, double3 x) => new double3(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1, x.z < edge.z ? 0 : 1);
        
        /// <summary>
        /// Returns a double3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static double3 Step(double edge, double3 x) => new double3(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1, x.z < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a double3 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static double3 Smoothstep(double3 edge0, double3 edge1, double3 v) => new double3(Maths.SmoothStep(Maths.Clamp((v.x - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.y - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.z - edge0.z) / (edge1.z - edge0.z), 0, 1)));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static double3 Smoothstep(double3 edge0, double3 edge1, double v) => new double3(Maths.SmoothStep(Maths.Clamp((v - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.z) / (edge1.z - edge0.z), 0, 1)));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool3 IsNaN(double3 v) => new bool3(double.IsNaN(v.x), double.IsNaN(v.y), double.IsNaN(v.z));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool3 IsInfinity(double3 v) => new bool3(double.IsInfinity(v.x), double.IsInfinity(v.y), double.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        public static double3 Fma(double3 a, double3 b, double3 c) => new double3(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y), Maths.Fma(a.z, b.z, c.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static double3 Min(double3 lhs, double3 rhs) => new double3(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static double3 Min(double3 lhs, double rhs) => new double3(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static double3 Max(double3 lhs, double3 rhs) => new double3(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static double3 Max(double3 lhs, double rhs) => new double3(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static double3 Clamp(double3 v, double3 min, double3 max) => new double3(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z));
        
        /// <summary>
        /// Returns a double3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static double3 Mix(double3 x, double3 y, bool3 a) => new double3(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator- (-v).
        /// </summary>
        public static double3 operator-(double3 v) => new double3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double3 operator+(double3 lhs, double3 rhs) => new double3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double3 operator+(double3 lhs, double rhs) => new double3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double3 operator+(double lhs, double3 rhs) => new double3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double3 operator-(double3 lhs, double3 rhs) => new double3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double3 operator-(double3 lhs, double rhs) => new double3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double3 operator-(double lhs, double3 rhs) => new double3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double3 operator*(double3 lhs, double3 rhs) => new double3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double3 operator*(double3 lhs, double rhs) => new double3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double3 operator*(double lhs, double3 rhs) => new double3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double3 operator/(double3 lhs, double3 rhs) => new double3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double3 operator/(double3 lhs, double rhs) => new double3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a double3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double3 operator/(double lhs, double3 rhs) => new double3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);

        #endregion

    }
}
