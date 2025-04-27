using System;

namespace DVG
{
    public static partial class Maths
    {
        public static float Lerp(float a, float b, float value) => a + ((b - a) * value);
        public static float Smoothstep(float edge0, float edge1, float v)
        {
            float x = Clamp((v - edge0) / (edge1 - edge0), 0, 1);
            return x * x * (3.0f - 2.0f * x);
        }
        public static float Radians(float degrees) => degrees / 180 / MathF.PI;
        public static float Degrees(float radians) => radians * 180 * MathF.PI;
        public static float Fma(float a, float b, float c) => a * b + c;
        public static float RoundEven(float value) => MathF.Round(value, MidpointRounding.ToEven);
        public static float InverseSqrt(float value) => 1f / (MathF.Sqrt(value));
        public static float Log2(float value) => MathF.Log(value, 2);
        public static float Exp2(float value) => MathF.Pow(2, value);


        public static double Lerp(double a, double b, double value) => a + ((b - a) * value);
        public static double Smoothstep(double edge0, double edge1, double v)
        {
            double x = Clamp((v - edge0) / (edge1 - edge0), 0, 1);
            return x * x * (3.0f - 2.0f * x);
        }
        public static double Degrees(double radians) => radians * 180 * Math.PI;
        public static double Radians(double degrees) => degrees / 180 / Math.PI;
        public static double Fma(double a, double b, double c) => a * b + c;
        public static double RoundEven(double value) => Math.Round(value, MidpointRounding.ToEven);
        public static double InverseSqrt(double value) => 1.0 / (Math.Sqrt(value));
        public static double Log2(double value) => Math.Log(value, 2);
        public static double Exp2(double value) => Math.Pow(2, value);


        public static float Abs(float x) => MathF.Abs(x);
        public static float Acos(float x) => MathF.Acos(x);
        public static float Acosh(float x) => MathF.Acosh(x);
        public static float Asin(float x) => MathF.Asin(x);
        public static float Asinh(float x) => MathF.Asinh(x);
        public static float Atan(float x) => MathF.Atan(x);
        public static float Atan2(float y, float x) => MathF.Atan2(y, x);
        public static float Atanh(float x) => MathF.Atanh(x);
        public static float Cbrt(float x) => MathF.Cbrt(x);
        public static float Ceiling(float x) => MathF.Ceiling(x);
        public static float Clamp(float value, float min, float max) => Math.Clamp(value, min, max);
        public static float Cos(float x) => MathF.Cos(x);
        public static float Cosh(float x) => MathF.Cosh(x);
        public static float Exp(float x) => MathF.Exp(x);
        public static float Floor(float x) => MathF.Floor(x);
        public static float Log(float x) => MathF.Log(x);
        public static float Log(float x, float y) => MathF.Log(x, y);
        public static float Log10(float x) => MathF.Log(x);
        public static float Max(float x, float y) => MathF.Max(x, y);
        public static float Min(float x, float y) => MathF.Min(x, y);
        public static float Pow(float x, float y) => MathF.Pow(x, y);
        public static float Round(float a) => MathF.Round(a);
        public static float Sin(float x) => MathF.Sin(x);
        public static float Sinh(float x) => MathF.Sinh(x);
        public static float Sqrt(float x) => MathF.Sqrt(x);
        public static float Tan(float x) => MathF.Tan(x);
        public static float Tanh(float x) => MathF.Tanh(x);
        public static float Truncate(float x) => MathF.Truncate(x);
        public static int Sign(float x) => MathF.Sign(x);

        public static double Abs(double value) => Math.Abs(value);
        public static double Acos(double d) => Math.Acos(d);
        public static double Acosh(double d) => Math.Acosh(d);
        public static double Asin(double d) => Math.Asin(d);
        public static double Asinh(double d) => Math.Asinh(d);
        public static double Atan(double d) => Math.Atan(d);
        public static double Atan2(double y, double x) => Math.Atan2(y, x);
        public static double Atanh(double d) => Math.Atanh(d);
        public static double Cbrt(double d) => Math.Cbrt(d);
        public static double Ceiling(double a) => Math.Ceiling(a);
        public static double Clamp(double value, double min, double max) => Math.Clamp(value, min, max);
        public static double Cos(double d) => Math.Cos(d);
        public static double Cosh(double value) => Math.Cosh(value);
        public static double Exp(double d) => Math.Exp(d);
        public static double Floor(double d) => Math.Floor(d);
        public static double Log(double d) => Math.Log(d);
        public static double Log(double a, double newBase) => Math.Log(a, newBase);
        public static double Log10(double d) => Math.Log10(d);
        public static double Max(double val1, double val2) => Math.Max(val1, val2);
        public static double Min(double val1, double val2) => Math.Min(val1, val2);
        public static double Pow(double x, double y) => Math.Pow(x, y);
        public static double Round(double a) => Math.Round(a);
        public static double Sin(double a) => Math.Sin(a);
        public static double Sinh(double value) => Math.Sinh(value);
        public static double Sqrt(double d) => Math.Sqrt(d);
        public static double Tan(double a) => Math.Tan(a);
        public static double Tanh(double value) => Math.Tanh(value);
        public static double Truncate(double d) => Math.Truncate(d);
        public static int Sign(double value) => Math.Sign(value);

        public static int Abs(int value) => Math.Abs(value);
        public static int Sign(int value) => Math.Sign(value);
        public static int Min(int val1, int val2) => Math.Min(val1, val2);
        public static int Max(int val1, int val2) => Math.Max(val1, val2);
        public static int Clamp(int value, int min, int max) => Math.Clamp(value, min, max);

        public static uint Clamp(uint value, uint min, uint max) => Math.Clamp(value, min, max);
        public static uint Min(uint val1, uint val2) => Math.Min(val1, val2);
        public static uint Max(uint val1, uint val2) => Math.Max(val1, val2);

    }
}