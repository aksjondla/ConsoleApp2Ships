using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Field
{
    class CreateField: ICreateField
    {
        public IField SpecificField { get; set; }
        public CreateField(IField _field)
        {
            SpecificField = _field;
        }

        public void Create()
        {
            SpecificField.SpecificField_ = new char[SpecificField.Width, SpecificField.Height];

            for (int i = 0; i < SpecificField.Width; i++)
            {
                for (int j = 0; j < SpecificField.Height; j++)
                {
                    SpecificField.SpecificField_[i, j] = '~';
                }
            }
        }
    }
}
