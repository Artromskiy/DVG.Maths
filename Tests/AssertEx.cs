using System;

namespace KibiHex.Tests
{
    internal static class AssertEx
    {
        public static void True(bool condition, string? message = null)
        {
            if (!condition)
                throw new InvalidOperationException(message ?? "Expected condition to be true.");
        }

        public static void Equal<T>(T expected, T actual, string? message = null)
        {
            if (!Equals(expected, actual))
                throw new InvalidOperationException(message ?? $"Expected '{expected}', got '{actual}'.");
        }

        public static void Near(float expected, float actual, float tolerance = 0.0001f)
        {
            if (float.IsNaN(actual) || MathF.Abs(expected - actual) > tolerance)
                throw new InvalidOperationException($"Expected {expected} ± {tolerance}, got {actual}.");
        }

        public static void Near(double expected, double actual, double tolerance = 0.0000001)
        {
            if (double.IsNaN(actual) || Math.Abs(expected - actual) > tolerance)
                throw new InvalidOperationException($"Expected {expected} ± {tolerance}, got {actual}.");
        }

        public static void Near(float3 expected, float3 actual, float tolerance = 0.0001f)
        {
            Near(expected.x, actual.x, tolerance);
            Near(expected.y, actual.y, tolerance);
            Near(expected.z, actual.z, tolerance);
        }

        public static void Near(float2 expected, float2 actual, float tolerance = 0.0001f)
        {
            Near(expected.x, actual.x, tolerance);
            Near(expected.y, actual.y, tolerance);
        }

        public static void Near(double3 expected, double3 actual, double tolerance = 0.0000001)
        {
            Near(expected.x, actual.x, tolerance);
            Near(expected.y, actual.y, tolerance);
            Near(expected.z, actual.z, tolerance);
        }

        public static void Throws<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                return;
            }
            throw new InvalidOperationException($"Expected {typeof(TException).Name}.");
        }
    }
}
