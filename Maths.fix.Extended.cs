using System.Runtime.CompilerServices;

namespace DVG
{
    public static partial class Maths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix SmoothDamp(fix current, fix target, ref fix velocity, fix smoothTime, fix deltaTime)
        {
            fix omega = 2 / smoothTime;
            fix delta = current - target;
            fix x = deltaTime * omega;
            fix exp = 1 / (1 + x + (x * x * ((x * new fix(15401)) + new fix(31457))));
            fix temp = (velocity * deltaTime) + (x * delta);
            velocity = (velocity - (omega * temp)) * exp;
            fix move = (delta + temp) * exp;
            bool stillMoving = Sign(delta) == Sign(move);
            fix final = stillMoving ? target + move : target;
            velocity = stillMoving ? velocity : 0;
            return final;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix InvLerp(fix edge0, fix edge1, fix value) => (value - edge0) / (edge1 - edge0);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix Remap(fix source, fix sourceFrom, fix sourceTo, fix targetFrom, fix targetTo) => targetFrom + ((source - sourceFrom) * (targetTo - targetFrom) / (sourceTo - sourceFrom));
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix MoveTowards(fix current, fix target, fix maxDelta)
        {
            var delta = Clamp(target - current, -maxDelta, maxDelta);
            return current + delta;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix RotateTowards(fix current, fix target, fix maxStep)
        {
            var delta = DeltaAngle(current, target);
            target = current + delta;
            return MoveTowards(current, target, maxStep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix SmoothDampAngle(fix current, fix target, ref fix velocity, fix smoothTime, fix deltaTime)
        {
            var delta = DeltaAngle(current, target);
            target = current + delta;
            return SmoothDamp(current, target, ref velocity, smoothTime, deltaTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix DeltaAngle(fix current, fix target)
        {
            var num = Repeat(target - current, 360);
            return num > 180 ? num - 360 : num;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fix Repeat(fix t, fix length) => Clamp(t - (Floor(t / length) * length), 0, length);
    }
}
