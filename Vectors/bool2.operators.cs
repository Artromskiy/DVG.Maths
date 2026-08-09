#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct bool2
    {

        public static bool operator ==(bool2 left, bool2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(bool2 left, bool2 right)
        {
            return left.x != right.x || left.y != right.y;
        }
    }
}
