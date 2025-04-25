using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Numerics;


namespace DVG
{
    /// <summary>
    /// Static class that contains static glsh functions
    /// </summary>
    public static partial class glsh
    {
        
        /// <summary>
        /// Returns a float4 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        public static float4 Radians(float4 v) => float4.Radians(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        public static float4 Degrees(float4 v) => float4.Degrees(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        public static float4 Sin(float4 v) => float4.Sin(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        public static float4 Cos(float4 v) => float4.Cos(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        public static float4 Tan(float4 v) => float4.Tan(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        public static float4 Asin(float4 v) => float4.Asin(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        public static float4 Acos(float4 v) => float4.Acos(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        public static float4 Atan(float4 y, float4 x) => float4.Atan(y, x);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        public static float4 Atan(float4 v) => float4.Atan(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        public static float4 Sinh(float4 v) => float4.Sinh(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        public static float4 Cosh(float4 v) => float4.Cosh(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        public static float4 Tanh(float4 v) => float4.Tanh(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        public static float4 Asinh(float4 v) => float4.Asinh(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        public static float4 Acosh(float4 v) => float4.Acosh(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        public static float4 Atanh(float4 v) => float4.Atanh(v);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(float4 v) => float4.Length(v);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float4 lhs, float4 rhs) => float4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float4 lhs, float4 rhs) => float4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static float4 Normalize(float4 v) => float4.Normalize(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float4 FaceForward(float4 N, float4 I, float4 Nref) => float4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float4 Reflect(float4 I, float4 N) => float4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float4 Refract(float4 I, float4 N, float eta) => float4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        public static float4 Pow(float4 lhs, float4 rhs) => float4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        public static float4 Exp(float4 v) => float4.Exp(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        public static float4 Log(float4 v) => float4.Log(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        public static float4 Exp2(float4 v) => float4.Exp2(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        public static float4 Log2(float4 v) => float4.Log2(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        public static float4 Sqrt(float4 v) => float4.Sqrt(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        public static float4 InverseSqrt(float4 v) => float4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float4 lhs, float4 rhs) => float4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float4 lhs, float4 rhs) => float4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float4 lhs, float4 rhs) => float4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float4 lhs, float4 rhs) => float4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float4 lhs, float4 rhs) => float4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float4 lhs, float4 rhs) => float4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static float4 Abs(float4 v) => float4.Abs(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static float4 Sign(float4 v) => float4.Sign(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        public static float4 Floor(float4 v) => float4.Floor(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        public static float4 Truncate(float4 v) => float4.Truncate(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        public static float4 Round(float4 v) => float4.Round(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        public static float4 RoundEven(float4 v) => float4.RoundEven(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        public static float4 Ceiling(float4 v) => float4.Ceiling(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        public static float4 Fract(float4 v) => float4.Fract(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static float4 Mod(float4 lhs, float4 rhs) => float4.Mod(lhs, rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static float4 Lerp(float4 edge0, float4 edge1, float4 v) => float4.Lerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static float4 Step(float4 edge, float4 x) => float4.Step(edge, x);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float4 edge1, float4 v) => float4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(float4 v) => float4.IsNaN(v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(float4 v) => float4.IsInfinity(v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        public static float4 Fma(float4 a, float4 b, float4 c) => float4.Fma(a, b, c);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float4 lhs, float4 rhs) => float4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float4 lhs, float4 rhs) => float4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float4 Clamp(float4 v, float4 min, float4 max) => float4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float4 Clamp(float4 v, float min, float max) => float4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static float4 Mix(float4 x, float4 y, bool4 a) => float4.Mix(x, y, a);
        
        /// <summary>
        /// Returns a int4 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        public static int4 FloatBitsToInt(float4 v) => float4.FloatBitsToInt(v);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        public static uint4 FloatBitsToUInt(float4 v) => float4.FloatBitsToUInt(v);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(float4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(float4 v) => v.ToString();
        
        public static bool Equals(float4 v, float4 other) => v.Equals(other);
        
        public static bool Equals(float4 v, object? obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        public static float SqrLength(float4 v) => float4.SqrLength(v);
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        public static float SqrDistance(float4 lhs, float4 rhs) => float4.SqrDistance(lhs, rhs);

    }
}
