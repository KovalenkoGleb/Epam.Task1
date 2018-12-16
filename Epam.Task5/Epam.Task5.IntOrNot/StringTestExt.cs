using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.IntOrNot
{
    public static class StringTestExt
    {
        public static bool IsInteger(this string str)
        {
            if (str.Contains('-'))
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if(char.IsSeparator(str[i]) || char.IsLetter(str[i]))
                {
                    return false;
                }
            }
        }
    }
}
