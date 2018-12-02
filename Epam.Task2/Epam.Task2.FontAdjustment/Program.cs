using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.FontAdjustment
{
    public class Program
    {        
        [Flags]
        public enum FontAdjustment : byte
        {
            none = 0,
            bold = 1,
            italic = 2,
            underline = 4,
        }

        public static int ReadNumber()
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n > 3)
                {
                    Console.WriteLine("You should enter a number from 1 to 3, try again: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("You should enter a number from 1 to 3, try again: ");
                n = ReadNumber();
            }

            return n;
        }

        public static void Main(string[] args)
        {
            FontAdjustment f = 0;
            int flag = 0;
            while (true)
            {
                Console.WriteLine($"Inscription parameters: {f} {Environment.NewLine} Enter: {Environment.NewLine} " +
                    $"1: bold {Environment.NewLine} 2: italic {Environment.NewLine} 3: underline");
                flag = ReadNumber();

                switch (flag)
                {
                    case 1:
                        f ^= FontAdjustment.bold;
                        break;
                    case 2:
                        f ^= FontAdjustment.italic;
                        break;
                    case 3:
                        f ^= FontAdjustment.underline;
                        break;
                }
            }
        }
    }
}
