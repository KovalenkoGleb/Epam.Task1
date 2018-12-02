using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] ch = new char[10];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = (char)(i + 64);                
                //Console.Write(ch[i]);
            }

            Console.WriteLine();

            MyString mystring1 = new MyString("abc");
            MyString mystring2 = new MyString("bc");


           
            Console.WriteLine("abc".Contains("bc"));
            //Console.WriteLine(mystring1);
            Console.WriteLine(mystring1.Contains(mystring2));
            
        }
    }
}
