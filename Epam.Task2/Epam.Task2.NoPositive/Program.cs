using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NoPositive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,,] bigArray = new int[5, 5, 5];
            Random randomGenerator = new Random();

            for (int i = 0; i < bigArray.GetLength(0); i++)
            {
                for (int j = 0; j < bigArray.GetLength(1); j++)
                {
                    for (int k = 0; k < bigArray.GetLength(2); k++)
                    {
                        bigArray[i, j, k] = randomGenerator.Next(-10, 10);
                    }
                }
            }

            for (int i = 0; i < bigArray.GetLength(0); i++)
            {
                for (int j = 0; j < bigArray.GetLength(1); j++)
                {
                    for (int k = 0; k < bigArray.GetLength(2); k++)
                    {
                        if (bigArray[i, j, k] > 0)
                        {
                            bigArray[i, j, k] = 0;                            
                        }
                    }
                }
            }

            for (int i = 0; i < bigArray.GetLength(0); i++)
            {
                for (int j = 0; j < bigArray.GetLength(1); j++)
                {
                    for (int k = 0; k < bigArray.GetLength(2); k++)
                    {
                        Console.Write($"{bigArray[i, j, k]} ");                        
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
