using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomGenerator = new Random();
            int[] array = new int[5];

            Console.Write("Original array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomGenerator.Next(-10,10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > -1)
                    sum += array[i];
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}