using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Lost
{
    public class Program
    {
        public static int SearchOfLast(Queue<int> roundOfPeople)
        {
            bool flag = true;
            while (roundOfPeople.Count != 1)
            {
                if (flag)
                {
                    roundOfPeople.Enqueue(roundOfPeople.Dequeue());
                    flag = !flag;
                }
                else
                {
                    roundOfPeople.Dequeue();
                    flag = !flag;
                }
            }

            return roundOfPeople.Peek();
        }

        public static void Main(string[] args)
        {
            try
            {
                Queue<int> roundOfPeople = new Queue<int>();
                Console.WriteLine("Enter n: ");
                int.TryParse(Console.ReadLine(), out int n);
                for (int i = 0; i < n; i++)
                {
                    roundOfPeople.Enqueue(i);
                }

                Console.WriteLine($"Last is {SearchOfLast(roundOfPeople)}");
            }
            catch
            {
                Console.WriteLine("Error. Wrong input");
            }
        }
    }
}
