using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.movment
{
    class Position
    {
        public int PositionX {  get; set; }
        public int PositionY {  get; set; }

        public int PositionAngle { get; set; }
        public Position (int positionX, int positionY, int positionAngle)
        {
            PositionX = positionX;
            PositionY = positionY;
            PositionAngle = positionAngle;
        }
    }
}
