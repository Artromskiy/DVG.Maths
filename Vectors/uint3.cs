#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type uint with 3 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct uint3 : IEquatable<uint3>, IComparable<uint3>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public uint x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public uint y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public uint z;

        public static readonly uint3 zero = new uint3(0u, 0u, 0u);

        public uint3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public uint3(uint value)
        {
            x = value;
            y = value;
            z = value;
        }

        public uint3(uint2 value)
        {
            x = value.x;
            y = value.y;
            z = 0u;
        }

        public uint3(uint3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public uint3(uint4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
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

        public int Count => 3;

        public bool Equals(uint3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            return obj is uint3 other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 31 + x.GetHashCode();
                hash = hash * 31 + y.GetHashCode();
                hash = hash * 31 + z.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(uint3 other)
        {
            var xComparison = x.CompareTo(other.x);
            if (xComparison != 0) return xComparison;
            var yComparison = y.CompareTo(other.y);
            if (yComparison != 0) return yComparison;
            var zComparison = z.CompareTo(other.z);
            if (zComparison != 0) return zComparison;
            return 0;
        }

        public override string ToString()
        {
            return $"[{x}, {y}, {z}]";
        }

        public static uint3 Parse(string value)
        {
            var values = value.Split(',');
            return new(uint.Parse(values[0]), uint.Parse(values[1]), uint.Parse(values[2]));
        }

        public static uint3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(uint.Parse(values[0], format), uint.Parse(values[1], format), uint.Parse(values[2], format));
        }
    }
}
