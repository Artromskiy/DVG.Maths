#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public partial struct bool3
    {

        public static bool operator ==(bool3 left, bool3 right)
        {
            return left.x == right.x && left.y == right.y && left.z == right.z;
        }

        public static bool operator !=(bool3 left, bool3 right)
        {
            return left.x != right.x || left.y != right.y || left.z != right.z;
        }
    }
}
