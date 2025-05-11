using System;
using System.Runtime.CompilerServices;

namespace DVG
{
    public static partial class Maths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Lerp(float edge0, float edge1, float value) => edge0 + ((edge1 - edge0) * value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmoothStep(float edge0, float edge1, float v)
        {
            float x = Clamp((v - edge0) / (edge1 - edge0), 0, 1);
            return x * x * (3.0f - 2.0f * x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Radians(float degrees) => degrees / 180 / MathF.PI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Degrees(float radians) => radians * 180 * MathF.PI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Fma(float a, float b, float c) => a * b + c;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RoundEven(float value) => MathF.Round(value, MidpointRounding.ToEven);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InverseSqrt(float value) => 1f / (MathF.Sqrt(value));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log2(float value) => MathF.Log(value, 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Exp2(float value) => MathF.Pow(2, value);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Lerp(double edge0, double edge1, double value) => edge0 + ((edge1 - edge0) * value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SmoothStep(double edge0, double edge1, double v)
        {
            double x = Clamp((v - edge0) / (edge1 - edge0), 0, 1);
            return x * x * (3.0f - 2.0f * x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Degrees(double radians) => radians * 180 * Math.PI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Radians(double degrees) => degrees / 180 / Math.PI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Fma(double a, double b, double c) => a * b + c;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double RoundEven(double value) => Math.Round(value, MidpointRounding.ToEven);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double InverseSqrt(double value) => 1.0 / (Math.Sqrt(value));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log2(double value) => Math.Log(value, 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Exp2(double value) => Math.Pow(2, value);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(float x) => MathF.Abs(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Acos(float x) => MathF.Acos(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Acosh(float x) => MathF.Acosh(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Asin(float x) => MathF.Asin(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Asinh(float x) => MathF.Asinh(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atan(float x) => MathF.Atan(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atan2(float y, float x) => MathF.Atan2(y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atanh(float x) => MathF.Atanh(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cbrt(float x) => MathF.Cbrt(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(float x) => MathF.Ceiling(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max) => Math.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cos(float x) => MathF.Cos(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cosh(float x) => MathF.Cosh(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Exp(float x) => MathF.Exp(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(float x) => MathF.Floor(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log(float x) => MathF.Log(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log(float x, float y) => MathF.Log(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log10(float x) => MathF.Log(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(float x, float y) => MathF.Max(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(float x, float y) => MathF.Min(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Pow(float x, float y) => MathF.Pow(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(float a) => MathF.Round(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sin(float x) => MathF.Sin(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sinh(float x) => MathF.Sinh(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(float x) => MathF.Sqrt(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Tan(float x) => MathF.Tan(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Tanh(float x) => MathF.Tanh(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(float x) => MathF.Truncate(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(float x) => MathF.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Abs(double value) => Math.Abs(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Acos(double d) => Math.Acos(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Acosh(double d) => Math.Acosh(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Asin(double d) => Math.Asin(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Asinh(double d) => Math.Asinh(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Atan(double d) => Math.Atan(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Atan2(double y, double x) => Math.Atan2(y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Atanh(double d) => Math.Atanh(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cbrt(double d) => Math.Cbrt(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Ceiling(double a) => Math.Ceiling(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double min, double max) => Math.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cos(double d) => Math.Cos(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cosh(double value) => Math.Cosh(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Exp(double d) => Math.Exp(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Floor(double d) => Math.Floor(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log(double d) => Math.Log(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log(double a, double newBase) => Math.Log(a, newBase);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log10(double d) => Math.Log10(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Max(double val1, double val2) => Math.Max(val1, val2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Min(double val1, double val2) => Math.Min(val1, val2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Pow(double x, double y) => Math.Pow(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(double a) => Math.Round(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sin(double a) => Math.Sin(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sinh(double value) => Math.Sinh(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sqrt(double d) => Math.Sqrt(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tan(double a) => Math.Tan(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tanh(double value) => Math.Tanh(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Truncate(double d) => Math.Truncate(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(double value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value) => Math.Abs(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(int value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int val1, int val2) => Math.Min(val1, val2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int val1, int val2) => Math.Max(val1, val2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int min, int max) => Math.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint value, uint min, uint max) => Math.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint val1, uint val2) => Math.Min(val1, val2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Max(uint val1, uint val2) => Math.Max(val1, val2);

    }
}