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
    /// A vector of type float with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct float4 : IEquatable<float4>, IComparable<float4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public float z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public float w;
        
        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly float4 zero = new float4(0f, 0f, 0f, 0f);

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float x, float y, float z, float w)
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
        public float4(float v)
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
        public float4(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float2 v, float z, float w)
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
        public float4(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float3 v, float w)
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
        public float4(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(float4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public float this[int index]
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
        public float r
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
        public float s
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
        public float g
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
        public float t
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
        public float b
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
        public float p
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
        public float a
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
        public float q
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
        public readonly float4 ___x => new float4(0f, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___r => new float4(0f, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___s => new float4(0f, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___y => new float4(0f, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___g => new float4(0f, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___t => new float4(0f, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___z => new float4(0f, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___b => new float4(0f, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___p => new float4(0f, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___w => new float4(0f, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___a => new float4(0f, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ___q => new float4(0f, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __x_ => new float4(0f, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __r_ => new float4(0f, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __s_ => new float4(0f, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __xx => new float4(0f, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __rr => new float4(0f, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ss => new float4(0f, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __xy => new float4(0f, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __rg => new float4(0f, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __st => new float4(0f, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __xz => new float4(0f, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __rb => new float4(0f, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __sp => new float4(0f, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __xw => new float4(0f, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ra => new float4(0f, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __sq => new float4(0f, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __y_ => new float4(0f, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __g_ => new float4(0f, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __t_ => new float4(0f, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __yx => new float4(0f, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __gr => new float4(0f, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ts => new float4(0f, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __yy => new float4(0f, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __gg => new float4(0f, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __tt => new float4(0f, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __yz => new float4(0f, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __gb => new float4(0f, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __tp => new float4(0f, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __yw => new float4(0f, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ga => new float4(0f, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __tq => new float4(0f, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __z_ => new float4(0f, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __b_ => new float4(0f, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __p_ => new float4(0f, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __zx => new float4(0f, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __br => new float4(0f, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ps => new float4(0f, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __zy => new float4(0f, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __bg => new float4(0f, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __pt => new float4(0f, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __zz => new float4(0f, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __bb => new float4(0f, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __pp => new float4(0f, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __zw => new float4(0f, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ba => new float4(0f, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __pq => new float4(0f, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __w_ => new float4(0f, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __a_ => new float4(0f, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __q_ => new float4(0f, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __wx => new float4(0f, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ar => new float4(0f, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __qs => new float4(0f, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __wy => new float4(0f, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ag => new float4(0f, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __qt => new float4(0f, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __wz => new float4(0f, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ab => new float4(0f, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __qp => new float4(0f, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __ww => new float4(0f, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __aa => new float4(0f, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 __qq => new float4(0f, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _x__ => new float4(0f, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _r__ => new float4(0f, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _s__ => new float4(0f, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _x_x => new float4(0f, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _r_r => new float4(0f, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _s_s => new float4(0f, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _x_y => new float4(0f, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _r_g => new float4(0f, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _s_t => new float4(0f, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _x_z => new float4(0f, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _r_b => new float4(0f, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _s_p => new float4(0f, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _x_w => new float4(0f, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _r_a => new float4(0f, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _s_q => new float4(0f, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xx_ => new float4(0f, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rr_ => new float4(0f, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ss_ => new float4(0f, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xxx => new float4(0f, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rrr => new float4(0f, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sss => new float4(0f, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xxy => new float4(0f, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rrg => new float4(0f, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sst => new float4(0f, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xxz => new float4(0f, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rrb => new float4(0f, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ssp => new float4(0f, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xxw => new float4(0f, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rra => new float4(0f, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ssq => new float4(0f, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xy_ => new float4(0f, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rg_ => new float4(0f, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _st_ => new float4(0f, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xyx => new float4(0f, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rgr => new float4(0f, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sts => new float4(0f, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xyy => new float4(0f, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rgg => new float4(0f, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _stt => new float4(0f, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xyz => new float4(0f, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rgb => new float4(0f, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _stp => new float4(0f, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xyw => new float4(0f, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rga => new float4(0f, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _stq => new float4(0f, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xz_ => new float4(0f, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rb_ => new float4(0f, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sp_ => new float4(0f, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xzx => new float4(0f, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rbr => new float4(0f, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sps => new float4(0f, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xzy => new float4(0f, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rbg => new float4(0f, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _spt => new float4(0f, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xzz => new float4(0f, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rbb => new float4(0f, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _spp => new float4(0f, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xzw => new float4(0f, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rba => new float4(0f, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _spq => new float4(0f, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xw_ => new float4(0f, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ra_ => new float4(0f, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sq_ => new float4(0f, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xwx => new float4(0f, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rar => new float4(0f, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sqs => new float4(0f, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xwy => new float4(0f, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rag => new float4(0f, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sqt => new float4(0f, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xwz => new float4(0f, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _rab => new float4(0f, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sqp => new float4(0f, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _xww => new float4(0f, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _raa => new float4(0f, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _sqq => new float4(0f, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _y__ => new float4(0f, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _g__ => new float4(0f, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _t__ => new float4(0f, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _y_x => new float4(0f, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _g_r => new float4(0f, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _t_s => new float4(0f, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _y_y => new float4(0f, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _g_g => new float4(0f, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _t_t => new float4(0f, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _y_z => new float4(0f, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _g_b => new float4(0f, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _t_p => new float4(0f, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _y_w => new float4(0f, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _g_a => new float4(0f, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _t_q => new float4(0f, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yx_ => new float4(0f, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gr_ => new float4(0f, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ts_ => new float4(0f, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yxx => new float4(0f, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _grr => new float4(0f, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tss => new float4(0f, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yxy => new float4(0f, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _grg => new float4(0f, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tst => new float4(0f, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yxz => new float4(0f, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _grb => new float4(0f, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tsp => new float4(0f, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yxw => new float4(0f, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gra => new float4(0f, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tsq => new float4(0f, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yy_ => new float4(0f, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gg_ => new float4(0f, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tt_ => new float4(0f, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yyx => new float4(0f, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ggr => new float4(0f, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tts => new float4(0f, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yyy => new float4(0f, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ggg => new float4(0f, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ttt => new float4(0f, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yyz => new float4(0f, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ggb => new float4(0f, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ttp => new float4(0f, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yyw => new float4(0f, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gga => new float4(0f, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ttq => new float4(0f, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yz_ => new float4(0f, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gb_ => new float4(0f, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tp_ => new float4(0f, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yzx => new float4(0f, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gbr => new float4(0f, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tps => new float4(0f, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yzy => new float4(0f, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gbg => new float4(0f, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tpt => new float4(0f, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yzz => new float4(0f, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gbb => new float4(0f, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tpp => new float4(0f, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yzw => new float4(0f, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gba => new float4(0f, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tpq => new float4(0f, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yw_ => new float4(0f, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ga_ => new float4(0f, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tq_ => new float4(0f, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ywx => new float4(0f, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gar => new float4(0f, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tqs => new float4(0f, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ywy => new float4(0f, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gag => new float4(0f, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tqt => new float4(0f, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ywz => new float4(0f, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gab => new float4(0f, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tqp => new float4(0f, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _yww => new float4(0f, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _gaa => new float4(0f, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _tqq => new float4(0f, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _z__ => new float4(0f, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _b__ => new float4(0f, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _p__ => new float4(0f, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _z_x => new float4(0f, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _b_r => new float4(0f, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _p_s => new float4(0f, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _z_y => new float4(0f, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _b_g => new float4(0f, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _p_t => new float4(0f, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _z_z => new float4(0f, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _b_b => new float4(0f, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _p_p => new float4(0f, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _z_w => new float4(0f, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _b_a => new float4(0f, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _p_q => new float4(0f, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zx_ => new float4(0f, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _br_ => new float4(0f, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ps_ => new float4(0f, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zxx => new float4(0f, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _brr => new float4(0f, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pss => new float4(0f, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zxy => new float4(0f, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _brg => new float4(0f, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pst => new float4(0f, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zxz => new float4(0f, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _brb => new float4(0f, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _psp => new float4(0f, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zxw => new float4(0f, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bra => new float4(0f, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _psq => new float4(0f, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zy_ => new float4(0f, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bg_ => new float4(0f, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pt_ => new float4(0f, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zyx => new float4(0f, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bgr => new float4(0f, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pts => new float4(0f, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zyy => new float4(0f, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bgg => new float4(0f, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ptt => new float4(0f, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zyz => new float4(0f, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bgb => new float4(0f, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ptp => new float4(0f, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zyw => new float4(0f, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bga => new float4(0f, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ptq => new float4(0f, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zz_ => new float4(0f, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bb_ => new float4(0f, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pp_ => new float4(0f, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zzx => new float4(0f, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bbr => new float4(0f, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pps => new float4(0f, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zzy => new float4(0f, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bbg => new float4(0f, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ppt => new float4(0f, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zzz => new float4(0f, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bbb => new float4(0f, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ppp => new float4(0f, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zzw => new float4(0f, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bba => new float4(0f, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ppq => new float4(0f, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zw_ => new float4(0f, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ba_ => new float4(0f, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pq_ => new float4(0f, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zwx => new float4(0f, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bar => new float4(0f, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pqs => new float4(0f, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zwy => new float4(0f, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bag => new float4(0f, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pqt => new float4(0f, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zwz => new float4(0f, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _bab => new float4(0f, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pqp => new float4(0f, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _zww => new float4(0f, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _baa => new float4(0f, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _pqq => new float4(0f, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _w__ => new float4(0f, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _a__ => new float4(0f, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _q__ => new float4(0f, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _w_x => new float4(0f, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _a_r => new float4(0f, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _q_s => new float4(0f, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _w_y => new float4(0f, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _a_g => new float4(0f, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _q_t => new float4(0f, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _w_z => new float4(0f, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _a_b => new float4(0f, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _q_p => new float4(0f, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _w_w => new float4(0f, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _a_a => new float4(0f, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _q_q => new float4(0f, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wx_ => new float4(0f, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ar_ => new float4(0f, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qs_ => new float4(0f, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wxx => new float4(0f, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _arr => new float4(0f, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qss => new float4(0f, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wxy => new float4(0f, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _arg => new float4(0f, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qst => new float4(0f, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wxz => new float4(0f, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _arb => new float4(0f, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qsp => new float4(0f, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wxw => new float4(0f, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ara => new float4(0f, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qsq => new float4(0f, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wy_ => new float4(0f, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ag_ => new float4(0f, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qt_ => new float4(0f, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wyx => new float4(0f, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _agr => new float4(0f, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qts => new float4(0f, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wyy => new float4(0f, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _agg => new float4(0f, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qtt => new float4(0f, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wyz => new float4(0f, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _agb => new float4(0f, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qtp => new float4(0f, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wyw => new float4(0f, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aga => new float4(0f, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qtq => new float4(0f, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wz_ => new float4(0f, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ab_ => new float4(0f, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qp_ => new float4(0f, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wzx => new float4(0f, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _abr => new float4(0f, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qps => new float4(0f, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wzy => new float4(0f, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _abg => new float4(0f, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qpt => new float4(0f, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wzz => new float4(0f, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _abb => new float4(0f, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qpp => new float4(0f, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wzw => new float4(0f, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aba => new float4(0f, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qpq => new float4(0f, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _ww_ => new float4(0f, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aa_ => new float4(0f, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qq_ => new float4(0f, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wwx => new float4(0f, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aar => new float4(0f, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qqs => new float4(0f, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wwy => new float4(0f, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aag => new float4(0f, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qqt => new float4(0f, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _wwz => new float4(0f, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aab => new float4(0f, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qqp => new float4(0f, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _www => new float4(0f, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _aaa => new float4(0f, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 _qqq => new float4(0f, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x___ => new float4(x, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r___ => new float4(x, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s___ => new float4(x, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x__x => new float4(x, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r__r => new float4(x, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s__s => new float4(x, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x__y => new float4(x, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r__g => new float4(x, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s__t => new float4(x, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x__z => new float4(x, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r__b => new float4(x, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s__p => new float4(x, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x__w => new float4(x, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r__a => new float4(x, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s__q => new float4(x, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_x_ => new float4(x, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_r_ => new float4(x, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_s_ => new float4(x, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_xx => new float4(x, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_rr => new float4(x, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_ss => new float4(x, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_xy => new float4(x, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_rg => new float4(x, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_st => new float4(x, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_xz => new float4(x, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_rb => new float4(x, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_sp => new float4(x, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_xw => new float4(x, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_ra => new float4(x, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_sq => new float4(x, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_y_ => new float4(x, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_g_ => new float4(x, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_t_ => new float4(x, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_yx => new float4(x, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_gr => new float4(x, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_ts => new float4(x, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_yy => new float4(x, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_gg => new float4(x, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_tt => new float4(x, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_yz => new float4(x, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_gb => new float4(x, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_tp => new float4(x, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_yw => new float4(x, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_ga => new float4(x, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_tq => new float4(x, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_z_ => new float4(x, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_b_ => new float4(x, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_p_ => new float4(x, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_zx => new float4(x, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_br => new float4(x, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_ps => new float4(x, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_zy => new float4(x, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_bg => new float4(x, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_pt => new float4(x, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_zz => new float4(x, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_bb => new float4(x, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_pp => new float4(x, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_zw => new float4(x, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_ba => new float4(x, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_pq => new float4(x, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_w_ => new float4(x, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_a_ => new float4(x, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_q_ => new float4(x, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_wx => new float4(x, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_ar => new float4(x, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_qs => new float4(x, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_wy => new float4(x, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_ag => new float4(x, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_qt => new float4(x, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_wz => new float4(x, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_ab => new float4(x, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_qp => new float4(x, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 x_ww => new float4(x, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 r_aa => new float4(x, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 s_qq => new float4(x, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xx__ => new float4(x, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rr__ => new float4(x, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ss__ => new float4(x, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xx_x => new float4(x, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rr_r => new float4(x, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ss_s => new float4(x, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xx_y => new float4(x, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rr_g => new float4(x, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ss_t => new float4(x, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xx_z => new float4(x, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rr_b => new float4(x, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ss_p => new float4(x, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xx_w => new float4(x, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rr_a => new float4(x, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ss_q => new float4(x, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxx_ => new float4(x, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrr_ => new float4(x, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sss_ => new float4(x, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxxx => new float4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrrr => new float4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssss => new float4(x, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxxy => new float4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrrg => new float4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssst => new float4(x, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxxz => new float4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrrb => new float4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sssp => new float4(x, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxxw => new float4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrra => new float4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sssq => new float4(x, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxy_ => new float4(x, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrg_ => new float4(x, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sst_ => new float4(x, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxyx => new float4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrgr => new float4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssts => new float4(x, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxyy => new float4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrgg => new float4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sstt => new float4(x, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxyz => new float4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrgb => new float4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sstp => new float4(x, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxyw => new float4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrga => new float4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sstq => new float4(x, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxz_ => new float4(x, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrb_ => new float4(x, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssp_ => new float4(x, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxzx => new float4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrbr => new float4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssps => new float4(x, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxzy => new float4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrbg => new float4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sspt => new float4(x, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxzz => new float4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrbb => new float4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sspp => new float4(x, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxzw => new float4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrba => new float4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sspq => new float4(x, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxw_ => new float4(x, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rra_ => new float4(x, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssq_ => new float4(x, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxwx => new float4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrar => new float4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssqs => new float4(x, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxwy => new float4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrag => new float4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssqt => new float4(x, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxwz => new float4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rrab => new float4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssqp => new float4(x, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xxww => new float4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rraa => new float4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ssqq => new float4(x, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xy__ => new float4(x, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rg__ => new float4(x, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 st__ => new float4(x, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xy_x => new float4(x, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rg_r => new float4(x, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 st_s => new float4(x, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xy_y => new float4(x, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rg_g => new float4(x, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 st_t => new float4(x, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xy_z => new float4(x, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rg_b => new float4(x, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 st_p => new float4(x, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xy_w => new float4(x, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rg_a => new float4(x, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 st_q => new float4(x, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyx_ => new float4(x, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgr_ => new float4(x, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sts_ => new float4(x, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyxx => new float4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgrr => new float4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stss => new float4(x, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyxy => new float4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgrg => new float4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stst => new float4(x, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyxz => new float4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgrb => new float4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stsp => new float4(x, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyxw => new float4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgra => new float4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stsq => new float4(x, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyy_ => new float4(x, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgg_ => new float4(x, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stt_ => new float4(x, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyyx => new float4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rggr => new float4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stts => new float4(x, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyyy => new float4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rggg => new float4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sttt => new float4(x, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyyz => new float4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rggb => new float4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sttp => new float4(x, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyyw => new float4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgga => new float4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sttq => new float4(x, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyz_ => new float4(x, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgb_ => new float4(x, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stp_ => new float4(x, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyzx => new float4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgbr => new float4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stps => new float4(x, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyzy => new float4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgbg => new float4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stpt => new float4(x, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xyzz => new float4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgbb => new float4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stpp => new float4(x, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 xyzw
        {
            readonly get => new float4(x, y, z, w);
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
        public float4 rgba
        {
            readonly get => new float4(x, y, z, w);
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
        public float4 stpq
        {
            readonly get => new float4(x, y, z, w);
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
        public readonly float4 xyw_ => new float4(x, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rga_ => new float4(x, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stq_ => new float4(x, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xywx => new float4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgar => new float4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stqs => new float4(x, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xywy => new float4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgag => new float4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stqt => new float4(x, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 xywz
        {
            readonly get => new float4(x, y, w, z);
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
        public float4 rgab
        {
            readonly get => new float4(x, y, w, z);
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
        public float4 stqp
        {
            readonly get => new float4(x, y, w, z);
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
        public readonly float4 xyww => new float4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rgaa => new float4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 stqq => new float4(x, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xz__ => new float4(x, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rb__ => new float4(x, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sp__ => new float4(x, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xz_x => new float4(x, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rb_r => new float4(x, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sp_s => new float4(x, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xz_y => new float4(x, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rb_g => new float4(x, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sp_t => new float4(x, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xz_z => new float4(x, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rb_b => new float4(x, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sp_p => new float4(x, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xz_w => new float4(x, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rb_a => new float4(x, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sp_q => new float4(x, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzx_ => new float4(x, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbr_ => new float4(x, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sps_ => new float4(x, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzxx => new float4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbrr => new float4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spss => new float4(x, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzxy => new float4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbrg => new float4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spst => new float4(x, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzxz => new float4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbrb => new float4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spsp => new float4(x, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzxw => new float4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbra => new float4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spsq => new float4(x, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzy_ => new float4(x, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbg_ => new float4(x, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spt_ => new float4(x, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzyx => new float4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbgr => new float4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spts => new float4(x, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzyy => new float4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbgg => new float4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sptt => new float4(x, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzyz => new float4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbgb => new float4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sptp => new float4(x, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 xzyw
        {
            readonly get => new float4(x, z, y, w);
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
        public float4 rbga
        {
            readonly get => new float4(x, z, y, w);
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
        public float4 sptq
        {
            readonly get => new float4(x, z, y, w);
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
        public readonly float4 xzz_ => new float4(x, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbb_ => new float4(x, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spp_ => new float4(x, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzzx => new float4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbbr => new float4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spps => new float4(x, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzzy => new float4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbbg => new float4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sppt => new float4(x, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzzz => new float4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbbb => new float4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sppp => new float4(x, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzzw => new float4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbba => new float4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sppq => new float4(x, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzw_ => new float4(x, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rba_ => new float4(x, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spq_ => new float4(x, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzwx => new float4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbar => new float4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spqs => new float4(x, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 xzwy
        {
            readonly get => new float4(x, z, w, y);
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
        public float4 rbag
        {
            readonly get => new float4(x, z, w, y);
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
        public float4 spqt
        {
            readonly get => new float4(x, z, w, y);
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
        public readonly float4 xzwz => new float4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbab => new float4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spqp => new float4(x, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xzww => new float4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rbaa => new float4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 spqq => new float4(x, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xw__ => new float4(x, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ra__ => new float4(x, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sq__ => new float4(x, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xw_x => new float4(x, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ra_r => new float4(x, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sq_s => new float4(x, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xw_y => new float4(x, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ra_g => new float4(x, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sq_t => new float4(x, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xw_z => new float4(x, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ra_b => new float4(x, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sq_p => new float4(x, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xw_w => new float4(x, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ra_a => new float4(x, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sq_q => new float4(x, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwx_ => new float4(x, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rar_ => new float4(x, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqs_ => new float4(x, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwxx => new float4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rarr => new float4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqss => new float4(x, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwxy => new float4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rarg => new float4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqst => new float4(x, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwxz => new float4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rarb => new float4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqsp => new float4(x, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwxw => new float4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rara => new float4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqsq => new float4(x, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwy_ => new float4(x, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rag_ => new float4(x, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqt_ => new float4(x, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwyx => new float4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ragr => new float4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqts => new float4(x, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwyy => new float4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ragg => new float4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqtt => new float4(x, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 xwyz
        {
            readonly get => new float4(x, w, y, z);
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
        public float4 ragb
        {
            readonly get => new float4(x, w, y, z);
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
        public float4 sqtp
        {
            readonly get => new float4(x, w, y, z);
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
        public readonly float4 xwyw => new float4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raga => new float4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqtq => new float4(x, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwz_ => new float4(x, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rab_ => new float4(x, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqp_ => new float4(x, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwzx => new float4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rabr => new float4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqps => new float4(x, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 xwzy
        {
            readonly get => new float4(x, w, z, y);
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
        public float4 rabg
        {
            readonly get => new float4(x, w, z, y);
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
        public float4 sqpt
        {
            readonly get => new float4(x, w, z, y);
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
        public readonly float4 xwzz => new float4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 rabb => new float4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqpp => new float4(x, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwzw => new float4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raba => new float4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqpq => new float4(x, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xww_ => new float4(x, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raa_ => new float4(x, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqq_ => new float4(x, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwwx => new float4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raar => new float4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqqs => new float4(x, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwwy => new float4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raag => new float4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqqt => new float4(x, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwwz => new float4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raab => new float4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqqp => new float4(x, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 xwww => new float4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 raaa => new float4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 sqqq => new float4(x, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y___ => new float4(y, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g___ => new float4(y, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t___ => new float4(y, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y__x => new float4(y, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g__r => new float4(y, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t__s => new float4(y, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y__y => new float4(y, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g__g => new float4(y, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t__t => new float4(y, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y__z => new float4(y, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g__b => new float4(y, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t__p => new float4(y, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y__w => new float4(y, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g__a => new float4(y, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t__q => new float4(y, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_x_ => new float4(y, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_r_ => new float4(y, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_s_ => new float4(y, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_xx => new float4(y, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_rr => new float4(y, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_ss => new float4(y, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_xy => new float4(y, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_rg => new float4(y, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_st => new float4(y, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_xz => new float4(y, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_rb => new float4(y, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_sp => new float4(y, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_xw => new float4(y, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_ra => new float4(y, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_sq => new float4(y, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_y_ => new float4(y, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_g_ => new float4(y, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_t_ => new float4(y, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_yx => new float4(y, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_gr => new float4(y, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_ts => new float4(y, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_yy => new float4(y, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_gg => new float4(y, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_tt => new float4(y, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_yz => new float4(y, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_gb => new float4(y, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_tp => new float4(y, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_yw => new float4(y, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_ga => new float4(y, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_tq => new float4(y, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_z_ => new float4(y, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_b_ => new float4(y, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_p_ => new float4(y, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_zx => new float4(y, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_br => new float4(y, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_ps => new float4(y, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_zy => new float4(y, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_bg => new float4(y, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_pt => new float4(y, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_zz => new float4(y, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_bb => new float4(y, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_pp => new float4(y, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_zw => new float4(y, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_ba => new float4(y, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_pq => new float4(y, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_w_ => new float4(y, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_a_ => new float4(y, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_q_ => new float4(y, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_wx => new float4(y, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_ar => new float4(y, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_qs => new float4(y, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_wy => new float4(y, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_ag => new float4(y, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_qt => new float4(y, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_wz => new float4(y, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_ab => new float4(y, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_qp => new float4(y, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 y_ww => new float4(y, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 g_aa => new float4(y, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 t_qq => new float4(y, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yx__ => new float4(y, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gr__ => new float4(y, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ts__ => new float4(y, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yx_x => new float4(y, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gr_r => new float4(y, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ts_s => new float4(y, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yx_y => new float4(y, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gr_g => new float4(y, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ts_t => new float4(y, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yx_z => new float4(y, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gr_b => new float4(y, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ts_p => new float4(y, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yx_w => new float4(y, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gr_a => new float4(y, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ts_q => new float4(y, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxx_ => new float4(y, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grr_ => new float4(y, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tss_ => new float4(y, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxxx => new float4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grrr => new float4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsss => new float4(y, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxxy => new float4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grrg => new float4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsst => new float4(y, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxxz => new float4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grrb => new float4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tssp => new float4(y, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxxw => new float4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grra => new float4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tssq => new float4(y, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxy_ => new float4(y, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grg_ => new float4(y, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tst_ => new float4(y, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxyx => new float4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grgr => new float4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsts => new float4(y, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxyy => new float4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grgg => new float4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tstt => new float4(y, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxyz => new float4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grgb => new float4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tstp => new float4(y, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxyw => new float4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grga => new float4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tstq => new float4(y, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxz_ => new float4(y, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grb_ => new float4(y, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsp_ => new float4(y, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxzx => new float4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grbr => new float4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsps => new float4(y, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxzy => new float4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grbg => new float4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tspt => new float4(y, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxzz => new float4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grbb => new float4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tspp => new float4(y, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 yxzw
        {
            readonly get => new float4(y, x, z, w);
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
        public float4 grba
        {
            readonly get => new float4(y, x, z, w);
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
        public float4 tspq
        {
            readonly get => new float4(y, x, z, w);
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
        public readonly float4 yxw_ => new float4(y, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gra_ => new float4(y, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsq_ => new float4(y, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxwx => new float4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grar => new float4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsqs => new float4(y, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yxwy => new float4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 grag => new float4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsqt => new float4(y, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 yxwz
        {
            readonly get => new float4(y, x, w, z);
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
        public float4 grab
        {
            readonly get => new float4(y, x, w, z);
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
        public float4 tsqp
        {
            readonly get => new float4(y, x, w, z);
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
        public readonly float4 yxww => new float4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 graa => new float4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tsqq => new float4(y, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yy__ => new float4(y, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gg__ => new float4(y, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tt__ => new float4(y, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yy_x => new float4(y, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gg_r => new float4(y, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tt_s => new float4(y, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yy_y => new float4(y, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gg_g => new float4(y, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tt_t => new float4(y, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yy_z => new float4(y, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gg_b => new float4(y, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tt_p => new float4(y, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yy_w => new float4(y, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gg_a => new float4(y, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tt_q => new float4(y, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyx_ => new float4(y, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggr_ => new float4(y, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tts_ => new float4(y, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyxx => new float4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggrr => new float4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttss => new float4(y, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyxy => new float4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggrg => new float4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttst => new float4(y, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyxz => new float4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggrb => new float4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttsp => new float4(y, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyxw => new float4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggra => new float4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttsq => new float4(y, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyy_ => new float4(y, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggg_ => new float4(y, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttt_ => new float4(y, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyyx => new float4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gggr => new float4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttts => new float4(y, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyyy => new float4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gggg => new float4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tttt => new float4(y, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyyz => new float4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gggb => new float4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tttp => new float4(y, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyyw => new float4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggga => new float4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tttq => new float4(y, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyz_ => new float4(y, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggb_ => new float4(y, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttp_ => new float4(y, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyzx => new float4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggbr => new float4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttps => new float4(y, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyzy => new float4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggbg => new float4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttpt => new float4(y, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyzz => new float4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggbb => new float4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttpp => new float4(y, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyzw => new float4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggba => new float4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttpq => new float4(y, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyw_ => new float4(y, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gga_ => new float4(y, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttq_ => new float4(y, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yywx => new float4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggar => new float4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttqs => new float4(y, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yywy => new float4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggag => new float4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttqt => new float4(y, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yywz => new float4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggab => new float4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttqp => new float4(y, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yyww => new float4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ggaa => new float4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ttqq => new float4(y, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yz__ => new float4(y, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gb__ => new float4(y, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tp__ => new float4(y, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yz_x => new float4(y, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gb_r => new float4(y, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tp_s => new float4(y, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yz_y => new float4(y, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gb_g => new float4(y, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tp_t => new float4(y, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yz_z => new float4(y, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gb_b => new float4(y, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tp_p => new float4(y, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yz_w => new float4(y, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gb_a => new float4(y, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tp_q => new float4(y, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzx_ => new float4(y, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbr_ => new float4(y, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tps_ => new float4(y, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzxx => new float4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbrr => new float4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpss => new float4(y, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzxy => new float4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbrg => new float4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpst => new float4(y, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzxz => new float4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbrb => new float4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpsp => new float4(y, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 yzxw
        {
            readonly get => new float4(y, z, x, w);
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
        public float4 gbra
        {
            readonly get => new float4(y, z, x, w);
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
        public float4 tpsq
        {
            readonly get => new float4(y, z, x, w);
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
        public readonly float4 yzy_ => new float4(y, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbg_ => new float4(y, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpt_ => new float4(y, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzyx => new float4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbgr => new float4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpts => new float4(y, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzyy => new float4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbgg => new float4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tptt => new float4(y, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzyz => new float4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbgb => new float4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tptp => new float4(y, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzyw => new float4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbga => new float4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tptq => new float4(y, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzz_ => new float4(y, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbb_ => new float4(y, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpp_ => new float4(y, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzzx => new float4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbbr => new float4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpps => new float4(y, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzzy => new float4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbbg => new float4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tppt => new float4(y, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzzz => new float4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbbb => new float4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tppp => new float4(y, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzzw => new float4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbba => new float4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tppq => new float4(y, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzw_ => new float4(y, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gba_ => new float4(y, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpq_ => new float4(y, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 yzwx
        {
            readonly get => new float4(y, z, w, x);
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
        public float4 gbar
        {
            readonly get => new float4(y, z, w, x);
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
        public float4 tpqs
        {
            readonly get => new float4(y, z, w, x);
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
        public readonly float4 yzwy => new float4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbag => new float4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpqt => new float4(y, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzwz => new float4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbab => new float4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpqp => new float4(y, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yzww => new float4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gbaa => new float4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tpqq => new float4(y, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yw__ => new float4(y, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ga__ => new float4(y, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tq__ => new float4(y, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yw_x => new float4(y, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ga_r => new float4(y, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tq_s => new float4(y, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yw_y => new float4(y, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ga_g => new float4(y, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tq_t => new float4(y, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yw_z => new float4(y, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ga_b => new float4(y, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tq_p => new float4(y, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yw_w => new float4(y, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ga_a => new float4(y, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tq_q => new float4(y, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywx_ => new float4(y, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gar_ => new float4(y, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqs_ => new float4(y, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywxx => new float4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 garr => new float4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqss => new float4(y, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywxy => new float4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 garg => new float4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqst => new float4(y, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 ywxz
        {
            readonly get => new float4(y, w, x, z);
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
        public float4 garb
        {
            readonly get => new float4(y, w, x, z);
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
        public float4 tqsp
        {
            readonly get => new float4(y, w, x, z);
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
        public readonly float4 ywxw => new float4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gara => new float4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqsq => new float4(y, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywy_ => new float4(y, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gag_ => new float4(y, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqt_ => new float4(y, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywyx => new float4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gagr => new float4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqts => new float4(y, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywyy => new float4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gagg => new float4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqtt => new float4(y, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywyz => new float4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gagb => new float4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqtp => new float4(y, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywyw => new float4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaga => new float4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqtq => new float4(y, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywz_ => new float4(y, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gab_ => new float4(y, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqp_ => new float4(y, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 ywzx
        {
            readonly get => new float4(y, w, z, x);
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
        public float4 gabr
        {
            readonly get => new float4(y, w, z, x);
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
        public float4 tqps
        {
            readonly get => new float4(y, w, z, x);
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
        public readonly float4 ywzy => new float4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gabg => new float4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqpt => new float4(y, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywzz => new float4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gabb => new float4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqpp => new float4(y, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywzw => new float4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaba => new float4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqpq => new float4(y, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 yww_ => new float4(y, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaa_ => new float4(y, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqq_ => new float4(y, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywwx => new float4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaar => new float4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqqs => new float4(y, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywwy => new float4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaag => new float4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqqt => new float4(y, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywwz => new float4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaab => new float4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqqp => new float4(y, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ywww => new float4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 gaaa => new float4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 tqqq => new float4(y, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z___ => new float4(z, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b___ => new float4(z, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p___ => new float4(z, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z__x => new float4(z, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b__r => new float4(z, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p__s => new float4(z, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z__y => new float4(z, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b__g => new float4(z, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p__t => new float4(z, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z__z => new float4(z, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b__b => new float4(z, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p__p => new float4(z, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z__w => new float4(z, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b__a => new float4(z, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p__q => new float4(z, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_x_ => new float4(z, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_r_ => new float4(z, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_s_ => new float4(z, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_xx => new float4(z, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_rr => new float4(z, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_ss => new float4(z, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_xy => new float4(z, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_rg => new float4(z, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_st => new float4(z, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_xz => new float4(z, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_rb => new float4(z, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_sp => new float4(z, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_xw => new float4(z, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_ra => new float4(z, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_sq => new float4(z, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_y_ => new float4(z, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_g_ => new float4(z, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_t_ => new float4(z, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_yx => new float4(z, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_gr => new float4(z, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_ts => new float4(z, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_yy => new float4(z, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_gg => new float4(z, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_tt => new float4(z, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_yz => new float4(z, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_gb => new float4(z, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_tp => new float4(z, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_yw => new float4(z, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_ga => new float4(z, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_tq => new float4(z, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_z_ => new float4(z, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_b_ => new float4(z, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_p_ => new float4(z, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_zx => new float4(z, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_br => new float4(z, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_ps => new float4(z, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_zy => new float4(z, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_bg => new float4(z, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_pt => new float4(z, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_zz => new float4(z, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_bb => new float4(z, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_pp => new float4(z, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_zw => new float4(z, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_ba => new float4(z, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_pq => new float4(z, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_w_ => new float4(z, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_a_ => new float4(z, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_q_ => new float4(z, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_wx => new float4(z, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_ar => new float4(z, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_qs => new float4(z, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_wy => new float4(z, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_ag => new float4(z, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_qt => new float4(z, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_wz => new float4(z, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_ab => new float4(z, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_qp => new float4(z, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 z_ww => new float4(z, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 b_aa => new float4(z, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 p_qq => new float4(z, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zx__ => new float4(z, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 br__ => new float4(z, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ps__ => new float4(z, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zx_x => new float4(z, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 br_r => new float4(z, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ps_s => new float4(z, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zx_y => new float4(z, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 br_g => new float4(z, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ps_t => new float4(z, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zx_z => new float4(z, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 br_b => new float4(z, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ps_p => new float4(z, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zx_w => new float4(z, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 br_a => new float4(z, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ps_q => new float4(z, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxx_ => new float4(z, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brr_ => new float4(z, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pss_ => new float4(z, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxxx => new float4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brrr => new float4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psss => new float4(z, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxxy => new float4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brrg => new float4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psst => new float4(z, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxxz => new float4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brrb => new float4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pssp => new float4(z, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxxw => new float4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brra => new float4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pssq => new float4(z, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxy_ => new float4(z, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brg_ => new float4(z, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pst_ => new float4(z, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxyx => new float4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brgr => new float4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psts => new float4(z, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxyy => new float4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brgg => new float4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pstt => new float4(z, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxyz => new float4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brgb => new float4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pstp => new float4(z, x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 zxyw
        {
            readonly get => new float4(z, x, y, w);
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
        public float4 brga
        {
            readonly get => new float4(z, x, y, w);
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
        public float4 pstq
        {
            readonly get => new float4(z, x, y, w);
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
        public readonly float4 zxz_ => new float4(z, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brb_ => new float4(z, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psp_ => new float4(z, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxzx => new float4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brbr => new float4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psps => new float4(z, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxzy => new float4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brbg => new float4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pspt => new float4(z, x, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxzz => new float4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brbb => new float4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pspp => new float4(z, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxzw => new float4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brba => new float4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pspq => new float4(z, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxw_ => new float4(z, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bra_ => new float4(z, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psq_ => new float4(z, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxwx => new float4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brar => new float4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psqs => new float4(z, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 zxwy
        {
            readonly get => new float4(z, x, w, y);
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
        public float4 brag
        {
            readonly get => new float4(z, x, w, y);
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
        public float4 psqt
        {
            readonly get => new float4(z, x, w, y);
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
        public readonly float4 zxwz => new float4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 brab => new float4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psqp => new float4(z, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zxww => new float4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 braa => new float4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 psqq => new float4(z, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zy__ => new float4(z, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bg__ => new float4(z, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pt__ => new float4(z, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zy_x => new float4(z, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bg_r => new float4(z, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pt_s => new float4(z, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zy_y => new float4(z, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bg_g => new float4(z, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pt_t => new float4(z, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zy_z => new float4(z, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bg_b => new float4(z, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pt_p => new float4(z, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zy_w => new float4(z, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bg_a => new float4(z, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pt_q => new float4(z, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyx_ => new float4(z, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgr_ => new float4(z, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pts_ => new float4(z, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyxx => new float4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgrr => new float4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptss => new float4(z, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyxy => new float4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgrg => new float4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptst => new float4(z, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyxz => new float4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgrb => new float4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptsp => new float4(z, y, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 zyxw
        {
            readonly get => new float4(z, y, x, w);
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
        public float4 bgra
        {
            readonly get => new float4(z, y, x, w);
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
        public float4 ptsq
        {
            readonly get => new float4(z, y, x, w);
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
        public readonly float4 zyy_ => new float4(z, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgg_ => new float4(z, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptt_ => new float4(z, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyyx => new float4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bggr => new float4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptts => new float4(z, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyyy => new float4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bggg => new float4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pttt => new float4(z, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyyz => new float4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bggb => new float4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pttp => new float4(z, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyyw => new float4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgga => new float4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pttq => new float4(z, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyz_ => new float4(z, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgb_ => new float4(z, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptp_ => new float4(z, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyzx => new float4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgbr => new float4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptps => new float4(z, y, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyzy => new float4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgbg => new float4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptpt => new float4(z, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyzz => new float4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgbb => new float4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptpp => new float4(z, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyzw => new float4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgba => new float4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptpq => new float4(z, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyw_ => new float4(z, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bga_ => new float4(z, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptq_ => new float4(z, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 zywx
        {
            readonly get => new float4(z, y, w, x);
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
        public float4 bgar
        {
            readonly get => new float4(z, y, w, x);
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
        public float4 ptqs
        {
            readonly get => new float4(z, y, w, x);
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
        public readonly float4 zywy => new float4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgag => new float4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptqt => new float4(z, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zywz => new float4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgab => new float4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptqp => new float4(z, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zyww => new float4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bgaa => new float4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ptqq => new float4(z, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zz__ => new float4(z, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bb__ => new float4(z, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pp__ => new float4(z, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zz_x => new float4(z, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bb_r => new float4(z, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pp_s => new float4(z, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zz_y => new float4(z, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bb_g => new float4(z, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pp_t => new float4(z, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zz_z => new float4(z, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bb_b => new float4(z, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pp_p => new float4(z, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zz_w => new float4(z, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bb_a => new float4(z, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pp_q => new float4(z, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzx_ => new float4(z, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbr_ => new float4(z, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pps_ => new float4(z, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzxx => new float4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbrr => new float4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppss => new float4(z, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzxy => new float4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbrg => new float4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppst => new float4(z, z, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzxz => new float4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbrb => new float4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppsp => new float4(z, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzxw => new float4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbra => new float4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppsq => new float4(z, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzy_ => new float4(z, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbg_ => new float4(z, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppt_ => new float4(z, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzyx => new float4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbgr => new float4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppts => new float4(z, z, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzyy => new float4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbgg => new float4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pptt => new float4(z, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzyz => new float4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbgb => new float4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pptp => new float4(z, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzyw => new float4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbga => new float4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pptq => new float4(z, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzz_ => new float4(z, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbb_ => new float4(z, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppp_ => new float4(z, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzzx => new float4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbbr => new float4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppps => new float4(z, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzzy => new float4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbbg => new float4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pppt => new float4(z, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzzz => new float4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbbb => new float4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pppp => new float4(z, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzzw => new float4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbba => new float4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pppq => new float4(z, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzw_ => new float4(z, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bba_ => new float4(z, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppq_ => new float4(z, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzwx => new float4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbar => new float4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppqs => new float4(z, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzwy => new float4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbag => new float4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppqt => new float4(z, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzwz => new float4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbab => new float4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppqp => new float4(z, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zzww => new float4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bbaa => new float4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ppqq => new float4(z, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zw__ => new float4(z, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ba__ => new float4(z, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pq__ => new float4(z, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zw_x => new float4(z, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ba_r => new float4(z, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pq_s => new float4(z, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zw_y => new float4(z, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ba_g => new float4(z, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pq_t => new float4(z, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zw_z => new float4(z, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ba_b => new float4(z, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pq_p => new float4(z, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zw_w => new float4(z, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ba_a => new float4(z, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pq_q => new float4(z, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwx_ => new float4(z, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bar_ => new float4(z, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqs_ => new float4(z, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwxx => new float4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 barr => new float4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqss => new float4(z, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 zwxy
        {
            readonly get => new float4(z, w, x, y);
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
        public float4 barg
        {
            readonly get => new float4(z, w, x, y);
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
        public float4 pqst
        {
            readonly get => new float4(z, w, x, y);
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
        public readonly float4 zwxz => new float4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 barb => new float4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqsp => new float4(z, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwxw => new float4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bara => new float4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqsq => new float4(z, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwy_ => new float4(z, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bag_ => new float4(z, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqt_ => new float4(z, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 zwyx
        {
            readonly get => new float4(z, w, y, x);
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
        public float4 bagr
        {
            readonly get => new float4(z, w, y, x);
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
        public float4 pqts
        {
            readonly get => new float4(z, w, y, x);
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
        public readonly float4 zwyy => new float4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bagg => new float4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqtt => new float4(z, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwyz => new float4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bagb => new float4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqtp => new float4(z, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwyw => new float4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baga => new float4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqtq => new float4(z, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwz_ => new float4(z, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 bab_ => new float4(z, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqp_ => new float4(z, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwzx => new float4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 babr => new float4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqps => new float4(z, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwzy => new float4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 babg => new float4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqpt => new float4(z, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwzz => new float4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 babb => new float4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqpp => new float4(z, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwzw => new float4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baba => new float4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqpq => new float4(z, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zww_ => new float4(z, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baa_ => new float4(z, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqq_ => new float4(z, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwwx => new float4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baar => new float4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqqs => new float4(z, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwwy => new float4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baag => new float4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqqt => new float4(z, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwwz => new float4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baab => new float4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqqp => new float4(z, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 zwww => new float4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 baaa => new float4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 pqqq => new float4(z, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w___ => new float4(w, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a___ => new float4(w, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q___ => new float4(w, 0f, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w__x => new float4(w, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a__r => new float4(w, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q__s => new float4(w, 0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w__y => new float4(w, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a__g => new float4(w, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q__t => new float4(w, 0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w__z => new float4(w, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a__b => new float4(w, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q__p => new float4(w, 0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w__w => new float4(w, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a__a => new float4(w, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q__q => new float4(w, 0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_x_ => new float4(w, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_r_ => new float4(w, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_s_ => new float4(w, 0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_xx => new float4(w, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_rr => new float4(w, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_ss => new float4(w, 0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_xy => new float4(w, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_rg => new float4(w, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_st => new float4(w, 0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_xz => new float4(w, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_rb => new float4(w, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_sp => new float4(w, 0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_xw => new float4(w, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_ra => new float4(w, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_sq => new float4(w, 0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_y_ => new float4(w, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_g_ => new float4(w, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_t_ => new float4(w, 0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_yx => new float4(w, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_gr => new float4(w, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_ts => new float4(w, 0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_yy => new float4(w, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_gg => new float4(w, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_tt => new float4(w, 0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_yz => new float4(w, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_gb => new float4(w, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_tp => new float4(w, 0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_yw => new float4(w, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_ga => new float4(w, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_tq => new float4(w, 0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_z_ => new float4(w, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_b_ => new float4(w, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_p_ => new float4(w, 0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_zx => new float4(w, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_br => new float4(w, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_ps => new float4(w, 0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_zy => new float4(w, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_bg => new float4(w, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_pt => new float4(w, 0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_zz => new float4(w, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_bb => new float4(w, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_pp => new float4(w, 0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_zw => new float4(w, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_ba => new float4(w, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_pq => new float4(w, 0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_w_ => new float4(w, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_a_ => new float4(w, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_q_ => new float4(w, 0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_wx => new float4(w, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_ar => new float4(w, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_qs => new float4(w, 0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_wy => new float4(w, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_ag => new float4(w, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_qt => new float4(w, 0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_wz => new float4(w, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_ab => new float4(w, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_qp => new float4(w, 0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 w_ww => new float4(w, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 a_aa => new float4(w, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 q_qq => new float4(w, 0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wx__ => new float4(w, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ar__ => new float4(w, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qs__ => new float4(w, x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wx_x => new float4(w, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ar_r => new float4(w, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qs_s => new float4(w, x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wx_y => new float4(w, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ar_g => new float4(w, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qs_t => new float4(w, x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wx_z => new float4(w, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ar_b => new float4(w, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qs_p => new float4(w, x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wx_w => new float4(w, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ar_a => new float4(w, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qs_q => new float4(w, x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxx_ => new float4(w, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arr_ => new float4(w, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qss_ => new float4(w, x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxxx => new float4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arrr => new float4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsss => new float4(w, x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxxy => new float4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arrg => new float4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsst => new float4(w, x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxxz => new float4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arrb => new float4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qssp => new float4(w, x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxxw => new float4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arra => new float4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qssq => new float4(w, x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxy_ => new float4(w, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arg_ => new float4(w, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qst_ => new float4(w, x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxyx => new float4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 argr => new float4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsts => new float4(w, x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxyy => new float4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 argg => new float4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qstt => new float4(w, x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 wxyz
        {
            readonly get => new float4(w, x, y, z);
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
        public float4 argb
        {
            readonly get => new float4(w, x, y, z);
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
        public float4 qstp
        {
            readonly get => new float4(w, x, y, z);
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
        public readonly float4 wxyw => new float4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arga => new float4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qstq => new float4(w, x, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxz_ => new float4(w, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arb_ => new float4(w, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsp_ => new float4(w, x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxzx => new float4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arbr => new float4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsps => new float4(w, x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 wxzy
        {
            readonly get => new float4(w, x, z, y);
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
        public float4 arbg
        {
            readonly get => new float4(w, x, z, y);
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
        public float4 qspt
        {
            readonly get => new float4(w, x, z, y);
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
        public readonly float4 wxzz => new float4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arbb => new float4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qspp => new float4(w, x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxzw => new float4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arba => new float4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qspq => new float4(w, x, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxw_ => new float4(w, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ara_ => new float4(w, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsq_ => new float4(w, x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxwx => new float4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arar => new float4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsqs => new float4(w, x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxwy => new float4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arag => new float4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsqt => new float4(w, x, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxwz => new float4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 arab => new float4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsqp => new float4(w, x, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wxww => new float4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 araa => new float4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qsqq => new float4(w, x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wy__ => new float4(w, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ag__ => new float4(w, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qt__ => new float4(w, y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wy_x => new float4(w, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ag_r => new float4(w, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qt_s => new float4(w, y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wy_y => new float4(w, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ag_g => new float4(w, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qt_t => new float4(w, y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wy_z => new float4(w, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ag_b => new float4(w, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qt_p => new float4(w, y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wy_w => new float4(w, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ag_a => new float4(w, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qt_q => new float4(w, y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyx_ => new float4(w, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agr_ => new float4(w, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qts_ => new float4(w, y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyxx => new float4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agrr => new float4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtss => new float4(w, y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyxy => new float4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agrg => new float4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtst => new float4(w, y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 wyxz
        {
            readonly get => new float4(w, y, x, z);
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
        public float4 agrb
        {
            readonly get => new float4(w, y, x, z);
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
        public float4 qtsp
        {
            readonly get => new float4(w, y, x, z);
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
        public readonly float4 wyxw => new float4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agra => new float4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtsq => new float4(w, y, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyy_ => new float4(w, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agg_ => new float4(w, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtt_ => new float4(w, y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyyx => new float4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aggr => new float4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtts => new float4(w, y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyyy => new float4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aggg => new float4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qttt => new float4(w, y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyyz => new float4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aggb => new float4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qttp => new float4(w, y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyyw => new float4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agga => new float4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qttq => new float4(w, y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyz_ => new float4(w, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agb_ => new float4(w, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtp_ => new float4(w, y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 wyzx
        {
            readonly get => new float4(w, y, z, x);
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
        public float4 agbr
        {
            readonly get => new float4(w, y, z, x);
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
        public float4 qtps
        {
            readonly get => new float4(w, y, z, x);
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
        public readonly float4 wyzy => new float4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agbg => new float4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtpt => new float4(w, y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyzz => new float4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agbb => new float4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtpp => new float4(w, y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyzw => new float4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agba => new float4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtpq => new float4(w, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyw_ => new float4(w, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aga_ => new float4(w, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtq_ => new float4(w, y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wywx => new float4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agar => new float4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtqs => new float4(w, y, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wywy => new float4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agag => new float4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtqt => new float4(w, y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wywz => new float4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agab => new float4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtqp => new float4(w, y, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wyww => new float4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 agaa => new float4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qtqq => new float4(w, y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wz__ => new float4(w, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ab__ => new float4(w, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qp__ => new float4(w, z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wz_x => new float4(w, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ab_r => new float4(w, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qp_s => new float4(w, z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wz_y => new float4(w, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ab_g => new float4(w, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qp_t => new float4(w, z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wz_z => new float4(w, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ab_b => new float4(w, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qp_p => new float4(w, z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wz_w => new float4(w, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ab_a => new float4(w, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qp_q => new float4(w, z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzx_ => new float4(w, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abr_ => new float4(w, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qps_ => new float4(w, z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzxx => new float4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abrr => new float4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpss => new float4(w, z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 wzxy
        {
            readonly get => new float4(w, z, x, y);
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
        public float4 abrg
        {
            readonly get => new float4(w, z, x, y);
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
        public float4 qpst
        {
            readonly get => new float4(w, z, x, y);
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
        public readonly float4 wzxz => new float4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abrb => new float4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpsp => new float4(w, z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzxw => new float4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abra => new float4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpsq => new float4(w, z, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzy_ => new float4(w, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abg_ => new float4(w, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpt_ => new float4(w, z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float4 wzyx
        {
            readonly get => new float4(w, z, y, x);
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
        public float4 abgr
        {
            readonly get => new float4(w, z, y, x);
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
        public float4 qpts
        {
            readonly get => new float4(w, z, y, x);
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
        public readonly float4 wzyy => new float4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abgg => new float4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qptt => new float4(w, z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzyz => new float4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abgb => new float4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qptp => new float4(w, z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzyw => new float4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abga => new float4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qptq => new float4(w, z, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzz_ => new float4(w, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abb_ => new float4(w, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpp_ => new float4(w, z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzzx => new float4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abbr => new float4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpps => new float4(w, z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzzy => new float4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abbg => new float4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qppt => new float4(w, z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzzz => new float4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abbb => new float4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qppp => new float4(w, z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzzw => new float4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abba => new float4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qppq => new float4(w, z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzw_ => new float4(w, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aba_ => new float4(w, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpq_ => new float4(w, z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzwx => new float4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abar => new float4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpqs => new float4(w, z, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzwy => new float4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abag => new float4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpqt => new float4(w, z, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzwz => new float4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abab => new float4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpqp => new float4(w, z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wzww => new float4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 abaa => new float4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qpqq => new float4(w, z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ww__ => new float4(w, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aa__ => new float4(w, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qq__ => new float4(w, w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ww_x => new float4(w, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aa_r => new float4(w, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qq_s => new float4(w, w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ww_y => new float4(w, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aa_g => new float4(w, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qq_t => new float4(w, w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ww_z => new float4(w, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aa_b => new float4(w, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qq_p => new float4(w, w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 ww_w => new float4(w, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aa_a => new float4(w, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qq_q => new float4(w, w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwx_ => new float4(w, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aar_ => new float4(w, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqs_ => new float4(w, w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwxx => new float4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aarr => new float4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqss => new float4(w, w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwxy => new float4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aarg => new float4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqst => new float4(w, w, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwxz => new float4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aarb => new float4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqsp => new float4(w, w, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwxw => new float4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aara => new float4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqsq => new float4(w, w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwy_ => new float4(w, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aag_ => new float4(w, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqt_ => new float4(w, w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwyx => new float4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aagr => new float4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqts => new float4(w, w, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwyy => new float4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aagg => new float4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqtt => new float4(w, w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwyz => new float4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aagb => new float4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqtp => new float4(w, w, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwyw => new float4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaga => new float4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqtq => new float4(w, w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwz_ => new float4(w, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aab_ => new float4(w, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqp_ => new float4(w, w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwzx => new float4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aabr => new float4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqps => new float4(w, w, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwzy => new float4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aabg => new float4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqpt => new float4(w, w, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwzz => new float4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aabb => new float4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqpp => new float4(w, w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwzw => new float4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaba => new float4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqpq => new float4(w, w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 www_ => new float4(w, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaa_ => new float4(w, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqq_ => new float4(w, w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwwx => new float4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaar => new float4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqqs => new float4(w, w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwwy => new float4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaag => new float4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqqt => new float4(w, w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwwz => new float4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaab => new float4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqqp => new float4(w, w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 wwww => new float4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 aaaa => new float4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float4 qqqq => new float4(w, w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __x => new float3(0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __r => new float3(0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __s => new float3(0f, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __y => new float3(0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __g => new float3(0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __t => new float3(0f, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __z => new float3(0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __b => new float3(0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __p => new float3(0f, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __w => new float3(0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __a => new float3(0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 __q => new float3(0f, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _x_ => new float3(0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _r_ => new float3(0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _s_ => new float3(0f, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _xx => new float3(0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _rr => new float3(0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ss => new float3(0f, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _xy => new float3(0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _rg => new float3(0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _st => new float3(0f, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _xz => new float3(0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _rb => new float3(0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _sp => new float3(0f, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _xw => new float3(0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ra => new float3(0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _sq => new float3(0f, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _y_ => new float3(0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _g_ => new float3(0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _t_ => new float3(0f, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _yx => new float3(0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _gr => new float3(0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ts => new float3(0f, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _yy => new float3(0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _gg => new float3(0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _tt => new float3(0f, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _yz => new float3(0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _gb => new float3(0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _tp => new float3(0f, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _yw => new float3(0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ga => new float3(0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _tq => new float3(0f, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _z_ => new float3(0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _b_ => new float3(0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _p_ => new float3(0f, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _zx => new float3(0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _br => new float3(0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ps => new float3(0f, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _zy => new float3(0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _bg => new float3(0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _pt => new float3(0f, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _zz => new float3(0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _bb => new float3(0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _pp => new float3(0f, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _zw => new float3(0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ba => new float3(0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _pq => new float3(0f, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _w_ => new float3(0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _a_ => new float3(0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _q_ => new float3(0f, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _wx => new float3(0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ar => new float3(0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _qs => new float3(0f, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _wy => new float3(0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ag => new float3(0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _qt => new float3(0f, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _wz => new float3(0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ab => new float3(0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _qp => new float3(0f, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _ww => new float3(0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _aa => new float3(0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 _qq => new float3(0f, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 x__ => new float3(x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 r__ => new float3(x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 s__ => new float3(x, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 x_x => new float3(x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 r_r => new float3(x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 s_s => new float3(x, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 x_y => new float3(x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 r_g => new float3(x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 s_t => new float3(x, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 x_z => new float3(x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 r_b => new float3(x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 s_p => new float3(x, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 x_w => new float3(x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 r_a => new float3(x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 s_q => new float3(x, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xx_ => new float3(x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rr_ => new float3(x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ss_ => new float3(x, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xxx => new float3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rrr => new float3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sss => new float3(x, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xxy => new float3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rrg => new float3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sst => new float3(x, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xxz => new float3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rrb => new float3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ssp => new float3(x, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xxw => new float3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rra => new float3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ssq => new float3(x, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xy_ => new float3(x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rg_ => new float3(x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 st_ => new float3(x, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xyx => new float3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rgr => new float3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sts => new float3(x, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xyy => new float3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rgg => new float3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 stt => new float3(x, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 xyz
        {
            readonly get => new float3(x, y, z);
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
        public float3 rgb
        {
            readonly get => new float3(x, y, z);
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
        public float3 stp
        {
            readonly get => new float3(x, y, z);
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
        public float3 xyw
        {
            readonly get => new float3(x, y, w);
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
        public float3 rga
        {
            readonly get => new float3(x, y, w);
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
        public float3 stq
        {
            readonly get => new float3(x, y, w);
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
        public readonly float3 xz_ => new float3(x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rb_ => new float3(x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sp_ => new float3(x, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xzx => new float3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rbr => new float3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sps => new float3(x, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 xzy
        {
            readonly get => new float3(x, z, y);
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
        public float3 rbg
        {
            readonly get => new float3(x, z, y);
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
        public float3 spt
        {
            readonly get => new float3(x, z, y);
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
        public readonly float3 xzz => new float3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rbb => new float3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 spp => new float3(x, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 xzw
        {
            readonly get => new float3(x, z, w);
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
        public float3 rba
        {
            readonly get => new float3(x, z, w);
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
        public float3 spq
        {
            readonly get => new float3(x, z, w);
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
        public readonly float3 xw_ => new float3(x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ra_ => new float3(x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sq_ => new float3(x, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 xwx => new float3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 rar => new float3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sqs => new float3(x, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 xwy
        {
            readonly get => new float3(x, w, y);
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
        public float3 rag
        {
            readonly get => new float3(x, w, y);
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
        public float3 sqt
        {
            readonly get => new float3(x, w, y);
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
        public float3 xwz
        {
            readonly get => new float3(x, w, z);
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
        public float3 rab
        {
            readonly get => new float3(x, w, z);
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
        public float3 sqp
        {
            readonly get => new float3(x, w, z);
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
        public readonly float3 xww => new float3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 raa => new float3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 sqq => new float3(x, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 y__ => new float3(y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 g__ => new float3(y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 t__ => new float3(y, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 y_x => new float3(y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 g_r => new float3(y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 t_s => new float3(y, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 y_y => new float3(y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 g_g => new float3(y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 t_t => new float3(y, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 y_z => new float3(y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 g_b => new float3(y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 t_p => new float3(y, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 y_w => new float3(y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 g_a => new float3(y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 t_q => new float3(y, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yx_ => new float3(y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gr_ => new float3(y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ts_ => new float3(y, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yxx => new float3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 grr => new float3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tss => new float3(y, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yxy => new float3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 grg => new float3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tst => new float3(y, x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 yxz
        {
            readonly get => new float3(y, x, z);
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
        public float3 grb
        {
            readonly get => new float3(y, x, z);
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
        public float3 tsp
        {
            readonly get => new float3(y, x, z);
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
        public float3 yxw
        {
            readonly get => new float3(y, x, w);
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
        public float3 gra
        {
            readonly get => new float3(y, x, w);
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
        public float3 tsq
        {
            readonly get => new float3(y, x, w);
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
        public readonly float3 yy_ => new float3(y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gg_ => new float3(y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tt_ => new float3(y, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yyx => new float3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ggr => new float3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tts => new float3(y, y, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yyy => new float3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ggg => new float3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ttt => new float3(y, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yyz => new float3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ggb => new float3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ttp => new float3(y, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yyw => new float3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gga => new float3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ttq => new float3(y, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yz_ => new float3(y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gb_ => new float3(y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tp_ => new float3(y, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 yzx
        {
            readonly get => new float3(y, z, x);
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
        public float3 gbr
        {
            readonly get => new float3(y, z, x);
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
        public float3 tps
        {
            readonly get => new float3(y, z, x);
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
        public readonly float3 yzy => new float3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gbg => new float3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tpt => new float3(y, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 yzz => new float3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gbb => new float3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tpp => new float3(y, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 yzw
        {
            readonly get => new float3(y, z, w);
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
        public float3 gba
        {
            readonly get => new float3(y, z, w);
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
        public float3 tpq
        {
            readonly get => new float3(y, z, w);
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
        public readonly float3 yw_ => new float3(y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ga_ => new float3(y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tq_ => new float3(y, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 ywx
        {
            readonly get => new float3(y, w, x);
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
        public float3 gar
        {
            readonly get => new float3(y, w, x);
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
        public float3 tqs
        {
            readonly get => new float3(y, w, x);
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
        public readonly float3 ywy => new float3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gag => new float3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tqt => new float3(y, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 ywz
        {
            readonly get => new float3(y, w, z);
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
        public float3 gab
        {
            readonly get => new float3(y, w, z);
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
        public float3 tqp
        {
            readonly get => new float3(y, w, z);
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
        public readonly float3 yww => new float3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 gaa => new float3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 tqq => new float3(y, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 z__ => new float3(z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 b__ => new float3(z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 p__ => new float3(z, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 z_x => new float3(z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 b_r => new float3(z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 p_s => new float3(z, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 z_y => new float3(z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 b_g => new float3(z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 p_t => new float3(z, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 z_z => new float3(z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 b_b => new float3(z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 p_p => new float3(z, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 z_w => new float3(z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 b_a => new float3(z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 p_q => new float3(z, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zx_ => new float3(z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 br_ => new float3(z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ps_ => new float3(z, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zxx => new float3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 brr => new float3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pss => new float3(z, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 zxy
        {
            readonly get => new float3(z, x, y);
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
        public float3 brg
        {
            readonly get => new float3(z, x, y);
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
        public float3 pst
        {
            readonly get => new float3(z, x, y);
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
        public readonly float3 zxz => new float3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 brb => new float3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 psp => new float3(z, x, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 zxw
        {
            readonly get => new float3(z, x, w);
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
        public float3 bra
        {
            readonly get => new float3(z, x, w);
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
        public float3 psq
        {
            readonly get => new float3(z, x, w);
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
        public readonly float3 zy_ => new float3(z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bg_ => new float3(z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pt_ => new float3(z, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 zyx
        {
            readonly get => new float3(z, y, x);
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
        public float3 bgr
        {
            readonly get => new float3(z, y, x);
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
        public float3 pts
        {
            readonly get => new float3(z, y, x);
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
        public readonly float3 zyy => new float3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bgg => new float3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ptt => new float3(z, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zyz => new float3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bgb => new float3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ptp => new float3(z, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 zyw
        {
            readonly get => new float3(z, y, w);
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
        public float3 bga
        {
            readonly get => new float3(z, y, w);
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
        public float3 ptq
        {
            readonly get => new float3(z, y, w);
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
        public readonly float3 zz_ => new float3(z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bb_ => new float3(z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pp_ => new float3(z, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zzx => new float3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bbr => new float3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pps => new float3(z, z, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zzy => new float3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bbg => new float3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ppt => new float3(z, z, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zzz => new float3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bbb => new float3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ppp => new float3(z, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zzw => new float3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bba => new float3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ppq => new float3(z, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zw_ => new float3(z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ba_ => new float3(z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pq_ => new float3(z, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 zwx
        {
            readonly get => new float3(z, w, x);
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
        public float3 bar
        {
            readonly get => new float3(z, w, x);
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
        public float3 pqs
        {
            readonly get => new float3(z, w, x);
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
        public float3 zwy
        {
            readonly get => new float3(z, w, y);
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
        public float3 bag
        {
            readonly get => new float3(z, w, y);
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
        public float3 pqt
        {
            readonly get => new float3(z, w, y);
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
        public readonly float3 zwz => new float3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 bab => new float3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pqp => new float3(z, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 zww => new float3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 baa => new float3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 pqq => new float3(z, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 w__ => new float3(w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 a__ => new float3(w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 q__ => new float3(w, 0f, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 w_x => new float3(w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 a_r => new float3(w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 q_s => new float3(w, 0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 w_y => new float3(w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 a_g => new float3(w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 q_t => new float3(w, 0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 w_z => new float3(w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 a_b => new float3(w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 q_p => new float3(w, 0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 w_w => new float3(w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 a_a => new float3(w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 q_q => new float3(w, 0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wx_ => new float3(w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ar_ => new float3(w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qs_ => new float3(w, x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wxx => new float3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 arr => new float3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qss => new float3(w, x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 wxy
        {
            readonly get => new float3(w, x, y);
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
        public float3 arg
        {
            readonly get => new float3(w, x, y);
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
        public float3 qst
        {
            readonly get => new float3(w, x, y);
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
        public float3 wxz
        {
            readonly get => new float3(w, x, z);
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
        public float3 arb
        {
            readonly get => new float3(w, x, z);
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
        public float3 qsp
        {
            readonly get => new float3(w, x, z);
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
        public readonly float3 wxw => new float3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ara => new float3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qsq => new float3(w, x, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wy_ => new float3(w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ag_ => new float3(w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qt_ => new float3(w, y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 wyx
        {
            readonly get => new float3(w, y, x);
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
        public float3 agr
        {
            readonly get => new float3(w, y, x);
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
        public float3 qts
        {
            readonly get => new float3(w, y, x);
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
        public readonly float3 wyy => new float3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 agg => new float3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qtt => new float3(w, y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 wyz
        {
            readonly get => new float3(w, y, z);
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
        public float3 agb
        {
            readonly get => new float3(w, y, z);
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
        public float3 qtp
        {
            readonly get => new float3(w, y, z);
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
        public readonly float3 wyw => new float3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aga => new float3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qtq => new float3(w, y, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wz_ => new float3(w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ab_ => new float3(w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qp_ => new float3(w, z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float3 wzx
        {
            readonly get => new float3(w, z, x);
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
        public float3 abr
        {
            readonly get => new float3(w, z, x);
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
        public float3 qps
        {
            readonly get => new float3(w, z, x);
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
        public float3 wzy
        {
            readonly get => new float3(w, z, y);
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
        public float3 abg
        {
            readonly get => new float3(w, z, y);
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
        public float3 qpt
        {
            readonly get => new float3(w, z, y);
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
        public readonly float3 wzz => new float3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 abb => new float3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qpp => new float3(w, z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wzw => new float3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aba => new float3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qpq => new float3(w, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 ww_ => new float3(w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aa_ => new float3(w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qq_ => new float3(w, w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wwx => new float3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aar => new float3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qqs => new float3(w, w, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wwy => new float3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aag => new float3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qqt => new float3(w, w, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 wwz => new float3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aab => new float3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qqp => new float3(w, w, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 www => new float3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 aaa => new float3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float3 qqq => new float3(w, w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _x => new float2(0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _r => new float2(0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _s => new float2(0f, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _y => new float2(0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _g => new float2(0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _t => new float2(0f, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _z => new float2(0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _b => new float2(0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _p => new float2(0f, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _w => new float2(0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _a => new float2(0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 _q => new float2(0f, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 x_ => new float2(x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 r_ => new float2(x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 s_ => new float2(x, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 xx => new float2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 rr => new float2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 ss => new float2(x, x);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float2 xy
        {
            readonly get => new float2(x, y);
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
        public float2 rg
        {
            readonly get => new float2(x, y);
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
        public float2 st
        {
            readonly get => new float2(x, y);
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
        public float2 xz
        {
            readonly get => new float2(x, z);
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
        public float2 rb
        {
            readonly get => new float2(x, z);
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
        public float2 sp
        {
            readonly get => new float2(x, z);
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
        public float2 xw
        {
            readonly get => new float2(x, w);
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
        public float2 ra
        {
            readonly get => new float2(x, w);
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
        public float2 sq
        {
            readonly get => new float2(x, w);
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
        public readonly float2 y_ => new float2(y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 g_ => new float2(y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 t_ => new float2(y, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float2 yx
        {
            readonly get => new float2(y, x);
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
        public float2 gr
        {
            readonly get => new float2(y, x);
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
        public float2 ts
        {
            readonly get => new float2(y, x);
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
        public readonly float2 yy => new float2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 gg => new float2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 tt => new float2(y, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float2 yz
        {
            readonly get => new float2(y, z);
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
        public float2 gb
        {
            readonly get => new float2(y, z);
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
        public float2 tp
        {
            readonly get => new float2(y, z);
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
        public float2 yw
        {
            readonly get => new float2(y, w);
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
        public float2 ga
        {
            readonly get => new float2(y, w);
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
        public float2 tq
        {
            readonly get => new float2(y, w);
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
        public readonly float2 z_ => new float2(z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 b_ => new float2(z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 p_ => new float2(z, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float2 zx
        {
            readonly get => new float2(z, x);
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
        public float2 br
        {
            readonly get => new float2(z, x);
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
        public float2 ps
        {
            readonly get => new float2(z, x);
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
        public float2 zy
        {
            readonly get => new float2(z, y);
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
        public float2 bg
        {
            readonly get => new float2(z, y);
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
        public float2 pt
        {
            readonly get => new float2(z, y);
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
        public readonly float2 zz => new float2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 bb => new float2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 pp => new float2(z, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float2 zw
        {
            readonly get => new float2(z, w);
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
        public float2 ba
        {
            readonly get => new float2(z, w);
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
        public float2 pq
        {
            readonly get => new float2(z, w);
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
        public readonly float2 w_ => new float2(w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 a_ => new float2(w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 q_ => new float2(w, 0f);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public float2 wx
        {
            readonly get => new float2(w, x);
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
        public float2 ar
        {
            readonly get => new float2(w, x);
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
        public float2 qs
        {
            readonly get => new float2(w, x);
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
        public float2 wy
        {
            readonly get => new float2(w, y);
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
        public float2 ag
        {
            readonly get => new float2(w, y);
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
        public float2 qt
        {
            readonly get => new float2(w, y);
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
        public float2 wz
        {
            readonly get => new float2(w, z);
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
        public float2 ab
        {
            readonly get => new float2(w, z);
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
        public float2 qp
        {
            readonly get => new float2(w, z);
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
        public readonly float2 ww => new float2(w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 aa => new float2(w, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public readonly float2 qq => new float2(w, w);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public readonly int Count => 4;

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(float4 lhs, float4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(float4 lhs, float4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

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
        public readonly int CompareTo(float4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(float4 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is float4 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Length(float4 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float4 lhs, float4 rhs) => float4.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float4 lhs, float4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Normalize(float4 v) => v / float4.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 FaceForward(float4 N, float4 I, float4 Nref) => float4.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Reflect(float4 I, float4 N) => I - 2 * float4.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Refract(float4 I, float4 N, float eta)
        {
            var dNI = float4.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float4((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Clamp(float4 v, float min, float max) => new float4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Parse(string value)
        {
            var values = value.Split(", ");
            return new float4(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]), float.Parse(values[3]));
        }
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new float4(float.Parse(values[0], format), float.Parse(values[1], format), float.Parse(values[2], format), float.Parse(values[3], format));
        }
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrLength(float4 v) => v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w;
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(float4 lhs, float4 rhs) => float4.SqrLength(lhs - rhs);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 SmoothDamp(float4 source, float4 target, ref float4 velocity, float smoothTime, float deltaTime) => new float4(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime), Maths.SmoothDamp(source.w, target.w, ref velocity.w, smoothTime, deltaTime));
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 ClampLength(float4 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                float ratio = maxLength / Maths.Sqrt(sqrLength);
                return new float4(value.x * ratio, value.y * ratio, value.z * ratio, value.w * ratio);
            }
            return value;
        }
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 MoveTowards(float4 current, float4 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDist = SqrLength(delta);
            return sqrDist <= maxDelta * maxDelta ? target :
            current + delta * maxDelta * Maths.InverseSqrt(sqrDist);
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a float4 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Radians(float4 v) => new float4(Maths.Radians(v.x), Maths.Radians(v.y), Maths.Radians(v.z), Maths.Radians(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Degrees(float4 v) => new float4(Maths.Degrees(v.x), Maths.Degrees(v.y), Maths.Degrees(v.z), Maths.Degrees(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Sin(float4 v) => new float4(Maths.Sin(v.x), Maths.Sin(v.y), Maths.Sin(v.z), Maths.Sin(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Cos(float4 v) => new float4(Maths.Cos(v.x), Maths.Cos(v.y), Maths.Cos(v.z), Maths.Cos(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Tan(float4 v) => new float4(Maths.Tan(v.x), Maths.Tan(v.y), Maths.Tan(v.z), Maths.Tan(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Asin(float4 v) => new float4(Maths.Asin(v.x), Maths.Asin(v.y), Maths.Asin(v.z), Maths.Asin(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Acos(float4 v) => new float4(Maths.Acos(v.x), Maths.Acos(v.y), Maths.Acos(v.z), Maths.Acos(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Atan(float4 y, float4 x) => new float4(Maths.Atan(y.x / x.x), Maths.Atan(y.y / x.y), Maths.Atan(y.z / x.z), Maths.Atan(y.w / x.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Atan(float4 v) => new float4(Maths.Atan(v.x), Maths.Atan(v.y), Maths.Atan(v.z), Maths.Atan(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Sinh(float4 v) => new float4(Maths.Sinh(v.x), Maths.Sinh(v.y), Maths.Sinh(v.z), Maths.Sinh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Cosh(float4 v) => new float4(Maths.Cosh(v.x), Maths.Cosh(v.y), Maths.Cosh(v.z), Maths.Cosh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Tanh(float4 v) => new float4(Maths.Tanh(v.x), Maths.Tanh(v.y), Maths.Tanh(v.z), Maths.Tanh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Asinh(float4 v) => new float4(Maths.Asinh(v.x), Maths.Asinh(v.y), Maths.Asinh(v.z), Maths.Asinh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Acosh(float4 v) => new float4(Maths.Acosh(v.x), Maths.Acosh(v.y), Maths.Acosh(v.z), Maths.Acosh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Atanh(float4 v) => new float4(Maths.Atanh(v.x), Maths.Atanh(v.y), Maths.Atanh(v.z), Maths.Atanh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Pow(float4 lhs, float4 rhs) => new float4(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y), Maths.Pow(lhs.z, rhs.z), Maths.Pow(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Exp(float4 v) => new float4(Maths.Exp(v.x), Maths.Exp(v.y), Maths.Exp(v.z), Maths.Exp(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Log(float4 v) => new float4(Maths.Log(v.x), Maths.Log(v.y), Maths.Log(v.z), Maths.Log(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Exp2(float4 v) => new float4(Maths.Exp2(v.x), Maths.Exp2(v.y), Maths.Exp2(v.z), Maths.Exp2(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Log2(float4 v) => new float4(Maths.Log2(v.x), Maths.Log2(v.y), Maths.Log2(v.z), Maths.Log2(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Sqrt(float4 v) => new float4(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z), Maths.Sqrt(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InverseSqrt(float4 v) => new float4(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z), Maths.InverseSqrt(v.w));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 LesserThan(float4 lhs, float4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 LesserThanEqual(float4 lhs, float4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 GreaterThan(float4 lhs, float4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 GreaterThanEqual(float4 lhs, float4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Equal(float4 lhs, float4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 NotEqual(float4 lhs, float4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Abs(float4 v) => new float4(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z), Maths.Abs(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Sign(float4 v) => new float4(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z), Maths.Sign(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Floor(float4 v) => new float4(Maths.Floor(v.x), Maths.Floor(v.y), Maths.Floor(v.z), Maths.Floor(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Truncate(float4 v) => new float4(Maths.Truncate(v.x), Maths.Truncate(v.y), Maths.Truncate(v.z), Maths.Truncate(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Round(float4 v) => new float4(Maths.Round(v.x), Maths.Round(v.y), Maths.Round(v.z), Maths.Round(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 RoundEven(float4 v) => new float4(Maths.RoundEven(v.x), Maths.RoundEven(v.y), Maths.RoundEven(v.z), Maths.RoundEven(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Ceil (Maths.Ceil(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ceil(float4 v) => new float4(Maths.Ceil(v.x), Maths.Ceil(v.y), Maths.Ceil(v.z), Maths.Ceil(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Fract(float4 v) => new float4(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y), v.z - Maths.Floor(v.z), v.w - Maths.Floor(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Mod(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y), lhs.z - rhs.z * Maths.Floor(lhs.z / rhs.z), lhs.w - rhs.w * Maths.Floor(lhs.w / rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Mod(float4 lhs, float rhs) => new float4(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs), lhs.z - rhs * Maths.Floor(lhs.z / rhs), lhs.w - rhs * Maths.Floor(lhs.w / rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Lerp(float4 edge0, float4 edge1, float4 v) => new float4(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z), Maths.Lerp(edge0.w, edge1.w, v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Lerp(float4 edge0, float4 edge1, float v) => new float4(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v), Maths.Lerp(edge0.w, edge1.w, v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Step(float4 edge, float4 x) => new float4(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1, x.z < edge.z ? 0 : 1, x.w < edge.w ? 0 : 1);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Step(float edge, float4 x) => new float4(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1, x.z < edge ? 0 : 1, x.w < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a float4 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 SmoothStep(float4 edge0, float4 edge1, float4 x) => new float4(Maths.SmoothStep(edge0.x, edge1.x, x.x), Maths.SmoothStep(edge0.y, edge1.y, x.y), Maths.SmoothStep(edge0.z, edge1.z, x.z), Maths.SmoothStep(edge0.w, edge1.w, x.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 SmoothStep(float4 edge0, float4 edge1, float x) => new float4(Maths.SmoothStep(edge0.x, edge1.x, x), Maths.SmoothStep(edge0.y, edge1.y, x), Maths.SmoothStep(edge0.z, edge1.z, x), Maths.SmoothStep(edge0.w, edge1.w, x));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 IsNaN(float4 v) => new bool4(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z), float.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 IsInfinity(float4 v) => new bool4(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z), float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Fma(float4 a, float4 b, float4 c) => new float4(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y), Maths.Fma(a.z, b.z, c.z), Maths.Fma(a.w, b.w, c.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Min(float4 lhs, float4 rhs) => new float4(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z), Maths.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Min(float4 lhs, float rhs) => new float4(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs), Maths.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Max(float4 lhs, float4 rhs) => new float4(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z), Maths.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Max(float4 lhs, float rhs) => new float4(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs), Maths.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Clamp(float4 v, float4 min, float4 max) => new float4(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z), Maths.Clamp(v.w, min.w, max.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Mix(float4 x, float4 y, bool4 a) => new float4(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z, a.w ? y.w : x.w);
        
        /// <summary>
        /// Returns a int4 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 FloatBitsToInt(float4 v) => new int4(Unsafe.As<float, int>(ref v.x), Unsafe.As<float, int>(ref v.y), Unsafe.As<float, int>(ref v.z), Unsafe.As<float, int>(ref v.w));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 FloatBitsToUInt(float4 v) => new uint4(Unsafe.As<float, uint>(ref v.x), Unsafe.As<float, uint>(ref v.y), Unsafe.As<float, uint>(ref v.z), Unsafe.As<float, uint>(ref v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InvLerp(float4 edge0, float4 edge1, float4 v) => new float4(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y), Maths.InvLerp(edge0.z, edge1.z, v.z), Maths.InvLerp(edge0.w, edge1.w, v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InvLerp(float4 edge0, float4 edge1, float v) => new float4(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v), Maths.InvLerp(edge0.z, edge1.z, v), Maths.InvLerp(edge0.w, edge1.w, v));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator-(float4 v) => new float4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator+(float4 lhs, float4 rhs) => new float4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator+(float4 lhs, float rhs) => new float4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator+(float lhs, float4 rhs) => new float4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator-(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator-(float4 lhs, float rhs) => new float4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator-(float lhs, float4 rhs) => new float4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator*(float4 lhs, float4 rhs) => new float4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator*(float4 lhs, float rhs) => new float4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator*(float lhs, float4 rhs) => new float4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator/(float4 lhs, float4 rhs) => new float4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator/(float4 lhs, float rhs) => new float4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator/(float lhs, float4 rhs) => new float4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        #endregion

    }
}
