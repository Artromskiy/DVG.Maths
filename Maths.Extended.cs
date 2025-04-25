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
    }
}