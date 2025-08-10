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
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(double4 v) => double4.Length(v);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(double4 lhs, double4 rhs) => double4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(double4 lhs, double4 rhs) => double4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static double4 Normalize(double4 v) => double4.Normalize(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static double4 FaceForward(double4 N, double4 I, double4 Nref) => double4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double4 Reflect(double4 I, double4 N) => double4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double4 Refract(double4 I, double4 N, double eta) => double4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        public static double4 Sqrt(double4 v) => double4.Sqrt(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        public static double4 InverseSqrt(double4 v) => double4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(double4 lhs, double4 rhs) => double4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(double4 lhs, double4 rhs) => double4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(double4 lhs, double4 rhs) => double4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(double4 lhs, double4 rhs) => double4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(double4 lhs, double4 rhs) => double4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(double4 lhs, double4 rhs) => double4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static double4 Abs(double4 v) => double4.Abs(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static double4 Sign(double4 v) => double4.Sign(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        public static double4 Floor(double4 v) => double4.Floor(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        public static double4 Truncate(double4 v) => double4.Truncate(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        public static double4 Round(double4 v) => double4.Round(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        public static double4 RoundEven(double4 v) => double4.RoundEven(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Ceil (Maths.Ceil(v)).
        /// </summary>
        public static double4 Ceil(double4 v) => double4.Ceil(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        public static double4 Fract(double4 v) => double4.Fract(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static double4 Mod(double4 lhs, double4 rhs) => double4.Mod(lhs, rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static double4 Lerp(double4 edge0, double4 edge1, double4 v) => double4.Lerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static double4 Step(double4 edge, double4 x) => double4.Step(edge, x);
        
        /// <summary>
        /// Returns a double4 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        public static double4 SmoothStep(double4 edge0, double4 edge1, double4 x) => double4.SmoothStep(edge0, edge1, x);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(double4 v) => double4.IsNaN(v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(double4 v) => double4.IsInfinity(v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        public static double4 Fma(double4 a, double4 b, double4 c) => double4.Fma(a, b, c);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static double4 Min(double4 lhs, double4 rhs) => double4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static double4 Max(double4 lhs, double4 rhs) => double4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static double4 Clamp(double4 v, double4 min, double4 max) => double4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static double4 Clamp(double4 v, double min, double max) => double4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static double4 Mix(double4 x, double4 y, bool4 a) => double4.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(double4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(double4 v) => v.ToString();
        
        public static bool Equals(double4 v, double4 other) => v.Equals(other);
        
        public static bool Equals(double4 v, object? obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        public static double SqrLength(double4 v) => double4.SqrLength(v);
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        public static double SqrDistance(double4 lhs, double4 rhs) => double4.SqrDistance(lhs, rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        public static double4 InvLerp(double4 edge0, double4 edge1, double4 v) => double4.InvLerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        public static double4 ClampLength(double4 value, double maxLength) => double4.ClampLength(value, maxLength);
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        public static double4 MoveTowards(double4 current, double4 target, double maxDelta) => double4.MoveTowards(current, target, maxDelta);

    }
}
