namespace DVG
{
    public static partial class Maths
    {
        public static fix Sign(fix x) => Sign(x.raw);
        public static fix Radians(fix degrees) => degrees * fix.Pi / 180;
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

        private static readonly fix _atanCoeff1 = new fix(0x00003240); // 0.1963;
        private static readonly fix _atanCoeff2 = new fix(0x0000FB50); // 0.9817
        private static readonly fix _piDiv4 = new fix(0x0000C90F); // pi / 4
        private static readonly fix _threePiDiv4 = new fix(0x00025B2F); // 3 * pi / 4

        public static fix Atan2(fix inY, fix inX)
        {
            // This code is based on http://en.wikipedia.org/wiki/User:Msiddalingaiah/Ideas#Fast_arc_tangent

            var absInY = Abs(inY);
            fix mul1 = new fix(0x00003240); // 0.1963;
            fix mul2 = new fix(0x0000FB50); // 0.9817
            fix r;
            fix piAdd;
            if (inX.raw >= 0)
            {
                r = (inX - absInY) / (inX + absInY);
                piAdd = PiDiv4;
            }
            else
            {
                r = (inX + absInY) / (absInY - inX);
                piAdd = ThreePiDiv4;
            }
            fix r3 = r * r * r;
            fix angle = (mul1 * r3) - (mul2 * r) + piAdd;
            if (inY.raw < 0)
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
