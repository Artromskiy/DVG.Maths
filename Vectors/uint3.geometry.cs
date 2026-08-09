#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct uint3
    {

        public static uint3 Clamp(uint3 value, uint min, uint max)
        {
            return new(Maths.Clamp(value.x, min, max), Maths.Clamp(value.y, min, max), Maths.Clamp(value.z, min, max));
        }
    }
}
