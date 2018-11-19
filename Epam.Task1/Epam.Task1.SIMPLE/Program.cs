using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Epam.Task1
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
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
                Console.WriteLine("Error. You should enter a positive integer number. Enter a new one: ");
                n = ReadNumber();
            }
            return n;
        }


        public static void Main(string[] args)
        {
            if (IsPrime(ReadNumber()))
                Console.WriteLine("Number is a prime number.");
            else
                Console.WriteLine("Number is not a prime number.");
        }
    }
}

