using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Field
{
    interface IShow
    {
       IField SpecificField {  get; set; }
       void Show();
    }
}
