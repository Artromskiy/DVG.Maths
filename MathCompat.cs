using System;

namespace Delta.Maths
{
    // Keeps the public Maths facade available on netstandard2.0, where MathF
    // and several newer System.Math members are not part of the contract.
    internal static class MathF
    {
        public const float PI = (float)System.Math.PI;
        public static float Abs(float value) => (float)System.Math.Abs(value);
        public static float Acos(float value) => (float)System.Math.Acos(value);
        public static float Acosh(float value) => (float)System.Math.Log(value + System.Math.Sqrt(value * value - 1d));
        public static float Asin(float value) => (float)System.Math.Asin(value);
        public static float Asinh(float value) => (float)System.Math.Log(value + System.Math.Sqrt(value * value + 1d));
        public static float Atan(float value) => (float)System.Math.Atan(value);
        public static float Atan2(float y, float x) => (float)System.Math.Atan2(y, x);
        public static float Atanh(float value) => (float)(0.5d * System.Math.Log((1d + value) / (1d - value)));
        public static float Cbrt(float value) => value < 0f ? -(float)System.Math.Pow(-value, 1d / 3d) : (float)System.Math.Pow(value, 1d / 3d);
        public static float Ceiling(float value) => (float)System.Math.Ceiling(value);
        public static float Cos(float value) => (float)System.Math.Cos(value);
        public static float Cosh(float value) => (float)System.Math.Cosh(value);
        public static float Exp(float value) => (float)System.Math.Exp(value);
        public static float Floor(float value) => (float)System.Math.Floor(value);
        public static float Log(float value) => (float)System.Math.Log(value);
        public static float Log(float value, float numberBase) => (float)System.Math.Log(value, numberBase);
        public static float Log10(float value) => (float)System.Math.Log10(value);
        public static float Max(float left, float right) => System.Math.Max(left, right);
        public static float Min(float left, float right) => System.Math.Min(left, right);
        public static float Pow(float value, float power) => (float)System.Math.Pow(value, power);
        public static float Round(float value) => (float)System.Math.Round(value);
        public static float Round(float value, MidpointRounding mode) => (float)System.Math.Round(value, mode);
        public static float Sin(float value) => (float)System.Math.Sin(value);
        public static float Sinh(float value) => (float)System.Math.Sinh(value);
        public static float Sqrt(float value) => (float)System.Math.Sqrt(value);
        public static float Tan(float value) => (float)System.Math.Tan(value);
        public static float Tanh(float value) => (float)System.Math.Tanh(value);
        public static float Truncate(float value) => (float)System.Math.Truncate(value);
        public static int Sign(float value) => System.Math.Sign(value);
    }

    internal static class MathCompat
    {
        public static double Acosh(double value) => System.Math.Log(value + System.Math.Sqrt(value * value - 1d));
        public static double Asinh(double value) => System.Math.Log(value + System.Math.Sqrt(value * value + 1d));
        public static double Atanh(double value) => 0.5d * System.Math.Log((1d + value) / (1d - value));
        public static double Cbrt(double value) => value < 0d ? -System.Math.Pow(-value, 1d / 3d) : System.Math.Pow(value, 1d / 3d);
    }
}
