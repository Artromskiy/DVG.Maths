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
    /// A vector of type fix with 3 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct fix3 : IEquatable<fix3>, IComparable<fix3>
    {

        #region Fields

        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public fix x;

        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public fix y;

        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public fix z;

        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly fix3 zero = new fix3(fix.Zero, fix.Zero, fix.Zero);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix3(fix x, fix y, fix z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix3(fix v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix3(fix2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = fix.Zero;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix3(fix2 v, fix z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix3(fix3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fix3(fix4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Indexer

        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
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

        #endregion


        #region Properties

        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count
        {
            get => 3;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(fix3 lhs, fix3 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(fix3 lhs, fix3 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z;

        #endregion


        #region Functions

        /// <summary>
        /// Returns HashCode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        /// <summary>
        /// Compares two values
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(fix3 other) => Comparison.Combine(x, y, z, other.x, other.y, other.z);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(fix3 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is fix3 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix Length(fix3 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);

        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix Distance(fix3 lhs, fix3 rhs) => fix3.Length(lhs - rhs);

        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix Dot(fix3 lhs, fix3 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;

        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Cross(fix3 lhs, fix3 rhs) => new fix3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);

        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Normalize(fix3 v) => v / fix3.Length(v);

        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 FaceForward(fix3 N, fix3 I, fix3 Nref) => fix3.Dot(Nref, I) < 0 ? N : -N;

        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Reflect(fix3 I, fix3 N) => I - 2 * fix3.Dot(N, I) * N;

        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Refract(fix3 I, fix3 N, fix eta)
        {
            var dNI = fix3.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new fix3((fix)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        /// <summary>
        /// Returns a fix3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Clamp(fix3 v, fix min, fix max) => new fix3(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Parse(string value)
        {
            var values = value.Split(", ");
            return new fix3(fix.Parse(values[0]), fix.Parse(values[1]), fix.Parse(values[2]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new fix3(fix.Parse(values[0], format), fix.Parse(values[1], format), fix.Parse(values[2], format));
        }

        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix SqrLength(fix3 v) => v.x * v.x + v.y * v.y + v.z * v.z;

        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix SqrDistance(fix3 lhs, fix3 rhs) => fix3.SqrLength(lhs - rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 SmoothDamp(fix3 source, fix3 target, ref fix3 velocity, fix smoothTime, fix deltaTime) => new fix3(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime));

        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 ClampLength(fix3 value, fix maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                fix ratio = maxLength / Maths.Sqrt(sqrLength);
                return new fix3(value.x * ratio, value.y * ratio, value.z * ratio);
            }
            return value;
        }

        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 MoveTowards(fix3 current, fix3 target, fix maxDelta)
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
        public static fix3 Abs(fix3 v) => new fix3(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Sign(fix3 v) => new fix3(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Lerp(fix3 edge0, fix3 edge1, fix3 v) => new fix3(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Lerp(fix3 edge0, fix3 edge1, fix v) => new fix3(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Min(fix3 lhs, fix3 rhs) => new fix3(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Min(fix3 lhs, fix rhs) => new fix3(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Max(fix3 lhs, fix3 rhs) => new fix3(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 Max(fix3 lhs, fix rhs) => new fix3(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 InvLerp(fix3 edge0, fix3 edge1, fix3 v) => new fix3(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y), Maths.InvLerp(edge0.z, edge1.z, v.z));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 InvLerp(fix3 edge0, fix3 edge1, fix v) => new fix3(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v), Maths.InvLerp(edge0.z, edge1.z, v));

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a fix3 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator -(fix3 v) => new fix3(-v.x, -v.y, -v.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator +(fix3 lhs, fix3 rhs) => new fix3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator +(fix3 lhs, fix rhs) => new fix3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator +(fix lhs, fix3 rhs) => new fix3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator -(fix3 lhs, fix3 rhs) => new fix3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator -(fix3 lhs, fix rhs) => new fix3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator -(fix lhs, fix3 rhs) => new fix3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator *(fix3 lhs, fix3 rhs) => new fix3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator *(fix3 lhs, fix rhs) => new fix3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator *(fix lhs, fix3 rhs) => new fix3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator /(fix3 lhs, fix3 rhs) => new fix3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator /(fix3 lhs, fix rhs) => new fix3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);

        /// <summary>
        /// Returns a fix3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 operator /(fix lhs, fix3 rhs) => new fix3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);

        #endregion

    }
}
