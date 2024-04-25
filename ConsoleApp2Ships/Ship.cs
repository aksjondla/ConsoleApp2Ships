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
        public int Velocity_ { get; }

        public int PositionAngle_ {  get; set; }
        public Ship(Position position)
        {
            PositionX = position.PositionX;
            PositionY = position.PositionY;
            PositionAngle_ = position.PositionAngle;
        }

        public Position GetPosition()
        {
            return new Position(PositionX, PositionY, PositionAngle_);
        }

        public void SetPosition(Position NewValue)
        {
            PositionX = NewValue.PositionX;
            PositionY = NewValue.PositionY;
            PositionAngle_ = NewValue.PositionAngle;
        }

        public int GetVelocity()
        {
            return Velocity.GetValueShip();
        }
    }
}
