#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type uint with 4 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct uint4 : IEquatable<uint4>, IComparable<uint4>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public uint x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public uint y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public uint z;

        [System.Runtime.Serialization.DataMember(Order = 3)]
        public uint w;

        public static readonly uint4 zero = new uint4(0u, 0u, 0u, 0u);

        public uint4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public uint4(uint value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public uint4(uint2 value)
        {
            x = value.x;
            y = value.y;
            z = 0u;
            w = 0u;
        }

        public uint4(uint3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = 0u;
        }

        public uint4(uint4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
        }

        public uint this[int index]
        {
            get
            {
                if ((uint)index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return Unsafe.Add(ref x, index);
            }
            set
            {
                if ((uint)index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                Unsafe.Add(ref x, index) = value;
            }
        }

        public int Count => 4;

        public bool Equals(uint4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }

        public override bool Equals(object obj)
        {
            return obj is uint4 other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 31 + x.GetHashCode();
                hash = hash * 31 + y.GetHashCode();
                hash = hash * 31 + z.GetHashCode();
                hash = hash * 31 + w.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(uint4 other)
        {
            var xComparison = x.CompareTo(other.x);
            if (xComparison != 0) return xComparison;
            var yComparison = y.CompareTo(other.y);
            if (yComparison != 0) return yComparison;
            var zComparison = z.CompareTo(other.z);
            if (zComparison != 0) return zComparison;
            var wComparison = w.CompareTo(other.w);
            if (wComparison != 0) return wComparison;
            return 0;
        }

        public override string ToString()
        {
            return $"[{x}, {y}, {z}, {w}]";
        }

        public static uint4 Parse(string value)
        {
            var values = value.Split(',');
            return new(uint.Parse(values[0]), uint.Parse(values[1]), uint.Parse(values[2]), uint.Parse(values[3]));
        }

        public static uint4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(uint.Parse(values[0], format), uint.Parse(values[1], format), uint.Parse(values[2], format), uint.Parse(values[3], format));
        }
    }
}
