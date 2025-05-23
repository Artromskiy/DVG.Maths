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
        /// Returns a float2 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        public static float2 Radians(float2 v) => float2.Radians(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        public static float2 Degrees(float2 v) => float2.Degrees(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        public static float2 Sin(float2 v) => float2.Sin(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        public static float2 Cos(float2 v) => float2.Cos(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        public static float2 Tan(float2 v) => float2.Tan(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        public static float2 Asin(float2 v) => float2.Asin(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        public static float2 Acos(float2 v) => float2.Acos(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        public static float2 Atan(float2 y, float2 x) => float2.Atan(y, x);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        public static float2 Atan(float2 v) => float2.Atan(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        public static float2 Sinh(float2 v) => float2.Sinh(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        public static float2 Cosh(float2 v) => float2.Cosh(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        public static float2 Tanh(float2 v) => float2.Tanh(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        public static float2 Asinh(float2 v) => float2.Asinh(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        public static float2 Acosh(float2 v) => float2.Acosh(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        public static float2 Atanh(float2 v) => float2.Atanh(v);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(float2 v) => float2.Length(v);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float2 lhs, float2 rhs) => float2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float2 lhs, float2 rhs) => float2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static float2 Normalize(float2 v) => float2.Normalize(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float2 FaceForward(float2 N, float2 I, float2 Nref) => float2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float2 Reflect(float2 I, float2 N) => float2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float2 Refract(float2 I, float2 N, float eta) => float2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        public static float2 Pow(float2 lhs, float2 rhs) => float2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        public static float2 Exp(float2 v) => float2.Exp(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        public static float2 Log(float2 v) => float2.Log(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        public static float2 Exp2(float2 v) => float2.Exp2(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        public static float2 Log2(float2 v) => float2.Log2(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        public static float2 Sqrt(float2 v) => float2.Sqrt(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        public static float2 InverseSqrt(float2 v) => float2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(float2 lhs, float2 rhs) => float2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(float2 lhs, float2 rhs) => float2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(float2 lhs, float2 rhs) => float2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(float2 lhs, float2 rhs) => float2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(float2 lhs, float2 rhs) => float2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(float2 lhs, float2 rhs) => float2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static float2 Abs(float2 v) => float2.Abs(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static float2 Sign(float2 v) => float2.Sign(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        public static float2 Floor(float2 v) => float2.Floor(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        public static float2 Truncate(float2 v) => float2.Truncate(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        public static float2 Round(float2 v) => float2.Round(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        public static float2 RoundEven(float2 v) => float2.RoundEven(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        public static float2 Ceiling(float2 v) => float2.Ceiling(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        public static float2 Fract(float2 v) => float2.Fract(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static float2 Mod(float2 lhs, float2 rhs) => float2.Mod(lhs, rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static float2 Lerp(float2 edge0, float2 edge1, float2 v) => float2.Lerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static float2 Step(float2 edge, float2 x) => float2.Step(edge, x);
        
        /// <summary>
        /// Returns a float2 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        public static float2 SmoothStep(float2 edge0, float2 edge1, float2 x) => float2.SmoothStep(edge0, edge1, x);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool2 IsNaN(float2 v) => float2.IsNaN(v);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool2 IsInfinity(float2 v) => float2.IsInfinity(v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        public static float2 Fma(float2 a, float2 b, float2 c) => float2.Fma(a, b, c);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static float2 Min(float2 lhs, float2 rhs) => float2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static float2 Max(float2 lhs, float2 rhs) => float2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float2 Clamp(float2 v, float2 min, float2 max) => float2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float2 Clamp(float2 v, float min, float max) => float2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static float2 Mix(float2 x, float2 y, bool2 a) => float2.Mix(x, y, a);
        
        /// <summary>
        /// Returns a int2 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        public static int2 FloatBitsToInt(float2 v) => float2.FloatBitsToInt(v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        public static uint2 FloatBitsToUInt(float2 v) => float2.FloatBitsToUInt(v);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(float2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(float2 v) => v.ToString();
        
        public static bool Equals(float2 v, float2 other) => v.Equals(other);
        
        public static bool Equals(float2 v, object? obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        public static float SqrLength(float2 v) => float2.SqrLength(v);
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        public static float SqrDistance(float2 lhs, float2 rhs) => float2.SqrDistance(lhs, rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        public static float2 InvLerp(float2 edge0, float2 edge1, float2 v) => float2.InvLerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        public static float2 ClampLength(float2 value, float maxLength) => float2.ClampLength(value, maxLength);
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        public static float2 MoveTowards(float2 current, float2 target, float maxDelta) => float2.MoveTowards(current, target, maxDelta);

    }
}
