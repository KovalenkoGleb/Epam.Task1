using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.NumberValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string inp = Console.ReadLine();
            Regex regex1 = new Regex(@"-?[0-9]+");
            Regex regex2 = new Regex(@"-?[0-9]+\.[0-9]+");
            Regex regex3 = new Regex(@"-?[0-9]+\.[0-9]+e-?[0-9]");

            if (regex1.Match(inp).ToString().Count() == inp.Count() || (regex2.Match(inp).ToString().Count() == inp.Count()))
            {
                Console.WriteLine("Conventional notation");
            }
            else if (regex3.Match(inp).ToString().Count() == inp.Count())
            {
                Console.WriteLine("Scientific notation");
            }
            else
            {
                Console.WriteLine("It is not a number");
            }
        }
    }
}