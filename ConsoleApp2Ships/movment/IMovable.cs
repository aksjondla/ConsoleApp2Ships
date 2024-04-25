using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.movment
{
    interface IMovable
    {   
        int PositionX { get; set; }
        int PositionY { get; set; }
        int Velocity { get; set; }
    }
}
