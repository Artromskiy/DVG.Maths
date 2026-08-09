#pragma warning disable IDE1006
#nullable enable
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public static partial class maths
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 lerp(float2 edge0, float2 edge1, float2 value) => float2.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 lerp(float2 edge0, float2 edge1, float value) => float2.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float2 left, float2 right) => float2.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 normalize(float2 value) => float2.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 lerp(float3 edge0, float3 edge1, float3 value) => float3.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 lerp(float3 edge0, float3 edge1, float value) => float3.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float3 left, float3 right) => float3.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 normalize(float3 value) => float3.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 lerp(float4 edge0, float4 edge1, float4 value) => float4.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 lerp(float4 edge0, float4 edge1, float value) => float4.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float4 left, float4 right) => float4.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 normalize(float4 value) => float4.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 lerp(double2 edge0, double2 edge1, double2 value) => double2.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 lerp(double2 edge0, double2 edge1, double value) => double2.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double2 left, double2 right) => double2.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 normalize(double2 value) => double2.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 lerp(double3 edge0, double3 edge1, double3 value) => double3.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 lerp(double3 edge0, double3 edge1, double value) => double3.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double3 left, double3 right) => double3.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 normalize(double3 value) => double3.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 lerp(double4 edge0, double4 edge1, double4 value) => double4.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 lerp(double4 edge0, double4 edge1, double value) => double4.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double4 left, double4 right) => double4.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 normalize(double4 value) => double4.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 lerp(fix2 edge0, fix2 edge1, fix2 value) => fix2.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 lerp(fix2 edge0, fix2 edge1, fix value) => fix2.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix dot(fix2 left, fix2 right) => fix2.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 normalize(fix2 value) => fix2.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 lerp(fix3 edge0, fix3 edge1, fix3 value) => fix3.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 lerp(fix3 edge0, fix3 edge1, fix value) => fix3.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix dot(fix3 left, fix3 right) => fix3.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 normalize(fix3 value) => fix3.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 lerp(fix4 edge0, fix4 edge1, fix4 value) => fix4.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 lerp(fix4 edge0, fix4 edge1, fix value) => fix4.Lerp(edge0, edge1, value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix dot(fix4 left, fix4 right) => fix4.Dot(left, right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 normalize(fix4 value) => fix4.Normalize(value);
    }
}
