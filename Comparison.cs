using System;

namespace DVG
{
    public static class Comparison
    {
        public static int Combine<T1, T2>(
            T1 t11, T2 t21,
            T1 t12, T2 t22)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
        {
            int result = t11.CompareTo(t12);
            if (result != 0) return result;

            result = t21.CompareTo(t22);
            if (result != 0) return result;

            return 0;
        }

        public static int Combine<T1, T2, T3>(
            T1 t11, T2 t21, T3 t31,
            T1 t12, T2 t22, T3 t32)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
        {
            int result = t11.CompareTo(t12);
            if (result != 0) return result;

            result = t21.CompareTo(t22);
            if (result != 0) return result;

            result = t31.CompareTo(t32);
            if (result != 0) return result;

            return 0;
        }

        public static int Combine<T1, T2, T3, T4>(
            T1 t11, T2 t21, T3 t31, T4 t41,
            T1 t12, T2 t22, T3 t32, T4 t42)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
        {
            int result = t11.CompareTo(t12);
            if (result != 0) return result;

            result = t21.CompareTo(t22);
            if (result != 0) return result;

            result = t31.CompareTo(t32);
            if (result != 0) return result;

            result = t41.CompareTo(t42);
            if (result != 0) return result;

            return 0;
        }
    }
}
