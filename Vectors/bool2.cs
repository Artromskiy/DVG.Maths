#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type bool with 2 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct bool2 : IEquatable<bool2>, IComparable<bool2>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public bool x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public bool y;

        public static readonly bool2 zero = new bool2(false, false);

        public bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        public bool2(bool value)
        {
            x = value;
            y = value;
        }

        public bool2(bool2 value)
        {
            x = value.x;
            y = value.y;
        }

        public bool2(bool3 value)
        {
            x = value.x;
            y = value.y;
        }

        public bool2(bool4 value)
        {
            x = value.x;
            y = value.y;
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

        public int Count => 2;

        public bool Equals(bool2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj)
        {
            return obj is bool2 other && Equals(other);
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

        public int CompareTo(bool2 other)
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

        public static bool2 Parse(string value)
        {
            var values = value.Split(',');
            return new(bool.Parse(values[0]), bool.Parse(values[1]));
        }

        public static bool Any(bool2 value)
        {
            return value.x || value.y;
        }

        public static bool All(bool2 value)
        {
            return value.x && value.y;
        }
    }
}
