#pragma warning disable IDE1006
#nullable enable
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
        public static fix Length(fix3 v) => fix3.Length(v);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static fix Distance(fix3 lhs, fix3 rhs) => fix3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static fix Dot(fix3 lhs, fix3 rhs) => fix3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static fix3 Cross(fix3 lhs, fix3 rhs) => fix3.Cross(lhs, rhs);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static fix3 Normalize(fix3 v) => fix3.Normalize(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static fix3 FaceForward(fix3 N, fix3 I, fix3 Nref) => fix3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static fix3 Reflect(fix3 I, fix3 N) => fix3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static fix3 Refract(fix3 I, fix3 N, fix eta) => fix3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static fix3 Abs(fix3 v) => fix3.Abs(v);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static fix3 Sign(fix3 v) => fix3.Sign(v);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static fix3 Lerp(fix3 edge0, fix3 edge1, fix3 v) => fix3.Lerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static fix3 Step(fix3 edge, fix3 x) => fix3.Step(edge, x);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        public static fix3 SmoothStep(fix3 edge0, fix3 edge1, fix3 x) => fix3.SmoothStep(edge0, edge1, x);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static fix3 Min(fix3 lhs, fix3 rhs) => fix3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static fix3 Max(fix3 lhs, fix3 rhs) => fix3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static fix3 Clamp(fix3 v, fix3 min, fix3 max) => fix3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static fix3 Clamp(fix3 v, fix min, fix max) => fix3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static fix3 Mix(fix3 x, fix3 y, bool3 a) => fix3.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(fix3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(fix3 v) => v.ToString();
        
        public static bool Equals(fix3 v, fix3 other) => v.Equals(other);
        
        public static bool Equals(fix3 v, object? obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        public static fix SqrLength(fix3 v) => fix3.SqrLength(v);
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        public static fix SqrDistance(fix3 lhs, fix3 rhs) => fix3.SqrDistance(lhs, rhs);
        
        /// <summary>
        /// Returns a fix3 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        public static fix3 InvLerp(fix3 edge0, fix3 edge1, fix3 v) => fix3.InvLerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        public static fix3 ClampLength(fix3 value, fix maxLength) => fix3.ClampLength(value, maxLength);
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        public static fix3 MoveTowards(fix3 current, fix3 target, fix maxDelta) => fix3.MoveTowards(current, target, maxDelta);

    }
}
