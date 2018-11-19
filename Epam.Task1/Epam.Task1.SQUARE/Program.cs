using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1
{
    class Program
    {
        public static void PrintSquare(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i == j && i == n / 2)
                        Console.Write(' ');
                    else
                        Console.Write('*');
                Console.WriteLine();
            }
        }

        public static int ReadNumber()
        {
            int n;
            Console.WriteLine("Enter a positive odd integer number: ");
            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 2 == 0 || n % 1 != 0)
                {
                    Console.WriteLine("The number should be positive, odd and integer. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error. You should enter a positive, odd and integer number. Enter a new one: ");
                n = ReadNumber();
            }
            return n;
        }


        public static void Main(string[] args)
        {
            PrintSquare(ReadNumber());
        }
    }
}
