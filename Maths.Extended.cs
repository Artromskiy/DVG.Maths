using System;

namespace DVG
{
    public partial class Maths
    {
        public static float SmoothDamp(float current, float target, ref float velocity, float smoothTime, float deltaTime)
        {
            float omega = 2f / smoothTime;
            float delta = current - target;
            float x = deltaTime * omega;
            float exp = 1f / (1f + x + (x * x * ((x * 0.235f) + 0.48f)));
            float temp = (velocity * deltaTime) + (x * delta);
            velocity = (velocity - (omega * temp)) * exp;
            float move = (delta + temp) * exp;
            bool finalized = Sign(-delta) == Sign(move);
            float final = finalized ? target : target + move;
            velocity = finalized ? 0 : velocity;
            return final;
        }

        public static double SmoothDamp(double current, double target, ref double velocity, double smoothTime, double deltaTime)
        {
            double omega = 2.0 / smoothTime;
            double delta = current - target;
            double x = deltaTime * omega;
            double exp = 1.0 / (1.0 + x + (x * x * ((x * 0.235) + 0.48)));
            double temp = (velocity * deltaTime) + (x * delta);
            velocity = (velocity - (omega * temp)) * exp;
            double move = (delta + temp) * exp;
            bool finalized = Sign(-delta) == Sign(move);
            double final = finalized ? target : target + move;
            velocity = finalized ? 0 : velocity;
            return final;
        }

        public static float InvLerp(float edge0, float edge1, float value) => (value - edge0) / (edge1 - edge0);
        public static double InvLerp(double edge0, double edge1, double value) => (value - edge0) / (edge1 - edge0);

        public static float Remap(float source, float sourceFrom, float sourceTo, float targetFrom, float targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));
        public static double Remap(double source, double sourceFrom, double sourceTo, double targetFrom, double targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));


        public static float MoveTowards(float current, float target, float maxDelta)
        {
            float delta = target - current;
            float min = Min(maxDelta, Abs(delta));
            return delta > 0 ? current + min : current - min;
        }

        public static double MoveTowards(double current, double target, double maxDelta)
        {
            double delta = target - current;
            double min = Min(maxDelta, Abs(delta));
            return delta > 0 ? current + min : current - min;
        }

        public static float RotateTowards(float current, float target, float maxStep)
        {
            current = WrapAngle(current);
            target = WrapAngle(target);
            var delta = ((target - current + 540) % 360) - 180;
            var rotation = Clamp(delta, -maxStep, maxStep);
            return WrapAngle(current + rotation);
        }

        public static double RotateTowards(double current, double target, double maxStep)
        {
            current = WrapAngle(current);
            target = WrapAngle(target);
            var delta = ((target - current + 540) % 360) - 180;
            var rotation = Clamp(delta, -maxStep, maxStep);
            return WrapAngle(current + rotation);
        }

        public static float SmoothDampAngle(float current, float target, ref float velocity, float smoothTime, float deltaTime)
        {
            current = WrapAngle(current);
            target = WrapAngle(target);
            var delta = 180 - Abs(Abs(current - target) - 180);
            target = current + delta;
            return SmoothDamp(current, target, ref velocity, smoothTime, deltaTime);
        }

        public static double SmoothDampAngle(double current, double target, ref double velocity, double smoothTime, double deltaTime)
        {
            current = WrapAngle(current);
            target = WrapAngle(target);
            var delta = 180 - Abs(Abs(current - target) - 180);
            target = current + delta;
            return SmoothDamp(current, target, ref velocity, smoothTime, deltaTime);
        }

        private static float WrapAngle(float angle) => ((angle % 360) + 360) % 360;
        private static double WrapAngle(double angle) => ((angle % 360) + 360) % 360;
    }
}