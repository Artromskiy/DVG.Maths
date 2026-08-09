#pragma warning disable IDE1006
#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace Kibix
{
    public partial struct int3
    {

        #region Swizzles

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public int r
        {
            get => x;
            set
            {
                x = value;
            }
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public int s
        {
            get => x;
            set
            {
                x = value;
            }
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public int g
        {
            get => y;
            set
            {
                y = value;
            }
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public int t
        {
            get => y;
            set
            {
                y = value;
            }
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public int b
        {
            get => z;
            set
            {
                z = value;
            }
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public int p
        {
            get => z;
            set
            {
                z = value;
            }
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___x
        {
            get => new int4(0, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___r
        {
            get => new int4(0, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___s
        {
            get => new int4(0, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___y
        {
            get => new int4(0, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___g
        {
            get => new int4(0, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___t
        {
            get => new int4(0, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___z
        {
            get => new int4(0, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___b
        {
            get => new int4(0, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ___p
        {
            get => new int4(0, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __x_
        {
            get => new int4(0, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __r_
        {
            get => new int4(0, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __s_
        {
            get => new int4(0, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __xx
        {
            get => new int4(0, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __rr
        {
            get => new int4(0, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __ss
        {
            get => new int4(0, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __xy
        {
            get => new int4(0, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __rg
        {
            get => new int4(0, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __st
        {
            get => new int4(0, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __xz
        {
            get => new int4(0, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __rb
        {
            get => new int4(0, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __sp
        {
            get => new int4(0, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __y_
        {
            get => new int4(0, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __g_
        {
            get => new int4(0, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __t_
        {
            get => new int4(0, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __yx
        {
            get => new int4(0, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __gr
        {
            get => new int4(0, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __ts
        {
            get => new int4(0, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __yy
        {
            get => new int4(0, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __gg
        {
            get => new int4(0, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __tt
        {
            get => new int4(0, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __yz
        {
            get => new int4(0, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __gb
        {
            get => new int4(0, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __tp
        {
            get => new int4(0, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __z_
        {
            get => new int4(0, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __b_
        {
            get => new int4(0, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __p_
        {
            get => new int4(0, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __zx
        {
            get => new int4(0, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __br
        {
            get => new int4(0, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __ps
        {
            get => new int4(0, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __zy
        {
            get => new int4(0, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __bg
        {
            get => new int4(0, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __pt
        {
            get => new int4(0, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __zz
        {
            get => new int4(0, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __bb
        {
            get => new int4(0, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 __pp
        {
            get => new int4(0, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _x__
        {
            get => new int4(0, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _r__
        {
            get => new int4(0, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _s__
        {
            get => new int4(0, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _x_x
        {
            get => new int4(0, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _r_r
        {
            get => new int4(0, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _s_s
        {
            get => new int4(0, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _x_y
        {
            get => new int4(0, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _r_g
        {
            get => new int4(0, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _s_t
        {
            get => new int4(0, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _x_z
        {
            get => new int4(0, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _r_b
        {
            get => new int4(0, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _s_p
        {
            get => new int4(0, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xx_
        {
            get => new int4(0, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rr_
        {
            get => new int4(0, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ss_
        {
            get => new int4(0, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xxx
        {
            get => new int4(0, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rrr
        {
            get => new int4(0, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _sss
        {
            get => new int4(0, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xxy
        {
            get => new int4(0, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rrg
        {
            get => new int4(0, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _sst
        {
            get => new int4(0, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xxz
        {
            get => new int4(0, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rrb
        {
            get => new int4(0, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ssp
        {
            get => new int4(0, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xy_
        {
            get => new int4(0, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rg_
        {
            get => new int4(0, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _st_
        {
            get => new int4(0, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xyx
        {
            get => new int4(0, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rgr
        {
            get => new int4(0, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _sts
        {
            get => new int4(0, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xyy
        {
            get => new int4(0, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rgg
        {
            get => new int4(0, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _stt
        {
            get => new int4(0, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xyz
        {
            get => new int4(0, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rgb
        {
            get => new int4(0, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _stp
        {
            get => new int4(0, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xz_
        {
            get => new int4(0, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rb_
        {
            get => new int4(0, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _sp_
        {
            get => new int4(0, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xzx
        {
            get => new int4(0, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rbr
        {
            get => new int4(0, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _sps
        {
            get => new int4(0, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xzy
        {
            get => new int4(0, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rbg
        {
            get => new int4(0, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _spt
        {
            get => new int4(0, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _xzz
        {
            get => new int4(0, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _rbb
        {
            get => new int4(0, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _spp
        {
            get => new int4(0, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _y__
        {
            get => new int4(0, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _g__
        {
            get => new int4(0, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _t__
        {
            get => new int4(0, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _y_x
        {
            get => new int4(0, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _g_r
        {
            get => new int4(0, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _t_s
        {
            get => new int4(0, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _y_y
        {
            get => new int4(0, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _g_g
        {
            get => new int4(0, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _t_t
        {
            get => new int4(0, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _y_z
        {
            get => new int4(0, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _g_b
        {
            get => new int4(0, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _t_p
        {
            get => new int4(0, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yx_
        {
            get => new int4(0, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _gr_
        {
            get => new int4(0, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ts_
        {
            get => new int4(0, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yxx
        {
            get => new int4(0, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _grr
        {
            get => new int4(0, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tss
        {
            get => new int4(0, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yxy
        {
            get => new int4(0, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _grg
        {
            get => new int4(0, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tst
        {
            get => new int4(0, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yxz
        {
            get => new int4(0, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _grb
        {
            get => new int4(0, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tsp
        {
            get => new int4(0, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yy_
        {
            get => new int4(0, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _gg_
        {
            get => new int4(0, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tt_
        {
            get => new int4(0, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yyx
        {
            get => new int4(0, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ggr
        {
            get => new int4(0, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tts
        {
            get => new int4(0, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yyy
        {
            get => new int4(0, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ggg
        {
            get => new int4(0, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ttt
        {
            get => new int4(0, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yyz
        {
            get => new int4(0, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ggb
        {
            get => new int4(0, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ttp
        {
            get => new int4(0, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yz_
        {
            get => new int4(0, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _gb_
        {
            get => new int4(0, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tp_
        {
            get => new int4(0, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yzx
        {
            get => new int4(0, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _gbr
        {
            get => new int4(0, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tps
        {
            get => new int4(0, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yzy
        {
            get => new int4(0, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _gbg
        {
            get => new int4(0, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tpt
        {
            get => new int4(0, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _yzz
        {
            get => new int4(0, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _gbb
        {
            get => new int4(0, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _tpp
        {
            get => new int4(0, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _z__
        {
            get => new int4(0, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _b__
        {
            get => new int4(0, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _p__
        {
            get => new int4(0, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _z_x
        {
            get => new int4(0, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _b_r
        {
            get => new int4(0, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _p_s
        {
            get => new int4(0, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _z_y
        {
            get => new int4(0, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _b_g
        {
            get => new int4(0, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _p_t
        {
            get => new int4(0, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _z_z
        {
            get => new int4(0, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _b_b
        {
            get => new int4(0, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _p_p
        {
            get => new int4(0, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zx_
        {
            get => new int4(0, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _br_
        {
            get => new int4(0, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ps_
        {
            get => new int4(0, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zxx
        {
            get => new int4(0, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _brr
        {
            get => new int4(0, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _pss
        {
            get => new int4(0, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zxy
        {
            get => new int4(0, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _brg
        {
            get => new int4(0, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _pst
        {
            get => new int4(0, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zxz
        {
            get => new int4(0, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _brb
        {
            get => new int4(0, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _psp
        {
            get => new int4(0, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zy_
        {
            get => new int4(0, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bg_
        {
            get => new int4(0, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _pt_
        {
            get => new int4(0, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zyx
        {
            get => new int4(0, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bgr
        {
            get => new int4(0, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _pts
        {
            get => new int4(0, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zyy
        {
            get => new int4(0, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bgg
        {
            get => new int4(0, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ptt
        {
            get => new int4(0, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zyz
        {
            get => new int4(0, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bgb
        {
            get => new int4(0, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ptp
        {
            get => new int4(0, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zz_
        {
            get => new int4(0, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bb_
        {
            get => new int4(0, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _pp_
        {
            get => new int4(0, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zzx
        {
            get => new int4(0, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bbr
        {
            get => new int4(0, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _pps
        {
            get => new int4(0, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zzy
        {
            get => new int4(0, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bbg
        {
            get => new int4(0, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ppt
        {
            get => new int4(0, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _zzz
        {
            get => new int4(0, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _bbb
        {
            get => new int4(0, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 _ppp
        {
            get => new int4(0, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x___
        {
            get => new int4(x, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r___
        {
            get => new int4(x, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s___
        {
            get => new int4(x, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x__x
        {
            get => new int4(x, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r__r
        {
            get => new int4(x, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s__s
        {
            get => new int4(x, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x__y
        {
            get => new int4(x, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r__g
        {
            get => new int4(x, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s__t
        {
            get => new int4(x, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x__z
        {
            get => new int4(x, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r__b
        {
            get => new int4(x, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s__p
        {
            get => new int4(x, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_x_
        {
            get => new int4(x, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_r_
        {
            get => new int4(x, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_s_
        {
            get => new int4(x, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_xx
        {
            get => new int4(x, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_rr
        {
            get => new int4(x, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_ss
        {
            get => new int4(x, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_xy
        {
            get => new int4(x, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_rg
        {
            get => new int4(x, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_st
        {
            get => new int4(x, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_xz
        {
            get => new int4(x, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_rb
        {
            get => new int4(x, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_sp
        {
            get => new int4(x, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_y_
        {
            get => new int4(x, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_g_
        {
            get => new int4(x, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_t_
        {
            get => new int4(x, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_yx
        {
            get => new int4(x, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_gr
        {
            get => new int4(x, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_ts
        {
            get => new int4(x, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_yy
        {
            get => new int4(x, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_gg
        {
            get => new int4(x, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_tt
        {
            get => new int4(x, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_yz
        {
            get => new int4(x, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_gb
        {
            get => new int4(x, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_tp
        {
            get => new int4(x, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_z_
        {
            get => new int4(x, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_b_
        {
            get => new int4(x, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_p_
        {
            get => new int4(x, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_zx
        {
            get => new int4(x, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_br
        {
            get => new int4(x, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_ps
        {
            get => new int4(x, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_zy
        {
            get => new int4(x, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_bg
        {
            get => new int4(x, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_pt
        {
            get => new int4(x, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 x_zz
        {
            get => new int4(x, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 r_bb
        {
            get => new int4(x, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 s_pp
        {
            get => new int4(x, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xx__
        {
            get => new int4(x, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rr__
        {
            get => new int4(x, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ss__
        {
            get => new int4(x, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xx_x
        {
            get => new int4(x, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rr_r
        {
            get => new int4(x, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ss_s
        {
            get => new int4(x, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xx_y
        {
            get => new int4(x, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rr_g
        {
            get => new int4(x, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ss_t
        {
            get => new int4(x, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xx_z
        {
            get => new int4(x, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rr_b
        {
            get => new int4(x, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ss_p
        {
            get => new int4(x, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxx_
        {
            get => new int4(x, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrr_
        {
            get => new int4(x, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sss_
        {
            get => new int4(x, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxxx
        {
            get => new int4(x, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrrr
        {
            get => new int4(x, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ssss
        {
            get => new int4(x, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxxy
        {
            get => new int4(x, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrrg
        {
            get => new int4(x, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ssst
        {
            get => new int4(x, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxxz
        {
            get => new int4(x, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrrb
        {
            get => new int4(x, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sssp
        {
            get => new int4(x, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxy_
        {
            get => new int4(x, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrg_
        {
            get => new int4(x, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sst_
        {
            get => new int4(x, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxyx
        {
            get => new int4(x, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrgr
        {
            get => new int4(x, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ssts
        {
            get => new int4(x, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxyy
        {
            get => new int4(x, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrgg
        {
            get => new int4(x, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sstt
        {
            get => new int4(x, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxyz
        {
            get => new int4(x, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrgb
        {
            get => new int4(x, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sstp
        {
            get => new int4(x, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxz_
        {
            get => new int4(x, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrb_
        {
            get => new int4(x, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ssp_
        {
            get => new int4(x, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxzx
        {
            get => new int4(x, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrbr
        {
            get => new int4(x, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ssps
        {
            get => new int4(x, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxzy
        {
            get => new int4(x, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrbg
        {
            get => new int4(x, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sspt
        {
            get => new int4(x, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xxzz
        {
            get => new int4(x, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rrbb
        {
            get => new int4(x, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sspp
        {
            get => new int4(x, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xy__
        {
            get => new int4(x, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rg__
        {
            get => new int4(x, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 st__
        {
            get => new int4(x, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xy_x
        {
            get => new int4(x, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rg_r
        {
            get => new int4(x, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 st_s
        {
            get => new int4(x, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xy_y
        {
            get => new int4(x, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rg_g
        {
            get => new int4(x, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 st_t
        {
            get => new int4(x, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xy_z
        {
            get => new int4(x, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rg_b
        {
            get => new int4(x, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 st_p
        {
            get => new int4(x, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyx_
        {
            get => new int4(x, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgr_
        {
            get => new int4(x, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sts_
        {
            get => new int4(x, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyxx
        {
            get => new int4(x, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgrr
        {
            get => new int4(x, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stss
        {
            get => new int4(x, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyxy
        {
            get => new int4(x, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgrg
        {
            get => new int4(x, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stst
        {
            get => new int4(x, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyxz
        {
            get => new int4(x, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgrb
        {
            get => new int4(x, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stsp
        {
            get => new int4(x, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyy_
        {
            get => new int4(x, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgg_
        {
            get => new int4(x, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stt_
        {
            get => new int4(x, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyyx
        {
            get => new int4(x, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rggr
        {
            get => new int4(x, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stts
        {
            get => new int4(x, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyyy
        {
            get => new int4(x, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rggg
        {
            get => new int4(x, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sttt
        {
            get => new int4(x, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyyz
        {
            get => new int4(x, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rggb
        {
            get => new int4(x, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sttp
        {
            get => new int4(x, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyz_
        {
            get => new int4(x, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgb_
        {
            get => new int4(x, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stp_
        {
            get => new int4(x, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyzx
        {
            get => new int4(x, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgbr
        {
            get => new int4(x, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stps
        {
            get => new int4(x, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyzy
        {
            get => new int4(x, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgbg
        {
            get => new int4(x, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stpt
        {
            get => new int4(x, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xyzz
        {
            get => new int4(x, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rgbb
        {
            get => new int4(x, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 stpp
        {
            get => new int4(x, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xz__
        {
            get => new int4(x, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rb__
        {
            get => new int4(x, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sp__
        {
            get => new int4(x, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xz_x
        {
            get => new int4(x, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rb_r
        {
            get => new int4(x, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sp_s
        {
            get => new int4(x, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xz_y
        {
            get => new int4(x, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rb_g
        {
            get => new int4(x, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sp_t
        {
            get => new int4(x, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xz_z
        {
            get => new int4(x, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rb_b
        {
            get => new int4(x, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sp_p
        {
            get => new int4(x, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzx_
        {
            get => new int4(x, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbr_
        {
            get => new int4(x, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sps_
        {
            get => new int4(x, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzxx
        {
            get => new int4(x, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbrr
        {
            get => new int4(x, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spss
        {
            get => new int4(x, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzxy
        {
            get => new int4(x, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbrg
        {
            get => new int4(x, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spst
        {
            get => new int4(x, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzxz
        {
            get => new int4(x, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbrb
        {
            get => new int4(x, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spsp
        {
            get => new int4(x, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzy_
        {
            get => new int4(x, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbg_
        {
            get => new int4(x, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spt_
        {
            get => new int4(x, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzyx
        {
            get => new int4(x, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbgr
        {
            get => new int4(x, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spts
        {
            get => new int4(x, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzyy
        {
            get => new int4(x, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbgg
        {
            get => new int4(x, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sptt
        {
            get => new int4(x, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzyz
        {
            get => new int4(x, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbgb
        {
            get => new int4(x, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sptp
        {
            get => new int4(x, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzz_
        {
            get => new int4(x, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbb_
        {
            get => new int4(x, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spp_
        {
            get => new int4(x, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzzx
        {
            get => new int4(x, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbbr
        {
            get => new int4(x, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 spps
        {
            get => new int4(x, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzzy
        {
            get => new int4(x, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbbg
        {
            get => new int4(x, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sppt
        {
            get => new int4(x, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 xzzz
        {
            get => new int4(x, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 rbbb
        {
            get => new int4(x, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 sppp
        {
            get => new int4(x, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y___
        {
            get => new int4(y, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g___
        {
            get => new int4(y, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t___
        {
            get => new int4(y, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y__x
        {
            get => new int4(y, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g__r
        {
            get => new int4(y, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t__s
        {
            get => new int4(y, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y__y
        {
            get => new int4(y, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g__g
        {
            get => new int4(y, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t__t
        {
            get => new int4(y, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y__z
        {
            get => new int4(y, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g__b
        {
            get => new int4(y, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t__p
        {
            get => new int4(y, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_x_
        {
            get => new int4(y, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_r_
        {
            get => new int4(y, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_s_
        {
            get => new int4(y, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_xx
        {
            get => new int4(y, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_rr
        {
            get => new int4(y, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_ss
        {
            get => new int4(y, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_xy
        {
            get => new int4(y, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_rg
        {
            get => new int4(y, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_st
        {
            get => new int4(y, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_xz
        {
            get => new int4(y, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_rb
        {
            get => new int4(y, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_sp
        {
            get => new int4(y, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_y_
        {
            get => new int4(y, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_g_
        {
            get => new int4(y, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_t_
        {
            get => new int4(y, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_yx
        {
            get => new int4(y, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_gr
        {
            get => new int4(y, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_ts
        {
            get => new int4(y, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_yy
        {
            get => new int4(y, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_gg
        {
            get => new int4(y, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_tt
        {
            get => new int4(y, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_yz
        {
            get => new int4(y, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_gb
        {
            get => new int4(y, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_tp
        {
            get => new int4(y, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_z_
        {
            get => new int4(y, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_b_
        {
            get => new int4(y, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_p_
        {
            get => new int4(y, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_zx
        {
            get => new int4(y, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_br
        {
            get => new int4(y, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_ps
        {
            get => new int4(y, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_zy
        {
            get => new int4(y, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_bg
        {
            get => new int4(y, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_pt
        {
            get => new int4(y, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 y_zz
        {
            get => new int4(y, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 g_bb
        {
            get => new int4(y, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 t_pp
        {
            get => new int4(y, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yx__
        {
            get => new int4(y, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gr__
        {
            get => new int4(y, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ts__
        {
            get => new int4(y, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yx_x
        {
            get => new int4(y, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gr_r
        {
            get => new int4(y, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ts_s
        {
            get => new int4(y, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yx_y
        {
            get => new int4(y, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gr_g
        {
            get => new int4(y, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ts_t
        {
            get => new int4(y, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yx_z
        {
            get => new int4(y, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gr_b
        {
            get => new int4(y, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ts_p
        {
            get => new int4(y, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxx_
        {
            get => new int4(y, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grr_
        {
            get => new int4(y, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tss_
        {
            get => new int4(y, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxxx
        {
            get => new int4(y, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grrr
        {
            get => new int4(y, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tsss
        {
            get => new int4(y, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxxy
        {
            get => new int4(y, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grrg
        {
            get => new int4(y, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tsst
        {
            get => new int4(y, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxxz
        {
            get => new int4(y, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grrb
        {
            get => new int4(y, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tssp
        {
            get => new int4(y, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxy_
        {
            get => new int4(y, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grg_
        {
            get => new int4(y, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tst_
        {
            get => new int4(y, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxyx
        {
            get => new int4(y, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grgr
        {
            get => new int4(y, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tsts
        {
            get => new int4(y, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxyy
        {
            get => new int4(y, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grgg
        {
            get => new int4(y, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tstt
        {
            get => new int4(y, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxyz
        {
            get => new int4(y, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grgb
        {
            get => new int4(y, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tstp
        {
            get => new int4(y, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxz_
        {
            get => new int4(y, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grb_
        {
            get => new int4(y, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tsp_
        {
            get => new int4(y, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxzx
        {
            get => new int4(y, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grbr
        {
            get => new int4(y, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tsps
        {
            get => new int4(y, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxzy
        {
            get => new int4(y, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grbg
        {
            get => new int4(y, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tspt
        {
            get => new int4(y, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yxzz
        {
            get => new int4(y, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 grbb
        {
            get => new int4(y, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tspp
        {
            get => new int4(y, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yy__
        {
            get => new int4(y, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gg__
        {
            get => new int4(y, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tt__
        {
            get => new int4(y, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yy_x
        {
            get => new int4(y, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gg_r
        {
            get => new int4(y, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tt_s
        {
            get => new int4(y, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yy_y
        {
            get => new int4(y, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gg_g
        {
            get => new int4(y, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tt_t
        {
            get => new int4(y, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yy_z
        {
            get => new int4(y, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gg_b
        {
            get => new int4(y, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tt_p
        {
            get => new int4(y, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyx_
        {
            get => new int4(y, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggr_
        {
            get => new int4(y, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tts_
        {
            get => new int4(y, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyxx
        {
            get => new int4(y, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggrr
        {
            get => new int4(y, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttss
        {
            get => new int4(y, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyxy
        {
            get => new int4(y, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggrg
        {
            get => new int4(y, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttst
        {
            get => new int4(y, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyxz
        {
            get => new int4(y, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggrb
        {
            get => new int4(y, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttsp
        {
            get => new int4(y, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyy_
        {
            get => new int4(y, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggg_
        {
            get => new int4(y, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttt_
        {
            get => new int4(y, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyyx
        {
            get => new int4(y, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gggr
        {
            get => new int4(y, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttts
        {
            get => new int4(y, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyyy
        {
            get => new int4(y, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gggg
        {
            get => new int4(y, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tttt
        {
            get => new int4(y, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyyz
        {
            get => new int4(y, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gggb
        {
            get => new int4(y, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tttp
        {
            get => new int4(y, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyz_
        {
            get => new int4(y, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggb_
        {
            get => new int4(y, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttp_
        {
            get => new int4(y, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyzx
        {
            get => new int4(y, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggbr
        {
            get => new int4(y, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttps
        {
            get => new int4(y, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyzy
        {
            get => new int4(y, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggbg
        {
            get => new int4(y, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttpt
        {
            get => new int4(y, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yyzz
        {
            get => new int4(y, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ggbb
        {
            get => new int4(y, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ttpp
        {
            get => new int4(y, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yz__
        {
            get => new int4(y, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gb__
        {
            get => new int4(y, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tp__
        {
            get => new int4(y, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yz_x
        {
            get => new int4(y, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gb_r
        {
            get => new int4(y, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tp_s
        {
            get => new int4(y, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yz_y
        {
            get => new int4(y, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gb_g
        {
            get => new int4(y, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tp_t
        {
            get => new int4(y, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yz_z
        {
            get => new int4(y, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gb_b
        {
            get => new int4(y, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tp_p
        {
            get => new int4(y, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzx_
        {
            get => new int4(y, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbr_
        {
            get => new int4(y, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tps_
        {
            get => new int4(y, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzxx
        {
            get => new int4(y, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbrr
        {
            get => new int4(y, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpss
        {
            get => new int4(y, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzxy
        {
            get => new int4(y, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbrg
        {
            get => new int4(y, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpst
        {
            get => new int4(y, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzxz
        {
            get => new int4(y, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbrb
        {
            get => new int4(y, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpsp
        {
            get => new int4(y, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzy_
        {
            get => new int4(y, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbg_
        {
            get => new int4(y, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpt_
        {
            get => new int4(y, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzyx
        {
            get => new int4(y, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbgr
        {
            get => new int4(y, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpts
        {
            get => new int4(y, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzyy
        {
            get => new int4(y, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbgg
        {
            get => new int4(y, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tptt
        {
            get => new int4(y, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzyz
        {
            get => new int4(y, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbgb
        {
            get => new int4(y, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tptp
        {
            get => new int4(y, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzz_
        {
            get => new int4(y, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbb_
        {
            get => new int4(y, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpp_
        {
            get => new int4(y, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzzx
        {
            get => new int4(y, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbbr
        {
            get => new int4(y, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tpps
        {
            get => new int4(y, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzzy
        {
            get => new int4(y, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbbg
        {
            get => new int4(y, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tppt
        {
            get => new int4(y, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 yzzz
        {
            get => new int4(y, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 gbbb
        {
            get => new int4(y, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 tppp
        {
            get => new int4(y, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z___
        {
            get => new int4(z, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b___
        {
            get => new int4(z, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p___
        {
            get => new int4(z, 0, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z__x
        {
            get => new int4(z, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b__r
        {
            get => new int4(z, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p__s
        {
            get => new int4(z, 0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z__y
        {
            get => new int4(z, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b__g
        {
            get => new int4(z, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p__t
        {
            get => new int4(z, 0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z__z
        {
            get => new int4(z, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b__b
        {
            get => new int4(z, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p__p
        {
            get => new int4(z, 0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_x_
        {
            get => new int4(z, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_r_
        {
            get => new int4(z, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_s_
        {
            get => new int4(z, 0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_xx
        {
            get => new int4(z, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_rr
        {
            get => new int4(z, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_ss
        {
            get => new int4(z, 0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_xy
        {
            get => new int4(z, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_rg
        {
            get => new int4(z, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_st
        {
            get => new int4(z, 0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_xz
        {
            get => new int4(z, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_rb
        {
            get => new int4(z, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_sp
        {
            get => new int4(z, 0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_y_
        {
            get => new int4(z, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_g_
        {
            get => new int4(z, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_t_
        {
            get => new int4(z, 0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_yx
        {
            get => new int4(z, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_gr
        {
            get => new int4(z, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_ts
        {
            get => new int4(z, 0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_yy
        {
            get => new int4(z, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_gg
        {
            get => new int4(z, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_tt
        {
            get => new int4(z, 0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_yz
        {
            get => new int4(z, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_gb
        {
            get => new int4(z, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_tp
        {
            get => new int4(z, 0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_z_
        {
            get => new int4(z, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_b_
        {
            get => new int4(z, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_p_
        {
            get => new int4(z, 0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_zx
        {
            get => new int4(z, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_br
        {
            get => new int4(z, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_ps
        {
            get => new int4(z, 0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_zy
        {
            get => new int4(z, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_bg
        {
            get => new int4(z, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_pt
        {
            get => new int4(z, 0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 z_zz
        {
            get => new int4(z, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 b_bb
        {
            get => new int4(z, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 p_pp
        {
            get => new int4(z, 0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zx__
        {
            get => new int4(z, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 br__
        {
            get => new int4(z, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ps__
        {
            get => new int4(z, x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zx_x
        {
            get => new int4(z, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 br_r
        {
            get => new int4(z, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ps_s
        {
            get => new int4(z, x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zx_y
        {
            get => new int4(z, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 br_g
        {
            get => new int4(z, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ps_t
        {
            get => new int4(z, x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zx_z
        {
            get => new int4(z, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 br_b
        {
            get => new int4(z, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ps_p
        {
            get => new int4(z, x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxx_
        {
            get => new int4(z, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brr_
        {
            get => new int4(z, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pss_
        {
            get => new int4(z, x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxxx
        {
            get => new int4(z, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brrr
        {
            get => new int4(z, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 psss
        {
            get => new int4(z, x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxxy
        {
            get => new int4(z, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brrg
        {
            get => new int4(z, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 psst
        {
            get => new int4(z, x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxxz
        {
            get => new int4(z, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brrb
        {
            get => new int4(z, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pssp
        {
            get => new int4(z, x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxy_
        {
            get => new int4(z, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brg_
        {
            get => new int4(z, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pst_
        {
            get => new int4(z, x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxyx
        {
            get => new int4(z, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brgr
        {
            get => new int4(z, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 psts
        {
            get => new int4(z, x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxyy
        {
            get => new int4(z, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brgg
        {
            get => new int4(z, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pstt
        {
            get => new int4(z, x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxyz
        {
            get => new int4(z, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brgb
        {
            get => new int4(z, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pstp
        {
            get => new int4(z, x, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxz_
        {
            get => new int4(z, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brb_
        {
            get => new int4(z, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 psp_
        {
            get => new int4(z, x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxzx
        {
            get => new int4(z, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brbr
        {
            get => new int4(z, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 psps
        {
            get => new int4(z, x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxzy
        {
            get => new int4(z, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brbg
        {
            get => new int4(z, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pspt
        {
            get => new int4(z, x, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zxzz
        {
            get => new int4(z, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 brbb
        {
            get => new int4(z, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pspp
        {
            get => new int4(z, x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zy__
        {
            get => new int4(z, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bg__
        {
            get => new int4(z, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pt__
        {
            get => new int4(z, y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zy_x
        {
            get => new int4(z, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bg_r
        {
            get => new int4(z, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pt_s
        {
            get => new int4(z, y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zy_y
        {
            get => new int4(z, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bg_g
        {
            get => new int4(z, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pt_t
        {
            get => new int4(z, y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zy_z
        {
            get => new int4(z, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bg_b
        {
            get => new int4(z, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pt_p
        {
            get => new int4(z, y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyx_
        {
            get => new int4(z, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgr_
        {
            get => new int4(z, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pts_
        {
            get => new int4(z, y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyxx
        {
            get => new int4(z, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgrr
        {
            get => new int4(z, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptss
        {
            get => new int4(z, y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyxy
        {
            get => new int4(z, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgrg
        {
            get => new int4(z, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptst
        {
            get => new int4(z, y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyxz
        {
            get => new int4(z, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgrb
        {
            get => new int4(z, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptsp
        {
            get => new int4(z, y, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyy_
        {
            get => new int4(z, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgg_
        {
            get => new int4(z, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptt_
        {
            get => new int4(z, y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyyx
        {
            get => new int4(z, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bggr
        {
            get => new int4(z, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptts
        {
            get => new int4(z, y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyyy
        {
            get => new int4(z, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bggg
        {
            get => new int4(z, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pttt
        {
            get => new int4(z, y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyyz
        {
            get => new int4(z, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bggb
        {
            get => new int4(z, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pttp
        {
            get => new int4(z, y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyz_
        {
            get => new int4(z, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgb_
        {
            get => new int4(z, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptp_
        {
            get => new int4(z, y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyzx
        {
            get => new int4(z, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgbr
        {
            get => new int4(z, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptps
        {
            get => new int4(z, y, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyzy
        {
            get => new int4(z, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgbg
        {
            get => new int4(z, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptpt
        {
            get => new int4(z, y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zyzz
        {
            get => new int4(z, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bgbb
        {
            get => new int4(z, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ptpp
        {
            get => new int4(z, y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zz__
        {
            get => new int4(z, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bb__
        {
            get => new int4(z, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pp__
        {
            get => new int4(z, z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zz_x
        {
            get => new int4(z, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bb_r
        {
            get => new int4(z, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pp_s
        {
            get => new int4(z, z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zz_y
        {
            get => new int4(z, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bb_g
        {
            get => new int4(z, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pp_t
        {
            get => new int4(z, z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zz_z
        {
            get => new int4(z, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bb_b
        {
            get => new int4(z, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pp_p
        {
            get => new int4(z, z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzx_
        {
            get => new int4(z, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbr_
        {
            get => new int4(z, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pps_
        {
            get => new int4(z, z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzxx
        {
            get => new int4(z, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbrr
        {
            get => new int4(z, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppss
        {
            get => new int4(z, z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzxy
        {
            get => new int4(z, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbrg
        {
            get => new int4(z, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppst
        {
            get => new int4(z, z, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzxz
        {
            get => new int4(z, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbrb
        {
            get => new int4(z, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppsp
        {
            get => new int4(z, z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzy_
        {
            get => new int4(z, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbg_
        {
            get => new int4(z, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppt_
        {
            get => new int4(z, z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzyx
        {
            get => new int4(z, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbgr
        {
            get => new int4(z, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppts
        {
            get => new int4(z, z, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzyy
        {
            get => new int4(z, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbgg
        {
            get => new int4(z, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pptt
        {
            get => new int4(z, z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzyz
        {
            get => new int4(z, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbgb
        {
            get => new int4(z, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pptp
        {
            get => new int4(z, z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzz_
        {
            get => new int4(z, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbb_
        {
            get => new int4(z, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppp_
        {
            get => new int4(z, z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzzx
        {
            get => new int4(z, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbbr
        {
            get => new int4(z, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 ppps
        {
            get => new int4(z, z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzzy
        {
            get => new int4(z, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbbg
        {
            get => new int4(z, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pppt
        {
            get => new int4(z, z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 zzzz
        {
            get => new int4(z, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 bbbb
        {
            get => new int4(z, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int4 pppp
        {
            get => new int4(z, z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __x
        {
            get => new int3(0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __r
        {
            get => new int3(0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __s
        {
            get => new int3(0, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __y
        {
            get => new int3(0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __g
        {
            get => new int3(0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __t
        {
            get => new int3(0, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __z
        {
            get => new int3(0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __b
        {
            get => new int3(0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 __p
        {
            get => new int3(0, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _x_
        {
            get => new int3(0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _r_
        {
            get => new int3(0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _s_
        {
            get => new int3(0, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _xx
        {
            get => new int3(0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _rr
        {
            get => new int3(0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _ss
        {
            get => new int3(0, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _xy
        {
            get => new int3(0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _rg
        {
            get => new int3(0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _st
        {
            get => new int3(0, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _xz
        {
            get => new int3(0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _rb
        {
            get => new int3(0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _sp
        {
            get => new int3(0, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _y_
        {
            get => new int3(0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _g_
        {
            get => new int3(0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _t_
        {
            get => new int3(0, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _yx
        {
            get => new int3(0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _gr
        {
            get => new int3(0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _ts
        {
            get => new int3(0, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _yy
        {
            get => new int3(0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _gg
        {
            get => new int3(0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _tt
        {
            get => new int3(0, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _yz
        {
            get => new int3(0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _gb
        {
            get => new int3(0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _tp
        {
            get => new int3(0, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _z_
        {
            get => new int3(0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _b_
        {
            get => new int3(0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _p_
        {
            get => new int3(0, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _zx
        {
            get => new int3(0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _br
        {
            get => new int3(0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _ps
        {
            get => new int3(0, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _zy
        {
            get => new int3(0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _bg
        {
            get => new int3(0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _pt
        {
            get => new int3(0, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _zz
        {
            get => new int3(0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _bb
        {
            get => new int3(0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 _pp
        {
            get => new int3(0, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 x__
        {
            get => new int3(x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 r__
        {
            get => new int3(x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 s__
        {
            get => new int3(x, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 x_x
        {
            get => new int3(x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 r_r
        {
            get => new int3(x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 s_s
        {
            get => new int3(x, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 x_y
        {
            get => new int3(x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 r_g
        {
            get => new int3(x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 s_t
        {
            get => new int3(x, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 x_z
        {
            get => new int3(x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 r_b
        {
            get => new int3(x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 s_p
        {
            get => new int3(x, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xx_
        {
            get => new int3(x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rr_
        {
            get => new int3(x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ss_
        {
            get => new int3(x, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xxx
        {
            get => new int3(x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rrr
        {
            get => new int3(x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 sss
        {
            get => new int3(x, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xxy
        {
            get => new int3(x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rrg
        {
            get => new int3(x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 sst
        {
            get => new int3(x, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xxz
        {
            get => new int3(x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rrb
        {
            get => new int3(x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ssp
        {
            get => new int3(x, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xy_
        {
            get => new int3(x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rg_
        {
            get => new int3(x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 st_
        {
            get => new int3(x, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xyx
        {
            get => new int3(x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rgr
        {
            get => new int3(x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 sts
        {
            get => new int3(x, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xyy
        {
            get => new int3(x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rgg
        {
            get => new int3(x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 stt
        {
            get => new int3(x, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xyz
        {
            get => new int3(x, y, z);
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
        public int3 rgb
        {
            get => new int3(x, y, z);
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
        public int3 stp
        {
            get => new int3(x, y, z);
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
        public int3 xz_
        {
            get => new int3(x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rb_
        {
            get => new int3(x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 sp_
        {
            get => new int3(x, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xzx
        {
            get => new int3(x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rbr
        {
            get => new int3(x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 sps
        {
            get => new int3(x, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 xzy
        {
            get => new int3(x, z, y);
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
        public int3 rbg
        {
            get => new int3(x, z, y);
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
        public int3 spt
        {
            get => new int3(x, z, y);
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
        public int3 xzz
        {
            get => new int3(x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 rbb
        {
            get => new int3(x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 spp
        {
            get => new int3(x, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 y__
        {
            get => new int3(y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 g__
        {
            get => new int3(y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 t__
        {
            get => new int3(y, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 y_x
        {
            get => new int3(y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 g_r
        {
            get => new int3(y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 t_s
        {
            get => new int3(y, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 y_y
        {
            get => new int3(y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 g_g
        {
            get => new int3(y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 t_t
        {
            get => new int3(y, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 y_z
        {
            get => new int3(y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 g_b
        {
            get => new int3(y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 t_p
        {
            get => new int3(y, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yx_
        {
            get => new int3(y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 gr_
        {
            get => new int3(y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ts_
        {
            get => new int3(y, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yxx
        {
            get => new int3(y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 grr
        {
            get => new int3(y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tss
        {
            get => new int3(y, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yxy
        {
            get => new int3(y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 grg
        {
            get => new int3(y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tst
        {
            get => new int3(y, x, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yxz
        {
            get => new int3(y, x, z);
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
        public int3 grb
        {
            get => new int3(y, x, z);
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
        public int3 tsp
        {
            get => new int3(y, x, z);
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
        public int3 yy_
        {
            get => new int3(y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 gg_
        {
            get => new int3(y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tt_
        {
            get => new int3(y, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yyx
        {
            get => new int3(y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ggr
        {
            get => new int3(y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tts
        {
            get => new int3(y, y, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yyy
        {
            get => new int3(y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ggg
        {
            get => new int3(y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ttt
        {
            get => new int3(y, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yyz
        {
            get => new int3(y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ggb
        {
            get => new int3(y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ttp
        {
            get => new int3(y, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yz_
        {
            get => new int3(y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 gb_
        {
            get => new int3(y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tp_
        {
            get => new int3(y, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yzx
        {
            get => new int3(y, z, x);
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
        public int3 gbr
        {
            get => new int3(y, z, x);
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
        public int3 tps
        {
            get => new int3(y, z, x);
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
        public int3 yzy
        {
            get => new int3(y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 gbg
        {
            get => new int3(y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tpt
        {
            get => new int3(y, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 yzz
        {
            get => new int3(y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 gbb
        {
            get => new int3(y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 tpp
        {
            get => new int3(y, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 z__
        {
            get => new int3(z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 b__
        {
            get => new int3(z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 p__
        {
            get => new int3(z, 0, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 z_x
        {
            get => new int3(z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 b_r
        {
            get => new int3(z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 p_s
        {
            get => new int3(z, 0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 z_y
        {
            get => new int3(z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 b_g
        {
            get => new int3(z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 p_t
        {
            get => new int3(z, 0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 z_z
        {
            get => new int3(z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 b_b
        {
            get => new int3(z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 p_p
        {
            get => new int3(z, 0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zx_
        {
            get => new int3(z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 br_
        {
            get => new int3(z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ps_
        {
            get => new int3(z, x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zxx
        {
            get => new int3(z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 brr
        {
            get => new int3(z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 pss
        {
            get => new int3(z, x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zxy
        {
            get => new int3(z, x, y);
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
        public int3 brg
        {
            get => new int3(z, x, y);
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
        public int3 pst
        {
            get => new int3(z, x, y);
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
        public int3 zxz
        {
            get => new int3(z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 brb
        {
            get => new int3(z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 psp
        {
            get => new int3(z, x, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zy_
        {
            get => new int3(z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bg_
        {
            get => new int3(z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 pt_
        {
            get => new int3(z, y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zyx
        {
            get => new int3(z, y, x);
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
        public int3 bgr
        {
            get => new int3(z, y, x);
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
        public int3 pts
        {
            get => new int3(z, y, x);
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
        public int3 zyy
        {
            get => new int3(z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bgg
        {
            get => new int3(z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ptt
        {
            get => new int3(z, y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zyz
        {
            get => new int3(z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bgb
        {
            get => new int3(z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ptp
        {
            get => new int3(z, y, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zz_
        {
            get => new int3(z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bb_
        {
            get => new int3(z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 pp_
        {
            get => new int3(z, z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zzx
        {
            get => new int3(z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bbr
        {
            get => new int3(z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 pps
        {
            get => new int3(z, z, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zzy
        {
            get => new int3(z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bbg
        {
            get => new int3(z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ppt
        {
            get => new int3(z, z, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 zzz
        {
            get => new int3(z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 bbb
        {
            get => new int3(z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int3 ppp
        {
            get => new int3(z, z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _x
        {
            get => new int2(0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _r
        {
            get => new int2(0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _s
        {
            get => new int2(0, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _y
        {
            get => new int2(0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _g
        {
            get => new int2(0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _t
        {
            get => new int2(0, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _z
        {
            get => new int2(0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _b
        {
            get => new int2(0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 _p
        {
            get => new int2(0, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 x_
        {
            get => new int2(x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 r_
        {
            get => new int2(x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 s_
        {
            get => new int2(x, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 xx
        {
            get => new int2(x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 rr
        {
            get => new int2(x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 ss
        {
            get => new int2(x, x);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 xy
        {
            get => new int2(x, y);
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
        public int2 rg
        {
            get => new int2(x, y);
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
        public int2 st
        {
            get => new int2(x, y);
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
        public int2 xz
        {
            get => new int2(x, z);
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
        public int2 rb
        {
            get => new int2(x, z);
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
        public int2 sp
        {
            get => new int2(x, z);
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
        public int2 y_
        {
            get => new int2(y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 g_
        {
            get => new int2(y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 t_
        {
            get => new int2(y, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 yx
        {
            get => new int2(y, x);
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
        public int2 gr
        {
            get => new int2(y, x);
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
        public int2 ts
        {
            get => new int2(y, x);
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
        public int2 yy
        {
            get => new int2(y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 gg
        {
            get => new int2(y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 tt
        {
            get => new int2(y, y);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 yz
        {
            get => new int2(y, z);
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
        public int2 gb
        {
            get => new int2(y, z);
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
        public int2 tp
        {
            get => new int2(y, z);
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
        public int2 z_
        {
            get => new int2(z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 b_
        {
            get => new int2(z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 p_
        {
            get => new int2(z, 0);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 zx
        {
            get => new int2(z, x);
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
        public int2 br
        {
            get => new int2(z, x);
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
        public int2 ps
        {
            get => new int2(z, x);
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
        public int2 zy
        {
            get => new int2(z, y);
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
        public int2 bg
        {
            get => new int2(z, y);
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
        public int2 pt
        {
            get => new int2(z, y);
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
        public int2 zz
        {
            get => new int2(z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 bb
        {
            get => new int2(z, z);
        }

        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int2 pp
        {
            get => new int2(z, z);
        }

        #endregion

    }
}
