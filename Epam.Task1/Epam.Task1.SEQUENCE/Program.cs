using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1
{
    class Program
    {
        public static void ArrayOfnNumbers(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(i);
                if (i != n)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        public static int ReadNumber()
        {
            int n;
            Console.WriteLine("Enter a positive integer number: ");
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
            ArrayOfnNumbers(ReadNumber());
        }
    }
}
