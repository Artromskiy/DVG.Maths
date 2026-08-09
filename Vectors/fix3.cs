#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type fix with 3 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct fix3 : IEquatable<fix3>, IComparable<fix3>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public fix x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public fix y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public fix z;

        public static readonly fix3 zero = new fix3(0, 0, 0);

        public fix3(fix x, fix y, fix z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public fix3(fix value)
        {
            x = value;
            y = value;
            z = value;
        }

        public fix3(fix2 value)
        {
            x = value.x;
            y = value.y;
            z = 0;
        }

        public fix3(fix3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public fix3(fix4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
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

        public int Count => 3;

        public bool Equals(fix3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            return obj is fix3 other && Equals(other);
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

        public int CompareTo(fix3 other)
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

        public static fix3 Parse(string value)
        {
            var values = value.Split(',');
            return new(fix.Parse(values[0]), fix.Parse(values[1]), fix.Parse(values[2]));
        }

        public static fix3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(fix.Parse(values[0], format), fix.Parse(values[1], format), fix.Parse(values[2], format));
        }
    }
}
