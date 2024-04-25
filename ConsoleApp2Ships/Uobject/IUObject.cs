using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Uobject
{
    interface IUObject
    {
        object getValue(string key);
        void setValue(string key, object value);
    }
}
