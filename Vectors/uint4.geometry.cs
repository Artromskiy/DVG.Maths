#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct uint4
    {

        public static uint4 Clamp(uint4 value, uint min, uint max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max), Maths.Clamp(value.w, min, max));
        }
    }
}
