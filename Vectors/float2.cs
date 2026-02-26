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
    /// A vector of type float with 2 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct float2 : IEquatable<float2>, IComparable<float2>
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
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly float2 zero = new float2(0f, 0f);

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double2.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float2 v) => new double2((double)v.x, (double)v.y);

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
        /// Returns the number of components (2).
        /// </summary>
        public readonly int Count => 2;

        #endregion


        #region Operators
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(float2 lhs, float2 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(float2 lhs, float2 rhs) => lhs.x != rhs.x||lhs.y != rhs.y;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);
        
        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(float2 other) => Comparison.Combine(x, y, other.x, other.y);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(float2 other) => other == this;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is float2 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Length(float2 v) => Maths.Sqrt(v.x * v.x + v.y * v.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float2 lhs, float2 rhs) => float2.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float2 lhs, float2 rhs) => lhs.x * rhs.x + lhs.y * rhs.y;
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Normalize(float2 v) => v / float2.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 FaceForward(float2 N, float2 I, float2 Nref) => float2.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Reflect(float2 I, float2 N) => I - 2 * float2.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Refract(float2 I, float2 N, float eta)
        {
            var dNI = float2.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float2((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Clamp(float2 v, float min, float max) => new float2(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max));
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Parse(string value)
        {
            var values = value.Split(", ");
            return new float2(float.Parse(values[0]), float.Parse(values[1]));
        }
        
        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new float2(float.Parse(values[0], format), float.Parse(values[1], format));
        }
        
        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrLength(float2 v) => v.x * v.x + v.y * v.y;
        
        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(float2 lhs, float2 rhs) => float2.SqrLength(lhs - rhs);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SmoothDamp(float2 source, float2 target, ref float2 velocity, float smoothTime, float deltaTime) => new float2(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime));
        
        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ClampLength(float2 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                float ratio = maxLength / Maths.Sqrt(sqrLength);
                return new float2(value.x * ratio, value.y * ratio);
            }
            return value;
        }
        
        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 MoveTowards(float2 current, float2 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDist = SqrLength(delta);
            return sqrDist <= maxDelta * maxDelta ? target :
            current + delta * maxDelta * Maths.InverseSqrt(sqrDist);
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a float2 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Radians(float2 v) => new float2(Maths.Radians(v.x), Maths.Radians(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Degrees(float2 v) => new float2(Maths.Degrees(v.x), Maths.Degrees(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sin(float2 v) => new float2(Maths.Sin(v.x), Maths.Sin(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Cos(float2 v) => new float2(Maths.Cos(v.x), Maths.Cos(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Tan(float2 v) => new float2(Maths.Tan(v.x), Maths.Tan(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Asin(float2 v) => new float2(Maths.Asin(v.x), Maths.Asin(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Acos(float2 v) => new float2(Maths.Acos(v.x), Maths.Acos(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Atan(float2 y, float2 x) => new float2(Maths.Atan(y.x / x.x), Maths.Atan(y.y / x.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Atan(float2 v) => new float2(Maths.Atan(v.x), Maths.Atan(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sinh(float2 v) => new float2(Maths.Sinh(v.x), Maths.Sinh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Cosh(float2 v) => new float2(Maths.Cosh(v.x), Maths.Cosh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Tanh(float2 v) => new float2(Maths.Tanh(v.x), Maths.Tanh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Asinh(float2 v) => new float2(Maths.Asinh(v.x), Maths.Asinh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Acosh(float2 v) => new float2(Maths.Acosh(v.x), Maths.Acosh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Atanh(float2 v) => new float2(Maths.Atanh(v.x), Maths.Atanh(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Pow(float2 lhs, float2 rhs) => new float2(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Exp(float2 v) => new float2(Maths.Exp(v.x), Maths.Exp(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Log(float2 v) => new float2(Maths.Log(v.x), Maths.Log(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Exp2(float2 v) => new float2(Maths.Exp2(v.x), Maths.Exp2(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Log2(float2 v) => new float2(Maths.Log2(v.x), Maths.Log2(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sqrt(float2 v) => new float2(Maths.Sqrt(v.x), Maths.Sqrt(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InverseSqrt(float2 v) => new float2(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 LesserThan(float2 lhs, float2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 LesserThanEqual(float2 lhs, float2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 GreaterThan(float2 lhs, float2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 GreaterThanEqual(float2 lhs, float2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Equal(float2 lhs, float2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 NotEqual(float2 lhs, float2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Abs(float2 v) => new float2(Maths.Abs(v.x), Maths.Abs(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sign(float2 v) => new float2(Maths.Sign(v.x), Maths.Sign(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Floor(float2 v) => new float2(Maths.Floor(v.x), Maths.Floor(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Truncate(float2 v) => new float2(Maths.Truncate(v.x), Maths.Truncate(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Round(float2 v) => new float2(Maths.Round(v.x), Maths.Round(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 RoundEven(float2 v) => new float2(Maths.RoundEven(v.x), Maths.RoundEven(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Ceil (Maths.Ceil(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Ceil(float2 v) => new float2(Maths.Ceil(v.x), Maths.Ceil(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Fract(float2 v) => new float2(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Mod(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Mod(float2 lhs, float rhs) => new float2(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Lerp(float2 edge0, float2 edge1, float2 v) => new float2(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Lerp(float2 edge0, float2 edge1, float v) => new float2(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Step(float2 edge, float2 x) => new float2(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Step(float edge, float2 x) => new float2(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a float2 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SmoothStep(float2 edge0, float2 edge1, float2 x) => new float2(Maths.SmoothStep(edge0.x, edge1.x, x.x), Maths.SmoothStep(edge0.y, edge1.y, x.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of SmoothStep (Maths.SmoothStep(edge0, edge1, x)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SmoothStep(float2 edge0, float2 edge1, float x) => new float2(Maths.SmoothStep(edge0.x, edge1.x, x), Maths.SmoothStep(edge0.y, edge1.y, x));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 IsNaN(float2 v) => new bool2(float.IsNaN(v.x), float.IsNaN(v.y));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 IsInfinity(float2 v) => new bool2(float.IsInfinity(v.x), float.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Fma(float2 a, float2 b, float2 c) => new float2(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Min(float2 lhs, float2 rhs) => new float2(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Min(float2 lhs, float rhs) => new float2(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Max(float2 lhs, float2 rhs) => new float2(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Max(float2 lhs, float rhs) => new float2(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Clamp(float2 v, float2 min, float2 max) => new float2(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (a ? y : x).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Mix(float2 x, float2 y, bool2 a) => new float2(a.x ? y.x : x.x, a.y ? y.y : x.y);
        
        /// <summary>
        /// Returns a int2 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 FloatBitsToInt(float2 v) => new int2(Unsafe.As<float, int>(ref v.x), Unsafe.As<float, int>(ref v.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 FloatBitsToUInt(float2 v) => new uint2(Unsafe.As<float, uint>(ref v.x), Unsafe.As<float, uint>(ref v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InvLerp(float2 edge0, float2 edge1, float2 v) => new float2(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of InvLerp (Maths.InvLerp(edge0, edge1, v)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InvLerp(float2 edge0, float2 edge1, float v) => new float2(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float2 v) => new float2(-v.x, -v.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator+(float2 lhs, float2 rhs) => new float2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator+(float2 lhs, float rhs) => new float2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator+(float lhs, float2 rhs) => new float2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float2 lhs, float rhs) => new float2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator-(float lhs, float2 rhs) => new float2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator*(float2 lhs, float2 rhs) => new float2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator*(float2 lhs, float rhs) => new float2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator*(float lhs, float2 rhs) => new float2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator/(float2 lhs, float2 rhs) => new float2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator/(float2 lhs, float rhs) => new float2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator/(float lhs, float2 rhs) => new float2(lhs / rhs.x, lhs / rhs.y);

        #endregion

    }
}
