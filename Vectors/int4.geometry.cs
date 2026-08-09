#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct int4
    {

        public static int4 Clamp(int4 value, int min, int max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max), Maths.Clamp(value.w, min, max));
        }
    }
}
