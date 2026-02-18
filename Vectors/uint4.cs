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
    /// A vector of type uint with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct uint4 : IEquatable<uint4>, IComparable<uint4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public uint z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public uint w;
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public const int Count = 4;
        
        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly uint4 zero = new uint4(0u, 0u, 0u, 0u);

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint x, uint y, uint z, uint w)
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
        public uint4(uint v)
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
        public uint4(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0u;
            this.w = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint2 v, uint z, uint w)
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
        public uint4(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint3 v, uint w)
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
        public uint4(uint4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a float4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(uint4 v) => new float4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Implicitly converts this to a double4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(uint4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public uint this[int index]
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
        public uint r
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
        public uint s
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
        public uint g
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
        public uint t
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
        public uint b
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
        public uint p
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
        public uint a
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
        public uint q
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
        public readonly uint4 ___x => new uint4(0u, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___r => new uint4(0u, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___s => new uint4(0u, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___y => new uint4(0u, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___g => new uint4(0u, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___t => new uint4(0u, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___z => new uint4(0u, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___b => new uint4(0u, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___p => new uint4(0u, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___w => new uint4(0u, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___a => new uint4(0u, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ___q => new uint4(0u, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __x_ => new uint4(0u, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __r_ => new uint4(0u, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __s_ => new uint4(0u, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __xx => new uint4(0u, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __rr => new uint4(0u, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ss => new uint4(0u, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __xy => new uint4(0u, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __rg => new uint4(0u, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __st => new uint4(0u, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __xz => new uint4(0u, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __rb => new uint4(0u, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __sp => new uint4(0u, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __xw => new uint4(0u, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ra => new uint4(0u, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __sq => new uint4(0u, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __y_ => new uint4(0u, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __g_ => new uint4(0u, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __t_ => new uint4(0u, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __yx => new uint4(0u, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __gr => new uint4(0u, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ts => new uint4(0u, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __yy => new uint4(0u, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __gg => new uint4(0u, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __tt => new uint4(0u, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __yz => new uint4(0u, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __gb => new uint4(0u, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __tp => new uint4(0u, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __yw => new uint4(0u, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ga => new uint4(0u, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __tq => new uint4(0u, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __z_ => new uint4(0u, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __b_ => new uint4(0u, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __p_ => new uint4(0u, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __zx => new uint4(0u, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __br => new uint4(0u, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ps => new uint4(0u, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __zy => new uint4(0u, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __bg => new uint4(0u, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __pt => new uint4(0u, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __zz => new uint4(0u, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __bb => new uint4(0u, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __pp => new uint4(0u, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __zw => new uint4(0u, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ba => new uint4(0u, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __pq => new uint4(0u, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __w_ => new uint4(0u, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __a_ => new uint4(0u, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __q_ => new uint4(0u, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __wx => new uint4(0u, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ar => new uint4(0u, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __qs => new uint4(0u, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __wy => new uint4(0u, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ag => new uint4(0u, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __qt => new uint4(0u, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __wz => new uint4(0u, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ab => new uint4(0u, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __qp => new uint4(0u, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __ww => new uint4(0u, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __aa => new uint4(0u, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 __qq => new uint4(0u, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _x__ => new uint4(0u, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _r__ => new uint4(0u, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _s__ => new uint4(0u, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _x_x => new uint4(0u, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _r_r => new uint4(0u, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _s_s => new uint4(0u, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _x_y => new uint4(0u, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _r_g => new uint4(0u, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _s_t => new uint4(0u, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _x_z => new uint4(0u, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _r_b => new uint4(0u, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _s_p => new uint4(0u, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _x_w => new uint4(0u, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _r_a => new uint4(0u, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _s_q => new uint4(0u, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xx_ => new uint4(0u, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rr_ => new uint4(0u, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ss_ => new uint4(0u, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xxx => new uint4(0u, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rrr => new uint4(0u, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sss => new uint4(0u, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xxy => new uint4(0u, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rrg => new uint4(0u, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sst => new uint4(0u, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xxz => new uint4(0u, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rrb => new uint4(0u, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ssp => new uint4(0u, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xxw => new uint4(0u, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rra => new uint4(0u, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ssq => new uint4(0u, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xy_ => new uint4(0u, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rg_ => new uint4(0u, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _st_ => new uint4(0u, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xyx => new uint4(0u, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rgr => new uint4(0u, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sts => new uint4(0u, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xyy => new uint4(0u, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rgg => new uint4(0u, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _stt => new uint4(0u, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xyz => new uint4(0u, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rgb => new uint4(0u, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _stp => new uint4(0u, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xyw => new uint4(0u, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rga => new uint4(0u, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _stq => new uint4(0u, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xz_ => new uint4(0u, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rb_ => new uint4(0u, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sp_ => new uint4(0u, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xzx => new uint4(0u, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rbr => new uint4(0u, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sps => new uint4(0u, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xzy => new uint4(0u, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rbg => new uint4(0u, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _spt => new uint4(0u, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xzz => new uint4(0u, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rbb => new uint4(0u, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _spp => new uint4(0u, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xzw => new uint4(0u, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rba => new uint4(0u, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _spq => new uint4(0u, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xw_ => new uint4(0u, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ra_ => new uint4(0u, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sq_ => new uint4(0u, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xwx => new uint4(0u, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rar => new uint4(0u, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sqs => new uint4(0u, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xwy => new uint4(0u, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rag => new uint4(0u, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sqt => new uint4(0u, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xwz => new uint4(0u, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _rab => new uint4(0u, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sqp => new uint4(0u, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _xww => new uint4(0u, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _raa => new uint4(0u, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _sqq => new uint4(0u, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _y__ => new uint4(0u, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _g__ => new uint4(0u, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _t__ => new uint4(0u, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _y_x => new uint4(0u, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _g_r => new uint4(0u, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _t_s => new uint4(0u, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _y_y => new uint4(0u, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _g_g => new uint4(0u, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _t_t => new uint4(0u, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _y_z => new uint4(0u, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _g_b => new uint4(0u, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _t_p => new uint4(0u, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _y_w => new uint4(0u, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _g_a => new uint4(0u, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _t_q => new uint4(0u, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yx_ => new uint4(0u, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gr_ => new uint4(0u, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ts_ => new uint4(0u, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yxx => new uint4(0u, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _grr => new uint4(0u, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tss => new uint4(0u, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yxy => new uint4(0u, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _grg => new uint4(0u, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tst => new uint4(0u, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yxz => new uint4(0u, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _grb => new uint4(0u, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tsp => new uint4(0u, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yxw => new uint4(0u, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gra => new uint4(0u, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tsq => new uint4(0u, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yy_ => new uint4(0u, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gg_ => new uint4(0u, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tt_ => new uint4(0u, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yyx => new uint4(0u, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ggr => new uint4(0u, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tts => new uint4(0u, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yyy => new uint4(0u, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ggg => new uint4(0u, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ttt => new uint4(0u, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yyz => new uint4(0u, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ggb => new uint4(0u, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ttp => new uint4(0u, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yyw => new uint4(0u, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gga => new uint4(0u, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ttq => new uint4(0u, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yz_ => new uint4(0u, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gb_ => new uint4(0u, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tp_ => new uint4(0u, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yzx => new uint4(0u, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gbr => new uint4(0u, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tps => new uint4(0u, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yzy => new uint4(0u, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gbg => new uint4(0u, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tpt => new uint4(0u, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yzz => new uint4(0u, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gbb => new uint4(0u, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tpp => new uint4(0u, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yzw => new uint4(0u, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gba => new uint4(0u, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tpq => new uint4(0u, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yw_ => new uint4(0u, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ga_ => new uint4(0u, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tq_ => new uint4(0u, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ywx => new uint4(0u, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gar => new uint4(0u, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tqs => new uint4(0u, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ywy => new uint4(0u, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gag => new uint4(0u, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tqt => new uint4(0u, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ywz => new uint4(0u, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gab => new uint4(0u, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tqp => new uint4(0u, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _yww => new uint4(0u, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _gaa => new uint4(0u, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _tqq => new uint4(0u, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _z__ => new uint4(0u, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _b__ => new uint4(0u, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _p__ => new uint4(0u, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _z_x => new uint4(0u, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _b_r => new uint4(0u, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _p_s => new uint4(0u, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _z_y => new uint4(0u, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _b_g => new uint4(0u, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _p_t => new uint4(0u, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _z_z => new uint4(0u, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _b_b => new uint4(0u, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _p_p => new uint4(0u, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _z_w => new uint4(0u, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _b_a => new uint4(0u, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _p_q => new uint4(0u, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zx_ => new uint4(0u, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _br_ => new uint4(0u, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ps_ => new uint4(0u, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zxx => new uint4(0u, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _brr => new uint4(0u, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pss => new uint4(0u, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zxy => new uint4(0u, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _brg => new uint4(0u, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pst => new uint4(0u, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zxz => new uint4(0u, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _brb => new uint4(0u, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _psp => new uint4(0u, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zxw => new uint4(0u, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bra => new uint4(0u, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _psq => new uint4(0u, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zy_ => new uint4(0u, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bg_ => new uint4(0u, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pt_ => new uint4(0u, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zyx => new uint4(0u, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bgr => new uint4(0u, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pts => new uint4(0u, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zyy => new uint4(0u, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bgg => new uint4(0u, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ptt => new uint4(0u, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zyz => new uint4(0u, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bgb => new uint4(0u, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ptp => new uint4(0u, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zyw => new uint4(0u, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bga => new uint4(0u, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ptq => new uint4(0u, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zz_ => new uint4(0u, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bb_ => new uint4(0u, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pp_ => new uint4(0u, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zzx => new uint4(0u, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bbr => new uint4(0u, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pps => new uint4(0u, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zzy => new uint4(0u, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bbg => new uint4(0u, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ppt => new uint4(0u, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zzz => new uint4(0u, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bbb => new uint4(0u, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ppp => new uint4(0u, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zzw => new uint4(0u, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bba => new uint4(0u, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ppq => new uint4(0u, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zw_ => new uint4(0u, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ba_ => new uint4(0u, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pq_ => new uint4(0u, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zwx => new uint4(0u, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bar => new uint4(0u, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pqs => new uint4(0u, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zwy => new uint4(0u, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bag => new uint4(0u, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pqt => new uint4(0u, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zwz => new uint4(0u, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _bab => new uint4(0u, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pqp => new uint4(0u, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _zww => new uint4(0u, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _baa => new uint4(0u, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _pqq => new uint4(0u, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _w__ => new uint4(0u, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _a__ => new uint4(0u, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _q__ => new uint4(0u, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _w_x => new uint4(0u, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _a_r => new uint4(0u, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _q_s => new uint4(0u, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _w_y => new uint4(0u, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _a_g => new uint4(0u, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _q_t => new uint4(0u, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _w_z => new uint4(0u, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _a_b => new uint4(0u, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _q_p => new uint4(0u, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _w_w => new uint4(0u, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _a_a => new uint4(0u, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _q_q => new uint4(0u, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wx_ => new uint4(0u, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ar_ => new uint4(0u, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qs_ => new uint4(0u, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wxx => new uint4(0u, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _arr => new uint4(0u, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qss => new uint4(0u, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wxy => new uint4(0u, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _arg => new uint4(0u, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qst => new uint4(0u, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wxz => new uint4(0u, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _arb => new uint4(0u, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qsp => new uint4(0u, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wxw => new uint4(0u, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ara => new uint4(0u, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qsq => new uint4(0u, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wy_ => new uint4(0u, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ag_ => new uint4(0u, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qt_ => new uint4(0u, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wyx => new uint4(0u, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _agr => new uint4(0u, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qts => new uint4(0u, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wyy => new uint4(0u, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _agg => new uint4(0u, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qtt => new uint4(0u, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wyz => new uint4(0u, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _agb => new uint4(0u, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qtp => new uint4(0u, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wyw => new uint4(0u, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aga => new uint4(0u, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qtq => new uint4(0u, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wz_ => new uint4(0u, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ab_ => new uint4(0u, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qp_ => new uint4(0u, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wzx => new uint4(0u, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _abr => new uint4(0u, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qps => new uint4(0u, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wzy => new uint4(0u, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _abg => new uint4(0u, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qpt => new uint4(0u, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wzz => new uint4(0u, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _abb => new uint4(0u, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qpp => new uint4(0u, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wzw => new uint4(0u, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aba => new uint4(0u, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qpq => new uint4(0u, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _ww_ => new uint4(0u, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aa_ => new uint4(0u, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qq_ => new uint4(0u, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wwx => new uint4(0u, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aar => new uint4(0u, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qqs => new uint4(0u, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wwy => new uint4(0u, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aag => new uint4(0u, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qqt => new uint4(0u, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _wwz => new uint4(0u, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aab => new uint4(0u, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qqp => new uint4(0u, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _www => new uint4(0u, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _aaa => new uint4(0u, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 _qqq => new uint4(0u, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x___ => new uint4(x, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r___ => new uint4(x, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s___ => new uint4(x, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x__x => new uint4(x, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r__r => new uint4(x, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s__s => new uint4(x, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x__y => new uint4(x, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r__g => new uint4(x, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s__t => new uint4(x, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x__z => new uint4(x, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r__b => new uint4(x, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s__p => new uint4(x, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x__w => new uint4(x, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r__a => new uint4(x, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s__q => new uint4(x, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_x_ => new uint4(x, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_r_ => new uint4(x, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_s_ => new uint4(x, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_xx => new uint4(x, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_rr => new uint4(x, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_ss => new uint4(x, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_xy => new uint4(x, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_rg => new uint4(x, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_st => new uint4(x, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_xz => new uint4(x, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_rb => new uint4(x, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_sp => new uint4(x, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_xw => new uint4(x, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_ra => new uint4(x, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_sq => new uint4(x, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_y_ => new uint4(x, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_g_ => new uint4(x, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_t_ => new uint4(x, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_yx => new uint4(x, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_gr => new uint4(x, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_ts => new uint4(x, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_yy => new uint4(x, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_gg => new uint4(x, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_tt => new uint4(x, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_yz => new uint4(x, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_gb => new uint4(x, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_tp => new uint4(x, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_yw => new uint4(x, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_ga => new uint4(x, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_tq => new uint4(x, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_z_ => new uint4(x, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_b_ => new uint4(x, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_p_ => new uint4(x, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_zx => new uint4(x, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_br => new uint4(x, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_ps => new uint4(x, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_zy => new uint4(x, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_bg => new uint4(x, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_pt => new uint4(x, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_zz => new uint4(x, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_bb => new uint4(x, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_pp => new uint4(x, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_zw => new uint4(x, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_ba => new uint4(x, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_pq => new uint4(x, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_w_ => new uint4(x, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_a_ => new uint4(x, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_q_ => new uint4(x, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_wx => new uint4(x, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_ar => new uint4(x, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_qs => new uint4(x, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_wy => new uint4(x, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_ag => new uint4(x, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_qt => new uint4(x, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_wz => new uint4(x, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_ab => new uint4(x, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_qp => new uint4(x, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 x_ww => new uint4(x, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 r_aa => new uint4(x, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 s_qq => new uint4(x, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xx__ => new uint4(x, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rr__ => new uint4(x, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ss__ => new uint4(x, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xx_x => new uint4(x, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rr_r => new uint4(x, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ss_s => new uint4(x, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xx_y => new uint4(x, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rr_g => new uint4(x, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ss_t => new uint4(x, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xx_z => new uint4(x, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rr_b => new uint4(x, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ss_p => new uint4(x, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xx_w => new uint4(x, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rr_a => new uint4(x, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ss_q => new uint4(x, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxx_ => new uint4(x, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrr_ => new uint4(x, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sss_ => new uint4(x, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxxx => new uint4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrrr => new uint4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssss => new uint4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxxy => new uint4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrrg => new uint4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssst => new uint4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxxz => new uint4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrrb => new uint4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sssp => new uint4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxxw => new uint4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrra => new uint4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sssq => new uint4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxy_ => new uint4(x, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrg_ => new uint4(x, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sst_ => new uint4(x, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxyx => new uint4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrgr => new uint4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssts => new uint4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxyy => new uint4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrgg => new uint4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sstt => new uint4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxyz => new uint4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrgb => new uint4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sstp => new uint4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxyw => new uint4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrga => new uint4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sstq => new uint4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxz_ => new uint4(x, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrb_ => new uint4(x, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssp_ => new uint4(x, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxzx => new uint4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrbr => new uint4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssps => new uint4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxzy => new uint4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrbg => new uint4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sspt => new uint4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxzz => new uint4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrbb => new uint4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sspp => new uint4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxzw => new uint4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrba => new uint4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sspq => new uint4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxw_ => new uint4(x, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rra_ => new uint4(x, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssq_ => new uint4(x, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxwx => new uint4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrar => new uint4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssqs => new uint4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxwy => new uint4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrag => new uint4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssqt => new uint4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxwz => new uint4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rrab => new uint4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssqp => new uint4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xxww => new uint4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rraa => new uint4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ssqq => new uint4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xy__ => new uint4(x, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rg__ => new uint4(x, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 st__ => new uint4(x, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xy_x => new uint4(x, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rg_r => new uint4(x, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 st_s => new uint4(x, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xy_y => new uint4(x, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rg_g => new uint4(x, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 st_t => new uint4(x, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xy_z => new uint4(x, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rg_b => new uint4(x, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 st_p => new uint4(x, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xy_w => new uint4(x, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rg_a => new uint4(x, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 st_q => new uint4(x, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyx_ => new uint4(x, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgr_ => new uint4(x, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sts_ => new uint4(x, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyxx => new uint4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgrr => new uint4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stss => new uint4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyxy => new uint4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgrg => new uint4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stst => new uint4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyxz => new uint4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgrb => new uint4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stsp => new uint4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyxw => new uint4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgra => new uint4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stsq => new uint4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyy_ => new uint4(x, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgg_ => new uint4(x, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stt_ => new uint4(x, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyyx => new uint4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rggr => new uint4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stts => new uint4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyyy => new uint4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rggg => new uint4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sttt => new uint4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyyz => new uint4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rggb => new uint4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sttp => new uint4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyyw => new uint4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgga => new uint4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sttq => new uint4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyz_ => new uint4(x, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgb_ => new uint4(x, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stp_ => new uint4(x, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyzx => new uint4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgbr => new uint4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stps => new uint4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyzy => new uint4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgbg => new uint4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stpt => new uint4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xyzz => new uint4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgbb => new uint4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stpp => new uint4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 xyzw
        {
            readonly get => new uint4(x, y, z, w);
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
        public uint4 rgba
        {
            readonly get => new uint4(x, y, z, w);
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
        public uint4 stpq
        {
            readonly get => new uint4(x, y, z, w);
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
        public readonly uint4 xyw_ => new uint4(x, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rga_ => new uint4(x, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stq_ => new uint4(x, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xywx => new uint4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgar => new uint4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stqs => new uint4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xywy => new uint4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgag => new uint4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stqt => new uint4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 xywz
        {
            readonly get => new uint4(x, y, w, z);
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
        public uint4 rgab
        {
            readonly get => new uint4(x, y, w, z);
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
        public uint4 stqp
        {
            readonly get => new uint4(x, y, w, z);
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
        public readonly uint4 xyww => new uint4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rgaa => new uint4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 stqq => new uint4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xz__ => new uint4(x, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rb__ => new uint4(x, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sp__ => new uint4(x, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xz_x => new uint4(x, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rb_r => new uint4(x, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sp_s => new uint4(x, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xz_y => new uint4(x, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rb_g => new uint4(x, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sp_t => new uint4(x, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xz_z => new uint4(x, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rb_b => new uint4(x, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sp_p => new uint4(x, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xz_w => new uint4(x, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rb_a => new uint4(x, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sp_q => new uint4(x, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzx_ => new uint4(x, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbr_ => new uint4(x, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sps_ => new uint4(x, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzxx => new uint4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbrr => new uint4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spss => new uint4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzxy => new uint4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbrg => new uint4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spst => new uint4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzxz => new uint4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbrb => new uint4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spsp => new uint4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzxw => new uint4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbra => new uint4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spsq => new uint4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzy_ => new uint4(x, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbg_ => new uint4(x, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spt_ => new uint4(x, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzyx => new uint4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbgr => new uint4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spts => new uint4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzyy => new uint4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbgg => new uint4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sptt => new uint4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzyz => new uint4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbgb => new uint4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sptp => new uint4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 xzyw
        {
            readonly get => new uint4(x, z, y, w);
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
        public uint4 rbga
        {
            readonly get => new uint4(x, z, y, w);
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
        public uint4 sptq
        {
            readonly get => new uint4(x, z, y, w);
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
        public readonly uint4 xzz_ => new uint4(x, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbb_ => new uint4(x, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spp_ => new uint4(x, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzzx => new uint4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbbr => new uint4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spps => new uint4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzzy => new uint4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbbg => new uint4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sppt => new uint4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzzz => new uint4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbbb => new uint4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sppp => new uint4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzzw => new uint4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbba => new uint4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sppq => new uint4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzw_ => new uint4(x, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rba_ => new uint4(x, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spq_ => new uint4(x, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzwx => new uint4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbar => new uint4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spqs => new uint4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 xzwy
        {
            readonly get => new uint4(x, z, w, y);
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
        public uint4 rbag
        {
            readonly get => new uint4(x, z, w, y);
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
        public uint4 spqt
        {
            readonly get => new uint4(x, z, w, y);
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
        public readonly uint4 xzwz => new uint4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbab => new uint4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spqp => new uint4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xzww => new uint4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rbaa => new uint4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 spqq => new uint4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xw__ => new uint4(x, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ra__ => new uint4(x, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sq__ => new uint4(x, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xw_x => new uint4(x, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ra_r => new uint4(x, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sq_s => new uint4(x, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xw_y => new uint4(x, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ra_g => new uint4(x, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sq_t => new uint4(x, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xw_z => new uint4(x, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ra_b => new uint4(x, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sq_p => new uint4(x, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xw_w => new uint4(x, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ra_a => new uint4(x, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sq_q => new uint4(x, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwx_ => new uint4(x, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rar_ => new uint4(x, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqs_ => new uint4(x, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwxx => new uint4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rarr => new uint4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqss => new uint4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwxy => new uint4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rarg => new uint4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqst => new uint4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwxz => new uint4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rarb => new uint4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqsp => new uint4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwxw => new uint4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rara => new uint4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqsq => new uint4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwy_ => new uint4(x, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rag_ => new uint4(x, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqt_ => new uint4(x, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwyx => new uint4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ragr => new uint4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqts => new uint4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwyy => new uint4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ragg => new uint4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqtt => new uint4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 xwyz
        {
            readonly get => new uint4(x, w, y, z);
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
        public uint4 ragb
        {
            readonly get => new uint4(x, w, y, z);
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
        public uint4 sqtp
        {
            readonly get => new uint4(x, w, y, z);
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
        public readonly uint4 xwyw => new uint4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raga => new uint4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqtq => new uint4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwz_ => new uint4(x, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rab_ => new uint4(x, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqp_ => new uint4(x, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwzx => new uint4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rabr => new uint4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqps => new uint4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 xwzy
        {
            readonly get => new uint4(x, w, z, y);
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
        public uint4 rabg
        {
            readonly get => new uint4(x, w, z, y);
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
        public uint4 sqpt
        {
            readonly get => new uint4(x, w, z, y);
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
        public readonly uint4 xwzz => new uint4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 rabb => new uint4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqpp => new uint4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwzw => new uint4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raba => new uint4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqpq => new uint4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xww_ => new uint4(x, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raa_ => new uint4(x, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqq_ => new uint4(x, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwwx => new uint4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raar => new uint4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqqs => new uint4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwwy => new uint4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raag => new uint4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqqt => new uint4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwwz => new uint4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raab => new uint4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqqp => new uint4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 xwww => new uint4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 raaa => new uint4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 sqqq => new uint4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y___ => new uint4(y, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g___ => new uint4(y, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t___ => new uint4(y, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y__x => new uint4(y, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g__r => new uint4(y, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t__s => new uint4(y, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y__y => new uint4(y, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g__g => new uint4(y, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t__t => new uint4(y, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y__z => new uint4(y, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g__b => new uint4(y, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t__p => new uint4(y, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y__w => new uint4(y, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g__a => new uint4(y, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t__q => new uint4(y, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_x_ => new uint4(y, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_r_ => new uint4(y, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_s_ => new uint4(y, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_xx => new uint4(y, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_rr => new uint4(y, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_ss => new uint4(y, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_xy => new uint4(y, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_rg => new uint4(y, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_st => new uint4(y, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_xz => new uint4(y, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_rb => new uint4(y, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_sp => new uint4(y, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_xw => new uint4(y, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_ra => new uint4(y, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_sq => new uint4(y, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_y_ => new uint4(y, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_g_ => new uint4(y, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_t_ => new uint4(y, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_yx => new uint4(y, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_gr => new uint4(y, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_ts => new uint4(y, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_yy => new uint4(y, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_gg => new uint4(y, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_tt => new uint4(y, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_yz => new uint4(y, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_gb => new uint4(y, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_tp => new uint4(y, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_yw => new uint4(y, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_ga => new uint4(y, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_tq => new uint4(y, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_z_ => new uint4(y, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_b_ => new uint4(y, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_p_ => new uint4(y, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_zx => new uint4(y, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_br => new uint4(y, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_ps => new uint4(y, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_zy => new uint4(y, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_bg => new uint4(y, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_pt => new uint4(y, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_zz => new uint4(y, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_bb => new uint4(y, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_pp => new uint4(y, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_zw => new uint4(y, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_ba => new uint4(y, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_pq => new uint4(y, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_w_ => new uint4(y, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_a_ => new uint4(y, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_q_ => new uint4(y, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_wx => new uint4(y, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_ar => new uint4(y, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_qs => new uint4(y, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_wy => new uint4(y, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_ag => new uint4(y, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_qt => new uint4(y, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_wz => new uint4(y, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_ab => new uint4(y, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_qp => new uint4(y, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 y_ww => new uint4(y, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 g_aa => new uint4(y, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 t_qq => new uint4(y, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yx__ => new uint4(y, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gr__ => new uint4(y, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ts__ => new uint4(y, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yx_x => new uint4(y, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gr_r => new uint4(y, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ts_s => new uint4(y, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yx_y => new uint4(y, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gr_g => new uint4(y, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ts_t => new uint4(y, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yx_z => new uint4(y, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gr_b => new uint4(y, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ts_p => new uint4(y, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yx_w => new uint4(y, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gr_a => new uint4(y, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ts_q => new uint4(y, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxx_ => new uint4(y, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grr_ => new uint4(y, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tss_ => new uint4(y, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxxx => new uint4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grrr => new uint4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsss => new uint4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxxy => new uint4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grrg => new uint4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsst => new uint4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxxz => new uint4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grrb => new uint4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tssp => new uint4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxxw => new uint4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grra => new uint4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tssq => new uint4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxy_ => new uint4(y, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grg_ => new uint4(y, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tst_ => new uint4(y, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxyx => new uint4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grgr => new uint4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsts => new uint4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxyy => new uint4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grgg => new uint4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tstt => new uint4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxyz => new uint4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grgb => new uint4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tstp => new uint4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxyw => new uint4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grga => new uint4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tstq => new uint4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxz_ => new uint4(y, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grb_ => new uint4(y, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsp_ => new uint4(y, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxzx => new uint4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grbr => new uint4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsps => new uint4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxzy => new uint4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grbg => new uint4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tspt => new uint4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxzz => new uint4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grbb => new uint4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tspp => new uint4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 yxzw
        {
            readonly get => new uint4(y, x, z, w);
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
        public uint4 grba
        {
            readonly get => new uint4(y, x, z, w);
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
        public uint4 tspq
        {
            readonly get => new uint4(y, x, z, w);
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
        public readonly uint4 yxw_ => new uint4(y, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gra_ => new uint4(y, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsq_ => new uint4(y, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxwx => new uint4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grar => new uint4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsqs => new uint4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yxwy => new uint4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 grag => new uint4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsqt => new uint4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 yxwz
        {
            readonly get => new uint4(y, x, w, z);
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
        public uint4 grab
        {
            readonly get => new uint4(y, x, w, z);
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
        public uint4 tsqp
        {
            readonly get => new uint4(y, x, w, z);
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
        public readonly uint4 yxww => new uint4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 graa => new uint4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tsqq => new uint4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yy__ => new uint4(y, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gg__ => new uint4(y, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tt__ => new uint4(y, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yy_x => new uint4(y, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gg_r => new uint4(y, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tt_s => new uint4(y, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yy_y => new uint4(y, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gg_g => new uint4(y, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tt_t => new uint4(y, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yy_z => new uint4(y, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gg_b => new uint4(y, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tt_p => new uint4(y, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yy_w => new uint4(y, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gg_a => new uint4(y, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tt_q => new uint4(y, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyx_ => new uint4(y, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggr_ => new uint4(y, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tts_ => new uint4(y, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyxx => new uint4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggrr => new uint4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttss => new uint4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyxy => new uint4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggrg => new uint4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttst => new uint4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyxz => new uint4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggrb => new uint4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttsp => new uint4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyxw => new uint4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggra => new uint4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttsq => new uint4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyy_ => new uint4(y, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggg_ => new uint4(y, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttt_ => new uint4(y, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyyx => new uint4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gggr => new uint4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttts => new uint4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyyy => new uint4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gggg => new uint4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tttt => new uint4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyyz => new uint4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gggb => new uint4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tttp => new uint4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyyw => new uint4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggga => new uint4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tttq => new uint4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyz_ => new uint4(y, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggb_ => new uint4(y, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttp_ => new uint4(y, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyzx => new uint4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggbr => new uint4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttps => new uint4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyzy => new uint4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggbg => new uint4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttpt => new uint4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyzz => new uint4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggbb => new uint4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttpp => new uint4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyzw => new uint4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggba => new uint4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttpq => new uint4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyw_ => new uint4(y, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gga_ => new uint4(y, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttq_ => new uint4(y, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yywx => new uint4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggar => new uint4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttqs => new uint4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yywy => new uint4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggag => new uint4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttqt => new uint4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yywz => new uint4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggab => new uint4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttqp => new uint4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yyww => new uint4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ggaa => new uint4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ttqq => new uint4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yz__ => new uint4(y, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gb__ => new uint4(y, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tp__ => new uint4(y, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yz_x => new uint4(y, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gb_r => new uint4(y, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tp_s => new uint4(y, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yz_y => new uint4(y, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gb_g => new uint4(y, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tp_t => new uint4(y, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yz_z => new uint4(y, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gb_b => new uint4(y, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tp_p => new uint4(y, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yz_w => new uint4(y, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gb_a => new uint4(y, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tp_q => new uint4(y, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzx_ => new uint4(y, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbr_ => new uint4(y, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tps_ => new uint4(y, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzxx => new uint4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbrr => new uint4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpss => new uint4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzxy => new uint4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbrg => new uint4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpst => new uint4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzxz => new uint4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbrb => new uint4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpsp => new uint4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 yzxw
        {
            readonly get => new uint4(y, z, x, w);
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
        public uint4 gbra
        {
            readonly get => new uint4(y, z, x, w);
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
        public uint4 tpsq
        {
            readonly get => new uint4(y, z, x, w);
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
        public readonly uint4 yzy_ => new uint4(y, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbg_ => new uint4(y, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpt_ => new uint4(y, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzyx => new uint4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbgr => new uint4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpts => new uint4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzyy => new uint4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbgg => new uint4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tptt => new uint4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzyz => new uint4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbgb => new uint4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tptp => new uint4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzyw => new uint4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbga => new uint4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tptq => new uint4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzz_ => new uint4(y, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbb_ => new uint4(y, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpp_ => new uint4(y, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzzx => new uint4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbbr => new uint4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpps => new uint4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzzy => new uint4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbbg => new uint4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tppt => new uint4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzzz => new uint4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbbb => new uint4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tppp => new uint4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzzw => new uint4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbba => new uint4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tppq => new uint4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzw_ => new uint4(y, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gba_ => new uint4(y, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpq_ => new uint4(y, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 yzwx
        {
            readonly get => new uint4(y, z, w, x);
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
        public uint4 gbar
        {
            readonly get => new uint4(y, z, w, x);
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
        public uint4 tpqs
        {
            readonly get => new uint4(y, z, w, x);
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
        public readonly uint4 yzwy => new uint4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbag => new uint4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpqt => new uint4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzwz => new uint4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbab => new uint4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpqp => new uint4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yzww => new uint4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gbaa => new uint4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tpqq => new uint4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yw__ => new uint4(y, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ga__ => new uint4(y, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tq__ => new uint4(y, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yw_x => new uint4(y, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ga_r => new uint4(y, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tq_s => new uint4(y, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yw_y => new uint4(y, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ga_g => new uint4(y, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tq_t => new uint4(y, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yw_z => new uint4(y, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ga_b => new uint4(y, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tq_p => new uint4(y, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yw_w => new uint4(y, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ga_a => new uint4(y, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tq_q => new uint4(y, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywx_ => new uint4(y, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gar_ => new uint4(y, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqs_ => new uint4(y, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywxx => new uint4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 garr => new uint4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqss => new uint4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywxy => new uint4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 garg => new uint4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqst => new uint4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 ywxz
        {
            readonly get => new uint4(y, w, x, z);
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
        public uint4 garb
        {
            readonly get => new uint4(y, w, x, z);
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
        public uint4 tqsp
        {
            readonly get => new uint4(y, w, x, z);
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
        public readonly uint4 ywxw => new uint4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gara => new uint4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqsq => new uint4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywy_ => new uint4(y, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gag_ => new uint4(y, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqt_ => new uint4(y, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywyx => new uint4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gagr => new uint4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqts => new uint4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywyy => new uint4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gagg => new uint4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqtt => new uint4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywyz => new uint4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gagb => new uint4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqtp => new uint4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywyw => new uint4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaga => new uint4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqtq => new uint4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywz_ => new uint4(y, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gab_ => new uint4(y, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqp_ => new uint4(y, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 ywzx
        {
            readonly get => new uint4(y, w, z, x);
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
        public uint4 gabr
        {
            readonly get => new uint4(y, w, z, x);
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
        public uint4 tqps
        {
            readonly get => new uint4(y, w, z, x);
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
        public readonly uint4 ywzy => new uint4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gabg => new uint4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqpt => new uint4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywzz => new uint4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gabb => new uint4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqpp => new uint4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywzw => new uint4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaba => new uint4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqpq => new uint4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 yww_ => new uint4(y, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaa_ => new uint4(y, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqq_ => new uint4(y, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywwx => new uint4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaar => new uint4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqqs => new uint4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywwy => new uint4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaag => new uint4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqqt => new uint4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywwz => new uint4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaab => new uint4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqqp => new uint4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ywww => new uint4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 gaaa => new uint4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 tqqq => new uint4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z___ => new uint4(z, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b___ => new uint4(z, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p___ => new uint4(z, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z__x => new uint4(z, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b__r => new uint4(z, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p__s => new uint4(z, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z__y => new uint4(z, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b__g => new uint4(z, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p__t => new uint4(z, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z__z => new uint4(z, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b__b => new uint4(z, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p__p => new uint4(z, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z__w => new uint4(z, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b__a => new uint4(z, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p__q => new uint4(z, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_x_ => new uint4(z, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_r_ => new uint4(z, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_s_ => new uint4(z, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_xx => new uint4(z, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_rr => new uint4(z, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_ss => new uint4(z, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_xy => new uint4(z, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_rg => new uint4(z, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_st => new uint4(z, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_xz => new uint4(z, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_rb => new uint4(z, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_sp => new uint4(z, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_xw => new uint4(z, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_ra => new uint4(z, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_sq => new uint4(z, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_y_ => new uint4(z, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_g_ => new uint4(z, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_t_ => new uint4(z, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_yx => new uint4(z, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_gr => new uint4(z, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_ts => new uint4(z, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_yy => new uint4(z, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_gg => new uint4(z, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_tt => new uint4(z, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_yz => new uint4(z, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_gb => new uint4(z, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_tp => new uint4(z, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_yw => new uint4(z, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_ga => new uint4(z, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_tq => new uint4(z, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_z_ => new uint4(z, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_b_ => new uint4(z, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_p_ => new uint4(z, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_zx => new uint4(z, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_br => new uint4(z, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_ps => new uint4(z, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_zy => new uint4(z, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_bg => new uint4(z, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_pt => new uint4(z, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_zz => new uint4(z, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_bb => new uint4(z, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_pp => new uint4(z, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_zw => new uint4(z, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_ba => new uint4(z, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_pq => new uint4(z, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_w_ => new uint4(z, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_a_ => new uint4(z, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_q_ => new uint4(z, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_wx => new uint4(z, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_ar => new uint4(z, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_qs => new uint4(z, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_wy => new uint4(z, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_ag => new uint4(z, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_qt => new uint4(z, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_wz => new uint4(z, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_ab => new uint4(z, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_qp => new uint4(z, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 z_ww => new uint4(z, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 b_aa => new uint4(z, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 p_qq => new uint4(z, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zx__ => new uint4(z, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 br__ => new uint4(z, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ps__ => new uint4(z, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zx_x => new uint4(z, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 br_r => new uint4(z, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ps_s => new uint4(z, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zx_y => new uint4(z, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 br_g => new uint4(z, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ps_t => new uint4(z, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zx_z => new uint4(z, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 br_b => new uint4(z, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ps_p => new uint4(z, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zx_w => new uint4(z, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 br_a => new uint4(z, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ps_q => new uint4(z, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxx_ => new uint4(z, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brr_ => new uint4(z, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pss_ => new uint4(z, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxxx => new uint4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brrr => new uint4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psss => new uint4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxxy => new uint4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brrg => new uint4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psst => new uint4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxxz => new uint4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brrb => new uint4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pssp => new uint4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxxw => new uint4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brra => new uint4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pssq => new uint4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxy_ => new uint4(z, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brg_ => new uint4(z, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pst_ => new uint4(z, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxyx => new uint4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brgr => new uint4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psts => new uint4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxyy => new uint4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brgg => new uint4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pstt => new uint4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxyz => new uint4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brgb => new uint4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pstp => new uint4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 zxyw
        {
            readonly get => new uint4(z, x, y, w);
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
        public uint4 brga
        {
            readonly get => new uint4(z, x, y, w);
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
        public uint4 pstq
        {
            readonly get => new uint4(z, x, y, w);
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
        public readonly uint4 zxz_ => new uint4(z, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brb_ => new uint4(z, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psp_ => new uint4(z, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxzx => new uint4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brbr => new uint4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psps => new uint4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxzy => new uint4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brbg => new uint4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pspt => new uint4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxzz => new uint4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brbb => new uint4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pspp => new uint4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxzw => new uint4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brba => new uint4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pspq => new uint4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxw_ => new uint4(z, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bra_ => new uint4(z, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psq_ => new uint4(z, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxwx => new uint4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brar => new uint4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psqs => new uint4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 zxwy
        {
            readonly get => new uint4(z, x, w, y);
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
        public uint4 brag
        {
            readonly get => new uint4(z, x, w, y);
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
        public uint4 psqt
        {
            readonly get => new uint4(z, x, w, y);
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
        public readonly uint4 zxwz => new uint4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 brab => new uint4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psqp => new uint4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zxww => new uint4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 braa => new uint4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 psqq => new uint4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zy__ => new uint4(z, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bg__ => new uint4(z, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pt__ => new uint4(z, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zy_x => new uint4(z, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bg_r => new uint4(z, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pt_s => new uint4(z, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zy_y => new uint4(z, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bg_g => new uint4(z, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pt_t => new uint4(z, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zy_z => new uint4(z, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bg_b => new uint4(z, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pt_p => new uint4(z, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zy_w => new uint4(z, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bg_a => new uint4(z, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pt_q => new uint4(z, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyx_ => new uint4(z, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgr_ => new uint4(z, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pts_ => new uint4(z, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyxx => new uint4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgrr => new uint4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptss => new uint4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyxy => new uint4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgrg => new uint4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptst => new uint4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyxz => new uint4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgrb => new uint4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptsp => new uint4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 zyxw
        {
            readonly get => new uint4(z, y, x, w);
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
        public uint4 bgra
        {
            readonly get => new uint4(z, y, x, w);
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
        public uint4 ptsq
        {
            readonly get => new uint4(z, y, x, w);
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
        public readonly uint4 zyy_ => new uint4(z, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgg_ => new uint4(z, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptt_ => new uint4(z, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyyx => new uint4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bggr => new uint4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptts => new uint4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyyy => new uint4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bggg => new uint4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pttt => new uint4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyyz => new uint4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bggb => new uint4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pttp => new uint4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyyw => new uint4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgga => new uint4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pttq => new uint4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyz_ => new uint4(z, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgb_ => new uint4(z, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptp_ => new uint4(z, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyzx => new uint4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgbr => new uint4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptps => new uint4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyzy => new uint4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgbg => new uint4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptpt => new uint4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyzz => new uint4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgbb => new uint4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptpp => new uint4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyzw => new uint4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgba => new uint4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptpq => new uint4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyw_ => new uint4(z, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bga_ => new uint4(z, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptq_ => new uint4(z, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 zywx
        {
            readonly get => new uint4(z, y, w, x);
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
        public uint4 bgar
        {
            readonly get => new uint4(z, y, w, x);
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
        public uint4 ptqs
        {
            readonly get => new uint4(z, y, w, x);
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
        public readonly uint4 zywy => new uint4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgag => new uint4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptqt => new uint4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zywz => new uint4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgab => new uint4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptqp => new uint4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zyww => new uint4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bgaa => new uint4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ptqq => new uint4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zz__ => new uint4(z, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bb__ => new uint4(z, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pp__ => new uint4(z, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zz_x => new uint4(z, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bb_r => new uint4(z, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pp_s => new uint4(z, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zz_y => new uint4(z, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bb_g => new uint4(z, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pp_t => new uint4(z, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zz_z => new uint4(z, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bb_b => new uint4(z, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pp_p => new uint4(z, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zz_w => new uint4(z, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bb_a => new uint4(z, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pp_q => new uint4(z, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzx_ => new uint4(z, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbr_ => new uint4(z, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pps_ => new uint4(z, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzxx => new uint4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbrr => new uint4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppss => new uint4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzxy => new uint4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbrg => new uint4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppst => new uint4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzxz => new uint4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbrb => new uint4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppsp => new uint4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzxw => new uint4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbra => new uint4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppsq => new uint4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzy_ => new uint4(z, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbg_ => new uint4(z, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppt_ => new uint4(z, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzyx => new uint4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbgr => new uint4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppts => new uint4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzyy => new uint4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbgg => new uint4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pptt => new uint4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzyz => new uint4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbgb => new uint4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pptp => new uint4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzyw => new uint4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbga => new uint4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pptq => new uint4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzz_ => new uint4(z, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbb_ => new uint4(z, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppp_ => new uint4(z, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzzx => new uint4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbbr => new uint4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppps => new uint4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzzy => new uint4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbbg => new uint4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pppt => new uint4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzzz => new uint4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbbb => new uint4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pppp => new uint4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzzw => new uint4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbba => new uint4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pppq => new uint4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzw_ => new uint4(z, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bba_ => new uint4(z, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppq_ => new uint4(z, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzwx => new uint4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbar => new uint4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppqs => new uint4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzwy => new uint4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbag => new uint4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppqt => new uint4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzwz => new uint4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbab => new uint4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppqp => new uint4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zzww => new uint4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bbaa => new uint4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ppqq => new uint4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zw__ => new uint4(z, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ba__ => new uint4(z, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pq__ => new uint4(z, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zw_x => new uint4(z, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ba_r => new uint4(z, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pq_s => new uint4(z, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zw_y => new uint4(z, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ba_g => new uint4(z, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pq_t => new uint4(z, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zw_z => new uint4(z, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ba_b => new uint4(z, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pq_p => new uint4(z, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zw_w => new uint4(z, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ba_a => new uint4(z, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pq_q => new uint4(z, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwx_ => new uint4(z, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bar_ => new uint4(z, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqs_ => new uint4(z, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwxx => new uint4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 barr => new uint4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqss => new uint4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 zwxy
        {
            readonly get => new uint4(z, w, x, y);
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
        public uint4 barg
        {
            readonly get => new uint4(z, w, x, y);
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
        public uint4 pqst
        {
            readonly get => new uint4(z, w, x, y);
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
        public readonly uint4 zwxz => new uint4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 barb => new uint4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqsp => new uint4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwxw => new uint4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bara => new uint4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqsq => new uint4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwy_ => new uint4(z, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bag_ => new uint4(z, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqt_ => new uint4(z, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 zwyx
        {
            readonly get => new uint4(z, w, y, x);
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
        public uint4 bagr
        {
            readonly get => new uint4(z, w, y, x);
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
        public uint4 pqts
        {
            readonly get => new uint4(z, w, y, x);
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
        public readonly uint4 zwyy => new uint4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bagg => new uint4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqtt => new uint4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwyz => new uint4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bagb => new uint4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqtp => new uint4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwyw => new uint4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baga => new uint4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqtq => new uint4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwz_ => new uint4(z, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 bab_ => new uint4(z, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqp_ => new uint4(z, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwzx => new uint4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 babr => new uint4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqps => new uint4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwzy => new uint4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 babg => new uint4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqpt => new uint4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwzz => new uint4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 babb => new uint4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqpp => new uint4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwzw => new uint4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baba => new uint4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqpq => new uint4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zww_ => new uint4(z, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baa_ => new uint4(z, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqq_ => new uint4(z, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwwx => new uint4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baar => new uint4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqqs => new uint4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwwy => new uint4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baag => new uint4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqqt => new uint4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwwz => new uint4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baab => new uint4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqqp => new uint4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 zwww => new uint4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 baaa => new uint4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 pqqq => new uint4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w___ => new uint4(w, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a___ => new uint4(w, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q___ => new uint4(w, 0u, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w__x => new uint4(w, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a__r => new uint4(w, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q__s => new uint4(w, 0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w__y => new uint4(w, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a__g => new uint4(w, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q__t => new uint4(w, 0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w__z => new uint4(w, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a__b => new uint4(w, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q__p => new uint4(w, 0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w__w => new uint4(w, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a__a => new uint4(w, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q__q => new uint4(w, 0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_x_ => new uint4(w, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_r_ => new uint4(w, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_s_ => new uint4(w, 0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_xx => new uint4(w, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_rr => new uint4(w, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_ss => new uint4(w, 0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_xy => new uint4(w, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_rg => new uint4(w, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_st => new uint4(w, 0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_xz => new uint4(w, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_rb => new uint4(w, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_sp => new uint4(w, 0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_xw => new uint4(w, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_ra => new uint4(w, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_sq => new uint4(w, 0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_y_ => new uint4(w, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_g_ => new uint4(w, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_t_ => new uint4(w, 0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_yx => new uint4(w, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_gr => new uint4(w, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_ts => new uint4(w, 0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_yy => new uint4(w, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_gg => new uint4(w, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_tt => new uint4(w, 0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_yz => new uint4(w, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_gb => new uint4(w, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_tp => new uint4(w, 0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_yw => new uint4(w, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_ga => new uint4(w, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_tq => new uint4(w, 0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_z_ => new uint4(w, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_b_ => new uint4(w, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_p_ => new uint4(w, 0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_zx => new uint4(w, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_br => new uint4(w, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_ps => new uint4(w, 0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_zy => new uint4(w, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_bg => new uint4(w, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_pt => new uint4(w, 0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_zz => new uint4(w, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_bb => new uint4(w, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_pp => new uint4(w, 0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_zw => new uint4(w, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_ba => new uint4(w, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_pq => new uint4(w, 0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_w_ => new uint4(w, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_a_ => new uint4(w, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_q_ => new uint4(w, 0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_wx => new uint4(w, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_ar => new uint4(w, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_qs => new uint4(w, 0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_wy => new uint4(w, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_ag => new uint4(w, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_qt => new uint4(w, 0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_wz => new uint4(w, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_ab => new uint4(w, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_qp => new uint4(w, 0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 w_ww => new uint4(w, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 a_aa => new uint4(w, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 q_qq => new uint4(w, 0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wx__ => new uint4(w, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ar__ => new uint4(w, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qs__ => new uint4(w, x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wx_x => new uint4(w, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ar_r => new uint4(w, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qs_s => new uint4(w, x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wx_y => new uint4(w, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ar_g => new uint4(w, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qs_t => new uint4(w, x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wx_z => new uint4(w, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ar_b => new uint4(w, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qs_p => new uint4(w, x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wx_w => new uint4(w, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ar_a => new uint4(w, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qs_q => new uint4(w, x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxx_ => new uint4(w, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arr_ => new uint4(w, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qss_ => new uint4(w, x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxxx => new uint4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arrr => new uint4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsss => new uint4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxxy => new uint4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arrg => new uint4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsst => new uint4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxxz => new uint4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arrb => new uint4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qssp => new uint4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxxw => new uint4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arra => new uint4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qssq => new uint4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxy_ => new uint4(w, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arg_ => new uint4(w, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qst_ => new uint4(w, x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxyx => new uint4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 argr => new uint4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsts => new uint4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxyy => new uint4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 argg => new uint4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qstt => new uint4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 wxyz
        {
            readonly get => new uint4(w, x, y, z);
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
        public uint4 argb
        {
            readonly get => new uint4(w, x, y, z);
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
        public uint4 qstp
        {
            readonly get => new uint4(w, x, y, z);
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
        public readonly uint4 wxyw => new uint4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arga => new uint4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qstq => new uint4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxz_ => new uint4(w, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arb_ => new uint4(w, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsp_ => new uint4(w, x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxzx => new uint4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arbr => new uint4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsps => new uint4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 wxzy
        {
            readonly get => new uint4(w, x, z, y);
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
        public uint4 arbg
        {
            readonly get => new uint4(w, x, z, y);
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
        public uint4 qspt
        {
            readonly get => new uint4(w, x, z, y);
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
        public readonly uint4 wxzz => new uint4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arbb => new uint4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qspp => new uint4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxzw => new uint4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arba => new uint4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qspq => new uint4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxw_ => new uint4(w, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ara_ => new uint4(w, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsq_ => new uint4(w, x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxwx => new uint4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arar => new uint4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsqs => new uint4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxwy => new uint4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arag => new uint4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsqt => new uint4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxwz => new uint4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 arab => new uint4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsqp => new uint4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wxww => new uint4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 araa => new uint4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qsqq => new uint4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wy__ => new uint4(w, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ag__ => new uint4(w, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qt__ => new uint4(w, y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wy_x => new uint4(w, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ag_r => new uint4(w, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qt_s => new uint4(w, y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wy_y => new uint4(w, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ag_g => new uint4(w, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qt_t => new uint4(w, y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wy_z => new uint4(w, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ag_b => new uint4(w, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qt_p => new uint4(w, y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wy_w => new uint4(w, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ag_a => new uint4(w, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qt_q => new uint4(w, y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyx_ => new uint4(w, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agr_ => new uint4(w, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qts_ => new uint4(w, y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyxx => new uint4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agrr => new uint4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtss => new uint4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyxy => new uint4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agrg => new uint4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtst => new uint4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 wyxz
        {
            readonly get => new uint4(w, y, x, z);
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
        public uint4 agrb
        {
            readonly get => new uint4(w, y, x, z);
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
        public uint4 qtsp
        {
            readonly get => new uint4(w, y, x, z);
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
        public readonly uint4 wyxw => new uint4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agra => new uint4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtsq => new uint4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyy_ => new uint4(w, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agg_ => new uint4(w, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtt_ => new uint4(w, y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyyx => new uint4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aggr => new uint4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtts => new uint4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyyy => new uint4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aggg => new uint4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qttt => new uint4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyyz => new uint4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aggb => new uint4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qttp => new uint4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyyw => new uint4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agga => new uint4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qttq => new uint4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyz_ => new uint4(w, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agb_ => new uint4(w, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtp_ => new uint4(w, y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 wyzx
        {
            readonly get => new uint4(w, y, z, x);
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
        public uint4 agbr
        {
            readonly get => new uint4(w, y, z, x);
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
        public uint4 qtps
        {
            readonly get => new uint4(w, y, z, x);
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
        public readonly uint4 wyzy => new uint4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agbg => new uint4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtpt => new uint4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyzz => new uint4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agbb => new uint4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtpp => new uint4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyzw => new uint4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agba => new uint4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtpq => new uint4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyw_ => new uint4(w, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aga_ => new uint4(w, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtq_ => new uint4(w, y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wywx => new uint4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agar => new uint4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtqs => new uint4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wywy => new uint4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agag => new uint4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtqt => new uint4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wywz => new uint4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agab => new uint4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtqp => new uint4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wyww => new uint4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 agaa => new uint4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qtqq => new uint4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wz__ => new uint4(w, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ab__ => new uint4(w, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qp__ => new uint4(w, z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wz_x => new uint4(w, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ab_r => new uint4(w, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qp_s => new uint4(w, z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wz_y => new uint4(w, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ab_g => new uint4(w, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qp_t => new uint4(w, z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wz_z => new uint4(w, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ab_b => new uint4(w, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qp_p => new uint4(w, z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wz_w => new uint4(w, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ab_a => new uint4(w, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qp_q => new uint4(w, z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzx_ => new uint4(w, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abr_ => new uint4(w, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qps_ => new uint4(w, z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzxx => new uint4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abrr => new uint4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpss => new uint4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 wzxy
        {
            readonly get => new uint4(w, z, x, y);
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
        public uint4 abrg
        {
            readonly get => new uint4(w, z, x, y);
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
        public uint4 qpst
        {
            readonly get => new uint4(w, z, x, y);
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
        public readonly uint4 wzxz => new uint4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abrb => new uint4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpsp => new uint4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzxw => new uint4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abra => new uint4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpsq => new uint4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzy_ => new uint4(w, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abg_ => new uint4(w, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpt_ => new uint4(w, z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint4 wzyx
        {
            readonly get => new uint4(w, z, y, x);
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
        public uint4 abgr
        {
            readonly get => new uint4(w, z, y, x);
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
        public uint4 qpts
        {
            readonly get => new uint4(w, z, y, x);
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
        public readonly uint4 wzyy => new uint4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abgg => new uint4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qptt => new uint4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzyz => new uint4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abgb => new uint4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qptp => new uint4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzyw => new uint4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abga => new uint4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qptq => new uint4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzz_ => new uint4(w, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abb_ => new uint4(w, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpp_ => new uint4(w, z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzzx => new uint4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abbr => new uint4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpps => new uint4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzzy => new uint4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abbg => new uint4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qppt => new uint4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzzz => new uint4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abbb => new uint4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qppp => new uint4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzzw => new uint4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abba => new uint4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qppq => new uint4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzw_ => new uint4(w, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aba_ => new uint4(w, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpq_ => new uint4(w, z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzwx => new uint4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abar => new uint4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpqs => new uint4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzwy => new uint4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abag => new uint4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpqt => new uint4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzwz => new uint4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abab => new uint4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpqp => new uint4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wzww => new uint4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 abaa => new uint4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qpqq => new uint4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ww__ => new uint4(w, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aa__ => new uint4(w, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qq__ => new uint4(w, w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ww_x => new uint4(w, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aa_r => new uint4(w, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qq_s => new uint4(w, w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ww_y => new uint4(w, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aa_g => new uint4(w, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qq_t => new uint4(w, w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ww_z => new uint4(w, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aa_b => new uint4(w, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qq_p => new uint4(w, w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 ww_w => new uint4(w, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aa_a => new uint4(w, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qq_q => new uint4(w, w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwx_ => new uint4(w, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aar_ => new uint4(w, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqs_ => new uint4(w, w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwxx => new uint4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aarr => new uint4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqss => new uint4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwxy => new uint4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aarg => new uint4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqst => new uint4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwxz => new uint4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aarb => new uint4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqsp => new uint4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwxw => new uint4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aara => new uint4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqsq => new uint4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwy_ => new uint4(w, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aag_ => new uint4(w, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqt_ => new uint4(w, w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwyx => new uint4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aagr => new uint4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqts => new uint4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwyy => new uint4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aagg => new uint4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqtt => new uint4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwyz => new uint4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aagb => new uint4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqtp => new uint4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwyw => new uint4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaga => new uint4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqtq => new uint4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwz_ => new uint4(w, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aab_ => new uint4(w, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqp_ => new uint4(w, w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwzx => new uint4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aabr => new uint4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqps => new uint4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwzy => new uint4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aabg => new uint4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqpt => new uint4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwzz => new uint4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aabb => new uint4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqpp => new uint4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwzw => new uint4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaba => new uint4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqpq => new uint4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 www_ => new uint4(w, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaa_ => new uint4(w, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqq_ => new uint4(w, w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwwx => new uint4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaar => new uint4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqqs => new uint4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwwy => new uint4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaag => new uint4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqqt => new uint4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwwz => new uint4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaab => new uint4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqqp => new uint4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 wwww => new uint4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 aaaa => new uint4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint4 qqqq => new uint4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __x => new uint3(0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __r => new uint3(0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __s => new uint3(0u, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __y => new uint3(0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __g => new uint3(0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __t => new uint3(0u, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __z => new uint3(0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __b => new uint3(0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __p => new uint3(0u, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __w => new uint3(0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __a => new uint3(0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 __q => new uint3(0u, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _x_ => new uint3(0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _r_ => new uint3(0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _s_ => new uint3(0u, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _xx => new uint3(0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _rr => new uint3(0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ss => new uint3(0u, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _xy => new uint3(0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _rg => new uint3(0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _st => new uint3(0u, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _xz => new uint3(0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _rb => new uint3(0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _sp => new uint3(0u, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _xw => new uint3(0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ra => new uint3(0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _sq => new uint3(0u, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _y_ => new uint3(0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _g_ => new uint3(0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _t_ => new uint3(0u, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _yx => new uint3(0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _gr => new uint3(0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ts => new uint3(0u, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _yy => new uint3(0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _gg => new uint3(0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _tt => new uint3(0u, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _yz => new uint3(0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _gb => new uint3(0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _tp => new uint3(0u, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _yw => new uint3(0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ga => new uint3(0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _tq => new uint3(0u, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _z_ => new uint3(0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _b_ => new uint3(0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _p_ => new uint3(0u, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _zx => new uint3(0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _br => new uint3(0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ps => new uint3(0u, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _zy => new uint3(0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _bg => new uint3(0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _pt => new uint3(0u, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _zz => new uint3(0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _bb => new uint3(0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _pp => new uint3(0u, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _zw => new uint3(0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ba => new uint3(0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _pq => new uint3(0u, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _w_ => new uint3(0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _a_ => new uint3(0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _q_ => new uint3(0u, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _wx => new uint3(0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ar => new uint3(0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _qs => new uint3(0u, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _wy => new uint3(0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ag => new uint3(0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _qt => new uint3(0u, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _wz => new uint3(0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ab => new uint3(0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _qp => new uint3(0u, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _ww => new uint3(0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _aa => new uint3(0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 _qq => new uint3(0u, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 x__ => new uint3(x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 r__ => new uint3(x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 s__ => new uint3(x, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 x_x => new uint3(x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 r_r => new uint3(x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 s_s => new uint3(x, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 x_y => new uint3(x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 r_g => new uint3(x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 s_t => new uint3(x, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 x_z => new uint3(x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 r_b => new uint3(x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 s_p => new uint3(x, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 x_w => new uint3(x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 r_a => new uint3(x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 s_q => new uint3(x, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xx_ => new uint3(x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rr_ => new uint3(x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ss_ => new uint3(x, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xxx => new uint3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rrr => new uint3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sss => new uint3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xxy => new uint3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rrg => new uint3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sst => new uint3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xxz => new uint3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rrb => new uint3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ssp => new uint3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xxw => new uint3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rra => new uint3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ssq => new uint3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xy_ => new uint3(x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rg_ => new uint3(x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 st_ => new uint3(x, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xyx => new uint3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rgr => new uint3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sts => new uint3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xyy => new uint3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rgg => new uint3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 stt => new uint3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 xyz
        {
            readonly get => new uint3(x, y, z);
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
        public uint3 rgb
        {
            readonly get => new uint3(x, y, z);
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
        public uint3 stp
        {
            readonly get => new uint3(x, y, z);
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
        public uint3 xyw
        {
            readonly get => new uint3(x, y, w);
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
        public uint3 rga
        {
            readonly get => new uint3(x, y, w);
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
        public uint3 stq
        {
            readonly get => new uint3(x, y, w);
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
        public readonly uint3 xz_ => new uint3(x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rb_ => new uint3(x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sp_ => new uint3(x, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xzx => new uint3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rbr => new uint3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sps => new uint3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 xzy
        {
            readonly get => new uint3(x, z, y);
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
        public uint3 rbg
        {
            readonly get => new uint3(x, z, y);
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
        public uint3 spt
        {
            readonly get => new uint3(x, z, y);
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
        public readonly uint3 xzz => new uint3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rbb => new uint3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 spp => new uint3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 xzw
        {
            readonly get => new uint3(x, z, w);
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
        public uint3 rba
        {
            readonly get => new uint3(x, z, w);
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
        public uint3 spq
        {
            readonly get => new uint3(x, z, w);
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
        public readonly uint3 xw_ => new uint3(x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ra_ => new uint3(x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sq_ => new uint3(x, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 xwx => new uint3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 rar => new uint3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sqs => new uint3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 xwy
        {
            readonly get => new uint3(x, w, y);
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
        public uint3 rag
        {
            readonly get => new uint3(x, w, y);
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
        public uint3 sqt
        {
            readonly get => new uint3(x, w, y);
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
        public uint3 xwz
        {
            readonly get => new uint3(x, w, z);
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
        public uint3 rab
        {
            readonly get => new uint3(x, w, z);
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
        public uint3 sqp
        {
            readonly get => new uint3(x, w, z);
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
        public readonly uint3 xww => new uint3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 raa => new uint3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 sqq => new uint3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 y__ => new uint3(y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 g__ => new uint3(y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 t__ => new uint3(y, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 y_x => new uint3(y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 g_r => new uint3(y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 t_s => new uint3(y, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 y_y => new uint3(y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 g_g => new uint3(y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 t_t => new uint3(y, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 y_z => new uint3(y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 g_b => new uint3(y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 t_p => new uint3(y, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 y_w => new uint3(y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 g_a => new uint3(y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 t_q => new uint3(y, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yx_ => new uint3(y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gr_ => new uint3(y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ts_ => new uint3(y, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yxx => new uint3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 grr => new uint3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tss => new uint3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yxy => new uint3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 grg => new uint3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tst => new uint3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 yxz
        {
            readonly get => new uint3(y, x, z);
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
        public uint3 grb
        {
            readonly get => new uint3(y, x, z);
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
        public uint3 tsp
        {
            readonly get => new uint3(y, x, z);
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
        public uint3 yxw
        {
            readonly get => new uint3(y, x, w);
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
        public uint3 gra
        {
            readonly get => new uint3(y, x, w);
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
        public uint3 tsq
        {
            readonly get => new uint3(y, x, w);
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
        public readonly uint3 yy_ => new uint3(y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gg_ => new uint3(y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tt_ => new uint3(y, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yyx => new uint3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ggr => new uint3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tts => new uint3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yyy => new uint3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ggg => new uint3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ttt => new uint3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yyz => new uint3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ggb => new uint3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ttp => new uint3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yyw => new uint3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gga => new uint3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ttq => new uint3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yz_ => new uint3(y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gb_ => new uint3(y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tp_ => new uint3(y, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 yzx
        {
            readonly get => new uint3(y, z, x);
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
        public uint3 gbr
        {
            readonly get => new uint3(y, z, x);
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
        public uint3 tps
        {
            readonly get => new uint3(y, z, x);
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
        public readonly uint3 yzy => new uint3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gbg => new uint3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tpt => new uint3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 yzz => new uint3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gbb => new uint3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tpp => new uint3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 yzw
        {
            readonly get => new uint3(y, z, w);
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
        public uint3 gba
        {
            readonly get => new uint3(y, z, w);
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
        public uint3 tpq
        {
            readonly get => new uint3(y, z, w);
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
        public readonly uint3 yw_ => new uint3(y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ga_ => new uint3(y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tq_ => new uint3(y, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 ywx
        {
            readonly get => new uint3(y, w, x);
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
        public uint3 gar
        {
            readonly get => new uint3(y, w, x);
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
        public uint3 tqs
        {
            readonly get => new uint3(y, w, x);
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
        public readonly uint3 ywy => new uint3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gag => new uint3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tqt => new uint3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 ywz
        {
            readonly get => new uint3(y, w, z);
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
        public uint3 gab
        {
            readonly get => new uint3(y, w, z);
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
        public uint3 tqp
        {
            readonly get => new uint3(y, w, z);
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
        public readonly uint3 yww => new uint3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 gaa => new uint3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 tqq => new uint3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 z__ => new uint3(z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 b__ => new uint3(z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 p__ => new uint3(z, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 z_x => new uint3(z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 b_r => new uint3(z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 p_s => new uint3(z, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 z_y => new uint3(z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 b_g => new uint3(z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 p_t => new uint3(z, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 z_z => new uint3(z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 b_b => new uint3(z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 p_p => new uint3(z, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 z_w => new uint3(z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 b_a => new uint3(z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 p_q => new uint3(z, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zx_ => new uint3(z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 br_ => new uint3(z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ps_ => new uint3(z, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zxx => new uint3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 brr => new uint3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pss => new uint3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 zxy
        {
            readonly get => new uint3(z, x, y);
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
        public uint3 brg
        {
            readonly get => new uint3(z, x, y);
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
        public uint3 pst
        {
            readonly get => new uint3(z, x, y);
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
        public readonly uint3 zxz => new uint3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 brb => new uint3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 psp => new uint3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 zxw
        {
            readonly get => new uint3(z, x, w);
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
        public uint3 bra
        {
            readonly get => new uint3(z, x, w);
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
        public uint3 psq
        {
            readonly get => new uint3(z, x, w);
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
        public readonly uint3 zy_ => new uint3(z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bg_ => new uint3(z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pt_ => new uint3(z, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 zyx
        {
            readonly get => new uint3(z, y, x);
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
        public uint3 bgr
        {
            readonly get => new uint3(z, y, x);
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
        public uint3 pts
        {
            readonly get => new uint3(z, y, x);
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
        public readonly uint3 zyy => new uint3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bgg => new uint3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ptt => new uint3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zyz => new uint3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bgb => new uint3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ptp => new uint3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 zyw
        {
            readonly get => new uint3(z, y, w);
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
        public uint3 bga
        {
            readonly get => new uint3(z, y, w);
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
        public uint3 ptq
        {
            readonly get => new uint3(z, y, w);
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
        public readonly uint3 zz_ => new uint3(z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bb_ => new uint3(z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pp_ => new uint3(z, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zzx => new uint3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bbr => new uint3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pps => new uint3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zzy => new uint3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bbg => new uint3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ppt => new uint3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zzz => new uint3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bbb => new uint3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ppp => new uint3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zzw => new uint3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bba => new uint3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ppq => new uint3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zw_ => new uint3(z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ba_ => new uint3(z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pq_ => new uint3(z, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 zwx
        {
            readonly get => new uint3(z, w, x);
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
        public uint3 bar
        {
            readonly get => new uint3(z, w, x);
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
        public uint3 pqs
        {
            readonly get => new uint3(z, w, x);
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
        public uint3 zwy
        {
            readonly get => new uint3(z, w, y);
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
        public uint3 bag
        {
            readonly get => new uint3(z, w, y);
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
        public uint3 pqt
        {
            readonly get => new uint3(z, w, y);
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
        public readonly uint3 zwz => new uint3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 bab => new uint3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pqp => new uint3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 zww => new uint3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 baa => new uint3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 pqq => new uint3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 w__ => new uint3(w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 a__ => new uint3(w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 q__ => new uint3(w, 0u, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 w_x => new uint3(w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 a_r => new uint3(w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 q_s => new uint3(w, 0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 w_y => new uint3(w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 a_g => new uint3(w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 q_t => new uint3(w, 0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 w_z => new uint3(w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 a_b => new uint3(w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 q_p => new uint3(w, 0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 w_w => new uint3(w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 a_a => new uint3(w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 q_q => new uint3(w, 0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wx_ => new uint3(w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ar_ => new uint3(w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qs_ => new uint3(w, x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wxx => new uint3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 arr => new uint3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qss => new uint3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 wxy
        {
            readonly get => new uint3(w, x, y);
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
        public uint3 arg
        {
            readonly get => new uint3(w, x, y);
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
        public uint3 qst
        {
            readonly get => new uint3(w, x, y);
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
        public uint3 wxz
        {
            readonly get => new uint3(w, x, z);
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
        public uint3 arb
        {
            readonly get => new uint3(w, x, z);
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
        public uint3 qsp
        {
            readonly get => new uint3(w, x, z);
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
        public readonly uint3 wxw => new uint3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ara => new uint3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qsq => new uint3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wy_ => new uint3(w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ag_ => new uint3(w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qt_ => new uint3(w, y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 wyx
        {
            readonly get => new uint3(w, y, x);
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
        public uint3 agr
        {
            readonly get => new uint3(w, y, x);
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
        public uint3 qts
        {
            readonly get => new uint3(w, y, x);
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
        public readonly uint3 wyy => new uint3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 agg => new uint3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qtt => new uint3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 wyz
        {
            readonly get => new uint3(w, y, z);
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
        public uint3 agb
        {
            readonly get => new uint3(w, y, z);
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
        public uint3 qtp
        {
            readonly get => new uint3(w, y, z);
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
        public readonly uint3 wyw => new uint3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aga => new uint3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qtq => new uint3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wz_ => new uint3(w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ab_ => new uint3(w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qp_ => new uint3(w, z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint3 wzx
        {
            readonly get => new uint3(w, z, x);
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
        public uint3 abr
        {
            readonly get => new uint3(w, z, x);
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
        public uint3 qps
        {
            readonly get => new uint3(w, z, x);
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
        public uint3 wzy
        {
            readonly get => new uint3(w, z, y);
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
        public uint3 abg
        {
            readonly get => new uint3(w, z, y);
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
        public uint3 qpt
        {
            readonly get => new uint3(w, z, y);
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
        public readonly uint3 wzz => new uint3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 abb => new uint3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qpp => new uint3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wzw => new uint3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aba => new uint3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qpq => new uint3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 ww_ => new uint3(w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aa_ => new uint3(w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qq_ => new uint3(w, w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wwx => new uint3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aar => new uint3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qqs => new uint3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wwy => new uint3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aag => new uint3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qqt => new uint3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 wwz => new uint3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aab => new uint3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qqp => new uint3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 www => new uint3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 aaa => new uint3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint3 qqq => new uint3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _x => new uint2(0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _r => new uint2(0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _s => new uint2(0u, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _y => new uint2(0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _g => new uint2(0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _t => new uint2(0u, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _z => new uint2(0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _b => new uint2(0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _p => new uint2(0u, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _w => new uint2(0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _a => new uint2(0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 _q => new uint2(0u, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 x_ => new uint2(x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 r_ => new uint2(x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 s_ => new uint2(x, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 xx => new uint2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 rr => new uint2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 ss => new uint2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint2 xy
        {
            readonly get => new uint2(x, y);
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
        public uint2 rg
        {
            readonly get => new uint2(x, y);
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
        public uint2 st
        {
            readonly get => new uint2(x, y);
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
        public uint2 xz
        {
            readonly get => new uint2(x, z);
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
        public uint2 rb
        {
            readonly get => new uint2(x, z);
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
        public uint2 sp
        {
            readonly get => new uint2(x, z);
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
        public uint2 xw
        {
            readonly get => new uint2(x, w);
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
        public uint2 ra
        {
            readonly get => new uint2(x, w);
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
        public uint2 sq
        {
            readonly get => new uint2(x, w);
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
        public readonly uint2 y_ => new uint2(y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 g_ => new uint2(y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 t_ => new uint2(y, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint2 yx
        {
            readonly get => new uint2(y, x);
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
        public uint2 gr
        {
            readonly get => new uint2(y, x);
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
        public uint2 ts
        {
            readonly get => new uint2(y, x);
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
        public readonly uint2 yy => new uint2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 gg => new uint2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 tt => new uint2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint2 yz
        {
            readonly get => new uint2(y, z);
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
        public uint2 gb
        {
            readonly get => new uint2(y, z);
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
        public uint2 tp
        {
            readonly get => new uint2(y, z);
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
        public uint2 yw
        {
            readonly get => new uint2(y, w);
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
        public uint2 ga
        {
            readonly get => new uint2(y, w);
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
        public uint2 tq
        {
            readonly get => new uint2(y, w);
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
        public readonly uint2 z_ => new uint2(z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 b_ => new uint2(z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 p_ => new uint2(z, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint2 zx
        {
            readonly get => new uint2(z, x);
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
        public uint2 br
        {
            readonly get => new uint2(z, x);
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
        public uint2 ps
        {
            readonly get => new uint2(z, x);
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
        public uint2 zy
        {
            readonly get => new uint2(z, y);
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
        public uint2 bg
        {
            readonly get => new uint2(z, y);
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
        public uint2 pt
        {
            readonly get => new uint2(z, y);
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
        public readonly uint2 zz => new uint2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 bb => new uint2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 pp => new uint2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint2 zw
        {
            readonly get => new uint2(z, w);
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
        public uint2 ba
        {
            readonly get => new uint2(z, w);
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
        public uint2 pq
        {
            readonly get => new uint2(z, w);
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
        public readonly uint2 w_ => new uint2(w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 a_ => new uint2(w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 q_ => new uint2(w, 0u);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public uint2 wx
        {
            readonly get => new uint2(w, x);
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
        public uint2 ar
        {
            readonly get => new uint2(w, x);
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
        public uint2 qs
        {
            readonly get => new uint2(w, x);
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
        public uint2 wy
        {
            readonly get => new uint2(w, y);
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
        public uint2 ag
        {
            readonly get => new uint2(w, y);
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
        public uint2 qt
        {
            readonly get => new uint2(w, y);
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
        public uint2 wz
        {
            readonly get => new uint2(w, z);
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
        public uint2 ab
        {
            readonly get => new uint2(w, z);
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
        public uint2 qp
        {
            readonly get => new uint2(w, z);
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
        public readonly uint2 ww => new uint2(w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 aa => new uint2(w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly uint2 qq => new uint2(w, w);

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(uint4 lhs, uint4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(uint4 lhs, uint4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

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
        public readonly int CompareTo(uint4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(uint4 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is uint4 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Clamp(uint4 v, uint min, uint max) => new uint4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Parse(string value)
        {
            var values = value.Split(", ");
            return new uint4(uint.Parse(values[0]), uint.Parse(values[1]), uint.Parse(values[2]), uint.Parse(values[3]));
        }
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new uint4(uint.Parse(values[0], format), uint.Parse(values[1], format), uint.Parse(values[2], format), uint.Parse(values[3], format));
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 LesserThan(uint4 lhs, uint4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 LesserThanEqual(uint4 lhs, uint4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 GreaterThan(uint4 lhs, uint4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 GreaterThanEqual(uint4 lhs, uint4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Equal(uint4 lhs, uint4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 NotEqual(uint4 lhs, uint4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Min(uint4 lhs, uint4 rhs) => new uint4(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z), Maths.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Min(uint4 lhs, uint rhs) => new uint4(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs), Maths.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Max(uint4 lhs, uint4 rhs) => new uint4(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z), Maths.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Max(uint4 lhs, uint rhs) => new uint4(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs), Maths.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Clamp(uint4 v, uint4 min, uint4 max) => new uint4(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z), Maths.Clamp(v.w, min.w, max.w));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Mix(uint4 x, uint4 y, bool4 a) => new uint4(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z, a.w ? y.w : x.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of UIntBitsToFloat (Unsafe.As&lt;uint, float&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 UIntBitsToFloat(uint4 v) => new float4(Unsafe.As<uint, float>(ref v.x), Unsafe.As<uint, float>(ref v.y), Unsafe.As<uint, float>(ref v.z), Unsafe.As<uint, float>(ref v.w));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator+(uint4 lhs, uint4 rhs) => new uint4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator+(uint4 lhs, uint rhs) => new uint4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator+(uint lhs, uint4 rhs) => new uint4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator-(uint4 lhs, uint4 rhs) => new uint4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator-(uint4 lhs, uint rhs) => new uint4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator-(uint lhs, uint4 rhs) => new uint4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator*(uint4 lhs, uint4 rhs) => new uint4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator*(uint4 lhs, uint rhs) => new uint4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator*(uint lhs, uint4 rhs) => new uint4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator/(uint4 lhs, uint4 rhs) => new uint4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator/(uint4 lhs, uint rhs) => new uint4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator/(uint lhs, uint4 rhs) => new uint4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator~ (~v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator~(uint4 v) => new uint4(~v.x, ~v.y, ~v.z, ~v.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator%(uint4 lhs, uint4 rhs) => new uint4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator%(uint4 lhs, uint rhs) => new uint4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator%(uint lhs, uint4 rhs) => new uint4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator^(uint4 lhs, uint4 rhs) => new uint4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator^(uint4 lhs, uint rhs) => new uint4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator^(uint lhs, uint4 rhs) => new uint4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator|(uint4 lhs, uint4 rhs) => new uint4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator|(uint4 lhs, uint rhs) => new uint4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator|(uint lhs, uint4 rhs) => new uint4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator&(uint4 lhs, uint4 rhs) => new uint4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator&(uint4 lhs, uint rhs) => new uint4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a uint4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 operator&(uint lhs, uint4 rhs) => new uint4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);

        #endregion

    }
}
