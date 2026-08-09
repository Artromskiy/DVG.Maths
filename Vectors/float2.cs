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
    /// A vector of type float with 2 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct float2 : IEquatable<float2>, IComparable<float2>
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
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly float2 zero = new float2(0f, 0f);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        #endregion


        #region Implicit Operators

        /// <summary>
        /// Implicitly converts this to a double2.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float2 v) => new double2((double)v.x, (double)v.y);

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
        /// Returns the number of components (2).
        /// </summary>
        public int Count
        {
            get => 2;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(float2 lhs, float2 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(float2 lhs, float2 rhs) => lhs.x != rhs.x||lhs.y != rhs.y;

        #endregion


        #region Functions

        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(float2 other) => Comparison.Combine(x, y, other.x, other.y);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(float2 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is float2 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Length(float2 v) => Maths.Sqrt(v.x * v.x + v.y * v.y);

        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float2 lhs, float2 rhs) => float2.Length(lhs - rhs);

        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(float2 lhs, float2 rhs) => lhs.x * rhs.x + lhs.y * rhs.y;

        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Normalize(float2 v) => v / float2.Length(v);

        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 FaceForward(float2 N, float2 I, float2 Nref) => float2.Dot(Nref, I) < 0 ? N : -N;

        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Reflect(float2 I, float2 N) => I - 2 * float2.Dot(N, I) * N;

        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Refract(float2 I, float2 N, float eta)
        {
            var dNI = float2.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new float2((float)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Clamp(float2 v, float min, float max) => new float2(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Parse(string value)
        {
            var values = value.Split(", ");
            return new float2(float.Parse(values[0]), float.Parse(values[1]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new float2(float.Parse(values[0], format), float.Parse(values[1], format));
        }

        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrLength(float2 v) => v.x * v.x + v.y * v.y;

        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(float2 lhs, float2 rhs) => float2.SqrLength(lhs - rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SmoothDamp(float2 source, float2 target, ref float2 velocity, float smoothTime, float deltaTime) => new float2(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime));

        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ClampLength(float2 value, float maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                float ratio = maxLength / Maths.Sqrt(sqrLength);
                return new float2(value.x * ratio, value.y * ratio);
            }
            return value;
        }

        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 MoveTowards(float2 current, float2 target, float maxDelta)
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
        public static float2 Pow(float2 lhs, float2 rhs) => new float2(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Exp(float2 v) => new float2(Maths.Exp(v.x), Maths.Exp(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Log(float2 v) => new float2(Maths.Log(v.x), Maths.Log(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Exp2(float2 v) => new float2(Maths.Exp2(v.x), Maths.Exp2(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Log2(float2 v) => new float2(Maths.Log2(v.x), Maths.Log2(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sqrt(float2 v) => new float2(Maths.Sqrt(v.x), Maths.Sqrt(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InverseSqrt(float2 v) => new float2(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Abs(float2 v) => new float2(Maths.Abs(v.x), Maths.Abs(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Sign(float2 v) => new float2(Maths.Sign(v.x), Maths.Sign(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Lerp(float2 edge0, float2 edge1, float2 v) => new float2(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Lerp(float2 edge0, float2 edge1, float v) => new float2(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Min(float2 lhs, float2 rhs) => new float2(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Min(float2 lhs, float rhs) => new float2(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Max(float2 lhs, float2 rhs) => new float2(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Max(float2 lhs, float rhs) => new float2(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InvLerp(float2 edge0, float2 edge1, float2 v) => new float2(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InvLerp(float2 edge0, float2 edge1, float v) => new float2(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v));

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a float2 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator -(float2 v) => new float2(-v.x, -v.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator +(float2 lhs, float2 rhs) => new float2(lhs.x + rhs.x, lhs.y + rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator +(float2 lhs, float rhs) => new float2(lhs.x + rhs, lhs.y + rhs);

        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator +(float lhs, float2 rhs) => new float2(lhs + rhs.x, lhs + rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator -(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x, lhs.y - rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator -(float2 lhs, float rhs) => new float2(lhs.x - rhs, lhs.y - rhs);

        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator -(float lhs, float2 rhs) => new float2(lhs - rhs.x, lhs - rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator *(float2 lhs, float2 rhs) => new float2(lhs.x * rhs.x, lhs.y * rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator *(float2 lhs, float rhs) => new float2(lhs.x * rhs, lhs.y * rhs);

        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator *(float lhs, float2 rhs) => new float2(lhs * rhs.x, lhs * rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator /(float2 lhs, float2 rhs) => new float2(lhs.x / rhs.x, lhs.y / rhs.y);

        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator /(float2 lhs, float rhs) => new float2(lhs.x / rhs, lhs.y / rhs);

        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator /(float lhs, float2 rhs) => new float2(lhs / rhs.x, lhs / rhs.y);

        #endregion

    }
}
