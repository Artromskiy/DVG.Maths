namespace DVG
{
    partial class Maths
    {
        public static float SmoothDamp(float source, float target, ref float velocity, float smoothTime, float deltaTime)
        {
            float omega = 2f / smoothTime;
            float delta = source - target;
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

        public static double SmoothDamp(double source, double target, ref double velocity, double smoothTime, double deltaTime)
        {
            double omega = 2.0 / smoothTime;
            double delta = source - target;
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

        public static float InvLerp(float a, float b, float value) => (value - a) / (b - a);
        public static double InvLerp(double a, double b, double value) => (value - a) / (b - a);

        public static float Remap(float source, float sourceFrom, float sourceTo, float targetFrom, float targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));
        public static double Remap(double source, double sourceFrom, double sourceTo, double targetFrom, double targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));

    }
}