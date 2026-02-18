#pragma warning disable IDE1006
#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace DVG
{
    
    /// <summary>
    /// A vector of type bool with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct bool4 : IEquatable<bool4>, IComparable<bool4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public bool w;
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public const int Count = 4;
        
        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly bool4 zero = new bool4(false, false, false, false);

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = false;
            this.w = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool2 v, bool z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool2 v, bool z, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool3 v, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
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
        public bool r
        {
            readonly get => x;
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool s
        {
            readonly get => x;
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool g
        {
            readonly get => y;
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool t
        {
            readonly get => y;
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool b
        {
            readonly get => z;
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool p
        {
            readonly get => z;
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool a
        {
            readonly get => w;
            set
            {
                w = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public bool q
        {
            readonly get => w;
            set
            {
                w = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___x => new bool4(false, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___r => new bool4(false, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___s => new bool4(false, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___y => new bool4(false, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___g => new bool4(false, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___t => new bool4(false, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___z => new bool4(false, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___b => new bool4(false, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___p => new bool4(false, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___w => new bool4(false, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___a => new bool4(false, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ___q => new bool4(false, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __x_ => new bool4(false, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __r_ => new bool4(false, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __s_ => new bool4(false, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __xx => new bool4(false, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __rr => new bool4(false, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ss => new bool4(false, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __xy => new bool4(false, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __rg => new bool4(false, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __st => new bool4(false, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __xz => new bool4(false, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __rb => new bool4(false, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __sp => new bool4(false, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __xw => new bool4(false, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ra => new bool4(false, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __sq => new bool4(false, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __y_ => new bool4(false, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __g_ => new bool4(false, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __t_ => new bool4(false, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __yx => new bool4(false, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __gr => new bool4(false, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ts => new bool4(false, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __yy => new bool4(false, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __gg => new bool4(false, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __tt => new bool4(false, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __yz => new bool4(false, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __gb => new bool4(false, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __tp => new bool4(false, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __yw => new bool4(false, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ga => new bool4(false, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __tq => new bool4(false, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __z_ => new bool4(false, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __b_ => new bool4(false, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __p_ => new bool4(false, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __zx => new bool4(false, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __br => new bool4(false, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ps => new bool4(false, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __zy => new bool4(false, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __bg => new bool4(false, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __pt => new bool4(false, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __zz => new bool4(false, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __bb => new bool4(false, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __pp => new bool4(false, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __zw => new bool4(false, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ba => new bool4(false, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __pq => new bool4(false, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __w_ => new bool4(false, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __a_ => new bool4(false, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __q_ => new bool4(false, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __wx => new bool4(false, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ar => new bool4(false, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __qs => new bool4(false, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __wy => new bool4(false, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ag => new bool4(false, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __qt => new bool4(false, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __wz => new bool4(false, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ab => new bool4(false, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __qp => new bool4(false, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __ww => new bool4(false, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __aa => new bool4(false, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 __qq => new bool4(false, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _x__ => new bool4(false, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _r__ => new bool4(false, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _s__ => new bool4(false, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _x_x => new bool4(false, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _r_r => new bool4(false, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _s_s => new bool4(false, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _x_y => new bool4(false, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _r_g => new bool4(false, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _s_t => new bool4(false, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _x_z => new bool4(false, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _r_b => new bool4(false, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _s_p => new bool4(false, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _x_w => new bool4(false, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _r_a => new bool4(false, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _s_q => new bool4(false, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xx_ => new bool4(false, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rr_ => new bool4(false, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ss_ => new bool4(false, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xxx => new bool4(false, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rrr => new bool4(false, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sss => new bool4(false, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xxy => new bool4(false, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rrg => new bool4(false, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sst => new bool4(false, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xxz => new bool4(false, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rrb => new bool4(false, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ssp => new bool4(false, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xxw => new bool4(false, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rra => new bool4(false, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ssq => new bool4(false, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xy_ => new bool4(false, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rg_ => new bool4(false, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _st_ => new bool4(false, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xyx => new bool4(false, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rgr => new bool4(false, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sts => new bool4(false, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xyy => new bool4(false, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rgg => new bool4(false, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _stt => new bool4(false, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xyz => new bool4(false, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rgb => new bool4(false, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _stp => new bool4(false, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xyw => new bool4(false, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rga => new bool4(false, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _stq => new bool4(false, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xz_ => new bool4(false, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rb_ => new bool4(false, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sp_ => new bool4(false, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xzx => new bool4(false, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rbr => new bool4(false, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sps => new bool4(false, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xzy => new bool4(false, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rbg => new bool4(false, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _spt => new bool4(false, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xzz => new bool4(false, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rbb => new bool4(false, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _spp => new bool4(false, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xzw => new bool4(false, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rba => new bool4(false, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _spq => new bool4(false, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xw_ => new bool4(false, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ra_ => new bool4(false, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sq_ => new bool4(false, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xwx => new bool4(false, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rar => new bool4(false, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sqs => new bool4(false, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xwy => new bool4(false, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rag => new bool4(false, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sqt => new bool4(false, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xwz => new bool4(false, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _rab => new bool4(false, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sqp => new bool4(false, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _xww => new bool4(false, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _raa => new bool4(false, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _sqq => new bool4(false, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _y__ => new bool4(false, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _g__ => new bool4(false, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _t__ => new bool4(false, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _y_x => new bool4(false, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _g_r => new bool4(false, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _t_s => new bool4(false, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _y_y => new bool4(false, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _g_g => new bool4(false, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _t_t => new bool4(false, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _y_z => new bool4(false, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _g_b => new bool4(false, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _t_p => new bool4(false, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _y_w => new bool4(false, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _g_a => new bool4(false, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _t_q => new bool4(false, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yx_ => new bool4(false, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gr_ => new bool4(false, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ts_ => new bool4(false, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yxx => new bool4(false, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _grr => new bool4(false, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tss => new bool4(false, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yxy => new bool4(false, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _grg => new bool4(false, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tst => new bool4(false, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yxz => new bool4(false, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _grb => new bool4(false, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tsp => new bool4(false, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yxw => new bool4(false, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gra => new bool4(false, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tsq => new bool4(false, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yy_ => new bool4(false, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gg_ => new bool4(false, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tt_ => new bool4(false, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yyx => new bool4(false, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ggr => new bool4(false, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tts => new bool4(false, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yyy => new bool4(false, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ggg => new bool4(false, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ttt => new bool4(false, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yyz => new bool4(false, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ggb => new bool4(false, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ttp => new bool4(false, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yyw => new bool4(false, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gga => new bool4(false, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ttq => new bool4(false, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yz_ => new bool4(false, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gb_ => new bool4(false, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tp_ => new bool4(false, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yzx => new bool4(false, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gbr => new bool4(false, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tps => new bool4(false, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yzy => new bool4(false, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gbg => new bool4(false, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tpt => new bool4(false, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yzz => new bool4(false, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gbb => new bool4(false, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tpp => new bool4(false, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yzw => new bool4(false, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gba => new bool4(false, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tpq => new bool4(false, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yw_ => new bool4(false, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ga_ => new bool4(false, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tq_ => new bool4(false, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ywx => new bool4(false, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gar => new bool4(false, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tqs => new bool4(false, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ywy => new bool4(false, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gag => new bool4(false, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tqt => new bool4(false, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ywz => new bool4(false, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gab => new bool4(false, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tqp => new bool4(false, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _yww => new bool4(false, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _gaa => new bool4(false, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _tqq => new bool4(false, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _z__ => new bool4(false, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _b__ => new bool4(false, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _p__ => new bool4(false, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _z_x => new bool4(false, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _b_r => new bool4(false, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _p_s => new bool4(false, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _z_y => new bool4(false, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _b_g => new bool4(false, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _p_t => new bool4(false, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _z_z => new bool4(false, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _b_b => new bool4(false, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _p_p => new bool4(false, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _z_w => new bool4(false, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _b_a => new bool4(false, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _p_q => new bool4(false, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zx_ => new bool4(false, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _br_ => new bool4(false, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ps_ => new bool4(false, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zxx => new bool4(false, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _brr => new bool4(false, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pss => new bool4(false, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zxy => new bool4(false, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _brg => new bool4(false, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pst => new bool4(false, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zxz => new bool4(false, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _brb => new bool4(false, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _psp => new bool4(false, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zxw => new bool4(false, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bra => new bool4(false, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _psq => new bool4(false, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zy_ => new bool4(false, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bg_ => new bool4(false, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pt_ => new bool4(false, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zyx => new bool4(false, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bgr => new bool4(false, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pts => new bool4(false, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zyy => new bool4(false, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bgg => new bool4(false, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ptt => new bool4(false, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zyz => new bool4(false, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bgb => new bool4(false, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ptp => new bool4(false, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zyw => new bool4(false, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bga => new bool4(false, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ptq => new bool4(false, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zz_ => new bool4(false, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bb_ => new bool4(false, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pp_ => new bool4(false, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zzx => new bool4(false, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bbr => new bool4(false, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pps => new bool4(false, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zzy => new bool4(false, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bbg => new bool4(false, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ppt => new bool4(false, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zzz => new bool4(false, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bbb => new bool4(false, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ppp => new bool4(false, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zzw => new bool4(false, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bba => new bool4(false, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ppq => new bool4(false, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zw_ => new bool4(false, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ba_ => new bool4(false, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pq_ => new bool4(false, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zwx => new bool4(false, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bar => new bool4(false, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pqs => new bool4(false, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zwy => new bool4(false, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bag => new bool4(false, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pqt => new bool4(false, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zwz => new bool4(false, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _bab => new bool4(false, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pqp => new bool4(false, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _zww => new bool4(false, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _baa => new bool4(false, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _pqq => new bool4(false, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _w__ => new bool4(false, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _a__ => new bool4(false, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _q__ => new bool4(false, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _w_x => new bool4(false, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _a_r => new bool4(false, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _q_s => new bool4(false, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _w_y => new bool4(false, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _a_g => new bool4(false, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _q_t => new bool4(false, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _w_z => new bool4(false, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _a_b => new bool4(false, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _q_p => new bool4(false, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _w_w => new bool4(false, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _a_a => new bool4(false, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _q_q => new bool4(false, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wx_ => new bool4(false, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ar_ => new bool4(false, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qs_ => new bool4(false, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wxx => new bool4(false, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _arr => new bool4(false, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qss => new bool4(false, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wxy => new bool4(false, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _arg => new bool4(false, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qst => new bool4(false, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wxz => new bool4(false, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _arb => new bool4(false, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qsp => new bool4(false, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wxw => new bool4(false, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ara => new bool4(false, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qsq => new bool4(false, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wy_ => new bool4(false, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ag_ => new bool4(false, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qt_ => new bool4(false, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wyx => new bool4(false, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _agr => new bool4(false, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qts => new bool4(false, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wyy => new bool4(false, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _agg => new bool4(false, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qtt => new bool4(false, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wyz => new bool4(false, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _agb => new bool4(false, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qtp => new bool4(false, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wyw => new bool4(false, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aga => new bool4(false, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qtq => new bool4(false, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wz_ => new bool4(false, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ab_ => new bool4(false, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qp_ => new bool4(false, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wzx => new bool4(false, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _abr => new bool4(false, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qps => new bool4(false, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wzy => new bool4(false, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _abg => new bool4(false, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qpt => new bool4(false, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wzz => new bool4(false, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _abb => new bool4(false, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qpp => new bool4(false, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wzw => new bool4(false, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aba => new bool4(false, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qpq => new bool4(false, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _ww_ => new bool4(false, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aa_ => new bool4(false, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qq_ => new bool4(false, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wwx => new bool4(false, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aar => new bool4(false, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qqs => new bool4(false, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wwy => new bool4(false, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aag => new bool4(false, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qqt => new bool4(false, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _wwz => new bool4(false, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aab => new bool4(false, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qqp => new bool4(false, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _www => new bool4(false, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _aaa => new bool4(false, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 _qqq => new bool4(false, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x___ => new bool4(x, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r___ => new bool4(x, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s___ => new bool4(x, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x__x => new bool4(x, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r__r => new bool4(x, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s__s => new bool4(x, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x__y => new bool4(x, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r__g => new bool4(x, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s__t => new bool4(x, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x__z => new bool4(x, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r__b => new bool4(x, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s__p => new bool4(x, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x__w => new bool4(x, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r__a => new bool4(x, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s__q => new bool4(x, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_x_ => new bool4(x, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_r_ => new bool4(x, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_s_ => new bool4(x, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_xx => new bool4(x, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_rr => new bool4(x, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_ss => new bool4(x, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_xy => new bool4(x, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_rg => new bool4(x, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_st => new bool4(x, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_xz => new bool4(x, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_rb => new bool4(x, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_sp => new bool4(x, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_xw => new bool4(x, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_ra => new bool4(x, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_sq => new bool4(x, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_y_ => new bool4(x, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_g_ => new bool4(x, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_t_ => new bool4(x, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_yx => new bool4(x, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_gr => new bool4(x, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_ts => new bool4(x, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_yy => new bool4(x, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_gg => new bool4(x, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_tt => new bool4(x, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_yz => new bool4(x, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_gb => new bool4(x, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_tp => new bool4(x, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_yw => new bool4(x, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_ga => new bool4(x, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_tq => new bool4(x, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_z_ => new bool4(x, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_b_ => new bool4(x, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_p_ => new bool4(x, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_zx => new bool4(x, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_br => new bool4(x, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_ps => new bool4(x, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_zy => new bool4(x, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_bg => new bool4(x, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_pt => new bool4(x, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_zz => new bool4(x, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_bb => new bool4(x, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_pp => new bool4(x, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_zw => new bool4(x, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_ba => new bool4(x, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_pq => new bool4(x, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_w_ => new bool4(x, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_a_ => new bool4(x, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_q_ => new bool4(x, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_wx => new bool4(x, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_ar => new bool4(x, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_qs => new bool4(x, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_wy => new bool4(x, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_ag => new bool4(x, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_qt => new bool4(x, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_wz => new bool4(x, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_ab => new bool4(x, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_qp => new bool4(x, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 x_ww => new bool4(x, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 r_aa => new bool4(x, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 s_qq => new bool4(x, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xx__ => new bool4(x, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rr__ => new bool4(x, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ss__ => new bool4(x, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xx_x => new bool4(x, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rr_r => new bool4(x, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ss_s => new bool4(x, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xx_y => new bool4(x, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rr_g => new bool4(x, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ss_t => new bool4(x, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xx_z => new bool4(x, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rr_b => new bool4(x, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ss_p => new bool4(x, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xx_w => new bool4(x, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rr_a => new bool4(x, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ss_q => new bool4(x, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxx_ => new bool4(x, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrr_ => new bool4(x, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sss_ => new bool4(x, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxxx => new bool4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrrr => new bool4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssss => new bool4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxxy => new bool4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrrg => new bool4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssst => new bool4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxxz => new bool4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrrb => new bool4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sssp => new bool4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxxw => new bool4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrra => new bool4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sssq => new bool4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxy_ => new bool4(x, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrg_ => new bool4(x, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sst_ => new bool4(x, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxyx => new bool4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrgr => new bool4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssts => new bool4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxyy => new bool4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrgg => new bool4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sstt => new bool4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxyz => new bool4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrgb => new bool4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sstp => new bool4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxyw => new bool4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrga => new bool4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sstq => new bool4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxz_ => new bool4(x, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrb_ => new bool4(x, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssp_ => new bool4(x, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxzx => new bool4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrbr => new bool4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssps => new bool4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxzy => new bool4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrbg => new bool4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sspt => new bool4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxzz => new bool4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrbb => new bool4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sspp => new bool4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxzw => new bool4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrba => new bool4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sspq => new bool4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxw_ => new bool4(x, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rra_ => new bool4(x, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssq_ => new bool4(x, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxwx => new bool4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrar => new bool4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssqs => new bool4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxwy => new bool4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrag => new bool4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssqt => new bool4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxwz => new bool4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rrab => new bool4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssqp => new bool4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xxww => new bool4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rraa => new bool4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ssqq => new bool4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xy__ => new bool4(x, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rg__ => new bool4(x, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 st__ => new bool4(x, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xy_x => new bool4(x, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rg_r => new bool4(x, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 st_s => new bool4(x, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xy_y => new bool4(x, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rg_g => new bool4(x, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 st_t => new bool4(x, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xy_z => new bool4(x, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rg_b => new bool4(x, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 st_p => new bool4(x, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xy_w => new bool4(x, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rg_a => new bool4(x, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 st_q => new bool4(x, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyx_ => new bool4(x, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgr_ => new bool4(x, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sts_ => new bool4(x, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyxx => new bool4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgrr => new bool4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stss => new bool4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyxy => new bool4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgrg => new bool4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stst => new bool4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyxz => new bool4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgrb => new bool4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stsp => new bool4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyxw => new bool4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgra => new bool4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stsq => new bool4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyy_ => new bool4(x, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgg_ => new bool4(x, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stt_ => new bool4(x, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyyx => new bool4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rggr => new bool4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stts => new bool4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyyy => new bool4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rggg => new bool4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sttt => new bool4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyyz => new bool4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rggb => new bool4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sttp => new bool4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyyw => new bool4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgga => new bool4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sttq => new bool4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyz_ => new bool4(x, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgb_ => new bool4(x, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stp_ => new bool4(x, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyzx => new bool4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgbr => new bool4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stps => new bool4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyzy => new bool4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgbg => new bool4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stpt => new bool4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyzz => new bool4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgbb => new bool4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stpp => new bool4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 xyzw
        {
            readonly get => new bool4(x, y, z, w);
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 rgba
        {
            readonly get => new bool4(x, y, z, w);
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 stpq
        {
            readonly get => new bool4(x, y, z, w);
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyw_ => new bool4(x, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rga_ => new bool4(x, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stq_ => new bool4(x, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xywx => new bool4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgar => new bool4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stqs => new bool4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xywy => new bool4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgag => new bool4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stqt => new bool4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 xywz
        {
            readonly get => new bool4(x, y, w, z);
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 rgab
        {
            readonly get => new bool4(x, y, w, z);
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 stqp
        {
            readonly get => new bool4(x, y, w, z);
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xyww => new bool4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rgaa => new bool4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 stqq => new bool4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xz__ => new bool4(x, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rb__ => new bool4(x, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sp__ => new bool4(x, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xz_x => new bool4(x, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rb_r => new bool4(x, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sp_s => new bool4(x, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xz_y => new bool4(x, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rb_g => new bool4(x, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sp_t => new bool4(x, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xz_z => new bool4(x, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rb_b => new bool4(x, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sp_p => new bool4(x, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xz_w => new bool4(x, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rb_a => new bool4(x, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sp_q => new bool4(x, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzx_ => new bool4(x, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbr_ => new bool4(x, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sps_ => new bool4(x, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzxx => new bool4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbrr => new bool4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spss => new bool4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzxy => new bool4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbrg => new bool4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spst => new bool4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzxz => new bool4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbrb => new bool4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spsp => new bool4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzxw => new bool4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbra => new bool4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spsq => new bool4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzy_ => new bool4(x, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbg_ => new bool4(x, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spt_ => new bool4(x, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzyx => new bool4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbgr => new bool4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spts => new bool4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzyy => new bool4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbgg => new bool4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sptt => new bool4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzyz => new bool4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbgb => new bool4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sptp => new bool4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 xzyw
        {
            readonly get => new bool4(x, z, y, w);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 rbga
        {
            readonly get => new bool4(x, z, y, w);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 sptq
        {
            readonly get => new bool4(x, z, y, w);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzz_ => new bool4(x, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbb_ => new bool4(x, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spp_ => new bool4(x, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzzx => new bool4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbbr => new bool4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spps => new bool4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzzy => new bool4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbbg => new bool4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sppt => new bool4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzzz => new bool4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbbb => new bool4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sppp => new bool4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzzw => new bool4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbba => new bool4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sppq => new bool4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzw_ => new bool4(x, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rba_ => new bool4(x, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spq_ => new bool4(x, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzwx => new bool4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbar => new bool4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spqs => new bool4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 xzwy
        {
            readonly get => new bool4(x, z, w, y);
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 rbag
        {
            readonly get => new bool4(x, z, w, y);
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 spqt
        {
            readonly get => new bool4(x, z, w, y);
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzwz => new bool4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbab => new bool4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spqp => new bool4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xzww => new bool4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rbaa => new bool4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 spqq => new bool4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xw__ => new bool4(x, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ra__ => new bool4(x, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sq__ => new bool4(x, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xw_x => new bool4(x, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ra_r => new bool4(x, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sq_s => new bool4(x, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xw_y => new bool4(x, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ra_g => new bool4(x, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sq_t => new bool4(x, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xw_z => new bool4(x, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ra_b => new bool4(x, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sq_p => new bool4(x, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xw_w => new bool4(x, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ra_a => new bool4(x, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sq_q => new bool4(x, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwx_ => new bool4(x, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rar_ => new bool4(x, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqs_ => new bool4(x, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwxx => new bool4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rarr => new bool4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqss => new bool4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwxy => new bool4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rarg => new bool4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqst => new bool4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwxz => new bool4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rarb => new bool4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqsp => new bool4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwxw => new bool4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rara => new bool4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqsq => new bool4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwy_ => new bool4(x, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rag_ => new bool4(x, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqt_ => new bool4(x, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwyx => new bool4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ragr => new bool4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqts => new bool4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwyy => new bool4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ragg => new bool4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqtt => new bool4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 xwyz
        {
            readonly get => new bool4(x, w, y, z);
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 ragb
        {
            readonly get => new bool4(x, w, y, z);
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 sqtp
        {
            readonly get => new bool4(x, w, y, z);
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwyw => new bool4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raga => new bool4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqtq => new bool4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwz_ => new bool4(x, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rab_ => new bool4(x, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqp_ => new bool4(x, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwzx => new bool4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rabr => new bool4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqps => new bool4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 xwzy
        {
            readonly get => new bool4(x, w, z, y);
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 rabg
        {
            readonly get => new bool4(x, w, z, y);
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 sqpt
        {
            readonly get => new bool4(x, w, z, y);
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwzz => new bool4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 rabb => new bool4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqpp => new bool4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwzw => new bool4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raba => new bool4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqpq => new bool4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xww_ => new bool4(x, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raa_ => new bool4(x, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqq_ => new bool4(x, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwwx => new bool4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raar => new bool4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqqs => new bool4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwwy => new bool4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raag => new bool4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqqt => new bool4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwwz => new bool4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raab => new bool4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqqp => new bool4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 xwww => new bool4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 raaa => new bool4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 sqqq => new bool4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y___ => new bool4(y, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g___ => new bool4(y, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t___ => new bool4(y, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y__x => new bool4(y, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g__r => new bool4(y, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t__s => new bool4(y, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y__y => new bool4(y, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g__g => new bool4(y, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t__t => new bool4(y, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y__z => new bool4(y, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g__b => new bool4(y, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t__p => new bool4(y, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y__w => new bool4(y, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g__a => new bool4(y, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t__q => new bool4(y, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_x_ => new bool4(y, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_r_ => new bool4(y, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_s_ => new bool4(y, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_xx => new bool4(y, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_rr => new bool4(y, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_ss => new bool4(y, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_xy => new bool4(y, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_rg => new bool4(y, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_st => new bool4(y, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_xz => new bool4(y, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_rb => new bool4(y, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_sp => new bool4(y, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_xw => new bool4(y, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_ra => new bool4(y, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_sq => new bool4(y, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_y_ => new bool4(y, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_g_ => new bool4(y, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_t_ => new bool4(y, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_yx => new bool4(y, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_gr => new bool4(y, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_ts => new bool4(y, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_yy => new bool4(y, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_gg => new bool4(y, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_tt => new bool4(y, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_yz => new bool4(y, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_gb => new bool4(y, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_tp => new bool4(y, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_yw => new bool4(y, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_ga => new bool4(y, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_tq => new bool4(y, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_z_ => new bool4(y, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_b_ => new bool4(y, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_p_ => new bool4(y, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_zx => new bool4(y, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_br => new bool4(y, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_ps => new bool4(y, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_zy => new bool4(y, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_bg => new bool4(y, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_pt => new bool4(y, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_zz => new bool4(y, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_bb => new bool4(y, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_pp => new bool4(y, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_zw => new bool4(y, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_ba => new bool4(y, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_pq => new bool4(y, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_w_ => new bool4(y, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_a_ => new bool4(y, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_q_ => new bool4(y, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_wx => new bool4(y, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_ar => new bool4(y, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_qs => new bool4(y, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_wy => new bool4(y, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_ag => new bool4(y, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_qt => new bool4(y, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_wz => new bool4(y, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_ab => new bool4(y, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_qp => new bool4(y, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 y_ww => new bool4(y, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 g_aa => new bool4(y, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 t_qq => new bool4(y, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yx__ => new bool4(y, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gr__ => new bool4(y, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ts__ => new bool4(y, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yx_x => new bool4(y, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gr_r => new bool4(y, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ts_s => new bool4(y, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yx_y => new bool4(y, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gr_g => new bool4(y, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ts_t => new bool4(y, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yx_z => new bool4(y, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gr_b => new bool4(y, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ts_p => new bool4(y, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yx_w => new bool4(y, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gr_a => new bool4(y, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ts_q => new bool4(y, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxx_ => new bool4(y, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grr_ => new bool4(y, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tss_ => new bool4(y, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxxx => new bool4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grrr => new bool4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsss => new bool4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxxy => new bool4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grrg => new bool4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsst => new bool4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxxz => new bool4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grrb => new bool4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tssp => new bool4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxxw => new bool4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grra => new bool4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tssq => new bool4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxy_ => new bool4(y, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grg_ => new bool4(y, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tst_ => new bool4(y, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxyx => new bool4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grgr => new bool4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsts => new bool4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxyy => new bool4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grgg => new bool4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tstt => new bool4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxyz => new bool4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grgb => new bool4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tstp => new bool4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxyw => new bool4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grga => new bool4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tstq => new bool4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxz_ => new bool4(y, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grb_ => new bool4(y, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsp_ => new bool4(y, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxzx => new bool4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grbr => new bool4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsps => new bool4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxzy => new bool4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grbg => new bool4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tspt => new bool4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxzz => new bool4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grbb => new bool4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tspp => new bool4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 yxzw
        {
            readonly get => new bool4(y, x, z, w);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 grba
        {
            readonly get => new bool4(y, x, z, w);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 tspq
        {
            readonly get => new bool4(y, x, z, w);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxw_ => new bool4(y, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gra_ => new bool4(y, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsq_ => new bool4(y, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxwx => new bool4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grar => new bool4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsqs => new bool4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxwy => new bool4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 grag => new bool4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsqt => new bool4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 yxwz
        {
            readonly get => new bool4(y, x, w, z);
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 grab
        {
            readonly get => new bool4(y, x, w, z);
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 tsqp
        {
            readonly get => new bool4(y, x, w, z);
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yxww => new bool4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 graa => new bool4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tsqq => new bool4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yy__ => new bool4(y, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gg__ => new bool4(y, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tt__ => new bool4(y, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yy_x => new bool4(y, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gg_r => new bool4(y, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tt_s => new bool4(y, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yy_y => new bool4(y, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gg_g => new bool4(y, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tt_t => new bool4(y, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yy_z => new bool4(y, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gg_b => new bool4(y, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tt_p => new bool4(y, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yy_w => new bool4(y, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gg_a => new bool4(y, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tt_q => new bool4(y, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyx_ => new bool4(y, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggr_ => new bool4(y, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tts_ => new bool4(y, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyxx => new bool4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggrr => new bool4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttss => new bool4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyxy => new bool4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggrg => new bool4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttst => new bool4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyxz => new bool4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggrb => new bool4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttsp => new bool4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyxw => new bool4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggra => new bool4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttsq => new bool4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyy_ => new bool4(y, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggg_ => new bool4(y, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttt_ => new bool4(y, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyyx => new bool4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gggr => new bool4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttts => new bool4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyyy => new bool4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gggg => new bool4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tttt => new bool4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyyz => new bool4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gggb => new bool4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tttp => new bool4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyyw => new bool4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggga => new bool4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tttq => new bool4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyz_ => new bool4(y, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggb_ => new bool4(y, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttp_ => new bool4(y, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyzx => new bool4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggbr => new bool4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttps => new bool4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyzy => new bool4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggbg => new bool4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttpt => new bool4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyzz => new bool4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggbb => new bool4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttpp => new bool4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyzw => new bool4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggba => new bool4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttpq => new bool4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyw_ => new bool4(y, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gga_ => new bool4(y, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttq_ => new bool4(y, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yywx => new bool4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggar => new bool4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttqs => new bool4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yywy => new bool4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggag => new bool4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttqt => new bool4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yywz => new bool4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggab => new bool4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttqp => new bool4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yyww => new bool4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ggaa => new bool4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ttqq => new bool4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yz__ => new bool4(y, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gb__ => new bool4(y, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tp__ => new bool4(y, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yz_x => new bool4(y, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gb_r => new bool4(y, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tp_s => new bool4(y, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yz_y => new bool4(y, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gb_g => new bool4(y, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tp_t => new bool4(y, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yz_z => new bool4(y, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gb_b => new bool4(y, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tp_p => new bool4(y, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yz_w => new bool4(y, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gb_a => new bool4(y, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tp_q => new bool4(y, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzx_ => new bool4(y, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbr_ => new bool4(y, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tps_ => new bool4(y, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzxx => new bool4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbrr => new bool4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpss => new bool4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzxy => new bool4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbrg => new bool4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpst => new bool4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzxz => new bool4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbrb => new bool4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpsp => new bool4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 yzxw
        {
            readonly get => new bool4(y, z, x, w);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 gbra
        {
            readonly get => new bool4(y, z, x, w);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 tpsq
        {
            readonly get => new bool4(y, z, x, w);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzy_ => new bool4(y, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbg_ => new bool4(y, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpt_ => new bool4(y, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzyx => new bool4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbgr => new bool4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpts => new bool4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzyy => new bool4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbgg => new bool4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tptt => new bool4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzyz => new bool4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbgb => new bool4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tptp => new bool4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzyw => new bool4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbga => new bool4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tptq => new bool4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzz_ => new bool4(y, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbb_ => new bool4(y, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpp_ => new bool4(y, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzzx => new bool4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbbr => new bool4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpps => new bool4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzzy => new bool4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbbg => new bool4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tppt => new bool4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzzz => new bool4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbbb => new bool4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tppp => new bool4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzzw => new bool4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbba => new bool4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tppq => new bool4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzw_ => new bool4(y, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gba_ => new bool4(y, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpq_ => new bool4(y, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 yzwx
        {
            readonly get => new bool4(y, z, w, x);
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 gbar
        {
            readonly get => new bool4(y, z, w, x);
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 tpqs
        {
            readonly get => new bool4(y, z, w, x);
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzwy => new bool4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbag => new bool4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpqt => new bool4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzwz => new bool4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbab => new bool4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpqp => new bool4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yzww => new bool4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gbaa => new bool4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tpqq => new bool4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yw__ => new bool4(y, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ga__ => new bool4(y, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tq__ => new bool4(y, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yw_x => new bool4(y, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ga_r => new bool4(y, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tq_s => new bool4(y, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yw_y => new bool4(y, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ga_g => new bool4(y, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tq_t => new bool4(y, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yw_z => new bool4(y, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ga_b => new bool4(y, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tq_p => new bool4(y, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yw_w => new bool4(y, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ga_a => new bool4(y, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tq_q => new bool4(y, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywx_ => new bool4(y, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gar_ => new bool4(y, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqs_ => new bool4(y, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywxx => new bool4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 garr => new bool4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqss => new bool4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywxy => new bool4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 garg => new bool4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqst => new bool4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 ywxz
        {
            readonly get => new bool4(y, w, x, z);
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 garb
        {
            readonly get => new bool4(y, w, x, z);
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 tqsp
        {
            readonly get => new bool4(y, w, x, z);
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywxw => new bool4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gara => new bool4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqsq => new bool4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywy_ => new bool4(y, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gag_ => new bool4(y, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqt_ => new bool4(y, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywyx => new bool4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gagr => new bool4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqts => new bool4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywyy => new bool4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gagg => new bool4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqtt => new bool4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywyz => new bool4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gagb => new bool4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqtp => new bool4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywyw => new bool4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaga => new bool4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqtq => new bool4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywz_ => new bool4(y, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gab_ => new bool4(y, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqp_ => new bool4(y, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 ywzx
        {
            readonly get => new bool4(y, w, z, x);
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 gabr
        {
            readonly get => new bool4(y, w, z, x);
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 tqps
        {
            readonly get => new bool4(y, w, z, x);
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywzy => new bool4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gabg => new bool4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqpt => new bool4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywzz => new bool4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gabb => new bool4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqpp => new bool4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywzw => new bool4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaba => new bool4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqpq => new bool4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 yww_ => new bool4(y, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaa_ => new bool4(y, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqq_ => new bool4(y, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywwx => new bool4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaar => new bool4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqqs => new bool4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywwy => new bool4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaag => new bool4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqqt => new bool4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywwz => new bool4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaab => new bool4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqqp => new bool4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ywww => new bool4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 gaaa => new bool4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 tqqq => new bool4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z___ => new bool4(z, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b___ => new bool4(z, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p___ => new bool4(z, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z__x => new bool4(z, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b__r => new bool4(z, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p__s => new bool4(z, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z__y => new bool4(z, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b__g => new bool4(z, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p__t => new bool4(z, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z__z => new bool4(z, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b__b => new bool4(z, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p__p => new bool4(z, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z__w => new bool4(z, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b__a => new bool4(z, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p__q => new bool4(z, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_x_ => new bool4(z, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_r_ => new bool4(z, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_s_ => new bool4(z, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_xx => new bool4(z, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_rr => new bool4(z, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_ss => new bool4(z, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_xy => new bool4(z, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_rg => new bool4(z, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_st => new bool4(z, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_xz => new bool4(z, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_rb => new bool4(z, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_sp => new bool4(z, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_xw => new bool4(z, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_ra => new bool4(z, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_sq => new bool4(z, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_y_ => new bool4(z, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_g_ => new bool4(z, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_t_ => new bool4(z, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_yx => new bool4(z, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_gr => new bool4(z, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_ts => new bool4(z, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_yy => new bool4(z, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_gg => new bool4(z, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_tt => new bool4(z, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_yz => new bool4(z, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_gb => new bool4(z, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_tp => new bool4(z, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_yw => new bool4(z, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_ga => new bool4(z, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_tq => new bool4(z, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_z_ => new bool4(z, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_b_ => new bool4(z, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_p_ => new bool4(z, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_zx => new bool4(z, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_br => new bool4(z, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_ps => new bool4(z, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_zy => new bool4(z, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_bg => new bool4(z, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_pt => new bool4(z, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_zz => new bool4(z, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_bb => new bool4(z, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_pp => new bool4(z, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_zw => new bool4(z, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_ba => new bool4(z, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_pq => new bool4(z, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_w_ => new bool4(z, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_a_ => new bool4(z, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_q_ => new bool4(z, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_wx => new bool4(z, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_ar => new bool4(z, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_qs => new bool4(z, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_wy => new bool4(z, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_ag => new bool4(z, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_qt => new bool4(z, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_wz => new bool4(z, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_ab => new bool4(z, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_qp => new bool4(z, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 z_ww => new bool4(z, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 b_aa => new bool4(z, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 p_qq => new bool4(z, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zx__ => new bool4(z, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 br__ => new bool4(z, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ps__ => new bool4(z, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zx_x => new bool4(z, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 br_r => new bool4(z, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ps_s => new bool4(z, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zx_y => new bool4(z, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 br_g => new bool4(z, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ps_t => new bool4(z, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zx_z => new bool4(z, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 br_b => new bool4(z, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ps_p => new bool4(z, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zx_w => new bool4(z, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 br_a => new bool4(z, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ps_q => new bool4(z, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxx_ => new bool4(z, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brr_ => new bool4(z, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pss_ => new bool4(z, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxxx => new bool4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brrr => new bool4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psss => new bool4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxxy => new bool4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brrg => new bool4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psst => new bool4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxxz => new bool4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brrb => new bool4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pssp => new bool4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxxw => new bool4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brra => new bool4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pssq => new bool4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxy_ => new bool4(z, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brg_ => new bool4(z, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pst_ => new bool4(z, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxyx => new bool4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brgr => new bool4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psts => new bool4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxyy => new bool4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brgg => new bool4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pstt => new bool4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxyz => new bool4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brgb => new bool4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pstp => new bool4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 zxyw
        {
            readonly get => new bool4(z, x, y, w);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 brga
        {
            readonly get => new bool4(z, x, y, w);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 pstq
        {
            readonly get => new bool4(z, x, y, w);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxz_ => new bool4(z, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brb_ => new bool4(z, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psp_ => new bool4(z, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxzx => new bool4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brbr => new bool4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psps => new bool4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxzy => new bool4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brbg => new bool4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pspt => new bool4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxzz => new bool4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brbb => new bool4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pspp => new bool4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxzw => new bool4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brba => new bool4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pspq => new bool4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxw_ => new bool4(z, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bra_ => new bool4(z, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psq_ => new bool4(z, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxwx => new bool4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brar => new bool4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psqs => new bool4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 zxwy
        {
            readonly get => new bool4(z, x, w, y);
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 brag
        {
            readonly get => new bool4(z, x, w, y);
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 psqt
        {
            readonly get => new bool4(z, x, w, y);
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxwz => new bool4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 brab => new bool4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psqp => new bool4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zxww => new bool4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 braa => new bool4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 psqq => new bool4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zy__ => new bool4(z, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bg__ => new bool4(z, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pt__ => new bool4(z, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zy_x => new bool4(z, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bg_r => new bool4(z, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pt_s => new bool4(z, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zy_y => new bool4(z, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bg_g => new bool4(z, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pt_t => new bool4(z, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zy_z => new bool4(z, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bg_b => new bool4(z, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pt_p => new bool4(z, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zy_w => new bool4(z, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bg_a => new bool4(z, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pt_q => new bool4(z, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyx_ => new bool4(z, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgr_ => new bool4(z, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pts_ => new bool4(z, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyxx => new bool4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgrr => new bool4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptss => new bool4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyxy => new bool4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgrg => new bool4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptst => new bool4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyxz => new bool4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgrb => new bool4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptsp => new bool4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 zyxw
        {
            readonly get => new bool4(z, y, x, w);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 bgra
        {
            readonly get => new bool4(z, y, x, w);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 ptsq
        {
            readonly get => new bool4(z, y, x, w);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyy_ => new bool4(z, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgg_ => new bool4(z, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptt_ => new bool4(z, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyyx => new bool4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bggr => new bool4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptts => new bool4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyyy => new bool4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bggg => new bool4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pttt => new bool4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyyz => new bool4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bggb => new bool4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pttp => new bool4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyyw => new bool4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgga => new bool4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pttq => new bool4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyz_ => new bool4(z, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgb_ => new bool4(z, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptp_ => new bool4(z, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyzx => new bool4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgbr => new bool4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptps => new bool4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyzy => new bool4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgbg => new bool4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptpt => new bool4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyzz => new bool4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgbb => new bool4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptpp => new bool4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyzw => new bool4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgba => new bool4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptpq => new bool4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyw_ => new bool4(z, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bga_ => new bool4(z, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptq_ => new bool4(z, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 zywx
        {
            readonly get => new bool4(z, y, w, x);
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 bgar
        {
            readonly get => new bool4(z, y, w, x);
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 ptqs
        {
            readonly get => new bool4(z, y, w, x);
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zywy => new bool4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgag => new bool4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptqt => new bool4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zywz => new bool4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgab => new bool4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptqp => new bool4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zyww => new bool4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bgaa => new bool4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ptqq => new bool4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zz__ => new bool4(z, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bb__ => new bool4(z, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pp__ => new bool4(z, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zz_x => new bool4(z, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bb_r => new bool4(z, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pp_s => new bool4(z, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zz_y => new bool4(z, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bb_g => new bool4(z, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pp_t => new bool4(z, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zz_z => new bool4(z, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bb_b => new bool4(z, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pp_p => new bool4(z, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zz_w => new bool4(z, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bb_a => new bool4(z, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pp_q => new bool4(z, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzx_ => new bool4(z, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbr_ => new bool4(z, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pps_ => new bool4(z, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzxx => new bool4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbrr => new bool4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppss => new bool4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzxy => new bool4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbrg => new bool4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppst => new bool4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzxz => new bool4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbrb => new bool4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppsp => new bool4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzxw => new bool4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbra => new bool4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppsq => new bool4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzy_ => new bool4(z, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbg_ => new bool4(z, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppt_ => new bool4(z, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzyx => new bool4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbgr => new bool4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppts => new bool4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzyy => new bool4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbgg => new bool4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pptt => new bool4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzyz => new bool4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbgb => new bool4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pptp => new bool4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzyw => new bool4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbga => new bool4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pptq => new bool4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzz_ => new bool4(z, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbb_ => new bool4(z, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppp_ => new bool4(z, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzzx => new bool4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbbr => new bool4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppps => new bool4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzzy => new bool4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbbg => new bool4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pppt => new bool4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzzz => new bool4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbbb => new bool4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pppp => new bool4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzzw => new bool4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbba => new bool4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pppq => new bool4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzw_ => new bool4(z, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bba_ => new bool4(z, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppq_ => new bool4(z, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzwx => new bool4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbar => new bool4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppqs => new bool4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzwy => new bool4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbag => new bool4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppqt => new bool4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzwz => new bool4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbab => new bool4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppqp => new bool4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zzww => new bool4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bbaa => new bool4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ppqq => new bool4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zw__ => new bool4(z, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ba__ => new bool4(z, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pq__ => new bool4(z, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zw_x => new bool4(z, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ba_r => new bool4(z, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pq_s => new bool4(z, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zw_y => new bool4(z, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ba_g => new bool4(z, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pq_t => new bool4(z, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zw_z => new bool4(z, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ba_b => new bool4(z, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pq_p => new bool4(z, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zw_w => new bool4(z, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ba_a => new bool4(z, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pq_q => new bool4(z, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwx_ => new bool4(z, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bar_ => new bool4(z, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqs_ => new bool4(z, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwxx => new bool4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 barr => new bool4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqss => new bool4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 zwxy
        {
            readonly get => new bool4(z, w, x, y);
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 barg
        {
            readonly get => new bool4(z, w, x, y);
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 pqst
        {
            readonly get => new bool4(z, w, x, y);
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwxz => new bool4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 barb => new bool4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqsp => new bool4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwxw => new bool4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bara => new bool4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqsq => new bool4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwy_ => new bool4(z, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bag_ => new bool4(z, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqt_ => new bool4(z, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 zwyx
        {
            readonly get => new bool4(z, w, y, x);
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 bagr
        {
            readonly get => new bool4(z, w, y, x);
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 pqts
        {
            readonly get => new bool4(z, w, y, x);
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwyy => new bool4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bagg => new bool4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqtt => new bool4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwyz => new bool4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bagb => new bool4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqtp => new bool4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwyw => new bool4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baga => new bool4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqtq => new bool4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwz_ => new bool4(z, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 bab_ => new bool4(z, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqp_ => new bool4(z, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwzx => new bool4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 babr => new bool4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqps => new bool4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwzy => new bool4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 babg => new bool4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqpt => new bool4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwzz => new bool4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 babb => new bool4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqpp => new bool4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwzw => new bool4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baba => new bool4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqpq => new bool4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zww_ => new bool4(z, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baa_ => new bool4(z, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqq_ => new bool4(z, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwwx => new bool4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baar => new bool4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqqs => new bool4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwwy => new bool4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baag => new bool4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqqt => new bool4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwwz => new bool4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baab => new bool4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqqp => new bool4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 zwww => new bool4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 baaa => new bool4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 pqqq => new bool4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w___ => new bool4(w, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a___ => new bool4(w, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q___ => new bool4(w, false, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w__x => new bool4(w, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a__r => new bool4(w, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q__s => new bool4(w, false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w__y => new bool4(w, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a__g => new bool4(w, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q__t => new bool4(w, false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w__z => new bool4(w, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a__b => new bool4(w, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q__p => new bool4(w, false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w__w => new bool4(w, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a__a => new bool4(w, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q__q => new bool4(w, false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_x_ => new bool4(w, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_r_ => new bool4(w, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_s_ => new bool4(w, false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_xx => new bool4(w, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_rr => new bool4(w, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_ss => new bool4(w, false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_xy => new bool4(w, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_rg => new bool4(w, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_st => new bool4(w, false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_xz => new bool4(w, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_rb => new bool4(w, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_sp => new bool4(w, false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_xw => new bool4(w, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_ra => new bool4(w, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_sq => new bool4(w, false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_y_ => new bool4(w, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_g_ => new bool4(w, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_t_ => new bool4(w, false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_yx => new bool4(w, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_gr => new bool4(w, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_ts => new bool4(w, false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_yy => new bool4(w, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_gg => new bool4(w, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_tt => new bool4(w, false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_yz => new bool4(w, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_gb => new bool4(w, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_tp => new bool4(w, false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_yw => new bool4(w, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_ga => new bool4(w, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_tq => new bool4(w, false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_z_ => new bool4(w, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_b_ => new bool4(w, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_p_ => new bool4(w, false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_zx => new bool4(w, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_br => new bool4(w, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_ps => new bool4(w, false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_zy => new bool4(w, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_bg => new bool4(w, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_pt => new bool4(w, false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_zz => new bool4(w, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_bb => new bool4(w, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_pp => new bool4(w, false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_zw => new bool4(w, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_ba => new bool4(w, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_pq => new bool4(w, false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_w_ => new bool4(w, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_a_ => new bool4(w, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_q_ => new bool4(w, false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_wx => new bool4(w, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_ar => new bool4(w, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_qs => new bool4(w, false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_wy => new bool4(w, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_ag => new bool4(w, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_qt => new bool4(w, false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_wz => new bool4(w, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_ab => new bool4(w, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_qp => new bool4(w, false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 w_ww => new bool4(w, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 a_aa => new bool4(w, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 q_qq => new bool4(w, false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wx__ => new bool4(w, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ar__ => new bool4(w, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qs__ => new bool4(w, x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wx_x => new bool4(w, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ar_r => new bool4(w, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qs_s => new bool4(w, x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wx_y => new bool4(w, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ar_g => new bool4(w, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qs_t => new bool4(w, x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wx_z => new bool4(w, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ar_b => new bool4(w, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qs_p => new bool4(w, x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wx_w => new bool4(w, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ar_a => new bool4(w, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qs_q => new bool4(w, x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxx_ => new bool4(w, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arr_ => new bool4(w, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qss_ => new bool4(w, x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxxx => new bool4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arrr => new bool4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsss => new bool4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxxy => new bool4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arrg => new bool4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsst => new bool4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxxz => new bool4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arrb => new bool4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qssp => new bool4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxxw => new bool4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arra => new bool4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qssq => new bool4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxy_ => new bool4(w, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arg_ => new bool4(w, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qst_ => new bool4(w, x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxyx => new bool4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 argr => new bool4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsts => new bool4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxyy => new bool4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 argg => new bool4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qstt => new bool4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 wxyz
        {
            readonly get => new bool4(w, x, y, z);
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 argb
        {
            readonly get => new bool4(w, x, y, z);
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 qstp
        {
            readonly get => new bool4(w, x, y, z);
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxyw => new bool4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arga => new bool4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qstq => new bool4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxz_ => new bool4(w, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arb_ => new bool4(w, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsp_ => new bool4(w, x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxzx => new bool4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arbr => new bool4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsps => new bool4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 wxzy
        {
            readonly get => new bool4(w, x, z, y);
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 arbg
        {
            readonly get => new bool4(w, x, z, y);
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 qspt
        {
            readonly get => new bool4(w, x, z, y);
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxzz => new bool4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arbb => new bool4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qspp => new bool4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxzw => new bool4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arba => new bool4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qspq => new bool4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxw_ => new bool4(w, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ara_ => new bool4(w, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsq_ => new bool4(w, x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxwx => new bool4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arar => new bool4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsqs => new bool4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxwy => new bool4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arag => new bool4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsqt => new bool4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxwz => new bool4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 arab => new bool4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsqp => new bool4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wxww => new bool4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 araa => new bool4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qsqq => new bool4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wy__ => new bool4(w, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ag__ => new bool4(w, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qt__ => new bool4(w, y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wy_x => new bool4(w, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ag_r => new bool4(w, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qt_s => new bool4(w, y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wy_y => new bool4(w, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ag_g => new bool4(w, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qt_t => new bool4(w, y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wy_z => new bool4(w, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ag_b => new bool4(w, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qt_p => new bool4(w, y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wy_w => new bool4(w, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ag_a => new bool4(w, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qt_q => new bool4(w, y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyx_ => new bool4(w, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agr_ => new bool4(w, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qts_ => new bool4(w, y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyxx => new bool4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agrr => new bool4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtss => new bool4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyxy => new bool4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agrg => new bool4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtst => new bool4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 wyxz
        {
            readonly get => new bool4(w, y, x, z);
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 agrb
        {
            readonly get => new bool4(w, y, x, z);
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 qtsp
        {
            readonly get => new bool4(w, y, x, z);
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyxw => new bool4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agra => new bool4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtsq => new bool4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyy_ => new bool4(w, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agg_ => new bool4(w, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtt_ => new bool4(w, y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyyx => new bool4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aggr => new bool4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtts => new bool4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyyy => new bool4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aggg => new bool4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qttt => new bool4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyyz => new bool4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aggb => new bool4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qttp => new bool4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyyw => new bool4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agga => new bool4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qttq => new bool4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyz_ => new bool4(w, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agb_ => new bool4(w, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtp_ => new bool4(w, y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 wyzx
        {
            readonly get => new bool4(w, y, z, x);
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 agbr
        {
            readonly get => new bool4(w, y, z, x);
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 qtps
        {
            readonly get => new bool4(w, y, z, x);
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyzy => new bool4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agbg => new bool4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtpt => new bool4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyzz => new bool4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agbb => new bool4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtpp => new bool4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyzw => new bool4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agba => new bool4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtpq => new bool4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyw_ => new bool4(w, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aga_ => new bool4(w, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtq_ => new bool4(w, y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wywx => new bool4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agar => new bool4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtqs => new bool4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wywy => new bool4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agag => new bool4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtqt => new bool4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wywz => new bool4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agab => new bool4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtqp => new bool4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wyww => new bool4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 agaa => new bool4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qtqq => new bool4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wz__ => new bool4(w, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ab__ => new bool4(w, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qp__ => new bool4(w, z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wz_x => new bool4(w, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ab_r => new bool4(w, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qp_s => new bool4(w, z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wz_y => new bool4(w, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ab_g => new bool4(w, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qp_t => new bool4(w, z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wz_z => new bool4(w, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ab_b => new bool4(w, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qp_p => new bool4(w, z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wz_w => new bool4(w, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ab_a => new bool4(w, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qp_q => new bool4(w, z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzx_ => new bool4(w, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abr_ => new bool4(w, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qps_ => new bool4(w, z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzxx => new bool4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abrr => new bool4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpss => new bool4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 wzxy
        {
            readonly get => new bool4(w, z, x, y);
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 abrg
        {
            readonly get => new bool4(w, z, x, y);
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 qpst
        {
            readonly get => new bool4(w, z, x, y);
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzxz => new bool4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abrb => new bool4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpsp => new bool4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzxw => new bool4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abra => new bool4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpsq => new bool4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzy_ => new bool4(w, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abg_ => new bool4(w, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpt_ => new bool4(w, z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 wzyx
        {
            readonly get => new bool4(w, z, y, x);
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 abgr
        {
            readonly get => new bool4(w, z, y, x);
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool4 qpts
        {
            readonly get => new bool4(w, z, y, x);
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzyy => new bool4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abgg => new bool4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qptt => new bool4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzyz => new bool4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abgb => new bool4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qptp => new bool4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzyw => new bool4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abga => new bool4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qptq => new bool4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzz_ => new bool4(w, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abb_ => new bool4(w, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpp_ => new bool4(w, z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzzx => new bool4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abbr => new bool4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpps => new bool4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzzy => new bool4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abbg => new bool4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qppt => new bool4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzzz => new bool4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abbb => new bool4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qppp => new bool4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzzw => new bool4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abba => new bool4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qppq => new bool4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzw_ => new bool4(w, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aba_ => new bool4(w, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpq_ => new bool4(w, z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzwx => new bool4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abar => new bool4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpqs => new bool4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzwy => new bool4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abag => new bool4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpqt => new bool4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzwz => new bool4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abab => new bool4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpqp => new bool4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wzww => new bool4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 abaa => new bool4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qpqq => new bool4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ww__ => new bool4(w, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aa__ => new bool4(w, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qq__ => new bool4(w, w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ww_x => new bool4(w, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aa_r => new bool4(w, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qq_s => new bool4(w, w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ww_y => new bool4(w, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aa_g => new bool4(w, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qq_t => new bool4(w, w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ww_z => new bool4(w, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aa_b => new bool4(w, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qq_p => new bool4(w, w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 ww_w => new bool4(w, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aa_a => new bool4(w, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qq_q => new bool4(w, w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwx_ => new bool4(w, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aar_ => new bool4(w, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqs_ => new bool4(w, w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwxx => new bool4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aarr => new bool4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqss => new bool4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwxy => new bool4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aarg => new bool4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqst => new bool4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwxz => new bool4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aarb => new bool4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqsp => new bool4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwxw => new bool4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aara => new bool4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqsq => new bool4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwy_ => new bool4(w, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aag_ => new bool4(w, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqt_ => new bool4(w, w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwyx => new bool4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aagr => new bool4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqts => new bool4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwyy => new bool4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aagg => new bool4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqtt => new bool4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwyz => new bool4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aagb => new bool4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqtp => new bool4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwyw => new bool4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaga => new bool4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqtq => new bool4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwz_ => new bool4(w, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aab_ => new bool4(w, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqp_ => new bool4(w, w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwzx => new bool4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aabr => new bool4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqps => new bool4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwzy => new bool4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aabg => new bool4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqpt => new bool4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwzz => new bool4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aabb => new bool4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqpp => new bool4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwzw => new bool4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaba => new bool4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqpq => new bool4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 www_ => new bool4(w, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaa_ => new bool4(w, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqq_ => new bool4(w, w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwwx => new bool4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaar => new bool4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqqs => new bool4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwwy => new bool4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaag => new bool4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqqt => new bool4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwwz => new bool4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaab => new bool4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqqp => new bool4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 wwww => new bool4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 aaaa => new bool4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool4 qqqq => new bool4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __x => new bool3(false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __r => new bool3(false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __s => new bool3(false, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __y => new bool3(false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __g => new bool3(false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __t => new bool3(false, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __z => new bool3(false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __b => new bool3(false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __p => new bool3(false, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __w => new bool3(false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __a => new bool3(false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 __q => new bool3(false, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _x_ => new bool3(false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _r_ => new bool3(false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _s_ => new bool3(false, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _xx => new bool3(false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _rr => new bool3(false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ss => new bool3(false, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _xy => new bool3(false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _rg => new bool3(false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _st => new bool3(false, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _xz => new bool3(false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _rb => new bool3(false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _sp => new bool3(false, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _xw => new bool3(false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ra => new bool3(false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _sq => new bool3(false, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _y_ => new bool3(false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _g_ => new bool3(false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _t_ => new bool3(false, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _yx => new bool3(false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _gr => new bool3(false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ts => new bool3(false, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _yy => new bool3(false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _gg => new bool3(false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _tt => new bool3(false, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _yz => new bool3(false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _gb => new bool3(false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _tp => new bool3(false, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _yw => new bool3(false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ga => new bool3(false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _tq => new bool3(false, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _z_ => new bool3(false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _b_ => new bool3(false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _p_ => new bool3(false, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _zx => new bool3(false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _br => new bool3(false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ps => new bool3(false, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _zy => new bool3(false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _bg => new bool3(false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _pt => new bool3(false, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _zz => new bool3(false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _bb => new bool3(false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _pp => new bool3(false, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _zw => new bool3(false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ba => new bool3(false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _pq => new bool3(false, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _w_ => new bool3(false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _a_ => new bool3(false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _q_ => new bool3(false, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _wx => new bool3(false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ar => new bool3(false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _qs => new bool3(false, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _wy => new bool3(false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ag => new bool3(false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _qt => new bool3(false, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _wz => new bool3(false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ab => new bool3(false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _qp => new bool3(false, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _ww => new bool3(false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _aa => new bool3(false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 _qq => new bool3(false, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 x__ => new bool3(x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 r__ => new bool3(x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 s__ => new bool3(x, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 x_x => new bool3(x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 r_r => new bool3(x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 s_s => new bool3(x, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 x_y => new bool3(x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 r_g => new bool3(x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 s_t => new bool3(x, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 x_z => new bool3(x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 r_b => new bool3(x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 s_p => new bool3(x, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 x_w => new bool3(x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 r_a => new bool3(x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 s_q => new bool3(x, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xx_ => new bool3(x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rr_ => new bool3(x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ss_ => new bool3(x, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xxx => new bool3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rrr => new bool3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sss => new bool3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xxy => new bool3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rrg => new bool3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sst => new bool3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xxz => new bool3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rrb => new bool3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ssp => new bool3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xxw => new bool3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rra => new bool3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ssq => new bool3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xy_ => new bool3(x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rg_ => new bool3(x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 st_ => new bool3(x, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xyx => new bool3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rgr => new bool3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sts => new bool3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xyy => new bool3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rgg => new bool3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 stt => new bool3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 xyz
        {
            readonly get => new bool3(x, y, z);
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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 rgb
        {
            readonly get => new bool3(x, y, z);
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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 stp
        {
            readonly get => new bool3(x, y, z);
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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 xyw
        {
            readonly get => new bool3(x, y, w);
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 rga
        {
            readonly get => new bool3(x, y, w);
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 stq
        {
            readonly get => new bool3(x, y, w);
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xz_ => new bool3(x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rb_ => new bool3(x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sp_ => new bool3(x, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xzx => new bool3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rbr => new bool3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sps => new bool3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 xzy
        {
            readonly get => new bool3(x, z, y);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 rbg
        {
            readonly get => new bool3(x, z, y);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 spt
        {
            readonly get => new bool3(x, z, y);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xzz => new bool3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rbb => new bool3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 spp => new bool3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 xzw
        {
            readonly get => new bool3(x, z, w);
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 rba
        {
            readonly get => new bool3(x, z, w);
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 spq
        {
            readonly get => new bool3(x, z, w);
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xw_ => new bool3(x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ra_ => new bool3(x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sq_ => new bool3(x, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xwx => new bool3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 rar => new bool3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sqs => new bool3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 xwy
        {
            readonly get => new bool3(x, w, y);
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 rag
        {
            readonly get => new bool3(x, w, y);
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 sqt
        {
            readonly get => new bool3(x, w, y);
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 xwz
        {
            readonly get => new bool3(x, w, z);
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 rab
        {
            readonly get => new bool3(x, w, z);
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 sqp
        {
            readonly get => new bool3(x, w, z);
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 xww => new bool3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 raa => new bool3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 sqq => new bool3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 y__ => new bool3(y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 g__ => new bool3(y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 t__ => new bool3(y, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 y_x => new bool3(y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 g_r => new bool3(y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 t_s => new bool3(y, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 y_y => new bool3(y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 g_g => new bool3(y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 t_t => new bool3(y, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 y_z => new bool3(y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 g_b => new bool3(y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 t_p => new bool3(y, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 y_w => new bool3(y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 g_a => new bool3(y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 t_q => new bool3(y, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yx_ => new bool3(y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gr_ => new bool3(y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ts_ => new bool3(y, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yxx => new bool3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 grr => new bool3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tss => new bool3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yxy => new bool3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 grg => new bool3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tst => new bool3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 yxz
        {
            readonly get => new bool3(y, x, z);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 grb
        {
            readonly get => new bool3(y, x, z);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 tsp
        {
            readonly get => new bool3(y, x, z);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 yxw
        {
            readonly get => new bool3(y, x, w);
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 gra
        {
            readonly get => new bool3(y, x, w);
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 tsq
        {
            readonly get => new bool3(y, x, w);
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yy_ => new bool3(y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gg_ => new bool3(y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tt_ => new bool3(y, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yyx => new bool3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ggr => new bool3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tts => new bool3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yyy => new bool3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ggg => new bool3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ttt => new bool3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yyz => new bool3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ggb => new bool3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ttp => new bool3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yyw => new bool3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gga => new bool3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ttq => new bool3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yz_ => new bool3(y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gb_ => new bool3(y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tp_ => new bool3(y, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 yzx
        {
            readonly get => new bool3(y, z, x);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 gbr
        {
            readonly get => new bool3(y, z, x);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 tps
        {
            readonly get => new bool3(y, z, x);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yzy => new bool3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gbg => new bool3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tpt => new bool3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yzz => new bool3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gbb => new bool3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tpp => new bool3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 yzw
        {
            readonly get => new bool3(y, z, w);
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 gba
        {
            readonly get => new bool3(y, z, w);
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 tpq
        {
            readonly get => new bool3(y, z, w);
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yw_ => new bool3(y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ga_ => new bool3(y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tq_ => new bool3(y, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 ywx
        {
            readonly get => new bool3(y, w, x);
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 gar
        {
            readonly get => new bool3(y, w, x);
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 tqs
        {
            readonly get => new bool3(y, w, x);
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ywy => new bool3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gag => new bool3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tqt => new bool3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 ywz
        {
            readonly get => new bool3(y, w, z);
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 gab
        {
            readonly get => new bool3(y, w, z);
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 tqp
        {
            readonly get => new bool3(y, w, z);
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 yww => new bool3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 gaa => new bool3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 tqq => new bool3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 z__ => new bool3(z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 b__ => new bool3(z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 p__ => new bool3(z, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 z_x => new bool3(z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 b_r => new bool3(z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 p_s => new bool3(z, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 z_y => new bool3(z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 b_g => new bool3(z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 p_t => new bool3(z, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 z_z => new bool3(z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 b_b => new bool3(z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 p_p => new bool3(z, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 z_w => new bool3(z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 b_a => new bool3(z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 p_q => new bool3(z, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zx_ => new bool3(z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 br_ => new bool3(z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ps_ => new bool3(z, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zxx => new bool3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 brr => new bool3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pss => new bool3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 zxy
        {
            readonly get => new bool3(z, x, y);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 brg
        {
            readonly get => new bool3(z, x, y);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 pst
        {
            readonly get => new bool3(z, x, y);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zxz => new bool3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 brb => new bool3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 psp => new bool3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 zxw
        {
            readonly get => new bool3(z, x, w);
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 bra
        {
            readonly get => new bool3(z, x, w);
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 psq
        {
            readonly get => new bool3(z, x, w);
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zy_ => new bool3(z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bg_ => new bool3(z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pt_ => new bool3(z, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 zyx
        {
            readonly get => new bool3(z, y, x);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 bgr
        {
            readonly get => new bool3(z, y, x);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 pts
        {
            readonly get => new bool3(z, y, x);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zyy => new bool3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bgg => new bool3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ptt => new bool3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zyz => new bool3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bgb => new bool3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ptp => new bool3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 zyw
        {
            readonly get => new bool3(z, y, w);
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 bga
        {
            readonly get => new bool3(z, y, w);
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 ptq
        {
            readonly get => new bool3(z, y, w);
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zz_ => new bool3(z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bb_ => new bool3(z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pp_ => new bool3(z, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zzx => new bool3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bbr => new bool3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pps => new bool3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zzy => new bool3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bbg => new bool3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ppt => new bool3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zzz => new bool3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bbb => new bool3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ppp => new bool3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zzw => new bool3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bba => new bool3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ppq => new bool3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zw_ => new bool3(z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ba_ => new bool3(z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pq_ => new bool3(z, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 zwx
        {
            readonly get => new bool3(z, w, x);
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 bar
        {
            readonly get => new bool3(z, w, x);
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 pqs
        {
            readonly get => new bool3(z, w, x);
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 zwy
        {
            readonly get => new bool3(z, w, y);
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 bag
        {
            readonly get => new bool3(z, w, y);
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 pqt
        {
            readonly get => new bool3(z, w, y);
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zwz => new bool3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 bab => new bool3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pqp => new bool3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 zww => new bool3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 baa => new bool3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 pqq => new bool3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 w__ => new bool3(w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 a__ => new bool3(w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 q__ => new bool3(w, false, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 w_x => new bool3(w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 a_r => new bool3(w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 q_s => new bool3(w, false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 w_y => new bool3(w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 a_g => new bool3(w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 q_t => new bool3(w, false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 w_z => new bool3(w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 a_b => new bool3(w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 q_p => new bool3(w, false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 w_w => new bool3(w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 a_a => new bool3(w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 q_q => new bool3(w, false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wx_ => new bool3(w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ar_ => new bool3(w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qs_ => new bool3(w, x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wxx => new bool3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 arr => new bool3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qss => new bool3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 wxy
        {
            readonly get => new bool3(w, x, y);
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 arg
        {
            readonly get => new bool3(w, x, y);
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 qst
        {
            readonly get => new bool3(w, x, y);
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 wxz
        {
            readonly get => new bool3(w, x, z);
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 arb
        {
            readonly get => new bool3(w, x, z);
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 qsp
        {
            readonly get => new bool3(w, x, z);
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wxw => new bool3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ara => new bool3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qsq => new bool3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wy_ => new bool3(w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ag_ => new bool3(w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qt_ => new bool3(w, y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 wyx
        {
            readonly get => new bool3(w, y, x);
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 agr
        {
            readonly get => new bool3(w, y, x);
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 qts
        {
            readonly get => new bool3(w, y, x);
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wyy => new bool3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 agg => new bool3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qtt => new bool3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 wyz
        {
            readonly get => new bool3(w, y, z);
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 agb
        {
            readonly get => new bool3(w, y, z);
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 qtp
        {
            readonly get => new bool3(w, y, z);
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wyw => new bool3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aga => new bool3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qtq => new bool3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wz_ => new bool3(w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ab_ => new bool3(w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qp_ => new bool3(w, z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 wzx
        {
            readonly get => new bool3(w, z, x);
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 abr
        {
            readonly get => new bool3(w, z, x);
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 qps
        {
            readonly get => new bool3(w, z, x);
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 wzy
        {
            readonly get => new bool3(w, z, y);
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 abg
        {
            readonly get => new bool3(w, z, y);
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool3 qpt
        {
            readonly get => new bool3(w, z, y);
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wzz => new bool3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 abb => new bool3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qpp => new bool3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wzw => new bool3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aba => new bool3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qpq => new bool3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 ww_ => new bool3(w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aa_ => new bool3(w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qq_ => new bool3(w, w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wwx => new bool3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aar => new bool3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qqs => new bool3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wwy => new bool3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aag => new bool3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qqt => new bool3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 wwz => new bool3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aab => new bool3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qqp => new bool3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 www => new bool3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 aaa => new bool3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool3 qqq => new bool3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _x => new bool2(false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _r => new bool2(false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _s => new bool2(false, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _y => new bool2(false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _g => new bool2(false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _t => new bool2(false, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _z => new bool2(false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _b => new bool2(false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _p => new bool2(false, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _w => new bool2(false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _a => new bool2(false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 _q => new bool2(false, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 x_ => new bool2(x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 r_ => new bool2(x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 s_ => new bool2(x, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 xx => new bool2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 rr => new bool2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 ss => new bool2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 xy
        {
            readonly get => new bool2(x, y);
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 rg
        {
            readonly get => new bool2(x, y);
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 st
        {
            readonly get => new bool2(x, y);
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 xz
        {
            readonly get => new bool2(x, z);
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 rb
        {
            readonly get => new bool2(x, z);
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 sp
        {
            readonly get => new bool2(x, z);
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 xw
        {
            readonly get => new bool2(x, w);
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ra
        {
            readonly get => new bool2(x, w);
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 sq
        {
            readonly get => new bool2(x, w);
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 y_ => new bool2(y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 g_ => new bool2(y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 t_ => new bool2(y, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 yx
        {
            readonly get => new bool2(y, x);
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 gr
        {
            readonly get => new bool2(y, x);
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ts
        {
            readonly get => new bool2(y, x);
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 yy => new bool2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 gg => new bool2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 tt => new bool2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 yz
        {
            readonly get => new bool2(y, z);
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 gb
        {
            readonly get => new bool2(y, z);
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 tp
        {
            readonly get => new bool2(y, z);
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 yw
        {
            readonly get => new bool2(y, w);
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ga
        {
            readonly get => new bool2(y, w);
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 tq
        {
            readonly get => new bool2(y, w);
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 z_ => new bool2(z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 b_ => new bool2(z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 p_ => new bool2(z, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 zx
        {
            readonly get => new bool2(z, x);
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 br
        {
            readonly get => new bool2(z, x);
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ps
        {
            readonly get => new bool2(z, x);
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 zy
        {
            readonly get => new bool2(z, y);
            set
            {
                z = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 bg
        {
            readonly get => new bool2(z, y);
            set
            {
                z = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 pt
        {
            readonly get => new bool2(z, y);
            set
            {
                z = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 zz => new bool2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 bb => new bool2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 pp => new bool2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 zw
        {
            readonly get => new bool2(z, w);
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ba
        {
            readonly get => new bool2(z, w);
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 pq
        {
            readonly get => new bool2(z, w);
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 w_ => new bool2(w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 a_ => new bool2(w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 q_ => new bool2(w, false);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 wx
        {
            readonly get => new bool2(w, x);
            set
            {
                w = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ar
        {
            readonly get => new bool2(w, x);
            set
            {
                w = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 qs
        {
            readonly get => new bool2(w, x);
            set
            {
                w = value.x;
                x = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 wy
        {
            readonly get => new bool2(w, y);
            set
            {
                w = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ag
        {
            readonly get => new bool2(w, y);
            set
            {
                w = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 qt
        {
            readonly get => new bool2(w, y);
            set
            {
                w = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 wz
        {
            readonly get => new bool2(w, z);
            set
            {
                w = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 ab
        {
            readonly get => new bool2(w, z);
            set
            {
                w = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool2 qp
        {
            readonly get => new bool2(w, z);
            set
            {
                w = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 ww => new bool2(w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 aa => new bool2(w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly bool2 qq => new bool2(w, w);

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(bool4 lhs, bool4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(bool4 lhs, bool4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);
        
        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(bool4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bool4 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is bool4 other && Equals(other);

        #endregion


        #region Static Functions
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(bool4 v) => v.x||v.y||v.z||v.w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(bool4 v) => v.x&&v.y&&v.z&&v.w;
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Parse(string value)
        {
            var values = value.Split(", ");
            return new bool4(bool.Parse(values[0]), bool.Parse(values[1]), bool.Parse(values[2]), bool.Parse(values[3]));
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Equal(bool4 lhs, bool4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 NotEqual(bool4 lhs, bool4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Not (!v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Not(bool4 v) => new bool4(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Mix(bool4 x, bool4 y, bool4 a) => new bool4(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z, a.w ? y.w : x.w);

        #endregion

    }
}
