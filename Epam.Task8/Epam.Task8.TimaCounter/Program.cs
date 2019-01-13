using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.TimaCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string inp = Console.ReadLine();
            Regex regex1 = new Regex(@"0?[0-9]\:[0-5][0-9]");
            Regex regex2 = new Regex(@"1[0-9]\:[0-5][0-9]");
            Regex regex3 = new Regex(@"2[0-3]\:[0-5][0-9]");

            int count = regex1.Matches(inp).Count + regex2.Matches(inp).Count + regex3.Matches(inp).Count;
            Console.WriteLine($"There are {count} times in text.");
            
        }
    }
}
