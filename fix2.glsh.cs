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
        public static fix Length(fix2 v) => fix2.Length(v);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static fix Distance(fix2 lhs, fix2 rhs) => fix2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static fix Dot(fix2 lhs, fix2 rhs) => fix2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static fix2 Normalize(fix2 v) => fix2.Normalize(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static fix2 FaceForward(fix2 N, fix2 I, fix2 Nref) => fix2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static fix2 Reflect(fix2 I, fix2 N) => fix2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static fix2 Refract(fix2 I, fix2 N, fix eta) => fix2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static fix2 Abs(fix2 v) => fix2.Abs(v);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static fix2 Sign(fix2 v) => fix2.Sign(v);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static fix2 Lerp(fix2 edge0, fix2 edge1, fix2 v) => fix2.Lerp(edge0, edge1, v);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static fix2 Step(fix2 edge, fix2 x) => fix2.Step(edge, x);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        public static fix2 SmoothStep(fix2 edge0, fix2 edge1, fix2 x) => fix2.SmoothStep(edge0, edge1, x);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static fix2 Min(fix2 lhs, fix2 rhs) => fix2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static fix2 Max(fix2 lhs, fix2 rhs) => fix2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static fix2 Clamp(fix2 v, fix2 min, fix2 max) => fix2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static fix2 Clamp(fix2 v, fix min, fix max) => fix2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a fix2 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static fix2 Mix(fix2 x, fix2 y, bool2 a) => fix2.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(fix2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(fix2 v) => v.ToString();
        
        public static bool Equals(fix2 v, fix2 other) => v.Equals(other);
        
        public static bool Equals(fix2 v, object? obj) => v.Equals(obj);

    }
}
