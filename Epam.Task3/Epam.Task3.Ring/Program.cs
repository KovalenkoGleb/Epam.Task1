using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter x: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter inner r: ");
                int r1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter outer r: ");
                int r2 = int.Parse(Console.ReadLine());

                Ring ring = new Ring(x, y, r1, r2);

                Console.WriteLine($"Area = {ring.Area}{Environment.NewLine}Circumference = {ring.Circumference}{Environment.NewLine}");
            }
            catch
            {
                Console.WriteLine("Incorrect input data");
            }
        }
    }
}
