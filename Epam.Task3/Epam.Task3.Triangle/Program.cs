using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                int c = int.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine($"Area = {triangle.Area}{Environment.NewLine}Perimeter = {triangle.Perimeter}");

                Console.WriteLine("Enter new a: ");
                triangle.A = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new b: ");
                triangle.B = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new c: ");
                triangle.C = int.Parse(Console.ReadLine());

                Console.WriteLine($"Area = {triangle.Area}{Environment.NewLine}Perimeter = {triangle.Perimeter}");
            }
            catch
            {
                Console.WriteLine("You have entered wrong input data, no way to make the figure.");
            }
        }
    }
}
