using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.DateExist
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter text: ");
            string inp = Console.ReadLine();
            Regex regex = new Regex(@"\d{2}-\d{2}-\d{4}");
            if (regex.IsMatch(inp))
            {
                Console.WriteLine($"Text \"${inp}\" contains date: {regex.Match(inp)}");
            }
        }
    }
}
