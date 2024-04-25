using ConsoleApp2Ships.Field;
using ConsoleApp2Ships.movment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships
{
    class AIMovment
    {
        public List<IMovable> movables;
        public IField FieldServer;

        public AIMovment(List<IMovable> movables, IField _FieldServer)
        {
            this.movables = movables;;
            FieldServer = _FieldServer;
        }

        public void AIComand()
        {
            foreach (var item in movables)
            {
                Position p = item.GetPosition();
                switch (p.PositionAngle)
                {
                    case 0:
                        if ( (p.PositionY - 1) < 0)
                        {
                            Random rnd = new Random();
                            int result = rnd.Next(0, 3);
                            if (result >= p.PositionAngle)
                            {
                                result++;
                            }
                            p.PositionAngle = result;
                        }
                        break;
                    case 1:
                        if (p.PositionY == FieldServer.Height)
                        {
                            Random rnd = new Random();
                            int result = rnd.Next(0, 3);
                            if (result >= p.PositionAngle)
                            {
                                result++;
                            }
                            p.PositionAngle = result;
                        }
                        break;
                    case 2:

                        if (p.PositionX == FieldServer.Width)
                        {
                            Random rnd = new Random();
                            int result = rnd.Next(0, 3);
                            if (result >= p.PositionAngle)
                            {
                                result++;
                            }
                            p.PositionAngle = result;
                        }
                        
                        break;
                    case 3:
                        if ((p.PositionX - 1) < 0)
                        {
                            Random rnd = new Random();
                            int result = rnd.Next(0, 3);
                            if (result >= p.PositionAngle)
                            {
                                result++;
                            }
                            p.PositionAngle = result;
                        }
                        break;
                    default:

                        break;
                }
                item.SetPosition(p);
                var move = new Move(item);
                move.move();
            }
        }
    }
}
