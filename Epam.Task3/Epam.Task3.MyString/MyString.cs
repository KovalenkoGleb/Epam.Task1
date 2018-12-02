using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
    public class MyString
    {
        private char[] chars = new char[0];

        public char this[int id]
        {
            get
            {
                return chars[id];
            }

            set
            {
                chars[id] = value;
            }
        }

        public MyString()
        {
            this.chars = new char[16];
        }

        public MyString(int newlength)
        {
            this.chars = new char[newlength];
        }

        public MyString(char[] charmas)
        {
            this.chars = new char[charmas.Length];

            for (int i = 0; i < charmas.Length; i++)
            {
                this.chars[i] = charmas[i];
            }
        }

        public MyString(string str)
        {
            chars = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                this.chars[i] = str[i];
            }
        }

        public int Length
        {
            get
            {
                return this.chars.Length;
            }
        }

        public static int Compare(MyString a, MyString b)
        {
            int minLength = Math.Min(a.Length, b.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (a[i] > b[i])
                    return 1;
                if (a[i] < b[i])
                    return -1;
            }
            if (a.Length < b.Length)
            {
                return -1;
            }
            if (a.Length > b.Length)
            {
                return 1;
            }
            return 0;
        }

        public static MyString Concat(MyString a, MyString b)
        {
            MyString temp = new MyString(a.Length + b.Length);

            for (int i = 0; i < a.Length; i++)
            {

                temp[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                temp[i + a.Length] = b[i];
            }

            return temp;
        }

        public bool Contains(MyString b)
        {
            for (int i = 0; i < this.Length - b.Length+1; i++) //проверить работоспособность
            {
                bool result = true;
                for (int j = i; j < b.Length; j++)
                {
                    if (chars[j] != b[j - i])
                    {
                        result = false;
                        break;
                    }
                }
                if(result)
                {
                    return result;
                }
            }
            return false;
            
        }

        public override string ToString()
        {
            var strbuild = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
            {
                strbuild.Append(chars[i]);
            }
            return strbuild.ToString();
        }
    }
}
