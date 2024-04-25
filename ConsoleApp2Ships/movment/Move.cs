using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.movment
{
    class Move
    {
        private IMovable movable;
        public Move(IMovable _movable)
        {
            movable = _movable;
        }

        public void move()
        {
            
        }
    }
}
