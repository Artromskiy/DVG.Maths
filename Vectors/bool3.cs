#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type bool with 3 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct bool3 : IEquatable<bool3>, IComparable<bool3>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public bool x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public bool y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public bool z;

        public static readonly bool3 zero = new bool3(false, false, false);

        public bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool3(bool value)
        {
            x = value;
            y = value;
            z = value;
        }

        public bool3(bool2 value)
        {
            x = value.x;
            y = value.y;
            z = false;
        }

        public bool3(bool3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public bool3(bool4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
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

        public int Count => 3;

        public bool Equals(bool3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            return obj is bool3 other && Equals(other);
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

        public int CompareTo(bool3 other)
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

        public static bool3 Parse(string value)
        {
            var values = value.Split(',');
            return new(bool.Parse(values[0]), bool.Parse(values[1]), bool.Parse(values[2]));
        }

        public static bool Any(bool3 value)
        {
            return value.x || value.y || value.z;
        }

        public static bool All(bool3 value)
        {
            return value.x && value.y && value.z;
        }
    }
}
