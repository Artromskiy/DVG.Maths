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
    /// A vector of type float with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct float3 : IEquatable<float3>, IComparable<float3>
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
        /// Returns the number of components (3).
        /// </summary>
        public const int Count = 3;
        
        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly float3 zero = new float3(0f, 0f, 0f);

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(float3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

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

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(float3 lhs, float3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(float3 lhs, float3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);
        
        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(float3 other) => Comparison.Combine(x, y, z, other.x, other.y, other.z);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(float3 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is float3 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Length(float3 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float3 lhs, float3 rhs) => float3.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float3 lhs, float3 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Cross(float3 lhs, float3 rhs) => new float3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Normalize(float3 v) => v / float3.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 FaceForward(float3 N, float3 I, float3 Nref) => float3.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Reflect(float3 I, float3 N) => I - 2 * float3.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Refract(float3 I, float3 N, float eta)
        {
            var dNI = float3.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float3((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Clamp(float3 v, float min, float max) => new float3(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max));
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Parse(string value)
        {
            var values = value.Split(", ");
            return new float3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));
        }
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new float3(float.Parse(values[0], format), float.Parse(values[1], format), float.Parse(values[2], format));
        }
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrLength(float3 v) => v.x * v.x + v.y * v.y + v.z * v.z;
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(float3 lhs, float3 rhs) => float3.SqrLength(lhs - rhs);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 SmoothDamp(float3 source, float3 target, ref float3 velocity, float smoothTime, float deltaTime) => new float3(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime));
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 ClampLength(float3 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                float ratio = maxLength / Maths.Sqrt(sqrLength);
                return new float3(value.x * ratio, value.y * ratio, value.z * ratio);
            }
            return value;
        }
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 MoveTowards(float3 current, float3 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDist = SqrLength(delta);
            return sqrDist <= maxDelta * maxDelta ? target :
            current + delta * maxDelta * Maths.InverseSqrt(sqrDist);
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a float3 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Radians(float3 v) => new float3(Maths.Radians(v.x), Maths.Radians(v.y), Maths.Radians(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Degrees(float3 v) => new float3(Maths.Degrees(v.x), Maths.Degrees(v.y), Maths.Degrees(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Sin(float3 v) => new float3(Maths.Sin(v.x), Maths.Sin(v.y), Maths.Sin(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Cos(float3 v) => new float3(Maths.Cos(v.x), Maths.Cos(v.y), Maths.Cos(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Tan(float3 v) => new float3(Maths.Tan(v.x), Maths.Tan(v.y), Maths.Tan(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Asin(float3 v) => new float3(Maths.Asin(v.x), Maths.Asin(v.y), Maths.Asin(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Acos(float3 v) => new float3(Maths.Acos(v.x), Maths.Acos(v.y), Maths.Acos(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Atan(float3 y, float3 x) => new float3(Maths.Atan(y.x / x.x), Maths.Atan(y.y / x.y), Maths.Atan(y.z / x.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Atan(float3 v) => new float3(Maths.Atan(v.x), Maths.Atan(v.y), Maths.Atan(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Sinh(float3 v) => new float3(Maths.Sinh(v.x), Maths.Sinh(v.y), Maths.Sinh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Cosh(float3 v) => new float3(Maths.Cosh(v.x), Maths.Cosh(v.y), Maths.Cosh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Tanh(float3 v) => new float3(Maths.Tanh(v.x), Maths.Tanh(v.y), Maths.Tanh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Asinh(float3 v) => new float3(Maths.Asinh(v.x), Maths.Asinh(v.y), Maths.Asinh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Acosh(float3 v) => new float3(Maths.Acosh(v.x), Maths.Acosh(v.y), Maths.Acosh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Atanh(float3 v) => new float3(Maths.Atanh(v.x), Maths.Atanh(v.y), Maths.Atanh(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Pow(float3 lhs, float3 rhs) => new float3(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y), Maths.Pow(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Exp(float3 v) => new float3(Maths.Exp(v.x), Maths.Exp(v.y), Maths.Exp(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Log(float3 v) => new float3(Maths.Log(v.x), Maths.Log(v.y), Maths.Log(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Exp2(float3 v) => new float3(Maths.Exp2(v.x), Maths.Exp2(v.y), Maths.Exp2(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Log2(float3 v) => new float3(Maths.Log2(v.x), Maths.Log2(v.y), Maths.Log2(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Sqrt(float3 v) => new float3(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InverseSqrt(float3 v) => new float3(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 LesserThan(float3 lhs, float3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 LesserThanEqual(float3 lhs, float3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 GreaterThan(float3 lhs, float3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 GreaterThanEqual(float3 lhs, float3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Equal(float3 lhs, float3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 NotEqual(float3 lhs, float3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Abs(float3 v) => new float3(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Sign(float3 v) => new float3(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Floor(float3 v) => new float3(Maths.Floor(v.x), Maths.Floor(v.y), Maths.Floor(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Truncate(float3 v) => new float3(Maths.Truncate(v.x), Maths.Truncate(v.y), Maths.Truncate(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Round(float3 v) => new float3(Maths.Round(v.x), Maths.Round(v.y), Maths.Round(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 RoundEven(float3 v) => new float3(Maths.RoundEven(v.x), Maths.RoundEven(v.y), Maths.RoundEven(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Ceil (Maths.Ceil(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Ceil(float3 v) => new float3(Maths.Ceil(v.x), Maths.Ceil(v.y), Maths.Ceil(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Fract(float3 v) => new float3(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y), v.z - Maths.Floor(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Mod(float3 lhs, float3 rhs) => new float3(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y), lhs.z - rhs.z * Maths.Floor(lhs.z / rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Mod(float3 lhs, float rhs) => new float3(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs), lhs.z - rhs * Maths.Floor(lhs.z / rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Lerp(float3 edge0, float3 edge1, float3 v) => new float3(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Lerp(float3 edge0, float3 edge1, float v) => new float3(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Step(float3 edge, float3 x) => new float3(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1, x.z < edge.z ? 0 : 1);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Step(float edge, float3 x) => new float3(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1, x.z < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a float3 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 SmoothStep(float3 edge0, float3 edge1, float3 x) => new float3(Maths.SmoothStep(edge0.x, edge1.x, x.x), Maths.SmoothStep(edge0.y, edge1.y, x.y), Maths.SmoothStep(edge0.z, edge1.z, x.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 SmoothStep(float3 edge0, float3 edge1, float x) => new float3(Maths.SmoothStep(edge0.x, edge1.x, x), Maths.SmoothStep(edge0.y, edge1.y, x), Maths.SmoothStep(edge0.z, edge1.z, x));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 IsNaN(float3 v) => new bool3(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 IsInfinity(float3 v) => new bool3(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Fma(float3 a, float3 b, float3 c) => new float3(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y), Maths.Fma(a.z, b.z, c.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Min(float3 lhs, float3 rhs) => new float3(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Min(float3 lhs, float rhs) => new float3(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Max(float3 lhs, float3 rhs) => new float3(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Max(float3 lhs, float rhs) => new float3(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Clamp(float3 v, float3 min, float3 max) => new float3(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Mix(float3 x, float3 y, bool3 a) => new float3(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 FloatBitsToInt(float3 v) => new int3(Unsafe.As<float, int>(ref v.x), Unsafe.As<float, int>(ref v.y), Unsafe.As<float, int>(ref v.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 FloatBitsToUInt(float3 v) => new uint3(Unsafe.As<float, uint>(ref v.x), Unsafe.As<float, uint>(ref v.y), Unsafe.As<float, uint>(ref v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InvLerp(float3 edge0, float3 edge1, float3 v) => new float3(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y), Maths.InvLerp(edge0.z, edge1.z, v.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InvLerp(float3 edge0, float3 edge1, float v) => new float3(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v), Maths.InvLerp(edge0.z, edge1.z, v));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator-(float3 v) => new float3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator+(float3 lhs, float3 rhs) => new float3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator+(float3 lhs, float rhs) => new float3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator+(float lhs, float3 rhs) => new float3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator-(float3 lhs, float3 rhs) => new float3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator-(float3 lhs, float rhs) => new float3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator-(float lhs, float3 rhs) => new float3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator*(float3 lhs, float3 rhs) => new float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator*(float3 lhs, float rhs) => new float3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator*(float lhs, float3 rhs) => new float3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator/(float3 lhs, float3 rhs) => new float3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator/(float3 lhs, float rhs) => new float3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator/(float lhs, float3 rhs) => new float3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);

        #endregion

    }
}
