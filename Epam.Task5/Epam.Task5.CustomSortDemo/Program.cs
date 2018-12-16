using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.CustomSortDemo
{
    public class Program
    {
        public static void CustomQSort<T>(T[] elements, int left, int right, Func<T, T, int> comparator)
        {
            int i = left, j = right;
            T pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (comparator(elements[i], pivot) < 0)
                {
                    i++;
                }

                while (comparator(elements[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                CustomQSort(elements, left, j, comparator);
            }

            if (i < right)
            {
                CustomQSort(elements, i, right, comparator);
            }
        }

        public static int StringByAlphaComparator(string x, string y)
        {
            if (x.CompareTo(y) > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static int StringByLengthComparator(string x, string y)
        {
            if (ReferenceEquals(x, null))
            {
                return -1;
            }

            if (ReferenceEquals(y, null))
            {
                return 1;
            }

            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x.Length > y.Length)
            {
                return 1;
            }
            else if (x.Length < y.Length)
            {
                return -1;
            }
            else
            {
                return StringByAlphaComparator(x, y);
            }
        }

        public static void Main(string[] args)
        {
            int arrayLength = 5;
            string[] arrayOfStrings = new string[arrayLength];

            Console.WriteLine($"Enter {arrayLength} string, that you want to sort by it's length: ");
            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfStrings[i] = Console.ReadLine();
            }

            Console.WriteLine();

            CustomQSort(arrayOfStrings, 0, arrayOfStrings.Length - 1, StringByLengthComparator);
            Console.WriteLine("Sorted strings: ");
            foreach (var item in arrayOfStrings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
