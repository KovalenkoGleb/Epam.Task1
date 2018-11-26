using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ArrayProcessing
{
    public class Program
    {
        public static void ArraySort(ref int[] array)
        {
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(50);
            int[] array = new int[5];

            Console.Write("Original array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(50);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Console.Write("Sorted array: ");
            ArraySort(ref array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Maximum = {array[0]}{Environment.NewLine}Minimum = {array[array.Length - 1]}");
        }
    }
}
