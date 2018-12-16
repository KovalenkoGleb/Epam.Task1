using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.NumberArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 5;
            Random random = new Random();
            Console.WriteLine($"Sum calculator for array of numbers{Environment.NewLine}");

            Console.WriteLine("Integer array: ");
            int[] intmas = new int[count];
            for (int i = 0; i < intmas.Length; i++)
            {
                intmas[i] = random.Next(10);
                Console.Write($"{intmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {intmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("Double array: ");
            double[] doublemas = new double[count];
            for (int i = 0; i < doublemas.Length; i++)
            {
                doublemas[i] = (double)random.Next(10);
                Console.Write($"{doublemas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {doublemas.Sum()}{Environment.NewLine}");

            Console.WriteLine("Float array: ");
            float[] floatmas = new float[count];
            for (int i = 0; i < floatmas.Length; i++)
            {
                floatmas[i] = (float)random.Next(10);
                Console.Write($"{floatmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {floatmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("Byte array: ");
            byte[] bytemas = new byte[count];
            for (int i = 0; i < bytemas.Length; i++)
            {
                bytemas[i] = (byte)random.Next(10);
                Console.Write($"{bytemas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {bytemas.Sum()}{Environment.NewLine}");

            Console.WriteLine("Sbyte array: ");
            sbyte[] sbytemas = new sbyte[count];
            for (int i = 0; i < sbytemas.Length; i++)
            {
                sbytemas[i] = (sbyte)random.Next(10);
                Console.Write($"{sbytemas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {sbytemas.Sum()}{Environment.NewLine}");

            Console.WriteLine("Short array: ");
            short[] shortmas = new short[count];
            for (int i = 0; i < shortmas.Length; i++)
            {
                shortmas[i] = (short)random.Next(10);
                Console.Write($"{shortmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {shortmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("Ushort array: ");
            ushort[] ushortmas = new ushort[count];
            for (int i = 0; i < ushortmas.Length; i++)
            {
                ushortmas[i] = (ushort)random.Next(10);
                Console.Write($"{ushortmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {ushortmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("uint array: ");
            uint[] uintmas = new uint[count];
            for (int i = 0; i < uintmas.Length; i++)
            {
                uintmas[i] = (uint)random.Next(10);
                Console.Write($"{uintmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {uintmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("long array: ");
            long[] longmas = new long[count];
            for (int i = 0; i < longmas.Length; i++)
            {
                longmas[i] = (long)random.Next(10);
                Console.Write($"{longmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {longmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("ulong array: ");
            ulong[] ulongmas = new ulong[count];
            for (int i = 0; i < ulongmas.Length; i++)
            {
                ulongmas[i] = (ulong)random.Next(10);
                Console.Write($"{ulongmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {ulongmas.Sum()}{Environment.NewLine}");

            Console.WriteLine("decimal array: ");
            decimal[] decimalmas = new decimal[count];
            for (int i = 0; i < decimalmas.Length; i++)
            {
                decimalmas[i] = (decimal)random.Next(10);
                Console.Write($"{decimalmas[i]} ");
            }

            Console.WriteLine($"{Environment.NewLine}Array sum = {decimalmas.Sum()}{Environment.NewLine}");
        }
    }
}
