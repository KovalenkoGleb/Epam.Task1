using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02
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
                Console.WriteLine("Enter r: ");
                int r = int.Parse(Console.ReadLine());

                Round round = new Round(x, y, r);
                Console.WriteLine($"Area = {round.Area}{Environment.NewLine}Circumference = {round.Circumference}");
                
                Console.WriteLine("Enter new x: ");
                round.X = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new y: ");
                round.Y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new r: ");
                round.Radius = int.Parse(Console.ReadLine());

                Console.WriteLine($"Area = {round.Area}{Environment.NewLine}Circumference = {round.Circumference}");
            }
            catch
            {
                Console.WriteLine("You have entered wrong input data, no way to make the figure.");
            }
        }
    }
}
