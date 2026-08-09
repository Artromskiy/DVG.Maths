#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type fix with 4 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct fix4 : IEquatable<fix4>, IComparable<fix4>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public fix x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public fix y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public fix z;

        [System.Runtime.Serialization.DataMember(Order = 3)]
        public fix w;

        public static readonly fix4 zero = new fix4(0, 0, 0, 0);

        public fix4(fix x, fix y, fix z, fix w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public fix4(fix value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public fix4(fix2 value)
        {
            x = value.x;
            y = value.y;
            z = 0;
            w = 0;
        }

        public fix4(fix3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = 0;
        }

        public fix4(fix4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
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

        public int Count => 4;

        public bool Equals(fix4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }

        public override bool Equals(object obj)
        {
            return obj is fix4 other && Equals(other);
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

        public int CompareTo(fix4 other)
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

        public static fix4 Parse(string value)
        {
            var values = value.Split(',');
            return new(fix.Parse(values[0]), fix.Parse(values[1]), fix.Parse(values[2]), fix.Parse(values[3]));
        }

        public static fix4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(fix.Parse(values[0], format), fix.Parse(values[1], format), fix.Parse(values[2], format), fix.Parse(values[3], format));
        }
    }
}
