using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Ships.Observer
{
    interface ISubject
    {
        void Attached(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
