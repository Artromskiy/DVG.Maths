#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace DVG
{
    
    /// <summary>
    /// A vector of type bool with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct bool3 : IEquatable<bool3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public bool z;
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public const int Count = 3;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bool3(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bool3(bool2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public bool3(bool2 v, bool z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public bool3(bool3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public bool3(bool4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int index]
        {
            get
            {
                if ((uint)index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return Unsafe.Add(ref x, index);
            }
            set
            {
                if ((uint)index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                Unsafe.Add(ref x, index) = value;
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool2 xy
        {
            get
            {
                return new bool2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool2 xz
        {
            get
            {
                return new bool2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool2 yz
        {
            get
            {
                return new bool2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool3 xyz
        {
            get
            {
                return new bool3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool2 rg
        {
            get
            {
                return new bool2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool2 rb
        {
            get
            {
                return new bool2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool2 gb
        {
            get
            {
                return new bool2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool3 rgb
        {
            get
            {
                return new bool3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public bool r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public bool g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public bool b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        #endregion


        #region Operators
        
        public static bool operator==(bool3 lhs, bool3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;
        
        public static bool operator!=(bool3 lhs, bool3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public override readonly string ToString() => x + ", " + y + ", " + z;
        
        public readonly bool Equals(bool3 other) => other == this;
        
        public override readonly bool Equals(object? obj) => obj is bool3 other && Equals(other);
        
        public readonly bool SqrLength() => x * x + y * y + z * z;

        #endregion


        #region Static Functions
        
        public static bool Any(bool3 v) => v.x||v.y||v.z;
        
        public static bool All(bool3 v) => v.x&&v.y&&v.z;

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(bool3 lhs, bool3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(bool3 lhs, bool3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Not (!v).
        /// </summary>
        public static bool3 Not(bool3 v) => new bool3(!v.x, !v.y, !v.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static bool3 Mix(bool3 x, bool3 y, bool3 a) => new bool3(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z);

        #endregion

    }
}
