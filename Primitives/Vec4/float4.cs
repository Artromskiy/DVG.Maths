#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace DVG
{
    
    /// <summary>
    /// A vector of type float with 4 components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct float4 : IEquatable<float4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public float z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public float w;
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public const int Count = 4;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
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
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 xy
        {
            get
            {
                return new float2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 xz
        {
            get
            {
                return new float2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 yz
        {
            get
            {
                return new float2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 xyz
        {
            get
            {
                return new float3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 xw
        {
            get
            {
                return new float2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 yw
        {
            get
            {
                return new float2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 xyw
        {
            get
            {
                return new float3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 zw
        {
            get
            {
                return new float2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 xzw
        {
            get
            {
                return new float3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 yzw
        {
            get
            {
                return new float3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float4 xyzw
        {
            get
            {
                return new float4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 rg
        {
            get
            {
                return new float2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 rb
        {
            get
            {
                return new float2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 gb
        {
            get
            {
                return new float2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 rgb
        {
            get
            {
                return new float3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 ra
        {
            get
            {
                return new float2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 ga
        {
            get
            {
                return new float2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 rga
        {
            get
            {
                return new float3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float2 ba
        {
            get
            {
                return new float2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 rba
        {
            get
            {
                return new float3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float3 gba
        {
            get
            {
                return new float3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components.
        /// </summary>
        public float4 rgba
        {
            get
            {
                return new float4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public float r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public float g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public float b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component.
        /// </summary>
        public float a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }

        #endregion


        #region Operators
        
        public static bool operator==(float4 lhs, float4 rhs) => lhs.x == rhs.x&&lhs.y == rhs.y&&lhs.z == rhs.z&&lhs.w == rhs.w;
        
        public static bool operator!=(float4 lhs, float4 rhs) => lhs.x != rhs.x||lhs.y != rhs.y||lhs.z != rhs.z||lhs.w != rhs.w;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public override readonly string ToString() => x + ", " + y + ", " + z + ", " + w;
        
        public readonly bool Equals(float4 other) => other == this;
        
        public override readonly bool Equals(object? obj) => obj is float4 other && Equals(other);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(float4 v) => Maths.Sqrt(((v.x*v.x + v.y*v.y) + (v.z*v.z + v.w*v.w)));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float4 lhs, float4 rhs) => float4.Length(lhs - rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float4 lhs, float4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static float4 Normalize(float4 v) => v / float4.Length(v);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float4 FaceForward(float4 N, float4 I, float4 Nref) => float4.Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float4 Reflect(float4 I, float4 N) => I - 2 * float4.Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
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
        public static float4 Clamp(float4 v, float min, float max) => new float4(Maths.Clamp(v.x, min, max), Maths.Clamp(v.y, min, max), Maths.Clamp(v.z, min, max), Maths.Clamp(v.w, min, max));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a float4 from component-wise application of Radians (Maths.Radians(v)).
        /// </summary>
        public static float4 Radians(float4 v) => new float4(Maths.Radians(v.x), Maths.Radians(v.y), Maths.Radians(v.z), Maths.Radians(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Degrees (Maths.Degrees(v)).
        /// </summary>
        public static float4 Degrees(float4 v) => new float4(Maths.Degrees(v.x), Maths.Degrees(v.y), Maths.Degrees(v.z), Maths.Degrees(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sin (Maths.Sin(v)).
        /// </summary>
        public static float4 Sin(float4 v) => new float4(Maths.Sin(v.x), Maths.Sin(v.y), Maths.Sin(v.z), Maths.Sin(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cos (Maths.Cos(v)).
        /// </summary>
        public static float4 Cos(float4 v) => new float4(Maths.Cos(v.x), Maths.Cos(v.y), Maths.Cos(v.z), Maths.Cos(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tan (Maths.Tan(v)).
        /// </summary>
        public static float4 Tan(float4 v) => new float4(Maths.Tan(v.x), Maths.Tan(v.y), Maths.Tan(v.z), Maths.Tan(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asin (Maths.Asin(v)).
        /// </summary>
        public static float4 Asin(float4 v) => new float4(Maths.Asin(v.x), Maths.Asin(v.y), Maths.Asin(v.z), Maths.Asin(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acos (Maths.Acos(v)).
        /// </summary>
        public static float4 Acos(float4 v) => new float4(Maths.Acos(v.x), Maths.Acos(v.y), Maths.Acos(v.z), Maths.Acos(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan (Maths.Atan(y / x)).
        /// </summary>
        public static float4 Atan(float4 y, float4 x) => new float4(Maths.Atan(y.x / x.x), Maths.Atan(y.y / x.y), Maths.Atan(y.z / x.z), Maths.Atan(y.w / x.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan (Maths.Atan(v)).
        /// </summary>
        public static float4 Atan(float4 v) => new float4(Maths.Atan(v.x), Maths.Atan(v.y), Maths.Atan(v.z), Maths.Atan(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sinh (Maths.Sinh(v)).
        /// </summary>
        public static float4 Sinh(float4 v) => new float4(Maths.Sinh(v.x), Maths.Sinh(v.y), Maths.Sinh(v.z), Maths.Sinh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cosh (Maths.Cosh(v)).
        /// </summary>
        public static float4 Cosh(float4 v) => new float4(Maths.Cosh(v.x), Maths.Cosh(v.y), Maths.Cosh(v.z), Maths.Cosh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tanh (Maths.Tanh(v)).
        /// </summary>
        public static float4 Tanh(float4 v) => new float4(Maths.Tanh(v.x), Maths.Tanh(v.y), Maths.Tanh(v.z), Maths.Tanh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asinh (Maths.Asinh(v)).
        /// </summary>
        public static float4 Asinh(float4 v) => new float4(Maths.Asinh(v.x), Maths.Asinh(v.y), Maths.Asinh(v.z), Maths.Asinh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acosh (Maths.Acosh(v)).
        /// </summary>
        public static float4 Acosh(float4 v) => new float4(Maths.Acosh(v.x), Maths.Acosh(v.y), Maths.Acosh(v.z), Maths.Acosh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atanh (Maths.Atanh(v)).
        /// </summary>
        public static float4 Atanh(float4 v) => new float4(Maths.Atanh(v.x), Maths.Atanh(v.y), Maths.Atanh(v.z), Maths.Atanh(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow (Maths.Pow(lhs, rhs)).
        /// </summary>
        public static float4 Pow(float4 lhs, float4 rhs) => new float4(Maths.Pow(lhs.x, rhs.x), Maths.Pow(lhs.y, rhs.y), Maths.Pow(lhs.z, rhs.z), Maths.Pow(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp (Maths.Exp(v)).
        /// </summary>
        public static float4 Exp(float4 v) => new float4(Maths.Exp(v.x), Maths.Exp(v.y), Maths.Exp(v.z), Maths.Exp(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log (Maths.Log(v)).
        /// </summary>
        public static float4 Log(float4 v) => new float4(Maths.Log(v.x), Maths.Log(v.y), Maths.Log(v.z), Maths.Log(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp2 (Maths.Exp2(v)).
        /// </summary>
        public static float4 Exp2(float4 v) => new float4(Maths.Exp2(v.x), Maths.Exp2(v.y), Maths.Exp2(v.z), Maths.Exp2(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log2 (Maths.Log2(v)).
        /// </summary>
        public static float4 Log2(float4 v) => new float4(Maths.Log2(v.x), Maths.Log2(v.y), Maths.Log2(v.z), Maths.Log2(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sqrt (Maths.Sqrt(v)).
        /// </summary>
        public static float4 Sqrt(float4 v) => new float4(Maths.Sqrt(v.x), Maths.Sqrt(v.y), Maths.Sqrt(v.z), Maths.Sqrt(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of InverseSqrt (Maths.InverseSqrt(v)).
        /// </summary>
        public static float4 InverseSqrt(float4 v) => new float4(Maths.InverseSqrt(v.x), Maths.InverseSqrt(v.y), Maths.InverseSqrt(v.z), Maths.InverseSqrt(v.w));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float4 lhs, float4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float4 lhs, float4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float4 lhs, float4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float4 lhs, float4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float4 lhs, float4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float4 lhs, float4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static float4 Abs(float4 v) => new float4(Maths.Abs(v.x), Maths.Abs(v.y), Maths.Abs(v.z), Maths.Abs(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static float4 Sign(float4 v) => new float4(Maths.Sign(v.x), Maths.Sign(v.y), Maths.Sign(v.z), Maths.Sign(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Floor (Maths.Floor(v)).
        /// </summary>
        public static float4 Floor(float4 v) => new float4(Maths.Floor(v.x), Maths.Floor(v.y), Maths.Floor(v.z), Maths.Floor(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Truncate (Maths.Truncate(v)).
        /// </summary>
        public static float4 Truncate(float4 v) => new float4(Maths.Truncate(v.x), Maths.Truncate(v.y), Maths.Truncate(v.z), Maths.Truncate(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Round (Maths.Round(v)).
        /// </summary>
        public static float4 Round(float4 v) => new float4(Maths.Round(v.x), Maths.Round(v.y), Maths.Round(v.z), Maths.Round(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of RoundEven (Maths.RoundEven(v)).
        /// </summary>
        public static float4 RoundEven(float4 v) => new float4(Maths.RoundEven(v.x), Maths.RoundEven(v.y), Maths.RoundEven(v.z), Maths.RoundEven(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Ceiling (Maths.Ceiling(v)).
        /// </summary>
        public static float4 Ceiling(float4 v) => new float4(Maths.Ceiling(v.x), Maths.Ceiling(v.y), Maths.Ceiling(v.z), Maths.Ceiling(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fract (v - Maths.Floor(v)).
        /// </summary>
        public static float4 Fract(float4 v) => new float4(v.x - Maths.Floor(v.x), v.y - Maths.Floor(v.y), v.z - Maths.Floor(v.z), v.w - Maths.Floor(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static float4 Mod(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x * Maths.Floor(lhs.x / rhs.x), lhs.y - rhs.y * Maths.Floor(lhs.y / rhs.y), lhs.z - rhs.z * Maths.Floor(lhs.z / rhs.z), lhs.w - rhs.w * Maths.Floor(lhs.w / rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mod (lhs - rhs * Maths.Floor(lhs / rhs)).
        /// </summary>
        public static float4 Mod(float4 lhs, float rhs) => new float4(lhs.x - rhs * Maths.Floor(lhs.x / rhs), lhs.y - rhs * Maths.Floor(lhs.y / rhs), lhs.z - rhs * Maths.Floor(lhs.z / rhs), lhs.w - rhs * Maths.Floor(lhs.w / rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static float4 Lerp(float4 edge0, float4 edge1, float4 v) => new float4(Maths.Lerp(edge0.x, edge1.x, v.x), Maths.Lerp(edge0.y, edge1.y, v.y), Maths.Lerp(edge0.z, edge1.z, v.z), Maths.Lerp(edge0.w, edge1.w, v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (Maths.Lerp(edge0, edge1, v)).
        /// </summary>
        public static float4 Lerp(float4 edge0, float4 edge1, float v) => new float4(Maths.Lerp(edge0.x, edge1.x, v), Maths.Lerp(edge0.y, edge1.y, v), Maths.Lerp(edge0.z, edge1.z, v), Maths.Lerp(edge0.w, edge1.w, v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static float4 Step(float4 edge, float4 x) => new float4(x.x < edge.x ? 0 : 1, x.y < edge.y ? 0 : 1, x.z < edge.z ? 0 : 1, x.w < edge.w ? 0 : 1);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Step (x &lt; edge ? 0 : 1).
        /// </summary>
        public static float4 Step(float edge, float4 x) => new float4(x.x < edge ? 0 : 1, x.y < edge ? 0 : 1, x.z < edge ? 0 : 1, x.w < edge ? 0 : 1);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float4 edge1, float4 v) => new float4(Maths.SmoothStep(Maths.Clamp((v.x - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.y - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.z - edge0.z) / (edge1.z - edge0.z), 0, 1)), Maths.SmoothStep(Maths.Clamp((v.w - edge0.w) / (edge1.w - edge0.w), 0, 1)));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (Maths.SmoothStep(Maths.Clamp((v - edge0) / (edge1 - edge0), 0, 1))).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float4 edge1, float v) => new float4(Maths.SmoothStep(Maths.Clamp((v - edge0.x) / (edge1.x - edge0.x), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.y) / (edge1.y - edge0.y), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.z) / (edge1.z - edge0.z), 0, 1)), Maths.SmoothStep(Maths.Clamp((v - edge0.w) / (edge1.w - edge0.w), 0, 1)));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(float4 v) => new bool4(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z), float.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(float4 v) => new bool4(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z), float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (Maths.Fma(a, b, c)).
        /// </summary>
        public static float4 Fma(float4 a, float4 b, float4 c) => new float4(Maths.Fma(a.x, b.x, c.x), Maths.Fma(a.y, b.y, c.y), Maths.Fma(a.z, b.z, c.z), Maths.Fma(a.w, b.w, c.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float4 lhs, float4 rhs) => new float4(Maths.Min(lhs.x, rhs.x), Maths.Min(lhs.y, rhs.y), Maths.Min(lhs.z, rhs.z), Maths.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float4 lhs, float rhs) => new float4(Maths.Min(lhs.x, rhs), Maths.Min(lhs.y, rhs), Maths.Min(lhs.z, rhs), Maths.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float4 lhs, float4 rhs) => new float4(Maths.Max(lhs.x, rhs.x), Maths.Max(lhs.y, rhs.y), Maths.Max(lhs.z, rhs.z), Maths.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float4 lhs, float rhs) => new float4(Maths.Max(lhs.x, rhs), Maths.Max(lhs.y, rhs), Maths.Max(lhs.z, rhs), Maths.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static float4 Clamp(float4 v, float4 min, float4 max) => new float4(Maths.Clamp(v.x, min.x, max.x), Maths.Clamp(v.y, min.y, max.y), Maths.Clamp(v.z, min.z, max.z), Maths.Clamp(v.w, min.w, max.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static float4 Mix(float4 x, float4 y, bool4 a) => new float4(a.x ? y.x : x.x, a.y ? y.y : x.y, a.z ? y.z : x.z, a.w ? y.w : x.w);
        
        /// <summary>
        /// Returns a int4 from component-wise application of FloatBitsToInt (Unsafe.As&lt;float, int&gt;(ref v)).
        /// </summary>
        public static int4 FloatBitsToInt(float4 v) => new int4(Unsafe.As<float, int>(ref v.x), Unsafe.As<float, int>(ref v.y), Unsafe.As<float, int>(ref v.z), Unsafe.As<float, int>(ref v.w));
        
        /// <summary>
        /// Returns a uint4 from component-wise application of FloatBitsToUInt (Unsafe.As&lt;float, uint&gt;(ref v)).
        /// </summary>
        public static uint4 FloatBitsToUInt(float4 v) => new uint4(Unsafe.As<float, uint>(ref v.x), Unsafe.As<float, uint>(ref v.y), Unsafe.As<float, uint>(ref v.z), Unsafe.As<float, uint>(ref v.w));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (-v).
        /// </summary>
        public static float4 operator-(float4 v) => new float4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float4 operator+(float4 lhs, float4 rhs) => new float4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float4 operator+(float4 lhs, float rhs) => new float4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float4 operator+(float lhs, float4 rhs) => new float4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float4 operator-(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float4 operator-(float4 lhs, float rhs) => new float4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float4 operator-(float lhs, float4 rhs) => new float4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float4 operator*(float4 lhs, float4 rhs) => new float4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float4 operator*(float4 lhs, float rhs) => new float4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float4 operator*(float lhs, float4 rhs) => new float4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float4 operator/(float4 lhs, float4 rhs) => new float4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float4 operator/(float4 lhs, float rhs) => new float4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float4 operator/(float lhs, float4 rhs) => new float4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);

        #endregion

    }
}
