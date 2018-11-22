﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2
{
    class Program
    {
        public static int ReadNumber()
        {
            int n;            
            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 1 != 0)
                {
                    Console.WriteLine("The number should be positive and integer. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error. You should enter a positive and integer number. Enter a new one: ");
                n = ReadNumber();
            }
            return n;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = ReadNumber();

            Console.WriteLine("Enter b: ");
            int b = ReadNumber();
            Console.WriteLine($"The rectangle area is {a * b}");

        }
    }
}
