using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Field
{
    interface IField
    {
        int Width { get; set; }
        int Height { get; set; }
        char[,] SpecificField_ {  get; set; }
    }
}
