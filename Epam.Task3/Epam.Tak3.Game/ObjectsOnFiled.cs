using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Tak3.Game
{
    public abstract class ObjectsOnFiled
    {
        private Position position;

        public Position Position
        {
            get
            {
                return this.position;
            }

            set
            {
                // the upper bound of position values should be checked in Main after the instance of the class Battlefield is created
                if (value.X < 0 || value.Y < 0) 
                {
                    throw new Exception("Object on filed position params must be >= 0");
                }
                else
                {
                    this.position = value;
                }
            }
        }
    }
}
