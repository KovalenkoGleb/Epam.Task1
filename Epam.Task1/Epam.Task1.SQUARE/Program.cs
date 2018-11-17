using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1
{
    class Program
    {
        static void PrintSquare(int n)
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
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSquare(n);
            Console.ReadKey();
        }
    }
}
