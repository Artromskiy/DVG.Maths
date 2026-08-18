using System;
using System.Globalization;
using System.Threading;

namespace DVG.Maths.Tests
{
    internal static class VectorBehaviorTests
    {
        public static void ConstructorsAndSwizzles()
        {
            AssertEx.Equal(new float4(1, 2, 3, 4), new float4(new float2(1, 2), 3, 4));
            AssertEx.Equal(new float4(1, 2, 3, 4), new float4(1, new float2(2, 3), 4));
            AssertEx.Equal(new float4(1, 2, 3, 4), new float4(1, 2, new float2(3, 4)));
            AssertEx.Equal(new float4(1, 2, 3, 4), new float4(new float2(1, 2), new float2(3, 4)));
            AssertEx.Equal(new float4(1, 2, 3, 4), new float4(new float3(1, 2, 3), 4));

            var value = new float3(1, 2, 3);
            AssertEx.Equal(new float3(3, 2, 1), value.zyx);
            value.yx = new float2(9, 8);
            AssertEx.Equal(new float3(8, 9, 3), value);
            value.r = 5;
            AssertEx.Equal(5f, value.x);
        }

        public static void OperatorsAndConversions()
        {
            AssertEx.Equal(new int3(5, 7, 9), new int3(1, 2, 3) + new int3(4, 5, 6));
            AssertEx.Equal(new int3(3, 6, 9), new int3(1, 2, 3) * 3);
            AssertEx.Equal(new int3(2, 4, 8), new int3(1, 2, 4) << 1);
            AssertEx.Equal(new int3(0, 2, 3), new int3(4, 6, 7) % 4);
            var incremented = new float3(1, 2, 3);
            incremented++;
            AssertEx.Equal(new float3(2, 3, 4), incremented);
            AssertEx.Equal(new float3(2, 3, 4), +incremented);

            AssertEx.Equal(new bool3(false, true, false), !new bool3(true, false, true));
            AssertEx.Equal(new bool3(true, false, false), new bool3(true, true, false) & new bool3(true, false, true));
            AssertEx.Equal(new bool3(true, true, false), new float3(1, 4, 3) < new float3(2, 5, 1));
            AssertEx.Equal(new bool3(true, false, true), new int3(1, 4, 3) <= 3);

            float3 floating = new int3(1, -2, 3);
            AssertEx.Equal(new float3(1, -2, 3), floating);
            var unsigned = (uint3)new int3(1, 2, 3);
            AssertEx.Equal(new uint3(1, 2, 3), unsigned);
            var signed = (int3)new uint3(4, 5, 6);
            AssertEx.Equal(new int3(4, 5, 6), signed);
        }

        public static void ParsingAndFormatting()
        {
            var previousCulture = Thread.CurrentThread.CurrentCulture;
            try
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
                var value = new float3(1.5f, -2.25f, 3.75f);
                AssertEx.Equal("1.5, -2.25, 3.75", value.ToString());
                AssertEx.Equal(value, float3.Parse(value.ToString()));
                AssertEx.Equal(value, float3.Parse("[1.5, -2.25, 3.75]"));
                AssertEx.Throws<FormatException>(() => float3.Parse("1, 2"));
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = previousCulture;
            }

            var indexed = new double3(1, 2, 3);
            indexed[1] = 8;
            AssertEx.Equal(8.0, indexed[1]);
            AssertEx.Throws<ArgumentOutOfRangeException>(() => indexed[-1] = 0);
            AssertEx.Throws<ArgumentOutOfRangeException>(() => _ = indexed[3]);
        }

        public static void CommonMaths()
        {
            AssertEx.Equal(new int3(1, 3, 2), int3.Min(new int3(1, 9, 2), new int3(5, 3, 8)));
            AssertEx.Equal(new int3(0, 5, 10), int3.Clamp(new int3(-1, 5, 12), 0, 10));
            AssertEx.Equal(new float3(0, 0.5f, 1), float3.Saturate(new float3(-2, 0.5f, 3)));
            AssertEx.Equal(new float3(0.25f, 0.75f, 0), float3.Fract(new float3(1.25f, -1.25f, 2)));
            AssertEx.Equal(new float3(0, 1, 1), float3.Step(new float3(1, 1, 1), new float3(0, 1, 2)));
            AssertEx.Equal(new float3(5, 10, 15), float3.Lerp(float3.zero, new float3(10, 20, 30), 0.5f));
            AssertEx.Equal(6, int3.Sum(new int3(1, 2, 3)));
            AssertEx.Equal(32, int3.Dot(new int3(1, 2, 3), new int3(4, 5, 6)));
            AssertEx.Equal(new bool3(true, false, true), float3.IsFinite(new float3(1, float.PositiveInfinity, 2)));
        }

        public static void Geometry()
        {
            // Cases adapted from Unity.Mathematics' official TestMath suite.
            AssertEx.Near(new float3(35.88f, -26.456f, 68.872f),
                float3.Reflect(new float3(1.2f, 3.6f, -2.8f), new float3(1.5f, -1.3f, 3.1f)));
            AssertEx.Near(new float3(-0.2863437f, 0.8056898f, -0.5185286f),
                float3.Refract(new float3(0.288375f, 0.865125f, -0.410365f),
                    new float3(0.662147f, -0.573861f, 0.481919f), 0.5f));
            AssertEx.Equal(float3.zero,
                float3.Refract(new float3(0.288375f, 0.865125f, -0.410365f),
                    new float3(0.662147f, -0.573861f, 0.481919f), 1.5f));

            AssertEx.Equal(new float3(0, 0, 1), float3.Cross(new float3(1, 0, 0), new float3(0, 1, 0)));
            AssertEx.Equal(new float3(2, 0, 0), float3.Project(new float3(2, 3, 4), new float3(1, 0, 0)));
            AssertEx.Equal(float3.zero, float3.ProjectSafe(new float3(2, 3, 4), float3.zero));
            AssertEx.Near(5f, float2.Length(new float2(3, 4)));
            AssertEx.Near(5f, float2.Distance(new float2(1, 1), new float2(4, 5)));
        }

        public static void Normalization()
        {
            AssertEx.Near(new float2(0.504883f, -0.863188f), float2.Normalize(new float2(3.1f, -5.3f)));
            AssertEx.True(maths.all(maths.isNaN(float3.Normalize(float3.zero))));
            AssertEx.Equal(float3.zero, float3.NormalizeSafe(float3.zero));
            AssertEx.Equal(new float3(1, 2, 3), float3.NormalizeSafe(float3.zero, new float3(1, 2, 3)));
            AssertEx.Near(new float3(0.267261f, 0.534523f, 0.801784f),
                float3.NormalizeSafe(new float3(1e-19f, 2e-19f, 3e-19f)));
            AssertEx.Equal(new float3(1, 2, 3),
                float3.NormalizeSafe(new float3(6.25e-20f), new float3(1, 2, 3)));
            AssertEx.Equal(new double3(1, 2, 3),
                double3.NormalizeSafe(new double3(8.61e-155), new double3(1, 2, 3)));
        }

        public static void ShaderStyleFacade()
        {
            AssertEx.Equal(Maths.Sin(0.5f), maths.sin(0.5f));
            AssertEx.Equal(float3.Dot(new float3(1, 2, 3), new float3(4, 5, 6)),
                maths.dot(new float3(1, 2, 3), new float3(4, 5, 6)));
            AssertEx.Equal(new float3(-1, 20, -3),
                maths.select(new float3(-1, -2, -3), new float3(10, 20, 30), new bool3(false, true, false)));
            AssertEx.Equal(new float3(-1, 10, -1),
                maths.select(-1f, 10f, new bool3(false, true, false)));
            AssertEx.True(maths.any(new bool3(false, true, false)));
            AssertEx.True(!maths.all(new bool3(true, false, true)));
        }

        public static void FixedPoint()
        {
            var value = new fix3((fix)1.5f, (fix)(-2.25f), (fix)3.5f);
            var absolute = fix3.Abs(value);
            AssertEx.Near(1.5f, (float)absolute.x, 0.0001f);
            AssertEx.Near(2.25f, (float)absolute.y, 0.0001f);
            AssertEx.Near(3.5f, (float)absolute.z, 0.0001f);
            AssertEx.Near(1f, (float)fix2.Length(new fix2(1, 0)), 0.0001f);
            AssertEx.Equal(new fix3(0, 0, 1), fix3.Cross(new fix3(1, 0, 0), new fix3(0, 1, 0)));
        }

        public static void ScalarRegressions()
        {
            AssertEx.Near(180.0, Maths.Degrees(Math.PI));
            AssertEx.Near(Math.PI, Maths.Radians(180.0));
            AssertEx.Near(2f, Maths.Log10(100f));
            AssertEx.Equal(0f, Maths.Saturate(-1f));
            AssertEx.Equal(1f, Maths.Step(0f, 0f));
        }
    }
}
