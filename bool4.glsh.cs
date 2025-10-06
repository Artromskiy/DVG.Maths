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
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(bool4 lhs, bool4 rhs) => bool4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(bool4 lhs, bool4 rhs) => bool4.NotEqual(lhs, rhs);
        
        public static bool Any(bool4 v) => bool4.Any(v);
        
        public static bool All(bool4 v) => bool4.All(v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Not (!v).
        /// </summary>
        public static bool4 Not(bool4 v) => bool4.Not(v);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static bool4 Mix(bool4 x, bool4 y, bool4 a) => bool4.Mix(x, y, a);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(bool4 v) => v.GetHashCode();
        
        /// <summary>
        /// Compares two values
        /// </summary>
        public static int CompareTo(bool4 v, bool4 other) => v.CompareTo(other);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(bool4 v) => v.ToString();
        
        public static bool Equals(bool4 v, bool4 other) => v.Equals(other);
        
        public static bool Equals(bool4 v, object? obj) => v.Equals(obj);

    }
}
