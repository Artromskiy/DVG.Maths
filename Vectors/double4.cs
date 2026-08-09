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
    /// A vector of type double with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct double4 : IEquatable<double4>, IComparable<double4>
    {

        #region Fields

        /// <summary>
        /// x-component
        /// </summary>
        [DataMember(Order = 0)]
        public double x;

        /// <summary>
        /// y-component
        /// </summary>
        [DataMember(Order = 1)]
        public double y;

        /// <summary>
        /// z-component
        /// </summary>
        [DataMember(Order = 2)]
        public double z;

        /// <summary>
        /// w-component
        /// </summary>
        [DataMember(Order = 3)]
        public double w;

        /// <summary>
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly double4 zero = new double4(0.0, 0.0, 0.0, 0.0);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double x, double y, double z, double w)
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
        public double4(double v)
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
        public double4(double2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
            this.w = 0.0;
        }

        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0.0;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double2 v, double z, double w)
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
        public double4(double3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0.0;
        }

        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4(double3 v, double w)
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
        public double4(double4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Indexer

        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
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
        public static bool operator==(double4 lhs, double4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(double4 lhs, double4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

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
        public readonly int CompareTo(double4 other) => Comparison.Combine(x, y, z, w, other.x, other.y, other.z, other.w);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}, {z}, {w}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(double4 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is double4 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Length(double4 v) => Maths.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w);

        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Distance(double4 lhs, double4 rhs) => double4.Length(lhs - rhs);

        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Dot(double4 lhs, double4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;

        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Normalize(double4 v) => v / double4.Length(v);

        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 FaceForward(double4 N, double4 I, double4 Nref) => double4.Dot(Nref, I) < 0 ? N : -N;

        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Reflect(double4 I, double4 N) => I - 2 * double4.Dot(N, I) * N;

        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Refract(double4 I, double4 N, double eta)
        {
            var dNI = double4.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new double4((double)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Clamp(double4 v, double min, double max) => new double4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Parse(string value)
        {
            var values = value.Split(", ");
            return new double4(double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2]), double.Parse(values[3]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new double4(double.Parse(values[0], format), double.Parse(values[1], format), double.Parse(values[2], format), double.Parse(values[3], format));
        }

        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SqrLength(double4 v) => v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w;

        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SqrDistance(double4 lhs, double4 rhs) => double4.SqrLength(lhs - rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 SmoothDamp(double4 source, double4 target, ref double4 velocity, double smoothTime, double deltaTime) => new double4(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime), Maths.SmoothDamp(source.z, target.z, ref velocity.z, smoothTime, deltaTime), Maths.SmoothDamp(source.w, target.w, ref velocity.w, smoothTime, deltaTime));

        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 ClampLength(double4 value, double maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                double ratio = maxLength / Maths.Sqrt(sqrLength);
                return new double4(value.x * ratio, value.y * ratio, value.z * ratio, value.w * ratio);
            }
            return value;
        }

        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 MoveTowards(double4 current, double4 target, double maxDelta)
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
        public static double4 Sqrt(double4 v) => new double4(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z), Maths.Sqrt(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 InverseSqrt(double4 v) => new double4(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z), Maths.InverseSqrt(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Abs(double4 v) => new double4(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z), Maths.Abs(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Sign(double4 v) => new double4(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z), Maths.Sign(v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Lerp(double4 edge0, double4 edge1, double4 v) => new double4(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z), Maths.Lerp(edge0.w, edge1.w, v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Lerp(double4 edge0, double4 edge1, double v) => new double4(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v), Maths.Lerp(edge0.w, edge1.w, v));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Min(double4 lhs, double4 rhs) => new double4(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z), Maths.Min(lhs.w, rhs.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Min(double4 lhs, double rhs) => new double4(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs), Maths.Min(lhs.w, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Max(double4 lhs, double4 rhs) => new double4(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z), Maths.Max(lhs.w, rhs.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Max(double4 lhs, double rhs) => new double4(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs), Maths.Max(lhs.w, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 InvLerp(double4 edge0, double4 edge1, double4 v) => new double4(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y), Maths.InvLerp(edge0.z, edge1.z, v.z), Maths.InvLerp(edge0.w, edge1.w, v.w));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 InvLerp(double4 edge0, double4 edge1, double v) => new double4(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v), Maths.InvLerp(edge0.z, edge1.z, v), Maths.InvLerp(edge0.w, edge1.w, v));

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a double4 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator -(double4 v) => new double4(-v.x, -v.y, -v.z, -v.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator +(double4 lhs, double4 rhs) => new double4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator +(double4 lhs, double rhs) => new double4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);

        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator +(double lhs, double4 rhs) => new double4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator -(double4 lhs, double4 rhs) => new double4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator -(double4 lhs, double rhs) => new double4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);

        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator -(double lhs, double4 rhs) => new double4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator *(double4 lhs, double4 rhs) => new double4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator *(double4 lhs, double rhs) => new double4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);

        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator *(double lhs, double4 rhs) => new double4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator /(double4 lhs, double4 rhs) => new double4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);

        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator /(double4 lhs, double rhs) => new double4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 operator /(double lhs, double4 rhs) => new double4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        #endregion

    }
}
