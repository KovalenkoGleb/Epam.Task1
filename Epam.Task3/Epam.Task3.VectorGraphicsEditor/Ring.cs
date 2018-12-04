﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Ring : Figure
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

        public override void DrawFigure()
        {
            Console.WriteLine($"Ring (A,r,R). A = ({this.inner.X}, {this.inner.Y}), r = {this.inner.Radius}, R = {this.outer.Radius}");
        }
    }
}
