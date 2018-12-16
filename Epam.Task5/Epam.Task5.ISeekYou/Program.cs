using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ISeekYou
{
    public class Program
    {
        private static Stopwatch sw = new Stopwatch();

        public static int PositiveCount(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int PositiveCountDeledate(int[] arr, Func<int, bool> comparator)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (comparator(arr[i]))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool PositiveComparator(int val)
        {
            return val > 0;
        }

        public static void Main(string[] args)
        {
            int consta = 100;
            int[] arr = new int[1000];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
            }

            int res = 0;
            double average_time = 0;
            for (int i = 0; i < consta; i++)
            {
                sw.Reset();
                sw.Start();
                res = PositiveCount(arr);
                average_time += sw.Elapsed.TotalMilliseconds;
            }

            average_time = average_time / consta;
            Console.WriteLine($"Average time for simple search is {average_time}");
            average_time = 0;

            for (int i = 0; i < consta; i++)
            {
                sw.Reset();
                sw.Start();
                res = PositiveCountDeledate(arr, PositiveComparator);
                average_time += sw.Elapsed.TotalMilliseconds;
            }

            average_time = average_time / consta;
            Console.WriteLine($"Average time for search that using instance delegate is {average_time}");
            average_time = 0;

            for (int i = 0; i < consta; i++)
            {
                sw.Reset();
                sw.Start();
                res = PositiveCountDeledate(arr, delegate(int num) { return num > 0; });
                average_time += sw.Elapsed.TotalMilliseconds;
            }

            average_time = average_time / consta;
            Console.WriteLine($"Average time for search that using anonymous method is {average_time}");
            average_time = 0;

            for (int i = 0; i < consta; i++)
            {
                sw.Reset();
                sw.Start();
                res = PositiveCountDeledate(arr, n => n > 0);
                average_time += sw.Elapsed.TotalMilliseconds;
            }

            average_time = average_time / consta;
            Console.WriteLine($"Average time for search that using lambda expression is {average_time}");
            average_time = 0;

            for (int i = 0; i < consta; i++)
            {
                sw.Reset();
                sw.Start();
                res = arr.Count(n => n > 0);
                average_time += sw.Elapsed.TotalMilliseconds;
            }

            average_time = average_time / consta;
            Console.WriteLine($"Average time for search that using LINQ is {average_time}");
        }
    }
}
