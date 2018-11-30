using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02
{
    public class Round
    {
        private int x;
        private int y;
        private int r;

        public Round(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            if (r < 0)
            {
                throw new Exception();
            }

            this.r = r;
        }

        public int Radius
        {
            get
            {
                return this.r;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.r = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public double Circumference
        {
            get
            {
                if (this.r >= 0)
                {
                    return Math.Round(Math.PI * 2 * this.r, 3);
                }
                else
                {
                    Console.WriteLine("There is no figure to find it's Circumference.");
                    return -1;
                }
            }
        }

        public double Area
        {
            get
            {
                if (this.r >= 0)
                {
                    return Math.Round(Math.PI * this.r * this.r, 3);
                }
                else
                {
                    Console.WriteLine("There is no figure to find it's Area.");
                    return -1;
                }
            }
        }
    }
}
