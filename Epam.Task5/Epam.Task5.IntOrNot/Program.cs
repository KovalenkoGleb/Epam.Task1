using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.IntOrNot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string, that you want to test: ");
            string str = Console.ReadLine();

            if (str.IsInteger())
            {
                Console.WriteLine("It is integer");
            }
            else
            {
                Console.WriteLine("It is not integer");
            }
        }
    }
}
