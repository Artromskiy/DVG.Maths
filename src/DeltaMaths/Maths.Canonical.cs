using System.Runtime.CompilerServices;

namespace Delta.Maths
{
    /// <summary>Canonical managed spelling for the scalar maths facade.</summary>
    /// <remarks>
    /// This facade forwards to the established <see cref="DeltaMaths"/> implementation.
    /// The lowercase <see cref="maths"/> facade remains the shader-authoring API.
    /// </remarks>
    public static class Maths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(float value) => DeltaMaths.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Abs(double value) => DeltaMaths.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value) => DeltaMaths.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(float left, float right) => DeltaMaths.Min(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Min(double left, double right) => DeltaMaths.Min(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int left, int right) => DeltaMaths.Min(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint left, uint right) => DeltaMaths.Min(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(float left, float right) => DeltaMaths.Max(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Max(double left, double right) => DeltaMaths.Max(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int left, int right) => DeltaMaths.Max(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Max(uint left, uint right) => DeltaMaths.Max(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max) => DeltaMaths.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double min, double max) => DeltaMaths.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int min, int max) => DeltaMaths.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint value, uint min, uint max) => DeltaMaths.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(float value) => DeltaMaths.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Floor(double value) => DeltaMaths.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceil(float value) => DeltaMaths.Ceil(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Ceil(double value) => DeltaMaths.Ceil(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(float value) => DeltaMaths.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sqrt(double value) => DeltaMaths.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Acos(float value) => DeltaMaths.Acos(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Acos(double value) => DeltaMaths.Acos(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sin(float value) => DeltaMaths.Sin(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sin(double value) => DeltaMaths.Sin(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Radians(float value) => DeltaMaths.Radians(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Radians(double value) => DeltaMaths.Radians(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(float value) => DeltaMaths.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(double value) => DeltaMaths.Round(value);
    }
}
