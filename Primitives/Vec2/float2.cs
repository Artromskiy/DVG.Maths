#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace DVG
{
    
    /// <summary>
    /// A vector of type float with 2 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct float2 : IEquatable<float2>
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
        /// Returns the number of components (2).
        /// </summary>
        public const int Count = 2;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double2.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float2 v) => new double2((double)v.x, (double)v.y);

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

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(float2 lhs, float2 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(float2 lhs, float2 rhs) => lhs.x != rhs.x||lhs.y != rhs.y;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => x + ", " + y;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(float2 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is float2 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Length(float2 v) => Maths.Sqrt(v.x * v.x + v.y * v.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float2 lhs, float2 rhs) => float2.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float2 lhs, float2 rhs) => (lhs.x * rhs.x + lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Normalize(float2 v) => v / float2.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 FaceForward(float2 N, float2 I, float2 Nref) => float2.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Reflect(float2 I, float2 N) => I - 2 * float2.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Refract(float2 I, float2 N, float eta)
        {
            var dNI = float2.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float2((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Clamp(float2 v, float min, float max) => new float2(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max));
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrLength(float2 v) => v.x * v.x + v.y * v.y;
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(float2 lhs, float2 rhs) => float2.SqrLength(lhs - rhs);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a float2 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Radians(float2 v) => new float2(Maths.Radians(v.x), Maths.Radians(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Degrees(float2 v) => new float2(Maths.Degrees(v.x), Maths.Degrees(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sin(float2 v) => new float2(Maths.Sin(v.x), Maths.Sin(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Cos(float2 v) => new float2(Maths.Cos(v.x), Maths.Cos(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Tan(float2 v) => new float2(Maths.Tan(v.x), Maths.Tan(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Asin(float2 v) => new float2(Maths.Asin(v.x), Maths.Asin(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Acos(float2 v) => new float2(Maths.Acos(v.x), Maths.Acos(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Atan(float2 y, float2 x) => new float2(Maths.Atan(y.x / x.x), Maths.Atan(y.y / x.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Atan(float2 v) => new float2(Maths.Atan(v.x), Maths.Atan(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sinh(float2 v) => new float2(Maths.Sinh(v.x), Maths.Sinh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Cosh(float2 v) => new float2(Maths.Cosh(v.x), Maths.Cosh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Tanh(float2 v) => new float2(Maths.Tanh(v.x), Maths.Tanh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Asinh(float2 v) => new float2(Maths.Asinh(v.x), Maths.Asinh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Acosh(float2 v) => new float2(Maths.Acosh(v.x), Maths.Acosh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Atanh(float2 v) => new float2(Maths.Atanh(v.x), Maths.Atanh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Pow(float2 lhs, float2 rhs) => new float2(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Exp(float2 v) => new float2(Maths.Exp(v.x), Maths.Exp(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Log(float2 v) => new float2(Maths.Log(v.x), Maths.Log(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Exp2(float2 v) => new float2(Maths.Exp2(v.x), Maths.Exp2(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Log2(float2 v) => new float2(Maths.Log2(v.x), Maths.Log2(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sqrt(float2 v) => new float2(Maths.Sqrt(v.x), Maths.Sqrt(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InverseSqrt(float2 v) => new float2(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 LesserThan(float2 lhs, float2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 LesserThanEqual(float2 lhs, float2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 GreaterThan(float2 lhs, float2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 GreaterThanEqual(float2 lhs, float2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Equal(float2 lhs, float2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 NotEqual(float2 lhs, float2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Abs(float2 v) => new float2(Maths.Abs(v.x), Maths.Abs(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sign(float2 v) => new float2(Maths.Sign(v.x), Maths.Sign(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Floor(float2 v) => new float2(Maths.Floor(v.x), Maths.Floor(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Truncate(float2 v) => new float2(Maths.Truncate(v.x), Maths.Truncate(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Round(float2 v) => new float2(Maths.Round(v.x), Maths.Round(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 RoundEven(float2 v) => new float2(Maths.RoundEven(v.x), Maths.RoundEven(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Ceiling(float2 v) => new float2(Maths.Ceiling(v.x), Maths.Ceiling(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Fract(float2 v) => new float2(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Mod(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Mod(float2 lhs, float rhs) => new float2(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Lerp(float2 edge0, float2 edge1, float2 v) => new float2(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Lerp(float2 edge0, float2 edge1, float v) => new float2(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Step(float2 edge, float2 x) => new float2(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Step(float edge, float2 x) => new float2(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Smoothstep(float2 edge0, float2 edge1, float2 v) => new float2(Maths.SmoothStep(Maths.Clamp((v.x - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.y - edge0.y) / (edge1.y - edge0.y), 0, 1)));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Smoothstep(float2 edge0, float2 edge1, float v) => new float2(Maths.SmoothStep(Maths.Clamp((v - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.y) / (edge1.y - edge0.y), 0, 1)));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 IsNaN(float2 v) => new bool2(float.IsNaN(v.x), float.IsNaN(v.y));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 IsInfinity(float2 v) => new bool2(float.IsInfinity(v.x), float.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Fma(float2 a, float2 b, float2 c) => new float2(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Min(float2 lhs, float2 rhs) => new float2(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Min(float2 lhs, float rhs) => new float2(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Max(float2 lhs, float2 rhs) => new float2(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Max(float2 lhs, float rhs) => new float2(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Clamp(float2 v, float2 min, float2 max) => new float2(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Mix(float2 x, float2 y, bool2 a) => new float2(a.x ? y.x : x.x, a.y ? y.y : x.y);
        
        /// <summary>
        /// Returns a int2 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 FloatBitsToInt(float2 v) => new int2(Unsafe.As<float, int>(ref v.x), Unsafe.As<float, int>(ref v.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 FloatBitsToUInt(float2 v) => new uint2(Unsafe.As<float, uint>(ref v.x), Unsafe.As<float, uint>(ref v.y));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float2 v) => new float2(-v.x, -v.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator+(float2 lhs, float2 rhs) => new float2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator+(float2 lhs, float rhs) => new float2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator+(float lhs, float2 rhs) => new float2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float2 lhs, float rhs) => new float2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float lhs, float2 rhs) => new float2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator*(float2 lhs, float2 rhs) => new float2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator*(float2 lhs, float rhs) => new float2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator*(float lhs, float2 rhs) => new float2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator/(float2 lhs, float2 rhs) => new float2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator/(float2 lhs, float rhs) => new float2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator/(float lhs, float2 rhs) => new float2(lhs / rhs.x, lhs / rhs.y);

        #endregion

    }
}
