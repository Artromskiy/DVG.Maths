using System;
using System.Globalization;
using System.Threading;

namespace Delta.Maths.Tests
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
                AssertEx.Equal(value, float3.Parse(value.ToString(), CultureInfo.InvariantCulture));
                AssertEx.Equal(value, float3.Parse("[1.5, -2.25, 3.75]", CultureInfo.InvariantCulture));
                AssertEx.Throws<FormatException>(() => float3.Parse("1, 2", CultureInfo.InvariantCulture));
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

        public static void CommonDeltaMaths()
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

        public static void IntegerShaderOperations()
        {
            var sum = DeltaMaths.UaddCarry(uint.MaxValue, 1u, out var carry);
            AssertEx.Equal(0u, sum);
            AssertEx.Equal(1u, carry);
            AssertEx.Equal(0u, maths.uaddCarry(uint.MaxValue, 1u, out carry));
            AssertEx.Equal(1u, carry);

            var difference = DeltaMaths.UsubBorrow(0u, 1u, out var borrow);
            AssertEx.Equal(uint.MaxValue, difference);
            AssertEx.Equal(1u, borrow);

            DeltaMaths.UmulExtended(uint.MaxValue, 2u, out var unsignedMsb, out var unsignedLsb);
            AssertEx.Equal(1u, unsignedMsb);
            AssertEx.Equal(0xfffffffeu, unsignedLsb);
            DeltaMaths.ImulExtended(-2, 3, out var signedMsb, out var signedLsb);
            AssertEx.Equal(-1, signedMsb);
            AssertEx.Equal(-6, signedLsb);

            AssertEx.Equal(32, DeltaMaths.BitCount(uint.MaxValue));
            AssertEx.Equal(4, DeltaMaths.BitCount(0x0f0u));
            AssertEx.Equal(4, DeltaMaths.FindLSB(0x10u));
            AssertEx.Equal(-1, DeltaMaths.FindLSB(0u));
            AssertEx.Equal(4, DeltaMaths.FindMSB(0x10u));
            AssertEx.Equal(0, DeltaMaths.FindMSB(-2));
            AssertEx.Equal(-1, DeltaMaths.FindMSB(-1));
            AssertEx.Equal(0xb0000000u, DeltaMaths.BitfieldReverse(0x0du));

            AssertEx.Equal(0x0fu, DeltaMaths.BitfieldExtract(0xf0u, 4, 4));
            AssertEx.Equal(-4, DeltaMaths.BitfieldExtract(-8, 1, 3));
            AssertEx.Equal(0xffff0050u, DeltaMaths.BitfieldInsert(0xffff0000u, 5u, 4, 4));
            AssertEx.Equal(0u, DeltaMaths.BitfieldExtract(uint.MaxValue, -1, 4));
            AssertEx.Equal(uint.MaxValue, DeltaMaths.BitfieldInsert(uint.MaxValue, 0u, 32, 1));

            var vectorSum = uint3.UaddCarry(new uint3(uint.MaxValue, 2u, 3u), new uint3(1u, 4u, 5u), out var vectorCarry);
            AssertEx.Equal(new uint3(0u, 6u, 8u), vectorSum);
            AssertEx.Equal(new uint3(1u, 0u, 0u), vectorCarry);
            AssertEx.Equal(new int3(32, 0, 2), maths.bitCount(new int3(-1, 0, 3)));
            AssertEx.Equal(new int3(0, -1, 3), maths.findMSB(new int3(-2, 0, 8)));
            AssertEx.Equal(new uint3(0x50u, 0x60u, 0x70u),
                maths.bitfieldInsert(new uint3(0u, 0u, 0u), new uint3(5u, 6u, 7u), 4, 4));
        }

        public static void FloatingPointShaderOperations()
        {
            var fractional = DeltaMaths.Modf(-3.75f, out var integerPart);
            AssertEx.Equal(-0.75f, fractional);
            AssertEx.Equal(-3f, integerPart);

            var vectorFractional = float3.Modf(new float3(-3.75f, 2.5f, -0.25f), out var vectorIntegerPart);
            AssertEx.Equal(new float3(-0.75f, 0.5f, -0.25f), vectorFractional);
            AssertEx.Equal(new float3(-3f, 2f, 0f), vectorIntegerPart);
            AssertEx.Equal(new float3(-0.75f, 0.5f, -0.25f), maths.modf(
                new float3(-3.75f, 2.5f, -0.25f), out var facadeIntegerPart));
            AssertEx.Equal(vectorIntegerPart, facadeIntegerPart);

            var mantissa = DeltaMaths.Frexp(6.5f, out var exponent);
            AssertEx.Equal(0.8125f, mantissa);
            AssertEx.Equal(3, exponent);
            AssertEx.Equal(6.5f, DeltaMaths.Ldexp(mantissa, exponent));
            var tinyMantissa = DeltaMaths.Frexp(float.Epsilon, out var tinyExponent);
            AssertEx.Equal(0.5f, tinyMantissa);
            AssertEx.Equal(-148, tinyExponent);

            var bits = new float3(
                DeltaMaths.IntBitsToFloat(0x3f800000),
                DeltaMaths.IntBitsToFloat(unchecked((int)0x80000000u)),
                DeltaMaths.IntBitsToFloat(0x7fc12345));
            AssertEx.Equal(new int3(0x3f800000, unchecked((int)0x80000000u), 0x7fc12345), float3.FloatBitsToInt(bits));
            AssertEx.Equal(new uint3(0x3f800000u, 0x80000000u, 0x7fc12345u), maths.floatBitsToUint(bits));
            AssertEx.Equal(bits, float3.UintBitsToFloat(float3.FloatBitsToUint(bits)));

            var packed = float2.PackHalf2x16(new float2(1f, -2f));
            AssertEx.Equal(0xc0003c00u, packed);
            AssertEx.Near(new float2(1f, -2f), float2.UnpackHalf2x16(packed));
            var special = float2.UnpackHalf2x16(float2.PackHalf2x16(
                new float2(float.PositiveInfinity, float.NaN)));
            AssertEx.True(float.IsPositiveInfinity(special.x));
            AssertEx.True(float.IsNaN(special.y));
        }

        public static void RelationalAndSelect()
        {
            var floatLeft = new float3(1f, 3f, 2f);
            var floatRight = new float3(2f, 3f, 1f);
            AssertEx.Equal(new bool3(true, false, false), float3.LessThan(floatLeft, floatRight));
            AssertEx.Equal(new bool3(false, true, true), maths.greaterThanOrEqual(floatLeft, floatRight));
            AssertEx.Equal(new bool3(false, true, false), bool3.Not(new bool3(true, false, true)));
            AssertEx.Equal(new bool3(false, true, false), maths.not(new bool3(true, false, true)));
            AssertEx.Equal(new int3(-1, 20, -3), maths.select(
                new int3(-1, -2, -3), new int3(10, 20, 30), new bool3(false, true, false)));
            AssertEx.Equal(new uint3(1u, 8u, 3u), maths.select(
                new uint3(1u, 2u, 3u), new uint3(7u, 8u, 9u), new bool3(false, true, false)));
        }

        public static void Half()
        {
            AssertEx.Equal(2, System.Runtime.InteropServices.Marshal.SizeOf<half>());
            AssertEx.Equal(4, System.Runtime.InteropServices.Marshal.SizeOf<half2>());
            AssertEx.Equal(8, System.Runtime.InteropServices.Marshal.SizeOf<half3>());
            AssertEx.Equal(8, System.Runtime.InteropServices.Marshal.SizeOf<half4>());
            AssertEx.Equal((ushort)0x3c00, new half(1f).raw);
            AssertEx.Equal(1f, new half((ushort)0x3c00).ToSingle());
            AssertEx.Equal((ushort)0xc000, new half(-2f).raw);

            foreach (var value in new[]
            {
                0f,
                -0f,
                1f,
                -2f,
                0.33325f,
                65504f,
                0.00006103515625f,
                float.Epsilon,
                float.PositiveInfinity,
                float.NaN,
            })
            {
                AssertEx.Equal(
                    BitConverter.HalfToUInt16Bits((System.Half)value),
                    new half(value).raw);
            }

            AssertEx.Equal(half.One, DeltaMaths.Abs(new half(-1f)));
            AssertEx.Equal(new half(0.5f), DeltaMaths.Lerp(half.Zero, half.One, new half(0.5f)));
            AssertEx.Equal(new half(0.25f), maths.fract(new half(1.25f)));
            AssertEx.Equal(new half(0.5f), maths.inverseSqrt(new half(4f)));
            AssertEx.Equal(new half(2f), maths.cbrt(new half(8f)));
            AssertEx.Equal(new half(3f), maths.log(new half(8f), new half(2f)));
            var halfValue = new half3(new half(1f), new half(-2f), new half(3f));
            AssertEx.Equal(new half3(new half(2f), new half(-4f), new half(6f)), halfValue * new half(2f));
            AssertEx.Equal(new half3(new half(3f), new half(-1f), new half(5f)), halfValue + new half3(2, 1, 2));
            AssertEx.Equal(new half3(new half(1f), new half(3f), new half(3f)),
                half3.Select(halfValue, new half3(3, 3, 3), new bool3(false, true, false)));
            AssertEx.Equal(new half3(new half(1f), new half(-2f), new half(3f)), halfValue.xyz);
            AssertEx.True(new half((ushort)0x7e00).IsNaN);
            AssertEx.True(half.PositiveInfinity.IsInfinity);
            AssertEx.True(half.MaxValue.IsFinite);
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
            AssertEx.Equal(DeltaMaths.Sin(0.5f), maths.sin(0.5f));
            AssertEx.Near(0.75f, DeltaMaths.Mod(-0.25f, 1f));
            AssertEx.Near(0.75f, maths.mod(-0.25f, 1f));
            AssertEx.Equal(new float3(0.75f, 0.25f, 0.5f),
                float3.Mod(new float3(-0.25f, 1.25f, 2.5f), 1f));
            AssertEx.Equal(new float3(0.75f, 0.25f, 0.5f),
                maths.mod(new float3(-0.25f, 1.25f, 2.5f), 1f));
            AssertEx.Equal(new float3(0.75f, 0.25f, 0.5f),
                maths.fract(new float3(-0.25f, 1.25f, 2.5f)));
            AssertEx.Near(new float3(0.5f, 0.25f, 2f),
                maths.inverseSqrt(new float3(4f, 16f, 0.25f)));
            AssertEx.Near(new float3(MathF.PI, MathF.PI / 2f, 0f),
                maths.radians(new float3(180f, 90f, 0f)));
            AssertEx.Near(new float3(180f, 90f, 0f),
                maths.degrees(new float3(MathF.PI, MathF.PI / 2f, 0f)));
            AssertEx.Near(new float3(MathF.PI / 2f, 0f, -MathF.PI / 2f),
                maths.atan2(new float3(1f, 0f, -1f), new float3(0f, 1f, 0f)));
            AssertEx.Equal(new float3(2f, 2f, -2f),
                maths.roundEven(new float3(1.5f, 2.5f, -1.5f)));
            AssertEx.Equal(float3.Dot(new float3(1, 2, 3), new float3(4, 5, 6)),
                maths.dot(new float3(1, 2, 3), new float3(4, 5, 6)));
            AssertEx.Equal(new float3(-1, 20, -3),
                maths.select(new float3(-1, -2, -3), new float3(10, 20, 30), new bool3(false, true, false)));
            AssertEx.Equal(new float3(-1, 10, -1),
                maths.select(-1f, 10f, new bool3(false, true, false)));
            AssertEx.True(maths.any(new bool3(false, true, false)));
            AssertEx.True(!maths.all(new bool3(true, false, true)));
        }

        public static void Packing()
        {
            AssertEx.Equal(0xffff0000u, float2.PackUnorm2x16(new float2(0f, 1f)));
            AssertEx.Near(new float2(0f, 1f), float2.UnpackUnorm2x16(0xffff0000u));
            AssertEx.Equal(0x7fff8001u, float2.PackSnorm2x16(new float2(-1f, 1f)));
            AssertEx.Near(new float2(-1f, 1f), float2.UnpackSnorm2x16(0x7fff8001u));

            AssertEx.Equal(0xffff8000u, float4.PackUnorm4x8(new float4(0f, 0.5f, 1f, 2f)));
            AssertEx.Near(new float4(0f, 128f / 255f, 1f, 1f), float4.UnpackUnorm4x8(0xffff8000u));
            AssertEx.Equal(0x7f20e081u, float4.PackSnorm4x8(new float4(-1f, -0.25f, 0.25f, 1f)));
            AssertEx.Near(new float4(-1f, -32f / 127f, 32f / 127f, 1f), float4.UnpackSnorm4x8(0x7f20e081u));

            var doubleWords = new uint2(0x89abcdefu, 0x01234567u);
            var packedDouble = DeltaMaths.PackDouble2x32(doubleWords);
            AssertEx.Equal(0x0123456789abcdefL, BitConverter.DoubleToInt64Bits(packedDouble));
            AssertEx.Equal(doubleWords, DeltaMaths.UnpackDouble2x32(packedDouble));
            AssertEx.Equal(packedDouble, maths.packDouble2x32(doubleWords));
            AssertEx.Equal(doubleWords, maths.unpackDouble2x32(packedDouble));
        }

        public static void FixedPoint()
        {
            var raw = new fix(65536);
            AssertEx.Equal(65536, raw.raw);
            AssertEx.True(raw.Equals((object)new fix(65536)));
            AssertEx.Equal((fix)1.5f, fix.Parse("1.5", CultureInfo.InvariantCulture));
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
            AssertEx.Near(180.0, DeltaMaths.Degrees(Math.PI));
            AssertEx.Near(Math.PI, DeltaMaths.Radians(180.0));
            AssertEx.Near(2f, DeltaMaths.Log10(100f));
            AssertEx.Equal(0f, DeltaMaths.Saturate(-1f));
            AssertEx.Equal(1f, DeltaMaths.Step(0f, 0f));
        }
    }
}
