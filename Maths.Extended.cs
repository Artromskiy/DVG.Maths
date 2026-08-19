using System.Runtime.CompilerServices;

namespace Delta.Maths
{
    public partial class Maths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmoothDamp(float current, float target, ref float velocity, float smoothTime, float deltaTime)
        {
            float omega = 2f / smoothTime;
            float delta = current - target;
            float x = deltaTime * omega;
            float exp = 1f / (1f + x + (x * x * ((x * 0.235f) + 0.48f)));
            float temp = (velocity * deltaTime) + (x * delta);
            velocity = (velocity - (omega * temp)) * exp;
            float move = (delta + temp) * exp;
            bool stillMoving = Sign(delta) == Sign(move);
            float final = stillMoving ? target + move : target;
            velocity = stillMoving ? velocity : 0;
            return final;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SmoothDamp(double current, double target, ref double velocity, double smoothTime, double deltaTime)
        {
            double omega = 2.0 / smoothTime;
            double delta = current - target;
            double x = deltaTime * omega;
            double exp = 1.0 / (1.0 + x + (x * x * ((x * 0.235) + 0.48)));
            double temp = (velocity * deltaTime) + (x * delta);
            velocity = (velocity - (omega * temp)) * exp;
            double move = (delta + temp) * exp;
            bool stillMoving = Sign(delta) == Sign(move);
            double final = stillMoving ? target + move : target;
            velocity = stillMoving ? velocity : 0;
            return final;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InvLerp(float edge0, float edge1, float value) => (value - edge0) / (edge1 - edge0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double InvLerp(double edge0, double edge1, double value) => (value - edge0) / (edge1 - edge0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Step(float edge, float value) => value < edge ? 0f : 1f;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Step(double edge, double value) => value < edge ? 0.0 : 1.0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Saturate(float value) => Clamp(value, 0f, 1f);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Saturate(double value) => Clamp(value, 0.0, 1.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Fract(float value) => value - Floor(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Fract(double value) => value - Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(float value) => float.IsNaN(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(double value) => double.IsNaN(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(float value) => float.IsInfinity(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(double value) => double.IsInfinity(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(float value) => !float.IsNaN(value) && !float.IsInfinity(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(double value) => !double.IsNaN(value) && !double.IsInfinity(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Remap(float source, float sourceFrom, float sourceTo, float targetFrom, float targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Remap(double source, double sourceFrom, double sourceTo, double targetFrom, double targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MoveTowards(float current, float target, float maxDelta)
        {
            var delta = Clamp(target - current, -maxDelta, maxDelta);
            return current + delta;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MoveTowards(double current, double target, double maxDelta)
        {
            var delta = Clamp(target - current, -maxDelta, maxDelta);
            return current + delta;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RotateTowards(float current, float target, float maxStep)
        {
            var delta = DeltaAngle(current, target);
            target = current + delta;
            return MoveTowards(current, target, maxStep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double RotateTowards(double current, double target, double maxStep)
        {
            var delta = DeltaAngle(current, target);
            target = current + delta;
            return MoveTowards(current, target, maxStep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmoothDampAngle(float current, float target, ref float velocity, float smoothTime, float deltaTime)
        {
            var delta = DeltaAngle(current, target);
            target = current + delta;
            return SmoothDamp(current, target, ref velocity, smoothTime, deltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SmoothDampAngle(double current, double target, ref double velocity, double smoothTime, double deltaTime)
        {
            var delta = DeltaAngle(current, target);
            target = current + delta;
            return SmoothDamp(current, target, ref velocity, smoothTime, deltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DeltaAngle(float current, float target)
        {
            var num = Repeat(target - current, 360);
            return num > 180 ? num - 360 : num;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double DeltaAngle(double current, double target)
        {
            var num = Repeat(target - current, 360);
            return num > 180 ? num - 360 : num;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Repeat(float t, float length) => Clamp(t - (Floor(t / length) * length), 0f, length);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Repeat(double t, double length) => Clamp(t - (Floor(t / length) * length), 0, length);
    }
}
