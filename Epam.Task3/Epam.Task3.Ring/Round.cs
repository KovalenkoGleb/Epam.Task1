using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
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

        public Round()
        {
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
                return Math.Round(Math.PI * 2 * this.r, 3);
            }
        }

        public double Area
        {
            get
            {
                return Math.Round(Math.PI * this.r * this.r, 3);
            }
        }
    }
}
