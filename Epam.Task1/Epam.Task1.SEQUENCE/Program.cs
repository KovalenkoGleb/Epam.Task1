using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1
{
    class Program
    {
        static void ArrayOfnNumbers(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(i);
                if (i != n)
                    Console.Write(", ");
            }
            Console.WriteLine();// Если не написать, то при дебаге "Нажмите на любую клавишу выводится в ту же строку, что некрасиво
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
                ArrayOfnNumbers(n);
            }
            catch 
            {
                Console.WriteLine("Error. You should enter a positive and integer number.");
                
            }
        }
    }
}
