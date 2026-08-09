#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type double with 4 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct double4 : IEquatable<double4>, IComparable<double4>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public double x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public double y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public double z;

        [System.Runtime.Serialization.DataMember(Order = 3)]
        public double w;

        public static readonly double4 zero = new double4(0.0, 0.0, 0.0, 0.0);

        public double4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public double4(double value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public double4(double2 value)
        {
            x = value.x;
            y = value.y;
            z = 0.0;
            w = 0.0;
        }

        public double4(double3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = 0.0;
        }

        public double4(double4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
        }

        public double this[int index]
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

        public bool Equals(double4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }

        public override bool Equals(object obj)
        {
            return obj is double4 other && Equals(other);
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

        public int CompareTo(double4 other)
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

        public static double4 Parse(string value)
        {
            var values = value.Split(',');
            return new(double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2]), double.Parse(values[3]));
        }

        public static double4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(double.Parse(values[0], format), double.Parse(values[1], format), double.Parse(values[2], format), double.Parse(values[3], format));
        }
    }
}
