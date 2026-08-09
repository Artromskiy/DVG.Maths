#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type bool with 4 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct bool4 : IEquatable<bool4>, IComparable<bool4>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public bool x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public bool y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public bool z;

        [System.Runtime.Serialization.DataMember(Order = 3)]
        public bool w;

        public static readonly bool4 zero = new bool4(false, false, false, false);

        public bool4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public bool4(bool value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public bool4(bool2 value)
        {
            x = value.x;
            y = value.y;
            z = false;
            w = false;
        }

        public bool4(bool3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = false;
        }

        public bool4(bool4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
        }

        public bool this[int index]
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

        public bool Equals(bool4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }

        public override bool Equals(object obj)
        {
            return obj is bool4 other && Equals(other);
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

        public int CompareTo(bool4 other)
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

        public static bool4 Parse(string value)
        {
            var values = value.Split(',');
            return new(bool.Parse(values[0]), bool.Parse(values[1]), bool.Parse(values[2]), bool.Parse(values[3]));
        }

        public static bool Any(bool4 value)
        {
            return value.x || value.y || value.z || value.w;
        }

        public static bool All(bool4 value)
        {
            return value.x && value.y && value.z && value.w;
        }
    }
}
