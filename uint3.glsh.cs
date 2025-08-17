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
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(uint3 lhs, uint3 rhs) => uint3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(uint3 lhs, uint3 rhs) => uint3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(uint3 lhs, uint3 rhs) => uint3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(uint3 lhs, uint3 rhs) => uint3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(uint3 lhs, uint3 rhs) => uint3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(uint3 lhs, uint3 rhs) => uint3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static uint3 Min(uint3 lhs, uint3 rhs) => uint3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static uint3 Max(uint3 lhs, uint3 rhs) => uint3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static uint3 Clamp(uint3 v, uint3 min, uint3 max) => uint3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static uint3 Clamp(uint3 v, uint min, uint max) => uint3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static uint3 Mix(uint3 x, uint3 y, bool3 a) => uint3.Mix(x, y, a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of UIntBitsToFloat (Unsafe.As&lt;uint, float&gt;(ref v)).
        /// </summary>
        public static float3 UIntBitsToFloat(uint3 v) => uint3.UIntBitsToFloat(v);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(uint3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(uint3 v) => v.ToString();
        
        public static bool Equals(uint3 v, uint3 other) => v.Equals(other);
        
        public static bool Equals(uint3 v, object? obj) => v.Equals(obj);

    }
}
