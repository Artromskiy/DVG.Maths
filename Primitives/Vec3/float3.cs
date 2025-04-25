#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace DVG
{
    
    /// <summary>
    /// A vector of type float with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct float3 : IEquatable<float3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public float z;
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public const int Count = 3;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public float3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public float3(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public float3(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public float3(float2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public float3(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public float3(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        public static implicit operator double3(float3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public float this[int index]
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
        public float2 xy
        {
            get
            {
                return new float2(x, y);
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
        public float2 xz
        {
            get
            {
                return new float2(x, z);
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
        public float2 yz
        {
            get
            {
                return new float2(y, z);
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
        public float3 xyz
        {
            get
            {
                return new float3(x, y, z);
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
        public float2 rg
        {
            get
            {
                return new float2(x, y);
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
        public float2 rb
        {
            get
            {
                return new float2(x, z);
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
        public float2 gb
        {
            get
            {
                return new float2(y, z);
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
        public float3 rgb
        {
            get
            {
                return new float3(x, y, z);
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
        public float r
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
        public float g
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
        public float b
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
        
        public static bool operator==(float3 lhs, float3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;
        
        public static bool operator!=(float3 lhs, float3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

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
        
        public readonly bool Equals(float3 other) => other == this;
        
        public override readonly bool Equals(object? obj) => obj is float3 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(float3 v) => Maths.Sqrt(((v.x*v.x + v.y*v.y) + v.z*v.z));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float3 lhs, float3 rhs) => float3.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float3 lhs, float3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static float3 Cross(float3 lhs, float3 rhs) => new float3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static float3 Normalize(float3 v) => v / float3.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float3 FaceForward(float3 N, float3 I, float3 Nref) => float3.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float3 Reflect(float3 I, float3 N) => I - 2 * float3.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float3 Refract(float3 I, float3 N, float eta)
        {
            var dNI = float3.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float3((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float3 Clamp(float3 v, float min, float max) => new float3(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a float3 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        public static float3 Radians(float3 v) => new float3(Maths.Radians(v.x), Maths.Radians(v.y), Maths.Radians(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        public static float3 Degrees(float3 v) => new float3(Maths.Degrees(v.x), Maths.Degrees(v.y), Maths.Degrees(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        public static float3 Sin(float3 v) => new float3(Maths.Sin(v.x), Maths.Sin(v.y), Maths.Sin(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        public static float3 Cos(float3 v) => new float3(Maths.Cos(v.x), Maths.Cos(v.y), Maths.Cos(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        public static float3 Tan(float3 v) => new float3(Maths.Tan(v.x), Maths.Tan(v.y), Maths.Tan(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        public static float3 Asin(float3 v) => new float3(Maths.Asin(v.x), Maths.Asin(v.y), Maths.Asin(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        public static float3 Acos(float3 v) => new float3(Maths.Acos(v.x), Maths.Acos(v.y), Maths.Acos(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        public static float3 Atan(float3 y, float3 x) => new float3(Maths.Atan(y.x / x.x), Maths.Atan(y.y / x.y), Maths.Atan(y.z / x.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        public static float3 Atan(float3 v) => new float3(Maths.Atan(v.x), Maths.Atan(v.y), Maths.Atan(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        public static float3 Sinh(float3 v) => new float3(Maths.Sinh(v.x), Maths.Sinh(v.y), Maths.Sinh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        public static float3 Cosh(float3 v) => new float3(Maths.Cosh(v.x), Maths.Cosh(v.y), Maths.Cosh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        public static float3 Tanh(float3 v) => new float3(Maths.Tanh(v.x), Maths.Tanh(v.y), Maths.Tanh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        public static float3 Asinh(float3 v) => new float3(Maths.Asinh(v.x), Maths.Asinh(v.y), Maths.Asinh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        public static float3 Acosh(float3 v) => new float3(Maths.Acosh(v.x), Maths.Acosh(v.y), Maths.Acosh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        public static float3 Atanh(float3 v) => new float3(Maths.Atanh(v.x), Maths.Atanh(v.y), Maths.Atanh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        public static float3 Pow(float3 lhs, float3 rhs) => new float3(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y), Maths.Pow(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        public static float3 Exp(float3 v) => new float3(Maths.Exp(v.x), Maths.Exp(v.y), Maths.Exp(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        public static float3 Log(float3 v) => new float3(Maths.Log(v.x), Maths.Log(v.y), Maths.Log(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        public static float3 Exp2(float3 v) => new float3(Maths.Exp2(v.x), Maths.Exp2(v.y), Maths.Exp2(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        public static float3 Log2(float3 v) => new float3(Maths.Log2(v.x), Maths.Log2(v.y), Maths.Log2(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        public static float3 Sqrt(float3 v) => new float3(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        public static float3 InverseSqrt(float3 v) => new float3(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(float3 lhs, float3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(float3 lhs, float3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(float3 lhs, float3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(float3 lhs, float3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(float3 lhs, float3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(float3 lhs, float3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static float3 Abs(float3 v) => new float3(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static float3 Sign(float3 v) => new float3(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        public static float3 Floor(float3 v) => new float3(Maths.Floor(v.x), Maths.Floor(v.y), Maths.Floor(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        public static float3 Truncate(float3 v) => new float3(Maths.Truncate(v.x), Maths.Truncate(v.y), Maths.Truncate(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        public static float3 Round(float3 v) => new float3(Maths.Round(v.x), Maths.Round(v.y), Maths.Round(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        public static float3 RoundEven(float3 v) => new float3(Maths.RoundEven(v.x), Maths.RoundEven(v.y), Maths.RoundEven(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        public static float3 Ceiling(float3 v) => new float3(Maths.Ceiling(v.x), Maths.Ceiling(v.y), Maths.Ceiling(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        public static float3 Fract(float3 v) => new float3(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y), v.z - Maths.Floor(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static float3 Mod(float3 lhs, float3 rhs) => new float3(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y), lhs.z - rhs.z * Maths.Floor(lhs.z / rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static float3 Mod(float3 lhs, float rhs) => new float3(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs), lhs.z - rhs * Maths.Floor(lhs.z / rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static float3 Lerp(float3 edge0, float3 edge1, float3 v) => new float3(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static float3 Lerp(float3 edge0, float3 edge1, float v) => new float3(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static float3 Step(float3 edge, float3 x) => new float3(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1, x.z < edge.z ? 0 : 1);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static float3 Step(float edge, float3 x) => new float3(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1, x.z < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static float3 Smoothstep(float3 edge0, float3 edge1, float3 v) => new float3(Maths.SmoothStep(Maths.Clamp((v.x - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.y - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.z - edge0.z) / (edge1.z - edge0.z), 0, 1)));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static float3 Smoothstep(float3 edge0, float3 edge1, float v) => new float3(Maths.SmoothStep(Maths.Clamp((v - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.z) / (edge1.z - edge0.z), 0, 1)));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool3 IsNaN(float3 v) => new bool3(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool3 IsInfinity(float3 v) => new bool3(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        public static float3 Fma(float3 a, float3 b, float3 c) => new float3(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y), Maths.Fma(a.z, b.z, c.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static float3 Min(float3 lhs, float3 rhs) => new float3(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static float3 Min(float3 lhs, float rhs) => new float3(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static float3 Max(float3 lhs, float3 rhs) => new float3(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static float3 Max(float3 lhs, float rhs) => new float3(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float3 Clamp(float3 v, float3 min, float3 max) => new float3(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static float3 Mix(float3 x, float3 y, bool3 a) => new float3(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        public static int3 FloatBitsToInt(float3 v) => new int3(Unsafe.As<float, int>(ref v.x), Unsafe.As<float, int>(ref v.y), Unsafe.As<float, int>(ref v.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        public static uint3 FloatBitsToUInt(float3 v) => new uint3(Unsafe.As<float, uint>(ref v.x), Unsafe.As<float, uint>(ref v.y), Unsafe.As<float, uint>(ref v.z));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (-v).
        /// </summary>
        public static float3 operator-(float3 v) => new float3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float3 operator+(float3 lhs, float3 rhs) => new float3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float3 operator+(float3 lhs, float rhs) => new float3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float3 operator+(float lhs, float3 rhs) => new float3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float3 operator-(float3 lhs, float3 rhs) => new float3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float3 operator-(float3 lhs, float rhs) => new float3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float3 operator-(float lhs, float3 rhs) => new float3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float3 operator*(float3 lhs, float3 rhs) => new float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float3 operator*(float3 lhs, float rhs) => new float3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float3 operator*(float lhs, float3 rhs) => new float3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float3 operator/(float3 lhs, float3 rhs) => new float3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float3 operator/(float3 lhs, float rhs) => new float3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float3 operator/(float lhs, float3 rhs) => new float3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);

        #endregion

    }
}
