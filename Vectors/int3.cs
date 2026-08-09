#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type int with 3 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct int3 : IEquatable<int3>, IComparable<int3>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public int x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public int z;

        public static readonly int3 zero = new int3(0, 0, 0);

        public int3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int3(int value)
        {
            x = value;
            y = value;
            z = value;
        }

        public int3(int2 value)
        {
            x = value.x;
            y = value.y;
            z = 0;
        }

        public int3(int3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public int3(int4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public int this[int index]
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

        public bool Equals(int3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            return obj is int3 other && Equals(other);
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

        public int CompareTo(int3 other)
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

        public static int3 Parse(string value)
        {
            var values = value.Split(',');
            return new(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));
        }

        public static int3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(int.Parse(values[0], format), int.Parse(values[1], format), int.Parse(values[2], format));
        }
    }
}
