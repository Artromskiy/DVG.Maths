#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type fix with 2 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct fix2 : IEquatable<fix2>, IComparable<fix2>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public fix x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public fix y;

        public static readonly fix2 zero = new fix2(0, 0);

        public fix2(fix x, fix y)
        {
            this.x = x;
            this.y = y;
        }

        public fix2(fix value)
        {
            x = value;
            y = value;
        }

        public fix2(fix2 value)
        {
            x = value.x;
            y = value.y;
        }

        public fix2(fix3 value)
        {
            x = value.x;
            y = value.y;
        }

        public fix2(fix4 value)
        {
            x = value.x;
            y = value.y;
        }

        public fix this[int index]
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

        public bool Equals(fix2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj)
        {
            return obj is fix2 other && Equals(other);
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

        public int CompareTo(fix2 other)
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

        public static fix2 Parse(string value)
        {
            var values = value.Split(',');
            return new(fix.Parse(values[0]), fix.Parse(values[1]));
        }

        public static fix2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(fix.Parse(values[0], format), fix.Parse(values[1], format));
        }
    }
}
