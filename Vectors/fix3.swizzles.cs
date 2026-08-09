#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct fix3
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

        public fix b
        {
            get => z;
            set => z = value;
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

        public fix p
        {
            get => z;
            set => z = value;
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
        public fix2 _z
        {
            get => new fix2(0, z);
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
        public fix2 xz
        {
            get => new fix2(x, z);
            set
            {
                x = value.x;
                z = value.y;
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
        public fix2 yz
        {
            get => new fix2(y, z);
            set
            {
                y = value.x;
                z = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 z_
        {
            get => new fix2(z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 zx
        {
            get => new fix2(z, x);
            set
            {
                z = value.x;
                x = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 zy
        {
            get => new fix2(z, y);
            set
            {
                z = value.x;
                y = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 zz
        {
            get => new fix2(z, z);
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
        public fix3 __z
        {
            get => new fix3(0, 0, z);
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
        public fix3 _xz
        {
            get => new fix3(0, x, z);
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
        public fix3 _yz
        {
            get => new fix3(0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _z_
        {
            get => new fix3(0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _zx
        {
            get => new fix3(0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _zy
        {
            get => new fix3(0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _zz
        {
            get => new fix3(0, z, z);
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
        public fix3 x_z
        {
            get => new fix3(x, 0, z);
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
        public fix3 xxz
        {
            get => new fix3(x, x, z);
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
        public fix3 xyz
        {
            get => new fix3(x, y, z);
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xz_
        {
            get => new fix3(x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xzx
        {
            get => new fix3(x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xzy
        {
            get => new fix3(x, z, y);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 xzz
        {
            get => new fix3(x, z, z);
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
        public fix3 y_z
        {
            get => new fix3(y, 0, z);
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
        public fix3 yxz
        {
            get => new fix3(y, x, z);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
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
        public fix3 yyz
        {
            get => new fix3(y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yz_
        {
            get => new fix3(y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yzx
        {
            get => new fix3(y, z, x);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yzy
        {
            get => new fix3(y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 yzz
        {
            get => new fix3(y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 z__
        {
            get => new fix3(z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 z_x
        {
            get => new fix3(z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 z_y
        {
            get => new fix3(z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 z_z
        {
            get => new fix3(z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zx_
        {
            get => new fix3(z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zxx
        {
            get => new fix3(z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zxy
        {
            get => new fix3(z, x, y);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zxz
        {
            get => new fix3(z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zy_
        {
            get => new fix3(z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zyx
        {
            get => new fix3(z, y, x);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zyy
        {
            get => new fix3(z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zyz
        {
            get => new fix3(z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zz_
        {
            get => new fix3(z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zzx
        {
            get => new fix3(z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zzy
        {
            get => new fix3(z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 zzz
        {
            get => new fix3(z, z, z);
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
        public fix4 ___z
        {
            get => new fix4(0, 0, 0, z);
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
        public fix4 __xz
        {
            get => new fix4(0, 0, x, z);
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
        public fix4 __yz
        {
            get => new fix4(0, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __z_
        {
            get => new fix4(0, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __zx
        {
            get => new fix4(0, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __zy
        {
            get => new fix4(0, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __zz
        {
            get => new fix4(0, 0, z, z);
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
        public fix4 _x_z
        {
            get => new fix4(0, x, 0, z);
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
        public fix4 _xxz
        {
            get => new fix4(0, x, x, z);
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
        public fix4 _xyz
        {
            get => new fix4(0, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xz_
        {
            get => new fix4(0, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xzx
        {
            get => new fix4(0, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xzy
        {
            get => new fix4(0, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _xzz
        {
            get => new fix4(0, x, z, z);
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
        public fix4 _y_z
        {
            get => new fix4(0, y, 0, z);
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
        public fix4 _yxz
        {
            get => new fix4(0, y, x, z);
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
        public fix4 _yyz
        {
            get => new fix4(0, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yz_
        {
            get => new fix4(0, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yzx
        {
            get => new fix4(0, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yzy
        {
            get => new fix4(0, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _yzz
        {
            get => new fix4(0, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _z__
        {
            get => new fix4(0, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _z_x
        {
            get => new fix4(0, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _z_y
        {
            get => new fix4(0, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _z_z
        {
            get => new fix4(0, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zx_
        {
            get => new fix4(0, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zxx
        {
            get => new fix4(0, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zxy
        {
            get => new fix4(0, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zxz
        {
            get => new fix4(0, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zy_
        {
            get => new fix4(0, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zyx
        {
            get => new fix4(0, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zyy
        {
            get => new fix4(0, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zyz
        {
            get => new fix4(0, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zz_
        {
            get => new fix4(0, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zzx
        {
            get => new fix4(0, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zzy
        {
            get => new fix4(0, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _zzz
        {
            get => new fix4(0, z, z, z);
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
        public fix4 x__z
        {
            get => new fix4(x, 0, 0, z);
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
        public fix4 x_xz
        {
            get => new fix4(x, 0, x, z);
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
        public fix4 x_yz
        {
            get => new fix4(x, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_z_
        {
            get => new fix4(x, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_zx
        {
            get => new fix4(x, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_zy
        {
            get => new fix4(x, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 x_zz
        {
            get => new fix4(x, 0, z, z);
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
        public fix4 xx_z
        {
            get => new fix4(x, x, 0, z);
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
        public fix4 xxxz
        {
            get => new fix4(x, x, x, z);
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
        public fix4 xxyz
        {
            get => new fix4(x, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxz_
        {
            get => new fix4(x, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxzx
        {
            get => new fix4(x, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxzy
        {
            get => new fix4(x, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xxzz
        {
            get => new fix4(x, x, z, z);
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
        public fix4 xy_z
        {
            get => new fix4(x, y, 0, z);
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
        public fix4 xyxz
        {
            get => new fix4(x, y, x, z);
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
        public fix4 xyyz
        {
            get => new fix4(x, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyz_
        {
            get => new fix4(x, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyzx
        {
            get => new fix4(x, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyzy
        {
            get => new fix4(x, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xyzz
        {
            get => new fix4(x, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xz__
        {
            get => new fix4(x, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xz_x
        {
            get => new fix4(x, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xz_y
        {
            get => new fix4(x, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xz_z
        {
            get => new fix4(x, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzx_
        {
            get => new fix4(x, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzxx
        {
            get => new fix4(x, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzxy
        {
            get => new fix4(x, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzxz
        {
            get => new fix4(x, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzy_
        {
            get => new fix4(x, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzyx
        {
            get => new fix4(x, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzyy
        {
            get => new fix4(x, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzyz
        {
            get => new fix4(x, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzz_
        {
            get => new fix4(x, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzzx
        {
            get => new fix4(x, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzzy
        {
            get => new fix4(x, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 xzzz
        {
            get => new fix4(x, z, z, z);
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
        public fix4 y__z
        {
            get => new fix4(y, 0, 0, z);
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
        public fix4 y_xz
        {
            get => new fix4(y, 0, x, z);
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
        public fix4 y_yz
        {
            get => new fix4(y, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_z_
        {
            get => new fix4(y, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_zx
        {
            get => new fix4(y, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_zy
        {
            get => new fix4(y, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 y_zz
        {
            get => new fix4(y, 0, z, z);
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
        public fix4 yx_z
        {
            get => new fix4(y, x, 0, z);
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
        public fix4 yxxz
        {
            get => new fix4(y, x, x, z);
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
        public fix4 yxyz
        {
            get => new fix4(y, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxz_
        {
            get => new fix4(y, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxzx
        {
            get => new fix4(y, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxzy
        {
            get => new fix4(y, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yxzz
        {
            get => new fix4(y, x, z, z);
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
        public fix4 yy_z
        {
            get => new fix4(y, y, 0, z);
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
        public fix4 yyxz
        {
            get => new fix4(y, y, x, z);
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
        public fix4 yyyz
        {
            get => new fix4(y, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyz_
        {
            get => new fix4(y, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyzx
        {
            get => new fix4(y, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyzy
        {
            get => new fix4(y, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yyzz
        {
            get => new fix4(y, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yz__
        {
            get => new fix4(y, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yz_x
        {
            get => new fix4(y, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yz_y
        {
            get => new fix4(y, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yz_z
        {
            get => new fix4(y, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzx_
        {
            get => new fix4(y, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzxx
        {
            get => new fix4(y, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzxy
        {
            get => new fix4(y, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzxz
        {
            get => new fix4(y, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzy_
        {
            get => new fix4(y, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzyx
        {
            get => new fix4(y, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzyy
        {
            get => new fix4(y, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzyz
        {
            get => new fix4(y, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzz_
        {
            get => new fix4(y, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzzx
        {
            get => new fix4(y, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzzy
        {
            get => new fix4(y, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 yzzz
        {
            get => new fix4(y, z, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z___
        {
            get => new fix4(z, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z__x
        {
            get => new fix4(z, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z__y
        {
            get => new fix4(z, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z__z
        {
            get => new fix4(z, 0, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_x_
        {
            get => new fix4(z, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_xx
        {
            get => new fix4(z, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_xy
        {
            get => new fix4(z, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_xz
        {
            get => new fix4(z, 0, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_y_
        {
            get => new fix4(z, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_yx
        {
            get => new fix4(z, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_yy
        {
            get => new fix4(z, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_yz
        {
            get => new fix4(z, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_z_
        {
            get => new fix4(z, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_zx
        {
            get => new fix4(z, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_zy
        {
            get => new fix4(z, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 z_zz
        {
            get => new fix4(z, 0, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zx__
        {
            get => new fix4(z, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zx_x
        {
            get => new fix4(z, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zx_y
        {
            get => new fix4(z, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zx_z
        {
            get => new fix4(z, x, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxx_
        {
            get => new fix4(z, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxxx
        {
            get => new fix4(z, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxxy
        {
            get => new fix4(z, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxxz
        {
            get => new fix4(z, x, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxy_
        {
            get => new fix4(z, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxyx
        {
            get => new fix4(z, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxyy
        {
            get => new fix4(z, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxyz
        {
            get => new fix4(z, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxz_
        {
            get => new fix4(z, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxzx
        {
            get => new fix4(z, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxzy
        {
            get => new fix4(z, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zxzz
        {
            get => new fix4(z, x, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zy__
        {
            get => new fix4(z, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zy_x
        {
            get => new fix4(z, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zy_y
        {
            get => new fix4(z, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zy_z
        {
            get => new fix4(z, y, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyx_
        {
            get => new fix4(z, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyxx
        {
            get => new fix4(z, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyxy
        {
            get => new fix4(z, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyxz
        {
            get => new fix4(z, y, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyy_
        {
            get => new fix4(z, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyyx
        {
            get => new fix4(z, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyyy
        {
            get => new fix4(z, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyyz
        {
            get => new fix4(z, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyz_
        {
            get => new fix4(z, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyzx
        {
            get => new fix4(z, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyzy
        {
            get => new fix4(z, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zyzz
        {
            get => new fix4(z, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zz__
        {
            get => new fix4(z, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zz_x
        {
            get => new fix4(z, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zz_y
        {
            get => new fix4(z, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zz_z
        {
            get => new fix4(z, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzx_
        {
            get => new fix4(z, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzxx
        {
            get => new fix4(z, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzxy
        {
            get => new fix4(z, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzxz
        {
            get => new fix4(z, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzy_
        {
            get => new fix4(z, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzyx
        {
            get => new fix4(z, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzyy
        {
            get => new fix4(z, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzyz
        {
            get => new fix4(z, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzz_
        {
            get => new fix4(z, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzzx
        {
            get => new fix4(z, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzzy
        {
            get => new fix4(z, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 zzzz
        {
            get => new fix4(z, z, z, z);
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
        public fix2 _b
        {
            get => new fix2(0, z);
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
        public fix2 rb
        {
            get => new fix2(x, z);
            set
            {
                x = value.x;
                z = value.y;
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
        public fix2 gb
        {
            get => new fix2(y, z);
            set
            {
                y = value.x;
                z = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 b_
        {
            get => new fix2(z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 br
        {
            get => new fix2(z, x);
            set
            {
                z = value.x;
                x = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 bg
        {
            get => new fix2(z, y);
            set
            {
                z = value.x;
                y = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 bb
        {
            get => new fix2(z, z);
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
        public fix3 __b
        {
            get => new fix3(0, 0, z);
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
        public fix3 _rb
        {
            get => new fix3(0, x, z);
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
        public fix3 _gb
        {
            get => new fix3(0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _b_
        {
            get => new fix3(0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _br
        {
            get => new fix3(0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _bg
        {
            get => new fix3(0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _bb
        {
            get => new fix3(0, z, z);
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
        public fix3 r_b
        {
            get => new fix3(x, 0, z);
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
        public fix3 rrb
        {
            get => new fix3(x, x, z);
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
        public fix3 rgb
        {
            get => new fix3(x, y, z);
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rb_
        {
            get => new fix3(x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rbr
        {
            get => new fix3(x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rbg
        {
            get => new fix3(x, z, y);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 rbb
        {
            get => new fix3(x, z, z);
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
        public fix3 g_b
        {
            get => new fix3(y, 0, z);
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
        public fix3 grb
        {
            get => new fix3(y, x, z);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
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
        public fix3 ggb
        {
            get => new fix3(y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 gb_
        {
            get => new fix3(y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 gbr
        {
            get => new fix3(y, z, x);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 gbg
        {
            get => new fix3(y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 gbb
        {
            get => new fix3(y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 b__
        {
            get => new fix3(z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 b_r
        {
            get => new fix3(z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 b_g
        {
            get => new fix3(z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 b_b
        {
            get => new fix3(z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 br_
        {
            get => new fix3(z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 brr
        {
            get => new fix3(z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 brg
        {
            get => new fix3(z, x, y);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 brb
        {
            get => new fix3(z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bg_
        {
            get => new fix3(z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bgr
        {
            get => new fix3(z, y, x);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bgg
        {
            get => new fix3(z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bgb
        {
            get => new fix3(z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bb_
        {
            get => new fix3(z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bbr
        {
            get => new fix3(z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bbg
        {
            get => new fix3(z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 bbb
        {
            get => new fix3(z, z, z);
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
        public fix4 ___b
        {
            get => new fix4(0, 0, 0, z);
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
        public fix4 __rb
        {
            get => new fix4(0, 0, x, z);
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
        public fix4 __gb
        {
            get => new fix4(0, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __b_
        {
            get => new fix4(0, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __br
        {
            get => new fix4(0, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __bg
        {
            get => new fix4(0, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __bb
        {
            get => new fix4(0, 0, z, z);
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
        public fix4 _r_b
        {
            get => new fix4(0, x, 0, z);
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
        public fix4 _rrb
        {
            get => new fix4(0, x, x, z);
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
        public fix4 _rgb
        {
            get => new fix4(0, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rb_
        {
            get => new fix4(0, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rbr
        {
            get => new fix4(0, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rbg
        {
            get => new fix4(0, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _rbb
        {
            get => new fix4(0, x, z, z);
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
        public fix4 _g_b
        {
            get => new fix4(0, y, 0, z);
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
        public fix4 _grb
        {
            get => new fix4(0, y, x, z);
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
        public fix4 _ggb
        {
            get => new fix4(0, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _gb_
        {
            get => new fix4(0, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _gbr
        {
            get => new fix4(0, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _gbg
        {
            get => new fix4(0, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _gbb
        {
            get => new fix4(0, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _b__
        {
            get => new fix4(0, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _b_r
        {
            get => new fix4(0, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _b_g
        {
            get => new fix4(0, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _b_b
        {
            get => new fix4(0, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _br_
        {
            get => new fix4(0, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _brr
        {
            get => new fix4(0, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _brg
        {
            get => new fix4(0, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _brb
        {
            get => new fix4(0, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bg_
        {
            get => new fix4(0, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bgr
        {
            get => new fix4(0, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bgg
        {
            get => new fix4(0, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bgb
        {
            get => new fix4(0, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bb_
        {
            get => new fix4(0, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bbr
        {
            get => new fix4(0, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bbg
        {
            get => new fix4(0, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _bbb
        {
            get => new fix4(0, z, z, z);
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
        public fix4 r__b
        {
            get => new fix4(x, 0, 0, z);
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
        public fix4 r_rb
        {
            get => new fix4(x, 0, x, z);
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
        public fix4 r_gb
        {
            get => new fix4(x, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_b_
        {
            get => new fix4(x, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_br
        {
            get => new fix4(x, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_bg
        {
            get => new fix4(x, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 r_bb
        {
            get => new fix4(x, 0, z, z);
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
        public fix4 rr_b
        {
            get => new fix4(x, x, 0, z);
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
        public fix4 rrrb
        {
            get => new fix4(x, x, x, z);
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
        public fix4 rrgb
        {
            get => new fix4(x, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrb_
        {
            get => new fix4(x, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrbr
        {
            get => new fix4(x, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrbg
        {
            get => new fix4(x, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rrbb
        {
            get => new fix4(x, x, z, z);
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
        public fix4 rg_b
        {
            get => new fix4(x, y, 0, z);
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
        public fix4 rgrb
        {
            get => new fix4(x, y, x, z);
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
        public fix4 rggb
        {
            get => new fix4(x, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgb_
        {
            get => new fix4(x, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgbr
        {
            get => new fix4(x, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgbg
        {
            get => new fix4(x, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rgbb
        {
            get => new fix4(x, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rb__
        {
            get => new fix4(x, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rb_r
        {
            get => new fix4(x, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rb_g
        {
            get => new fix4(x, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rb_b
        {
            get => new fix4(x, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbr_
        {
            get => new fix4(x, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbrr
        {
            get => new fix4(x, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbrg
        {
            get => new fix4(x, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbrb
        {
            get => new fix4(x, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbg_
        {
            get => new fix4(x, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbgr
        {
            get => new fix4(x, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbgg
        {
            get => new fix4(x, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbgb
        {
            get => new fix4(x, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbb_
        {
            get => new fix4(x, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbbr
        {
            get => new fix4(x, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbbg
        {
            get => new fix4(x, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 rbbb
        {
            get => new fix4(x, z, z, z);
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
        public fix4 g__b
        {
            get => new fix4(y, 0, 0, z);
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
        public fix4 g_rb
        {
            get => new fix4(y, 0, x, z);
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
        public fix4 g_gb
        {
            get => new fix4(y, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_b_
        {
            get => new fix4(y, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_br
        {
            get => new fix4(y, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_bg
        {
            get => new fix4(y, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 g_bb
        {
            get => new fix4(y, 0, z, z);
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
        public fix4 gr_b
        {
            get => new fix4(y, x, 0, z);
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
        public fix4 grrb
        {
            get => new fix4(y, x, x, z);
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
        public fix4 grgb
        {
            get => new fix4(y, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grb_
        {
            get => new fix4(y, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grbr
        {
            get => new fix4(y, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grbg
        {
            get => new fix4(y, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 grbb
        {
            get => new fix4(y, x, z, z);
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
        public fix4 gg_b
        {
            get => new fix4(y, y, 0, z);
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
        public fix4 ggrb
        {
            get => new fix4(y, y, x, z);
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
        public fix4 gggb
        {
            get => new fix4(y, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggb_
        {
            get => new fix4(y, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggbr
        {
            get => new fix4(y, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggbg
        {
            get => new fix4(y, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ggbb
        {
            get => new fix4(y, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gb__
        {
            get => new fix4(y, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gb_r
        {
            get => new fix4(y, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gb_g
        {
            get => new fix4(y, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gb_b
        {
            get => new fix4(y, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbr_
        {
            get => new fix4(y, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbrr
        {
            get => new fix4(y, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbrg
        {
            get => new fix4(y, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbrb
        {
            get => new fix4(y, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbg_
        {
            get => new fix4(y, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbgr
        {
            get => new fix4(y, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbgg
        {
            get => new fix4(y, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbgb
        {
            get => new fix4(y, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbb_
        {
            get => new fix4(y, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbbr
        {
            get => new fix4(y, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbbg
        {
            get => new fix4(y, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 gbbb
        {
            get => new fix4(y, z, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b___
        {
            get => new fix4(z, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b__r
        {
            get => new fix4(z, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b__g
        {
            get => new fix4(z, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b__b
        {
            get => new fix4(z, 0, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_r_
        {
            get => new fix4(z, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_rr
        {
            get => new fix4(z, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_rg
        {
            get => new fix4(z, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_rb
        {
            get => new fix4(z, 0, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_g_
        {
            get => new fix4(z, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_gr
        {
            get => new fix4(z, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_gg
        {
            get => new fix4(z, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_gb
        {
            get => new fix4(z, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_b_
        {
            get => new fix4(z, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_br
        {
            get => new fix4(z, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_bg
        {
            get => new fix4(z, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 b_bb
        {
            get => new fix4(z, 0, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 br__
        {
            get => new fix4(z, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 br_r
        {
            get => new fix4(z, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 br_g
        {
            get => new fix4(z, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 br_b
        {
            get => new fix4(z, x, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brr_
        {
            get => new fix4(z, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brrr
        {
            get => new fix4(z, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brrg
        {
            get => new fix4(z, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brrb
        {
            get => new fix4(z, x, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brg_
        {
            get => new fix4(z, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brgr
        {
            get => new fix4(z, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brgg
        {
            get => new fix4(z, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brgb
        {
            get => new fix4(z, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brb_
        {
            get => new fix4(z, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brbr
        {
            get => new fix4(z, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brbg
        {
            get => new fix4(z, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 brbb
        {
            get => new fix4(z, x, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bg__
        {
            get => new fix4(z, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bg_r
        {
            get => new fix4(z, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bg_g
        {
            get => new fix4(z, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bg_b
        {
            get => new fix4(z, y, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgr_
        {
            get => new fix4(z, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgrr
        {
            get => new fix4(z, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgrg
        {
            get => new fix4(z, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgrb
        {
            get => new fix4(z, y, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgg_
        {
            get => new fix4(z, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bggr
        {
            get => new fix4(z, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bggg
        {
            get => new fix4(z, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bggb
        {
            get => new fix4(z, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgb_
        {
            get => new fix4(z, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgbr
        {
            get => new fix4(z, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgbg
        {
            get => new fix4(z, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bgbb
        {
            get => new fix4(z, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bb__
        {
            get => new fix4(z, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bb_r
        {
            get => new fix4(z, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bb_g
        {
            get => new fix4(z, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bb_b
        {
            get => new fix4(z, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbr_
        {
            get => new fix4(z, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbrr
        {
            get => new fix4(z, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbrg
        {
            get => new fix4(z, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbrb
        {
            get => new fix4(z, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbg_
        {
            get => new fix4(z, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbgr
        {
            get => new fix4(z, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbgg
        {
            get => new fix4(z, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbgb
        {
            get => new fix4(z, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbb_
        {
            get => new fix4(z, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbbr
        {
            get => new fix4(z, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbbg
        {
            get => new fix4(z, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 bbbb
        {
            get => new fix4(z, z, z, z);
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
        public fix2 _p
        {
            get => new fix2(0, z);
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
        public fix2 sp
        {
            get => new fix2(x, z);
            set
            {
                x = value.x;
                z = value.y;
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
        public fix2 tp
        {
            get => new fix2(y, z);
            set
            {
                y = value.x;
                z = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 p_
        {
            get => new fix2(z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 ps
        {
            get => new fix2(z, x);
            set
            {
                z = value.x;
                x = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 pt
        {
            get => new fix2(z, y);
            set
            {
                z = value.x;
                y = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix2 pp
        {
            get => new fix2(z, z);
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
        public fix3 __p
        {
            get => new fix3(0, 0, z);
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
        public fix3 _sp
        {
            get => new fix3(0, x, z);
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
        public fix3 _tp
        {
            get => new fix3(0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _p_
        {
            get => new fix3(0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _ps
        {
            get => new fix3(0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _pt
        {
            get => new fix3(0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 _pp
        {
            get => new fix3(0, z, z);
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
        public fix3 s_p
        {
            get => new fix3(x, 0, z);
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
        public fix3 ssp
        {
            get => new fix3(x, x, z);
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
        public fix3 stp
        {
            get => new fix3(x, y, z);
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 sp_
        {
            get => new fix3(x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 sps
        {
            get => new fix3(x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 spt
        {
            get => new fix3(x, z, y);
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 spp
        {
            get => new fix3(x, z, z);
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
        public fix3 t_p
        {
            get => new fix3(y, 0, z);
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
        public fix3 tsp
        {
            get => new fix3(y, x, z);
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
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
        public fix3 ttp
        {
            get => new fix3(y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tp_
        {
            get => new fix3(y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tps
        {
            get => new fix3(y, z, x);
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tpt
        {
            get => new fix3(y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 tpp
        {
            get => new fix3(y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 p__
        {
            get => new fix3(z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 p_s
        {
            get => new fix3(z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 p_t
        {
            get => new fix3(z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 p_p
        {
            get => new fix3(z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ps_
        {
            get => new fix3(z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 pss
        {
            get => new fix3(z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 pst
        {
            get => new fix3(z, x, y);
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 psp
        {
            get => new fix3(z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 pt_
        {
            get => new fix3(z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 pts
        {
            get => new fix3(z, y, x);
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ptt
        {
            get => new fix3(z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ptp
        {
            get => new fix3(z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 pp_
        {
            get => new fix3(z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 pps
        {
            get => new fix3(z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ppt
        {
            get => new fix3(z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix3 ppp
        {
            get => new fix3(z, z, z);
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
        public fix4 ___p
        {
            get => new fix4(0, 0, 0, z);
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
        public fix4 __sp
        {
            get => new fix4(0, 0, x, z);
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
        public fix4 __tp
        {
            get => new fix4(0, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __p_
        {
            get => new fix4(0, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __ps
        {
            get => new fix4(0, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __pt
        {
            get => new fix4(0, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 __pp
        {
            get => new fix4(0, 0, z, z);
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
        public fix4 _s_p
        {
            get => new fix4(0, x, 0, z);
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
        public fix4 _ssp
        {
            get => new fix4(0, x, x, z);
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
        public fix4 _stp
        {
            get => new fix4(0, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _sp_
        {
            get => new fix4(0, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _sps
        {
            get => new fix4(0, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _spt
        {
            get => new fix4(0, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _spp
        {
            get => new fix4(0, x, z, z);
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
        public fix4 _t_p
        {
            get => new fix4(0, y, 0, z);
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
        public fix4 _tsp
        {
            get => new fix4(0, y, x, z);
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
        public fix4 _ttp
        {
            get => new fix4(0, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tp_
        {
            get => new fix4(0, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tps
        {
            get => new fix4(0, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tpt
        {
            get => new fix4(0, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _tpp
        {
            get => new fix4(0, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _p__
        {
            get => new fix4(0, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _p_s
        {
            get => new fix4(0, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _p_t
        {
            get => new fix4(0, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _p_p
        {
            get => new fix4(0, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ps_
        {
            get => new fix4(0, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _pss
        {
            get => new fix4(0, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _pst
        {
            get => new fix4(0, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _psp
        {
            get => new fix4(0, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _pt_
        {
            get => new fix4(0, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _pts
        {
            get => new fix4(0, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ptt
        {
            get => new fix4(0, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ptp
        {
            get => new fix4(0, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _pp_
        {
            get => new fix4(0, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _pps
        {
            get => new fix4(0, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ppt
        {
            get => new fix4(0, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 _ppp
        {
            get => new fix4(0, z, z, z);
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
        public fix4 s__p
        {
            get => new fix4(x, 0, 0, z);
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
        public fix4 s_sp
        {
            get => new fix4(x, 0, x, z);
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
        public fix4 s_tp
        {
            get => new fix4(x, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_p_
        {
            get => new fix4(x, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_ps
        {
            get => new fix4(x, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_pt
        {
            get => new fix4(x, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 s_pp
        {
            get => new fix4(x, 0, z, z);
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
        public fix4 ss_p
        {
            get => new fix4(x, x, 0, z);
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
        public fix4 sssp
        {
            get => new fix4(x, x, x, z);
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
        public fix4 sstp
        {
            get => new fix4(x, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ssp_
        {
            get => new fix4(x, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ssps
        {
            get => new fix4(x, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sspt
        {
            get => new fix4(x, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sspp
        {
            get => new fix4(x, x, z, z);
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
        public fix4 st_p
        {
            get => new fix4(x, y, 0, z);
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
        public fix4 stsp
        {
            get => new fix4(x, y, x, z);
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
        public fix4 sttp
        {
            get => new fix4(x, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stp_
        {
            get => new fix4(x, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stps
        {
            get => new fix4(x, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stpt
        {
            get => new fix4(x, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 stpp
        {
            get => new fix4(x, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sp__
        {
            get => new fix4(x, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sp_s
        {
            get => new fix4(x, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sp_t
        {
            get => new fix4(x, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sp_p
        {
            get => new fix4(x, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sps_
        {
            get => new fix4(x, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spss
        {
            get => new fix4(x, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spst
        {
            get => new fix4(x, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spsp
        {
            get => new fix4(x, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spt_
        {
            get => new fix4(x, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spts
        {
            get => new fix4(x, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sptt
        {
            get => new fix4(x, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sptp
        {
            get => new fix4(x, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spp_
        {
            get => new fix4(x, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 spps
        {
            get => new fix4(x, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sppt
        {
            get => new fix4(x, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 sppp
        {
            get => new fix4(x, z, z, z);
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
        public fix4 t__p
        {
            get => new fix4(y, 0, 0, z);
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
        public fix4 t_sp
        {
            get => new fix4(y, 0, x, z);
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
        public fix4 t_tp
        {
            get => new fix4(y, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_p_
        {
            get => new fix4(y, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_ps
        {
            get => new fix4(y, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_pt
        {
            get => new fix4(y, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 t_pp
        {
            get => new fix4(y, 0, z, z);
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
        public fix4 ts_p
        {
            get => new fix4(y, x, 0, z);
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
        public fix4 tssp
        {
            get => new fix4(y, x, x, z);
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
        public fix4 tstp
        {
            get => new fix4(y, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tsp_
        {
            get => new fix4(y, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tsps
        {
            get => new fix4(y, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tspt
        {
            get => new fix4(y, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tspp
        {
            get => new fix4(y, x, z, z);
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
        public fix4 tt_p
        {
            get => new fix4(y, y, 0, z);
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
        public fix4 ttsp
        {
            get => new fix4(y, y, x, z);
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

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tttp
        {
            get => new fix4(y, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttp_
        {
            get => new fix4(y, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttps
        {
            get => new fix4(y, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttpt
        {
            get => new fix4(y, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ttpp
        {
            get => new fix4(y, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tp__
        {
            get => new fix4(y, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tp_s
        {
            get => new fix4(y, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tp_t
        {
            get => new fix4(y, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tp_p
        {
            get => new fix4(y, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tps_
        {
            get => new fix4(y, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpss
        {
            get => new fix4(y, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpst
        {
            get => new fix4(y, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpsp
        {
            get => new fix4(y, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpt_
        {
            get => new fix4(y, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpts
        {
            get => new fix4(y, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tptt
        {
            get => new fix4(y, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tptp
        {
            get => new fix4(y, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpp_
        {
            get => new fix4(y, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tpps
        {
            get => new fix4(y, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tppt
        {
            get => new fix4(y, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 tppp
        {
            get => new fix4(y, z, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p___
        {
            get => new fix4(z, 0, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p__s
        {
            get => new fix4(z, 0, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p__t
        {
            get => new fix4(z, 0, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p__p
        {
            get => new fix4(z, 0, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_s_
        {
            get => new fix4(z, 0, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_ss
        {
            get => new fix4(z, 0, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_st
        {
            get => new fix4(z, 0, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_sp
        {
            get => new fix4(z, 0, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_t_
        {
            get => new fix4(z, 0, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_ts
        {
            get => new fix4(z, 0, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_tt
        {
            get => new fix4(z, 0, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_tp
        {
            get => new fix4(z, 0, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_p_
        {
            get => new fix4(z, 0, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_ps
        {
            get => new fix4(z, 0, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_pt
        {
            get => new fix4(z, 0, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 p_pp
        {
            get => new fix4(z, 0, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ps__
        {
            get => new fix4(z, x, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ps_s
        {
            get => new fix4(z, x, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ps_t
        {
            get => new fix4(z, x, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ps_p
        {
            get => new fix4(z, x, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pss_
        {
            get => new fix4(z, x, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 psss
        {
            get => new fix4(z, x, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 psst
        {
            get => new fix4(z, x, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pssp
        {
            get => new fix4(z, x, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pst_
        {
            get => new fix4(z, x, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 psts
        {
            get => new fix4(z, x, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pstt
        {
            get => new fix4(z, x, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pstp
        {
            get => new fix4(z, x, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 psp_
        {
            get => new fix4(z, x, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 psps
        {
            get => new fix4(z, x, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pspt
        {
            get => new fix4(z, x, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pspp
        {
            get => new fix4(z, x, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pt__
        {
            get => new fix4(z, y, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pt_s
        {
            get => new fix4(z, y, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pt_t
        {
            get => new fix4(z, y, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pt_p
        {
            get => new fix4(z, y, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pts_
        {
            get => new fix4(z, y, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptss
        {
            get => new fix4(z, y, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptst
        {
            get => new fix4(z, y, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptsp
        {
            get => new fix4(z, y, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptt_
        {
            get => new fix4(z, y, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptts
        {
            get => new fix4(z, y, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pttt
        {
            get => new fix4(z, y, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pttp
        {
            get => new fix4(z, y, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptp_
        {
            get => new fix4(z, y, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptps
        {
            get => new fix4(z, y, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptpt
        {
            get => new fix4(z, y, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ptpp
        {
            get => new fix4(z, y, z, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pp__
        {
            get => new fix4(z, z, 0, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pp_s
        {
            get => new fix4(z, z, 0, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pp_t
        {
            get => new fix4(z, z, 0, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pp_p
        {
            get => new fix4(z, z, 0, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pps_
        {
            get => new fix4(z, z, x, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppss
        {
            get => new fix4(z, z, x, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppst
        {
            get => new fix4(z, z, x, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppsp
        {
            get => new fix4(z, z, x, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppt_
        {
            get => new fix4(z, z, y, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppts
        {
            get => new fix4(z, z, y, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pptt
        {
            get => new fix4(z, z, y, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pptp
        {
            get => new fix4(z, z, y, z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppp_
        {
            get => new fix4(z, z, z, 0);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 ppps
        {
            get => new fix4(z, z, z, x);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pppt
        {
            get => new fix4(z, z, z, y);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public fix4 pppp
        {
            get => new fix4(z, z, z, z);
        }
    }
}
