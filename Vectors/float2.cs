#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type float with 2 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct float2 : IEquatable<float2>, IComparable<float2>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public float x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public float y;

        public static readonly float2 zero = new float2(0f, 0f);

        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float2(float value)
        {
            x = value;
            y = value;
        }

        public float2(float2 value)
        {
            x = value.x;
            y = value.y;
        }

        public float2(float3 value)
        {
            x = value.x;
            y = value.y;
        }

        public float2(float4 value)
        {
            x = value.x;
            y = value.y;
        }

        public float this[int index]
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

        public bool Equals(float2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj)
        {
            return obj is float2 other && Equals(other);
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

        public int CompareTo(float2 other)
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

        public static float2 Parse(string value)
        {
            var values = value.Split(',');
            return new(float.Parse(values[0]), float.Parse(values[1]));
        }

        public static float2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(float.Parse(values[0], format), float.Parse(values[1], format));
        }
    }
}
