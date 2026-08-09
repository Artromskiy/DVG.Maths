#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type int with 2 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct int2 : IEquatable<int2>, IComparable<int2>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public int x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int y;

        public static readonly int2 zero = new int2(0, 0);

        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int2(int value)
        {
            x = value;
            y = value;
        }

        public int2(int2 value)
        {
            x = value.x;
            y = value.y;
        }

        public int2(int3 value)
        {
            x = value.x;
            y = value.y;
        }

        public int2(int4 value)
        {
            x = value.x;
            y = value.y;
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

        public int Count => 2;

        public bool Equals(int2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj)
        {
            return obj is int2 other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 31 + x.GetHashCode();
                hash = hash * 31 + y.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(int2 other)
        {
            var xComparison = x.CompareTo(other.x);
            if (xComparison != 0) return xComparison;
            var yComparison = y.CompareTo(other.y);
            if (yComparison != 0) return yComparison;
            return 0;
        }

        public override string ToString()
        {
            return $"[{x}, {y}]";
        }

        public static int2 Parse(string value)
        {
            var values = value.Split(',');
            return new(int.Parse(values[0]), int.Parse(values[1]));
        }

        public static int2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(int.Parse(values[0], format), int.Parse(values[1], format));
        }
    }
}
