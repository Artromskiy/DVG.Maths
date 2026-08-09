#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace KibiHex
{
    /// <summary>A vector of type float with 3 components.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [System.Runtime.Serialization.DataContract]
    public partial struct float3 : IEquatable<float3>, IComparable<float3>
    {

        [System.Runtime.Serialization.DataMember(Order = 0)]
        public float x;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public float y;

        [System.Runtime.Serialization.DataMember(Order = 2)]
        public float z;

        public static readonly float3 zero = new float3(0f, 0f, 0f);

        public float3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float3(float value)
        {
            x = value;
            y = value;
            z = value;
        }

        public float3(float2 value)
        {
            x = value.x;
            y = value.y;
            z = 0f;
        }

        public float3(float3 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public float3(float4 value)
        {
            x = value.x;
            y = value.y;
            z = value.z;
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

        public int Count => 3;

        public bool Equals(float3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            return obj is float3 other && Equals(other);
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

        public int CompareTo(float3 other)
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

        public static float3 Parse(string value)
        {
            var values = value.Split(',');
            return new(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));
        }

        public static float3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(',');
            return new(float.Parse(values[0], format), float.Parse(values[1], format), float.Parse(values[2], format));
        }
    }
}
