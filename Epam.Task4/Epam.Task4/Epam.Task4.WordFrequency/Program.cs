using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.WordFrequency
{
    public class Program
    {
        public static void WordFounder(string s, ref Dictionary<string, int> wordFreq)
        {
            s.ToLower();
            char[] separators = new char[2] { ' ', '.' };
            while (s.Length != 0)
            {
                int i_sep = s.IndexOfAny(separators);
                if (i_sep == -1)
                {
                    i_sep = s.Length;
                }

                if (!wordFreq.ContainsKey(s.Substring(0, i_sep)))
                {
                    if (s.Substring(0, i_sep) != " ")
                    {
                        wordFreq.Add(s.Substring(0, i_sep), 1);
                    }
                }
                else
                {
                    wordFreq[s.Substring(0, i_sep)]++;
                }

                if (i_sep >= s.Length)
                {
                    i_sep = s.Length - 1;
                }

                s = s.Remove(0, i_sep + 1);
            }
        }

        public static void Main(string[] args)
        {
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadToEnd();
            WordFounder(s, ref wordFreq);


            foreach (var item in wordFreq)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
