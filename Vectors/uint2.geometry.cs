#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct uint2
    {

        public static uint2 Clamp(uint2 value, uint min, uint max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max));
        }
    }
}
