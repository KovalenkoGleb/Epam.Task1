using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.NumberArraySum
{
    public static class NumberArraySumExt
    {
        public static int Sum(this int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static double Sum(this double[] mas)
        {
            double sum = 0.0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static float Sum(this float[] mas)
        {
            float sum = 0.0F;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static byte Sum(this byte[] mas)
        {
            byte sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static sbyte Sum(this sbyte[] mas)
        {
            sbyte sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static short Sum(this short[] mas)
        {
            short sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static ushort Sum(this ushort[] mas)
        {
            ushort sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static uint Sum(this uint[] mas)
        {
            uint sum = 0U;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static long Sum(this long[] mas)
        {
            long sum = 0L;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static ulong Sum(this ulong[] mas)
        {
            ulong sum = 0UL;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        public static decimal Sum(this decimal[] mas)
        {
            decimal sum = 0.0M;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            return sum;
        }
    }
}
