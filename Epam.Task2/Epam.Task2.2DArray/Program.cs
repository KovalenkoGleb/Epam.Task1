using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2DArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random RandomGenerator = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = RandomGenerator.Next(10);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}