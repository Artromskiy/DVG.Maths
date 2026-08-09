#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct int2
    {

        public static int2 Clamp(int2 value, int min, int max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max));
        }
    }
}
