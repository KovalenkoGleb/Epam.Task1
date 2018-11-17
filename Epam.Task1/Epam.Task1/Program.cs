using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1
{
    class Program
    {
        static string NtoString(int n)
        {
            string result = null;

            for (int i = 0; i < n; i++)
            {
                result += i + 1;
                if (i != n - 1)
                    result += ", ";
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(NtoString(n));
            Console.ReadKey();
        }
    }
}
