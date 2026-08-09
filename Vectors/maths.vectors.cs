#pragma warning disable IDE1006
#nullable enable
using System.Runtime.CompilerServices;

namespace KibiHex
{
    public static partial class maths
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool2 value) => bool2.Any(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool2 value) => bool2.All(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool3 value) => bool3.Any(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool3 value) => bool3.All(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool4 value) => bool4.Any(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool4 value) => bool4.All(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 clamp(int2 value, int min, int max) => int2.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 clamp(int3 value, int min, int max) => int3.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 clamp(int4 value, int min, int max) => int4.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 clamp(uint2 value, uint min, uint max) => uint2.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 clamp(uint3 value, uint min, uint max) => uint3.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 clamp(uint4 value, uint min, uint max) => uint4.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 clamp(float2 value, float min, float max) => float2.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float length(float2 value) => float2.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float distance(float2 a, float2 b) => float2.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float2 a, float2 b) => float2.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 normalize(float2 value) => float2.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 faceForward(float2 N, float2 I, float2 Nref) => float2.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 reflect(float2 I, float2 N) => float2.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 refract(float2 I, float2 N, float eta) => float2.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrLength(float2 value) => float2.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrDistance(float2 a, float2 b) => float2.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 clampLength(float2 value, float maxLength) => float2.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 moveTowards(float2 current, float2 target, float maxDelta) => float2.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 abs(float2 value) => float2.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 sign(float2 value) => float2.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 lerp(float2 a, float2 b, float t) => float2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 lerp(float2 a, float2 b, float2 t) => float2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 min(float2 a, float2 b) => float2.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 max(float2 a, float2 b) => float2.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 invLerp(float2 edge0, float2 edge1, float2 value) => float2.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 invLerp(float2 edge0, float2 edge1, float value) => float2.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 smoothDamp(float2 source, float2 target, ref float2 velocity, float smoothTime, float deltaTime) => float2.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 pow(float2 a, float2 b) => float2.Pow(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 exp(float2 value) => float2.Exp(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 log(float2 value) => float2.Log(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 exp2(float2 value) => float2.Exp2(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 log2(float2 value) => float2.Log2(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 sqrt(float2 value) => float2.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 inverseSqrt(float2 value) => float2.InverseSqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 clamp(float3 value, float min, float max) => float3.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float length(float3 value) => float3.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float distance(float3 a, float3 b) => float3.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float3 a, float3 b) => float3.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cross(float3 a, float3 b) => float3.Cross(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 normalize(float3 value) => float3.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 faceForward(float3 N, float3 I, float3 Nref) => float3.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 reflect(float3 I, float3 N) => float3.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 refract(float3 I, float3 N, float eta) => float3.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrLength(float3 value) => float3.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrDistance(float3 a, float3 b) => float3.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 clampLength(float3 value, float maxLength) => float3.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 moveTowards(float3 current, float3 target, float maxDelta) => float3.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 abs(float3 value) => float3.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sign(float3 value) => float3.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 lerp(float3 a, float3 b, float t) => float3.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 lerp(float3 a, float3 b, float3 t) => float3.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 min(float3 a, float3 b) => float3.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 max(float3 a, float3 b) => float3.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 invLerp(float3 edge0, float3 edge1, float3 value) => float3.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 invLerp(float3 edge0, float3 edge1, float value) => float3.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 smoothDamp(float3 source, float3 target, ref float3 velocity, float smoothTime, float deltaTime) => float3.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 pow(float3 a, float3 b) => float3.Pow(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 exp(float3 value) => float3.Exp(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 log(float3 value) => float3.Log(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 exp2(float3 value) => float3.Exp2(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 log2(float3 value) => float3.Log2(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sqrt(float3 value) => float3.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 inverseSqrt(float3 value) => float3.InverseSqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 clamp(float4 value, float min, float max) => float4.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float length(float4 value) => float4.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float distance(float4 a, float4 b) => float4.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float4 a, float4 b) => float4.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 normalize(float4 value) => float4.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 faceForward(float4 N, float4 I, float4 Nref) => float4.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 reflect(float4 I, float4 N) => float4.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 refract(float4 I, float4 N, float eta) => float4.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrLength(float4 value) => float4.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrDistance(float4 a, float4 b) => float4.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 clampLength(float4 value, float maxLength) => float4.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 moveTowards(float4 current, float4 target, float maxDelta) => float4.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 abs(float4 value) => float4.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 sign(float4 value) => float4.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 lerp(float4 a, float4 b, float t) => float4.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 lerp(float4 a, float4 b, float4 t) => float4.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 min(float4 a, float4 b) => float4.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 max(float4 a, float4 b) => float4.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 invLerp(float4 edge0, float4 edge1, float4 value) => float4.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 invLerp(float4 edge0, float4 edge1, float value) => float4.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 smoothDamp(float4 source, float4 target, ref float4 velocity, float smoothTime, float deltaTime) => float4.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 pow(float4 a, float4 b) => float4.Pow(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 exp(float4 value) => float4.Exp(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 log(float4 value) => float4.Log(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 exp2(float4 value) => float4.Exp2(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 log2(float4 value) => float4.Log2(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 sqrt(float4 value) => float4.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 inverseSqrt(float4 value) => float4.InverseSqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 clamp(double2 value, double min, double max) => double2.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double length(double2 value) => double2.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double distance(double2 a, double2 b) => double2.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double2 a, double2 b) => double2.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 normalize(double2 value) => double2.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 faceForward(double2 N, double2 I, double2 Nref) => double2.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 reflect(double2 I, double2 N) => double2.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 refract(double2 I, double2 N, double eta) => double2.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sqrLength(double2 value) => double2.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sqrDistance(double2 a, double2 b) => double2.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 clampLength(double2 value, double maxLength) => double2.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 moveTowards(double2 current, double2 target, double maxDelta) => double2.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 abs(double2 value) => double2.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 sign(double2 value) => double2.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 lerp(double2 a, double2 b, double t) => double2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 lerp(double2 a, double2 b, double2 t) => double2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 min(double2 a, double2 b) => double2.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 max(double2 a, double2 b) => double2.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 invLerp(double2 edge0, double2 edge1, double2 value) => double2.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 invLerp(double2 edge0, double2 edge1, double value) => double2.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 smoothDamp(double2 source, double2 target, ref double2 velocity, double smoothTime, double deltaTime) => double2.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 sqrt(double2 value) => double2.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 inverseSqrt(double2 value) => double2.InverseSqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 clamp(double3 value, double min, double max) => double3.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double length(double3 value) => double3.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double distance(double3 a, double3 b) => double3.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double3 a, double3 b) => double3.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 cross(double3 a, double3 b) => double3.Cross(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 normalize(double3 value) => double3.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 faceForward(double3 N, double3 I, double3 Nref) => double3.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 reflect(double3 I, double3 N) => double3.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 refract(double3 I, double3 N, double eta) => double3.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sqrLength(double3 value) => double3.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sqrDistance(double3 a, double3 b) => double3.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 clampLength(double3 value, double maxLength) => double3.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 moveTowards(double3 current, double3 target, double maxDelta) => double3.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 abs(double3 value) => double3.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 sign(double3 value) => double3.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 lerp(double3 a, double3 b, double t) => double3.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 lerp(double3 a, double3 b, double3 t) => double3.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 min(double3 a, double3 b) => double3.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 max(double3 a, double3 b) => double3.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 invLerp(double3 edge0, double3 edge1, double3 value) => double3.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 invLerp(double3 edge0, double3 edge1, double value) => double3.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 smoothDamp(double3 source, double3 target, ref double3 velocity, double smoothTime, double deltaTime) => double3.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 sqrt(double3 value) => double3.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 inverseSqrt(double3 value) => double3.InverseSqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 clamp(double4 value, double min, double max) => double4.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double length(double4 value) => double4.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double distance(double4 a, double4 b) => double4.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double4 a, double4 b) => double4.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 normalize(double4 value) => double4.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 faceForward(double4 N, double4 I, double4 Nref) => double4.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 reflect(double4 I, double4 N) => double4.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 refract(double4 I, double4 N, double eta) => double4.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sqrLength(double4 value) => double4.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sqrDistance(double4 a, double4 b) => double4.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 clampLength(double4 value, double maxLength) => double4.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 moveTowards(double4 current, double4 target, double maxDelta) => double4.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 abs(double4 value) => double4.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 sign(double4 value) => double4.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 lerp(double4 a, double4 b, double t) => double4.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 lerp(double4 a, double4 b, double4 t) => double4.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 min(double4 a, double4 b) => double4.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 max(double4 a, double4 b) => double4.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 invLerp(double4 edge0, double4 edge1, double4 value) => double4.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 invLerp(double4 edge0, double4 edge1, double value) => double4.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 smoothDamp(double4 source, double4 target, ref double4 velocity, double smoothTime, double deltaTime) => double4.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 sqrt(double4 value) => double4.Sqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 inverseSqrt(double4 value) => double4.InverseSqrt(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 clamp(fix2 value, fix min, fix max) => fix2.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix length(fix2 value) => fix2.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix distance(fix2 a, fix2 b) => fix2.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix dot(fix2 a, fix2 b) => fix2.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 normalize(fix2 value) => fix2.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 faceForward(fix2 N, fix2 I, fix2 Nref) => fix2.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 reflect(fix2 I, fix2 N) => fix2.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 refract(fix2 I, fix2 N, fix eta) => fix2.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix sqrLength(fix2 value) => fix2.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix sqrDistance(fix2 a, fix2 b) => fix2.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 clampLength(fix2 value, fix maxLength) => fix2.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 moveTowards(fix2 current, fix2 target, fix maxDelta) => fix2.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 abs(fix2 value) => fix2.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 sign(fix2 value) => fix2.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 lerp(fix2 a, fix2 b, fix t) => fix2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 lerp(fix2 a, fix2 b, fix2 t) => fix2.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 min(fix2 a, fix2 b) => fix2.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 max(fix2 a, fix2 b) => fix2.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 invLerp(fix2 edge0, fix2 edge1, fix2 value) => fix2.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 invLerp(fix2 edge0, fix2 edge1, fix value) => fix2.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix2 smoothDamp(fix2 source, fix2 target, ref fix2 velocity, fix smoothTime, fix deltaTime) => fix2.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 clamp(fix3 value, fix min, fix max) => fix3.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix length(fix3 value) => fix3.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix distance(fix3 a, fix3 b) => fix3.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix dot(fix3 a, fix3 b) => fix3.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 cross(fix3 a, fix3 b) => fix3.Cross(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 normalize(fix3 value) => fix3.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 faceForward(fix3 N, fix3 I, fix3 Nref) => fix3.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 reflect(fix3 I, fix3 N) => fix3.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 refract(fix3 I, fix3 N, fix eta) => fix3.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix sqrLength(fix3 value) => fix3.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix sqrDistance(fix3 a, fix3 b) => fix3.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 clampLength(fix3 value, fix maxLength) => fix3.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 moveTowards(fix3 current, fix3 target, fix maxDelta) => fix3.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 abs(fix3 value) => fix3.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 sign(fix3 value) => fix3.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 lerp(fix3 a, fix3 b, fix t) => fix3.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 lerp(fix3 a, fix3 b, fix3 t) => fix3.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 min(fix3 a, fix3 b) => fix3.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 max(fix3 a, fix3 b) => fix3.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 invLerp(fix3 edge0, fix3 edge1, fix3 value) => fix3.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 invLerp(fix3 edge0, fix3 edge1, fix value) => fix3.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix3 smoothDamp(fix3 source, fix3 target, ref fix3 velocity, fix smoothTime, fix deltaTime) => fix3.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 clamp(fix4 value, fix min, fix max) => fix4.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix length(fix4 value) => fix4.Length(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix distance(fix4 a, fix4 b) => fix4.Distance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix dot(fix4 a, fix4 b) => fix4.Dot(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 normalize(fix4 value) => fix4.Normalize(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 faceForward(fix4 N, fix4 I, fix4 Nref) => fix4.FaceForward(N, I, Nref);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 reflect(fix4 I, fix4 N) => fix4.Reflect(I, N);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 refract(fix4 I, fix4 N, fix eta) => fix4.Refract(I, N, eta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix sqrLength(fix4 value) => fix4.SqrLength(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix sqrDistance(fix4 a, fix4 b) => fix4.SqrDistance(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 clampLength(fix4 value, fix maxLength) => fix4.ClampLength(value, maxLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 moveTowards(fix4 current, fix4 target, fix maxDelta) => fix4.MoveTowards(current, target, maxDelta);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 abs(fix4 value) => fix4.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 sign(fix4 value) => fix4.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 lerp(fix4 a, fix4 b, fix t) => fix4.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 lerp(fix4 a, fix4 b, fix4 t) => fix4.Lerp(a, b, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 min(fix4 a, fix4 b) => fix4.Min(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 max(fix4 a, fix4 b) => fix4.Max(a, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 invLerp(fix4 edge0, fix4 edge1, fix4 value) => fix4.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 invLerp(fix4 edge0, fix4 edge1, fix value) => fix4.InvLerp(edge0, edge1, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix4 smoothDamp(fix4 source, fix4 target, ref fix4 velocity, fix smoothTime, fix deltaTime) => fix4.SmoothDamp(source, target, ref velocity, smoothTime, deltaTime);
    }
}
