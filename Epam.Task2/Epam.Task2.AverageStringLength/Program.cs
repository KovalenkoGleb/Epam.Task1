using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AverageStringLength
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int averageLength = 0, count = 0, temp_count = 0;
            if (str.Length != 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetter(str[i]) || char.IsNumber(str[i]))
                    {
                        temp_count++;
                    }

                    if (char.IsPunctuation(str[i]) || char.IsSeparator(str[i]) || i == str.Length - 1)
                    {
                        averageLength += temp_count;
                        count++;
                        temp_count = 0;
                    }
                }

                Console.WriteLine(averageLength / count);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
