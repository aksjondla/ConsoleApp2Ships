using ConsoleApp2Ships.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Field
{
    class ShowField : IShow, ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public IField SpecificField {  get; set; }
        public ShowField(IField _field)
        {
            SpecificField = _field;
        }

        public void Show()
        {
            for (int i = 0; i < SpecificField.Width; i++)
            {
                for (int j = 0; j < SpecificField.Height; j++)
                {
                    Console.Write(SpecificField.SpecificField_[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Attached(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnChanget();
            }
        }
    }
}
