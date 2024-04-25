using ConsoleApp2Ships.movment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships
{
    internal class Ship : IMovable
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Velocity { get; set; }
        public Ship(int _positionX, int _positionY, int velocity)
        {

        }
    }
}
