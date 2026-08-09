#pragma warning disable IDE1006
#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace KibiHex
{

    /// <summary>
    /// A vector of type float with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct float4 : IEquatable<float4>, IComparable<float4>
    {

        #region Fields

        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public float x;

        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public float y;

        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public float z;

        /// <summary>
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public float w;

        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly float4 zero = new float4(0f, 0f, 0f, 0f);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
            this.w = 0f;
        }

        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0f;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float2 v, float z, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0f;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float3 v, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a double4.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(float4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);

        #endregion


        #region Indexer

        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
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

        #endregion


        #region Properties

        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count
        {
            get => 4;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(float4 lhs, float4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(float4 lhs, float4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

        #endregion


        #region Functions

        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(float4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(float4 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is float4 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Length(float4 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w);

        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float4 lhs, float4 rhs) => float4.Length(lhs - rhs);

        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float4 lhs, float4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;

        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Normalize(float4 v) => v / float4.Length(v);

        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 FaceForward(float4 N, float4 I, float4 Nref) => float4.Dot(Nref, I) < 0 ? N : -N;

        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Reflect(float4 I, float4 N) => I - 2 * float4.Dot(N, I) * N;

        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Refract(float4 I, float4 N, float eta)
        {
            var dNI = float4.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float4((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Clamp(float4 v, float min, float max) => new float4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Parse(string value)
        {
            var values = value.Split(", ");
            return new float4(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]), float.Parse(values[3]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new float4(float.Parse(values[0], format), float.Parse(values[1], format), float.Parse(values[2], format), float.Parse(values[3], format));
        }

        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrLength(float4 v) => v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w;

        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(float4 lhs, float4 rhs) => float4.SqrLength(lhs - rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 SmoothDamp(float4 source, float4 target, ref float4 velocity, float smoothTime, float deltaTime) => new float4(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime), Maths.SmoothDamp(source.w, target.w, ref velocity.w, smoothTime, deltaTime));

        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 ClampLength(float4 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                float ratio = maxLength / Maths.Sqrt(sqrLength);
                return new float4(value.x * ratio, value.y * ratio, value.z * ratio, value.w * ratio);
            }
            return value;
        }

        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 MoveTowards(float4 current, float4 target, float maxDelta)
        {
            var delta = target - current;
            var sqrDist = SqrLength(delta);
            return sqrDist <= maxDelta * maxDelta ? target :
            current + delta * maxDelta * Maths.InverseSqrt(sqrDist);
        }

        #endregion


        #region Component-Wise Static Functions

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Pow(float4 lhs, float4 rhs) => new float4(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y), Maths.Pow(lhs.z, rhs.z), Maths.Pow(lhs.w, rhs.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Exp(float4 v) => new float4(Maths.Exp(v.x), Maths.Exp(v.y), Maths.Exp(v.z), Maths.Exp(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Log(float4 v) => new float4(Maths.Log(v.x), Maths.Log(v.y), Maths.Log(v.z), Maths.Log(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Exp2(float4 v) => new float4(Maths.Exp2(v.x), Maths.Exp2(v.y), Maths.Exp2(v.z), Maths.Exp2(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Log2(float4 v) => new float4(Maths.Log2(v.x), Maths.Log2(v.y), Maths.Log2(v.z), Maths.Log2(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Sqrt(float4 v) => new float4(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z), Maths.Sqrt(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InverseSqrt(float4 v) => new float4(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z), Maths.InverseSqrt(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Abs(float4 v) => new float4(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z), Maths.Abs(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Sign(float4 v) => new float4(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z), Maths.Sign(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Lerp(float4 edge0, float4 edge1, float4 v) => new float4(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z), Maths.Lerp(edge0.w, edge1.w, v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Lerp(float4 edge0, float4 edge1, float v) => new float4(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v), Maths.Lerp(edge0.w, edge1.w, v));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Min(float4 lhs, float4 rhs) => new float4(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z), Maths.Min(lhs.w, rhs.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Min(float4 lhs, float rhs) => new float4(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs), Maths.Min(lhs.w, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Max(float4 lhs, float4 rhs) => new float4(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z), Maths.Max(lhs.w, rhs.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Max(float4 lhs, float rhs) => new float4(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs), Maths.Max(lhs.w, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InvLerp(float4 edge0, float4 edge1, float4 v) => new float4(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y), Maths.InvLerp(edge0.z, edge1.z, v.z), Maths.InvLerp(edge0.w, edge1.w, v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InvLerp(float4 edge0, float4 edge1, float v) => new float4(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v), Maths.InvLerp(edge0.z, edge1.z, v), Maths.InvLerp(edge0.w, edge1.w, v));

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a float4 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator -(float4 v) => new float4(-v.x, -v.y, -v.z, -v.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator +(float4 lhs, float4 rhs) => new float4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator +(float4 lhs, float rhs) => new float4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);

        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator +(float lhs, float4 rhs) => new float4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator -(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator -(float4 lhs, float rhs) => new float4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);

        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator -(float lhs, float4 rhs) => new float4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator *(float4 lhs, float4 rhs) => new float4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator *(float4 lhs, float rhs) => new float4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);

        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator *(float lhs, float4 rhs) => new float4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator /(float4 lhs, float4 rhs) => new float4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);

        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator /(float4 lhs, float rhs) => new float4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 operator /(float lhs, float4 rhs) => new float4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        #endregion

    }
}
