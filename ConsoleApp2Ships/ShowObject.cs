using ConsoleApp2Ships.Field;
using ConsoleApp2Ships.movment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships
{
    class ShowObject
    {
        public List<IMovable> obj;
        public IField FieldSourse;

        public ShowObject(List<IMovable> o, IField fieldSourse)
        {
            obj = o;
            FieldSourse = fieldSourse;
        }

        public void ShowObj()
        {
            foreach (var item in obj)
            {
                var p = item.GetPosition();

                if ((p.PositionY == FieldSourse.Width) || (p.PositionY > (FieldSourse.Width - 1)))
                {
                    p.PositionY = p.PositionY - 1;
                }
                if (p.PositionY < 0)
                {
                    p.PositionY = p.PositionY + 1;
                }
                if ((p.PositionX == FieldSourse.Height) || (p.PositionX > FieldSourse.Height))
                {
                    p.PositionX = p.PositionX - 1;
                }
                if (p.PositionX < 0)
                {
                    p.PositionX = p.PositionX + 1;
                }
                FieldSourse.SpecificField_[p.PositionY, p.PositionX] = '.';
            }
        }
    }
}
