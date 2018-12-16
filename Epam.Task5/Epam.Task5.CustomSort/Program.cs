using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.CustomSort
{
    public class Program
    {
        public static int AgeComparator(Person x, Person y)
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

            if (x.Age > y.Age)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

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

        public static void PersonsPrinter(Person[] elements)
        {
            foreach (var item in elements)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Person[] persones = new Person[10];
            persones[0] = new Person { Name = "Asha", Age = 30 };
            persones[1] = new Person { Name = "Mic", Age = 20 };
            persones[2] = new Person { Name = "Glen", Age = 40 };
            persones[3] = new Person { Name = "Jake", Age = 32 };
            persones[4] = new Person { Name = "Bellatrix", Age = 34 };
            persones[5] = new Person { Name = "Leroy", Age = 21 };
            persones[6] = new Person { Name = "Kirill", Age = 5 };
            persones[7] = new Person { Name = "Elsa", Age = 77 };
            persones[8] = new Person { Name = "Todd", Age = 100 };
            persones[9] = new Person { Name = "Alex", Age = 17 };

            Console.WriteLine("Original list of persons for sorting:");
            PersonsPrinter(persones);

            CustomQSort(persones, 0, persones.Length - 1, AgeComparator);

            Console.WriteLine("Sorted by age list of persones:");
            PersonsPrinter(persones);
        }
    }
}
