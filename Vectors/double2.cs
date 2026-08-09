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
    /// A vector of type double with 2 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    [DataContract]
    public partial struct double2 : IEquatable<double2>, IComparable<double2>
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
        /// Returns new vector with every component set to default.
        /// </summary>
        public static readonly double2 zero = new double2(0.0, 0.0);

        #endregion


        #region Constructors

        /// <summary>
        /// Component-wise constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// all-same-value constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>
        /// from-vector constructor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double4 v)
        {
            this.x = v.x;
            this.y = v.y;
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
        /// Returns the number of components (2).
        /// </summary>
        public int Count
        {
            get => 2;
        }

        #endregion


        #region Operators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(double2 lhs, double2 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(double2 lhs, double2 rhs) => lhs.x != rhs.x||lhs.y != rhs.y;

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
        public readonly int CompareTo(double2 other) => Comparison.Combine(x, y, other.x, other.y);

        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{x}, {y}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(double2 other) => other == this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => obj is double2 other && Equals(other);

        #endregion


        #region Static Functions

        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Length(double2 v) => Maths.Sqrt(v.x * v.x + v.y * v.y);

        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Distance(double2 lhs, double2 rhs) => double2.Length(lhs - rhs);

        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Dot(double2 lhs, double2 rhs) => lhs.x * rhs.x + lhs.y * rhs.y;

        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Normalize(double2 v) => v / double2.Length(v);

        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 FaceForward(double2 N, double2 I, double2 Nref) => double2.Dot(Nref, I) < 0 ? N : -N;

        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Reflect(double2 I, double2 N) => I - 2 * double2.Dot(N, I) * N;

        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Refract(double2 I, double2 N, double eta)
        {
            var dNI = double2.Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return new double2((double)0);
            return eta * I - (eta * dNI + Maths.Sqrt(k)) * N;
        }

        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Clamp(double2 v, double min, double max) => new double2(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max));

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Parse(string value)
        {
            var values = value.Split(", ");
            return new double2(double.Parse(values[0]), double.Parse(values[1]));
        }

        /// <summary>
        /// Parses vector value from string representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Parse(string value, IFormatProvider format)
        {
            var values = value.Split(", ");
            return new double2(double.Parse(values[0], format), double.Parse(values[1], format));
        }

        /// <summary>
        /// Returns the square length of this vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SqrLength(double2 v) => v.x * v.x + v.y * v.y;

        /// <summary>
        /// Returns the square distance between the two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SqrDistance(double2 lhs, double2 rhs) => double2.SqrLength(lhs - rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 SmoothDamp(double2 source, double2 target, ref double2 velocity, double smoothTime, double deltaTime) => new double2(Maths.SmoothDamp(source.x, target.x, ref velocity.x, smoothTime, deltaTime), Maths.SmoothDamp(source.y, target.y, ref velocity.y, smoothTime, deltaTime));

        /// <summary>
        /// Returns this vector with length clamped to maxLength.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 ClampLength(double2 value, double maxLength)
        {
            var sqrLength = SqrLength(value);
            if (sqrLength > maxLength * maxLength)
            {
                double ratio = maxLength / Maths.Sqrt(sqrLength);
                return new double2(value.x * ratio, value.y * ratio);
            }
            return value;
        }

        /// <summary>
        /// Moves vector towards target.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 MoveTowards(double2 current, double2 target, double maxDelta)
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
        public static double2 Sqrt(double2 v) => new double2(Maths.Sqrt(v.x), Maths.Sqrt(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 InverseSqrt(double2 v) => new double2(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Abs(double2 v) => new double2(Maths.Abs(v.x), Maths.Abs(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Sign(double2 v) => new double2(Maths.Sign(v.x), Maths.Sign(v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Lerp(double2 edge0, double2 edge1, double2 v) => new double2(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Lerp(double2 edge0, double2 edge1, double v) => new double2(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Min(double2 lhs, double2 rhs) => new double2(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Min(double2 lhs, double rhs) => new double2(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Max(double2 lhs, double2 rhs) => new double2(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Max(double2 lhs, double rhs) => new double2(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 InvLerp(double2 edge0, double2 edge1, double2 v) => new double2(Maths.InvLerp(edge0.x, edge1.x, v.x), Maths.InvLerp(edge0.y, edge1.y, v.y));

        /// <summary>
        /// DUMMY
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 InvLerp(double2 edge0, double2 edge1, double v) => new double2(Maths.InvLerp(edge0.x, edge1.x, v), Maths.InvLerp(edge0.y, edge1.y, v));

        #endregion


        #region Component-Wise Operator Overloads

        /// <summary>
        /// Returns a double2 from component-wise application of operator- (-v).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator -(double2 v) => new double2(-v.x, -v.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator +(double2 lhs, double2 rhs) => new double2(lhs.x + rhs.x, lhs.y + rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator +(double2 lhs, double rhs) => new double2(lhs.x + rhs, lhs.y + rhs);

        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator +(double lhs, double2 rhs) => new double2(lhs + rhs.x, lhs + rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator -(double2 lhs, double2 rhs) => new double2(lhs.x - rhs.x, lhs.y - rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator -(double2 lhs, double rhs) => new double2(lhs.x - rhs, lhs.y - rhs);

        /// <summary>
        /// Returns a double2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator -(double lhs, double2 rhs) => new double2(lhs - rhs.x, lhs - rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator *(double2 lhs, double2 rhs) => new double2(lhs.x * rhs.x, lhs.y * rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator *(double2 lhs, double rhs) => new double2(lhs.x * rhs, lhs.y * rhs);

        /// <summary>
        /// Returns a double2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator *(double lhs, double2 rhs) => new double2(lhs * rhs.x, lhs * rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator /(double2 lhs, double2 rhs) => new double2(lhs.x / rhs.x, lhs.y / rhs.y);

        /// <summary>
        /// Returns a double2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator /(double2 lhs, double rhs) => new double2(lhs.x / rhs, lhs.y / rhs);

        /// <summary>
        /// Returns a double2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator /(double lhs, double2 rhs) => new double2(lhs / rhs.x, lhs / rhs.y);

        #endregion

    }
}
