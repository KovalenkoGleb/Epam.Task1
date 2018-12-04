using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Tak3.Game
{
    public abstract class MovingObjects : ObjectsOnFiled
    {
        private bool alive = true;

        public bool IsAlive()
        {
            return this.alive;
        }

        public void Kill()
        {
            this.alive = false;
        }

        public abstract void Moving();
    }
}
