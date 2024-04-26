﻿using ConsoleApp2Ships.Field;
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
                
                FieldSourse.SpecificField_[p.PositionY, p.PositionX] = '.';
            }
        }
    }
}
