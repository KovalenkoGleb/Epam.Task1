using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Ring : Round
    {
        private Round inner;
        private Round outer;

        public Ring(int x, int y, int in_Rad, int out_Rad)
        {
            if (out_Rad < in_Rad)
            {
                throw new Exception();
            }

            this.inner = new Round(x, y, in_Rad);
            this.outer = new Round(x, y, out_Rad);
        }

        public new double Area
        {
            get
            {
                return this.outer.Area - this.inner.Area;
            }
        }

        public new double Circumference
        {
            get
            {
                return this.outer.Circumference + this.inner.Circumference;
            }
        }
    }
}
