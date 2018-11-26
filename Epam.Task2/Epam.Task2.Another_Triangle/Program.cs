using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Another_Triangle
{
    public class Program
    {
        public static int ReadNumber()
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 1 != 0)
                {
                    Console.WriteLine("The number should be positive and integer. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error. You should enter a positive and integer number. Enter a new one: ");
                n = ReadNumber();
            }

            return n;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = ReadNumber();

            int star_number = 1;
            int space_number = (n - 1) * 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < space_number / 2; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < star_number; j++)
                {
                    Console.Write('*');
                }

                for (int j = 0; j < space_number / 2; j++)
                {
                    Console.Write(' ');
                }

                Console.WriteLine();
                space_number -= 2;
                star_number += 2;
            }
        }
    }
}
