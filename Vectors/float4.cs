#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type float with 4 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct float4 : IEquatable<float4>, IComparable<float4>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public float x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public float y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public float z;

        [System.Runtime.Serialization.DataMember(Order = 3)]
        public float w;

        public static readonly float4 zero = new float4(0f, 0f, 0f, 0f);

        public float4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float4(float value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public float4(float2 value)
        {
            x = value.x;
            y = value.y;
            z = 0f;
            w = 0f;
        }

        public float4(float3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = 0f;
        }

        public float4(float4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
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

        public int Count => 4;

        public bool Equals(float4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }

        public override bool Equals(object obj)
        {
            return obj is float4 other && Equals(other);
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

        public int CompareTo(float4 other)
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

        public static float4 Parse(string value)
        {
            var values = value.Split(',');
            return new(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]), float.Parse(values[3]));
        }

        public static float4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(float.Parse(values[0], format), float.Parse(values[1], format), float.Parse(values[2], format), float.Parse(values[3], format));
        }
    }
}
