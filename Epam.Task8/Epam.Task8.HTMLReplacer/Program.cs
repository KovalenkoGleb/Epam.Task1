using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.HTMLReplacer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string inp = Console.ReadLine();
            Regex regex = new Regex(@"(<([^>]+)>)");

            var result = regex.Replace(inp, "_");
            Console.WriteLine($"Result: {result}");
        }
    }
}
