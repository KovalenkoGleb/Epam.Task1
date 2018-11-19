using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Epam.Task1
{
    class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;

        }


        static void Main(string[] args)
        {


            Console.WriteLine("Enter a positive integer number: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 1 != 0)
                {
                    Console.WriteLine("The number should be positive and integer. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }


                if (IsPrime(n))
                    Console.WriteLine("{0} is a prime number.", n);
                else
                    Console.WriteLine("{0} is not a prime number.", n);
            }
            catch
            {
                Console.WriteLine("Error. You should enter a positive integer number.");

            }
        }
    }
}
