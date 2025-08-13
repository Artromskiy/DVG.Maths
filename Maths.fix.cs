using System;

namespace DVG
{
    public static partial class Maths
    {
        private static readonly fix PiDiv4 = new fix(0x0000C90F);
        private static readonly fix ThreePiDiv4 = new fix(0x00025B2F);

        public static fix Sign(fix x) => Sign(x.raw);
        public static fix Radians(fix degrees)=> degrees * fix.Pi / 180;
        public static fix Degrees(fix radians) => radians * 180 / fix.Pi;
        public static fix Round(fix value)
        {
            int raw = value.raw;
            int half = 0x00008000;
            raw += raw >= 0 ? half : -half;
            return new fix(raw & unchecked((int)0xFFFF0000));
        }

        public static fix Abs(fix x)
        {
            // branchless implementation, see http://www.strchr.com/optimized_abs_function
            int mask = x.raw >> 31;
            return new fix((x.raw + mask) ^ mask);
        }

        public static fix Floor(fix x)
        {
            return new fix((int)((ulong)x.raw & 0xFFFF0000UL));
        }

        public static fix Ceil(fix x)
        {
            return new fix((int)
                (((ulong)x.raw & 0xFFFF0000UL) + (((ulong)x.raw & 0x0000FFFFUL) != 0UL ? (ulong)fix.One.raw : 0UL)));
        }

        public static fix Min(fix x, fix y)
        {
            return x.raw < y.raw ? x : y;
        }

        public static fix Max(fix x, fix y)
        {
            return x.raw > y.raw ? x : y;
        }

        public static fix Clamp(fix x, fix min, fix max)
        {
            return Min(Max(x, min), max);
        }

        public static fix Sqrt(fix x)
        {
            var inValue = x.raw;
            var neg = (inValue < 0);
            var num = (uint)(neg ? -inValue : inValue);
            var result = 0U;

            uint bit = (num & 0xFFF00000) != 0 ?
                (uint)1 << 30 :
                (uint)1 << 18;

            while (bit > num)
            {
                bit >>= 2;
            }

            for (var n = 0; n < 2; n++)
            {
                while (bit != 0)
                {
                    if (num >= result + bit)
                    {
                        num -= result + bit;
                        result = (result >> 1) + bit;
                    }
                    else
                    {
                        result >>= 1;
                    }
                    bit >>= 2;
                }

                if (n == 0)
                {
                    if (num > 65535)
                    {
                        num -= result;
                        num = (num << 16) - 0x8000;
                        result = (result << 16) + 0x8000;
                    }
                    else
                    {
                        num <<= 16;
                        result <<= 16;
                    }
                    bit = 1 << 14;
                }
            }

            if (num > result)
            {
                result++;
            }

            return new fix((int)(neg ? -result : result));
        }

        public static fix Sin(fix inAngle)
        {
            var tempAngle = inAngle % (fix.Pi << 1);

            if (tempAngle < fix.Zero)
                tempAngle += fix.Pi << 1;

            if (tempAngle > fix.Pi)
                tempAngle -= (fix.Pi << 1);
            else if (tempAngle < -fix.Pi)
                tempAngle += (fix.Pi << 1);

            fix tempAngleSq = tempAngle * tempAngle;

            fix tempOut;
            tempOut = (new fix(-13) * tempAngleSq) + new fix(546);
            tempOut = (tempOut * tempAngleSq) - new fix(10923);
            tempOut = (tempOut * tempAngleSq) + new fix(65536);
            tempOut = (tempOut * tempAngle);
            return tempOut;
        }

        public static fix Cos(fix inAngle)
        {
            return Sin(new fix(inAngle.raw + (fix.Pi.raw >> 1)));
        }

        public static fix Tan(fix inAngle)
        {
            return SDiv(Sin(inAngle), Cos(inAngle));
        }

        public static fix Asin(fix x)
        {
            if (x > fix.One || x < -fix.One)
                return fix.Zero;

            var rv = fix.One - (x * x);
            rv = x / Sqrt(rv);
            rv = Atan(rv);
            return rv;
        }


        public static fix Atan2(fix inY, fix inX)
        {
            // This code is based on http://en.wikipedia.org/wiki/User:Msiddalingaiah/Ideas#Fast_arc_tangent

            var absInY = Abs(inY);
            fix angle;
            if (inX >= fix.Zero)
            {
                var r = (inX - absInY) / (inX + absInY);
                var r3 = r * r * r;
                angle = (new fix(0x00003240) * r3) - (new fix(0x0000FB50) * r) + PiDiv4;
            }
            else
            {
                var r = (inX + absInY) / (absInY - inX);
                var r3 = r * r * r;
                angle = (new fix(0x00003240) * r3)
                        - (new fix(0x0000FB50) * r)
                        + ThreePiDiv4;
            }
            if (inY < fix.Zero)
            {
                angle = -angle;
            }

            return angle;
        }

        public static fix Atan(fix x)
        {
            return Atan2(x, fix.One);
        }

        public static fix Acos(fix x)
        {
            return new fix((fix.Pi.raw >> 1) - Asin(x).raw);
        }

        public static fix Lerp(fix edge0, fix edge1, fix value)
        {
            return edge0 + ((edge1 - edge0) * value);
        }

        public static fix SmoothStep(fix edge0, fix edge1, fix v)
        {
            fix x = Clamp((v - edge0) / (edge1 - edge0), 0, 1);
            return x * x * (3 - 2 * x);
        }

        public static fix Fma(fix a, fix b, fix c) => a * b + c;

        private static fix SDiv(fix inArg0, fix inArg1)
        {
            var result = inArg0 / inArg1;

            if (result == fix.MinValue)
            {
                return (inArg0 >= fix.Zero) == (inArg1 >= fix.Zero) ? fix.MaxValue : fix.MinValue;
            }

            return result;
        }
    }
}
