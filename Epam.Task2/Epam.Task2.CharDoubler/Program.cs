using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.CharDoubler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter second string: ");
            string str2 = Console.ReadLine();

            var sbuilder = new StringBuilder();

            for (int i = 0; i < str1.Length; i++)
            {
                sbuilder.Append(str1[i]);
                if (str2.Contains(str1[i]))
                {
                    sbuilder.Append(str1[i]);
                }
            }

            Console.WriteLine(sbuilder.ToString());
        }
    }
}
