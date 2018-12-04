using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Tak3.Game
{
    public abstract class StaticObjects : ObjectsOnFiled
    {
        private bool presence = true;

        public bool IsOnField()
        {
            return this.presence;
        }

        protected void DeleteFromField()
        {
            this.presence = false;
        }
    }
}
