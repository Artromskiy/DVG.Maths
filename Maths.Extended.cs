namespace DVG
{
    partial class Maths
    {
        public static float SmoothDamp(float src, float trg, ref float vel, float smoothTime, float deltaTime)
        {
            float omega = 2f / smoothTime;
            float delta = src - trg;
            float x = deltaTime * omega;
            float exp = 1f / (1f + x + (x * x * ((x * 0.235f) + 0.48f)));
            float temp = (vel * deltaTime) + (x * delta);
            vel = (vel - (omega * temp)) * exp;
            float move = (delta + temp) * exp;
            bool finalized = Sign(-delta) == Sign(move);
            float final = finalized ? trg : trg + move;
            vel = finalized ? 0 : vel;
            return final;
        }

        public static float InvLerp(float a, float b, float value) => (value - a) / (b - a);
        public static double InvLerp(double a, double b, double value) => (value - a) / (b - a);

        public static float Remap(float source, float sourceFrom, float sourceTo, float targetFrom, float targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));
        public static double Remap(double source, double sourceFrom, double sourceTo, double targetFrom, double targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));

    }
}