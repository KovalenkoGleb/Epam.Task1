using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    public class Triangle
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception();
            }
        }

        public int A
        {
            get
            {
                return this.a;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.a = value;
            }
        }

        public int B
        {
            get
            {
                return this.b;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.b = value;
            }
        }

        public int C
        {
            get
            {
                return this.c;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.c = value;
            }
        }

        public double Area
        {
            get
            {
                double p = 0.5 * (this.a + this.b + this.c);
                double s = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
                return Math.Round(s, 3);
            }
        }

        public int Perimeter
        {
            get
            {
                return this.a + this.b + this.c;
            }
        }
    }
}
