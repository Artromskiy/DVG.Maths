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
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(bool3 lhs, bool3 rhs) => bool3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(bool3 lhs, bool3 rhs) => bool3.NotEqual(lhs, rhs);
        
        public static bool Any(bool3 v) => bool3.Any(v);
        
        public static bool All(bool3 v) => bool3.All(v);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Not (!v).
        /// </summary>
        public static bool3 Not(bool3 v) => bool3.Not(v);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static bool3 Mix(bool3 x, bool3 y, bool3 a) => bool3.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(bool3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(bool3 v) => v.ToString();
        
        public static bool Equals(bool3 v, bool3 other) => v.Equals(other);
        
        public static bool Equals(bool3 v, object? obj) => v.Equals(obj);
        
        public static bool SqrLength(bool3 v) => v.SqrLength();

    }
}
