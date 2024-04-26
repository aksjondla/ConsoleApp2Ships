using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.movment
{
    class Rotable
    {
        public IMovable obj;

        public Rotable (IMovable obj)
        {
            this.obj = obj;
        }

        public void Auto()
        {
            var o = obj.GetPosition();
        }
    }
}
