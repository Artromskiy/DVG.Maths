#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix2
    {

        public fix r
        {
            get => x;
            set => x = value;
        }

        public fix g
        {
            get => y;
            set => y = value;
        }

        public fix s
        {
            get => x;
            set => x = value;
        }

        public fix t
        {
            get => y;
            set => y = value;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 _x
        {
            get => new fix2(0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 _y
        {
            get => new fix2(0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 x_
        {
            get => new fix2(x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 xx
        {
            get => new fix2(x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 xy
        {
            get => new fix2(x, y);
            set
            {
                x = value.x;
                y = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 y_
        {
            get => new fix2(y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 yx
        {
            get => new fix2(y, x);
            set
            {
                y = value.x;
                x = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 yy
        {
            get => new fix2(y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 __x
        {
            get => new fix3(0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 __y
        {
            get => new fix3(0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _x_
        {
            get => new fix3(0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _xx
        {
            get => new fix3(0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _xy
        {
            get => new fix3(0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _y_
        {
            get => new fix3(0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _yx
        {
            get => new fix3(0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _yy
        {
            get => new fix3(0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 x__
        {
            get => new fix3(x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 x_x
        {
            get => new fix3(x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 x_y
        {
            get => new fix3(x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xx_
        {
            get => new fix3(x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xxx
        {
            get => new fix3(x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xxy
        {
            get => new fix3(x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xy_
        {
            get => new fix3(x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xyx
        {
            get => new fix3(x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xyy
        {
            get => new fix3(x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 y__
        {
            get => new fix3(y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 y_x
        {
            get => new fix3(y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 y_y
        {
            get => new fix3(y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yx_
        {
            get => new fix3(y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yxx
        {
            get => new fix3(y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yxy
        {
            get => new fix3(y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yy_
        {
            get => new fix3(y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yyx
        {
            get => new fix3(y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yyy
        {
            get => new fix3(y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ___x
        {
            get => new fix4(0, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ___y
        {
            get => new fix4(0, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __x_
        {
            get => new fix4(0, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __xx
        {
            get => new fix4(0, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __xy
        {
            get => new fix4(0, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __y_
        {
            get => new fix4(0, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __yx
        {
            get => new fix4(0, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __yy
        {
            get => new fix4(0, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _x__
        {
            get => new fix4(0, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _x_x
        {
            get => new fix4(0, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _x_y
        {
            get => new fix4(0, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xx_
        {
            get => new fix4(0, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xxx
        {
            get => new fix4(0, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xxy
        {
            get => new fix4(0, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xy_
        {
            get => new fix4(0, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xyx
        {
            get => new fix4(0, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xyy
        {
            get => new fix4(0, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _y__
        {
            get => new fix4(0, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _y_x
        {
            get => new fix4(0, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _y_y
        {
            get => new fix4(0, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yx_
        {
            get => new fix4(0, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yxx
        {
            get => new fix4(0, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yxy
        {
            get => new fix4(0, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yy_
        {
            get => new fix4(0, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yyx
        {
            get => new fix4(0, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yyy
        {
            get => new fix4(0, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x___
        {
            get => new fix4(x, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x__x
        {
            get => new fix4(x, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x__y
        {
            get => new fix4(x, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_x_
        {
            get => new fix4(x, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_xx
        {
            get => new fix4(x, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_xy
        {
            get => new fix4(x, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_y_
        {
            get => new fix4(x, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_yx
        {
            get => new fix4(x, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_yy
        {
            get => new fix4(x, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xx__
        {
            get => new fix4(x, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xx_x
        {
            get => new fix4(x, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xx_y
        {
            get => new fix4(x, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxx_
        {
            get => new fix4(x, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxxx
        {
            get => new fix4(x, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxxy
        {
            get => new fix4(x, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxy_
        {
            get => new fix4(x, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxyx
        {
            get => new fix4(x, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxyy
        {
            get => new fix4(x, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xy__
        {
            get => new fix4(x, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xy_x
        {
            get => new fix4(x, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xy_y
        {
            get => new fix4(x, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyx_
        {
            get => new fix4(x, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyxx
        {
            get => new fix4(x, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyxy
        {
            get => new fix4(x, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyy_
        {
            get => new fix4(x, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyyx
        {
            get => new fix4(x, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyyy
        {
            get => new fix4(x, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y___
        {
            get => new fix4(y, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y__x
        {
            get => new fix4(y, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y__y
        {
            get => new fix4(y, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_x_
        {
            get => new fix4(y, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_xx
        {
            get => new fix4(y, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_xy
        {
            get => new fix4(y, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_y_
        {
            get => new fix4(y, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_yx
        {
            get => new fix4(y, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_yy
        {
            get => new fix4(y, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yx__
        {
            get => new fix4(y, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yx_x
        {
            get => new fix4(y, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yx_y
        {
            get => new fix4(y, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxx_
        {
            get => new fix4(y, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxxx
        {
            get => new fix4(y, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxxy
        {
            get => new fix4(y, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxy_
        {
            get => new fix4(y, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxyx
        {
            get => new fix4(y, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxyy
        {
            get => new fix4(y, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yy__
        {
            get => new fix4(y, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yy_x
        {
            get => new fix4(y, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yy_y
        {
            get => new fix4(y, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyx_
        {
            get => new fix4(y, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyxx
        {
            get => new fix4(y, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyxy
        {
            get => new fix4(y, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyy_
        {
            get => new fix4(y, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyyx
        {
            get => new fix4(y, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyyy
        {
            get => new fix4(y, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 _r
        {
            get => new fix2(0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 _g
        {
            get => new fix2(0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 r_
        {
            get => new fix2(x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 rr
        {
            get => new fix2(x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 rg
        {
            get => new fix2(x, y);
            set
            {
                x = value.x;
                y = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 g_
        {
            get => new fix2(y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 gr
        {
            get => new fix2(y, x);
            set
            {
                y = value.x;
                x = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 gg
        {
            get => new fix2(y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 __r
        {
            get => new fix3(0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 __g
        {
            get => new fix3(0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _r_
        {
            get => new fix3(0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _rr
        {
            get => new fix3(0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _rg
        {
            get => new fix3(0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _g_
        {
            get => new fix3(0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _gr
        {
            get => new fix3(0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _gg
        {
            get => new fix3(0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 r__
        {
            get => new fix3(x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 r_r
        {
            get => new fix3(x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 r_g
        {
            get => new fix3(x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rr_
        {
            get => new fix3(x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rrr
        {
            get => new fix3(x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rrg
        {
            get => new fix3(x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rg_
        {
            get => new fix3(x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rgr
        {
            get => new fix3(x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rgg
        {
            get => new fix3(x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 g__
        {
            get => new fix3(y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 g_r
        {
            get => new fix3(y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 g_g
        {
            get => new fix3(y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 gr_
        {
            get => new fix3(y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 grr
        {
            get => new fix3(y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 grg
        {
            get => new fix3(y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 gg_
        {
            get => new fix3(y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ggr
        {
            get => new fix3(y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ggg
        {
            get => new fix3(y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ___r
        {
            get => new fix4(0, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ___g
        {
            get => new fix4(0, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __r_
        {
            get => new fix4(0, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __rr
        {
            get => new fix4(0, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __rg
        {
            get => new fix4(0, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __g_
        {
            get => new fix4(0, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __gr
        {
            get => new fix4(0, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __gg
        {
            get => new fix4(0, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _r__
        {
            get => new fix4(0, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _r_r
        {
            get => new fix4(0, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _r_g
        {
            get => new fix4(0, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rr_
        {
            get => new fix4(0, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rrr
        {
            get => new fix4(0, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rrg
        {
            get => new fix4(0, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rg_
        {
            get => new fix4(0, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rgr
        {
            get => new fix4(0, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rgg
        {
            get => new fix4(0, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _g__
        {
            get => new fix4(0, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _g_r
        {
            get => new fix4(0, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _g_g
        {
            get => new fix4(0, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _gr_
        {
            get => new fix4(0, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _grr
        {
            get => new fix4(0, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _grg
        {
            get => new fix4(0, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _gg_
        {
            get => new fix4(0, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ggr
        {
            get => new fix4(0, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ggg
        {
            get => new fix4(0, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r___
        {
            get => new fix4(x, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r__r
        {
            get => new fix4(x, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r__g
        {
            get => new fix4(x, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_r_
        {
            get => new fix4(x, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_rr
        {
            get => new fix4(x, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_rg
        {
            get => new fix4(x, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_g_
        {
            get => new fix4(x, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_gr
        {
            get => new fix4(x, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_gg
        {
            get => new fix4(x, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rr__
        {
            get => new fix4(x, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rr_r
        {
            get => new fix4(x, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rr_g
        {
            get => new fix4(x, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrr_
        {
            get => new fix4(x, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrrr
        {
            get => new fix4(x, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrrg
        {
            get => new fix4(x, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrg_
        {
            get => new fix4(x, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrgr
        {
            get => new fix4(x, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrgg
        {
            get => new fix4(x, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rg__
        {
            get => new fix4(x, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rg_r
        {
            get => new fix4(x, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rg_g
        {
            get => new fix4(x, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgr_
        {
            get => new fix4(x, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgrr
        {
            get => new fix4(x, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgrg
        {
            get => new fix4(x, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgg_
        {
            get => new fix4(x, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rggr
        {
            get => new fix4(x, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rggg
        {
            get => new fix4(x, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g___
        {
            get => new fix4(y, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g__r
        {
            get => new fix4(y, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g__g
        {
            get => new fix4(y, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_r_
        {
            get => new fix4(y, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_rr
        {
            get => new fix4(y, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_rg
        {
            get => new fix4(y, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_g_
        {
            get => new fix4(y, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_gr
        {
            get => new fix4(y, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_gg
        {
            get => new fix4(y, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gr__
        {
            get => new fix4(y, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gr_r
        {
            get => new fix4(y, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gr_g
        {
            get => new fix4(y, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grr_
        {
            get => new fix4(y, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grrr
        {
            get => new fix4(y, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grrg
        {
            get => new fix4(y, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grg_
        {
            get => new fix4(y, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grgr
        {
            get => new fix4(y, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grgg
        {
            get => new fix4(y, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gg__
        {
            get => new fix4(y, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gg_r
        {
            get => new fix4(y, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gg_g
        {
            get => new fix4(y, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggr_
        {
            get => new fix4(y, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggrr
        {
            get => new fix4(y, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggrg
        {
            get => new fix4(y, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggg_
        {
            get => new fix4(y, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gggr
        {
            get => new fix4(y, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gggg
        {
            get => new fix4(y, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 _s
        {
            get => new fix2(0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 _t
        {
            get => new fix2(0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 s_
        {
            get => new fix2(x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 ss
        {
            get => new fix2(x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 st
        {
            get => new fix2(x, y);
            set
            {
                x = value.x;
                y = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 t_
        {
            get => new fix2(y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 ts
        {
            get => new fix2(y, x);
            set
            {
                y = value.x;
                x = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 tt
        {
            get => new fix2(y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 __s
        {
            get => new fix3(0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 __t
        {
            get => new fix3(0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _s_
        {
            get => new fix3(0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _ss
        {
            get => new fix3(0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _st
        {
            get => new fix3(0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _t_
        {
            get => new fix3(0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _ts
        {
            get => new fix3(0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _tt
        {
            get => new fix3(0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 s__
        {
            get => new fix3(x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 s_s
        {
            get => new fix3(x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 s_t
        {
            get => new fix3(x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ss_
        {
            get => new fix3(x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 sss
        {
            get => new fix3(x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 sst
        {
            get => new fix3(x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 st_
        {
            get => new fix3(x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 sts
        {
            get => new fix3(x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 stt
        {
            get => new fix3(x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 t__
        {
            get => new fix3(y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 t_s
        {
            get => new fix3(y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 t_t
        {
            get => new fix3(y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ts_
        {
            get => new fix3(y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tss
        {
            get => new fix3(y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tst
        {
            get => new fix3(y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tt_
        {
            get => new fix3(y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tts
        {
            get => new fix3(y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ttt
        {
            get => new fix3(y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ___s
        {
            get => new fix4(0, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ___t
        {
            get => new fix4(0, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __s_
        {
            get => new fix4(0, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __ss
        {
            get => new fix4(0, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __st
        {
            get => new fix4(0, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __t_
        {
            get => new fix4(0, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __ts
        {
            get => new fix4(0, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __tt
        {
            get => new fix4(0, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _s__
        {
            get => new fix4(0, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _s_s
        {
            get => new fix4(0, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _s_t
        {
            get => new fix4(0, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ss_
        {
            get => new fix4(0, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _sss
        {
            get => new fix4(0, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _sst
        {
            get => new fix4(0, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _st_
        {
            get => new fix4(0, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _sts
        {
            get => new fix4(0, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _stt
        {
            get => new fix4(0, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _t__
        {
            get => new fix4(0, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _t_s
        {
            get => new fix4(0, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _t_t
        {
            get => new fix4(0, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ts_
        {
            get => new fix4(0, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tss
        {
            get => new fix4(0, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tst
        {
            get => new fix4(0, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tt_
        {
            get => new fix4(0, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tts
        {
            get => new fix4(0, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ttt
        {
            get => new fix4(0, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s___
        {
            get => new fix4(x, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s__s
        {
            get => new fix4(x, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s__t
        {
            get => new fix4(x, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_s_
        {
            get => new fix4(x, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_ss
        {
            get => new fix4(x, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_st
        {
            get => new fix4(x, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_t_
        {
            get => new fix4(x, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_ts
        {
            get => new fix4(x, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_tt
        {
            get => new fix4(x, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ss__
        {
            get => new fix4(x, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ss_s
        {
            get => new fix4(x, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ss_t
        {
            get => new fix4(x, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sss_
        {
            get => new fix4(x, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ssss
        {
            get => new fix4(x, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ssst
        {
            get => new fix4(x, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sst_
        {
            get => new fix4(x, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ssts
        {
            get => new fix4(x, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sstt
        {
            get => new fix4(x, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 st__
        {
            get => new fix4(x, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 st_s
        {
            get => new fix4(x, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 st_t
        {
            get => new fix4(x, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sts_
        {
            get => new fix4(x, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stss
        {
            get => new fix4(x, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stst
        {
            get => new fix4(x, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stt_
        {
            get => new fix4(x, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stts
        {
            get => new fix4(x, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sttt
        {
            get => new fix4(x, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t___
        {
            get => new fix4(y, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t__s
        {
            get => new fix4(y, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t__t
        {
            get => new fix4(y, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_s_
        {
            get => new fix4(y, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_ss
        {
            get => new fix4(y, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_st
        {
            get => new fix4(y, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_t_
        {
            get => new fix4(y, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_ts
        {
            get => new fix4(y, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_tt
        {
            get => new fix4(y, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ts__
        {
            get => new fix4(y, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ts_s
        {
            get => new fix4(y, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ts_t
        {
            get => new fix4(y, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tss_
        {
            get => new fix4(y, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tsss
        {
            get => new fix4(y, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tsst
        {
            get => new fix4(y, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tst_
        {
            get => new fix4(y, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tsts
        {
            get => new fix4(y, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tstt
        {
            get => new fix4(y, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tt__
        {
            get => new fix4(y, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tt_s
        {
            get => new fix4(y, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tt_t
        {
            get => new fix4(y, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tts_
        {
            get => new fix4(y, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttss
        {
            get => new fix4(y, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttst
        {
            get => new fix4(y, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttt_
        {
            get => new fix4(y, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttts
        {
            get => new fix4(y, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tttt
        {
            get => new fix4(y, y, y, y);
        }
    }
}
