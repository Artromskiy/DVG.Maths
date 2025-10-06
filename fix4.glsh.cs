#pragma warning disable IDE1006
#nullable enable
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Numerics;
using System.Diagnostics;


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
        public static fix Length(fix4 v) => fix4.Length(v);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static fix Distance(fix4 lhs, fix4 rhs) => fix4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static fix Dot(fix4 lhs, fix4 rhs) => fix4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static fix4 Normalize(fix4 v) => fix4.Normalize(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static fix4 FaceForward(fix4 N, fix4 I, fix4 Nref) => fix4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static fix4 Reflect(fix4 I, fix4 N) => fix4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static fix4 Refract(fix4 I, fix4 N, fix eta) => fix4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static fix4 Abs(fix4 v) => fix4.Abs(v);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static fix4 Sign(fix4 v) => fix4.Sign(v);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static fix4 Lerp(fix4 edge0, fix4 edge1, fix4 v) => fix4.Lerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static fix4 Step(fix4 edge, fix4 x) => fix4.Step(edge, x);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        public static fix4 SmoothStep(fix4 edge0, fix4 edge1, fix4 x) => fix4.SmoothStep(edge0, edge1, x);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static fix4 Min(fix4 lhs, fix4 rhs) => fix4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static fix4 Max(fix4 lhs, fix4 rhs) => fix4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static fix4 Clamp(fix4 v, fix4 min, fix4 max) => fix4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static fix4 Clamp(fix4 v, fix min, fix max) => fix4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static fix4 Mix(fix4 x, fix4 y, bool4 a) => fix4.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(fix4 v) => v.GetHashCode();
        
        /// <summary>
        /// Compares two values
        /// </summary>
        public static int CompareTo(fix4 v, fix4 other) => v.CompareTo(other);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(fix4 v) => v.ToString();
        
        public static bool Equals(fix4 v, fix4 other) => v.Equals(other);
        
        public static bool Equals(fix4 v, object? obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        public static fix SqrLength(fix4 v) => fix4.SqrLength(v);
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        public static fix SqrDistance(fix4 lhs, fix4 rhs) => fix4.SqrDistance(lhs, rhs);
        
        /// <summary>
        /// Returns a fix4 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        public static fix4 InvLerp(fix4 edge0, fix4 edge1, fix4 v) => fix4.InvLerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        public static fix4 ClampLength(fix4 value, fix maxLength) => fix4.ClampLength(value, maxLength);
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        public static fix4 MoveTowards(fix4 current, fix4 target, fix maxDelta) => fix4.MoveTowards(current, target, maxDelta);

    }
}
