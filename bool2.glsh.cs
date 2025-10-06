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
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(bool2 lhs, bool2 rhs) => bool2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(bool2 lhs, bool2 rhs) => bool2.NotEqual(lhs, rhs);
        
        public static bool Any(bool2 v) => bool2.Any(v);
        
        public static bool All(bool2 v) => bool2.All(v);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Not (!v).
        /// </summary>
        public static bool2 Not(bool2 v) => bool2.Not(v);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static bool2 Mix(bool2 x, bool2 y, bool2 a) => bool2.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(bool2 v) => v.GetHashCode();
        
        /// <summary>
        /// Compares two values
        /// </summary>
        public static int CompareTo(bool2 v, bool2 other) => v.CompareTo(other);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(bool2 v) => v.ToString();
        
        public static bool Equals(bool2 v, bool2 other) => v.Equals(other);
        
        public static bool Equals(bool2 v, object? obj) => v.Equals(obj);

    }
}
