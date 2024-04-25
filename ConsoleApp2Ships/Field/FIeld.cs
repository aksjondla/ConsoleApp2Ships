using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Field
{
    class Field : IField
    { 
        public int Width {  get; set; }
        public int Height { get; set; }
        public char[,] SpecificField_ {  get; set; }

        public Field(int _width, int _height)
        {
            Width = _width;
            Height = _height;
        }
    }
}
