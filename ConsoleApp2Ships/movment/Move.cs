using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.movment
{
    class Move : ICommand
    {
        private IMovable movable;
        public Move(IMovable _movable)
        {
            movable = _movable;
        }

        public void Execute()
        {
            Position p = movable.GetPosition();
            switch (p.PositionAngle)
            {
                case 0:
                    movable.SetPosition(new Position(p.PositionX, p.PositionY-1, p.PositionAngle));
                    break;
                case 1:
                    movable.SetPosition(new Position(p.PositionX, p.PositionY+1, p.PositionAngle));
                    break;
                case 2:
                    movable.SetPosition(new Position(p.PositionX + 1, p.PositionY, p.PositionAngle));
                    break;
                case 3:
                    movable.SetPosition(new Position(p.PositionX - 1, p.PositionY, p.PositionAngle));
                    break;
                default:

                    break;
            }
        }
    }
}
