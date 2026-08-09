#pragma warning disable IDE1006
#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace KibiHex
{
    public partial struct int2
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

        #endregion

    }
}
