using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.EmailFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string inp = Console.ReadLine();
            Regex regex = new Regex(@"[0-9a-zA-Z][a-zA-Z0-9_\.-][0-9a-zA-Z]+\@[a-zA-Z]{2,6}\.[0-9a-zA-Z-\.]+");

            Console.WriteLine("Email adresses:");
            foreach (var item in regex.Matches(inp))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
