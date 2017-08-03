using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver observerPerson = new ObserverPerson();
            ObservablePerson observablePerson = new ObservablePerson();
            observablePerson.addObserver(observerPerson);
            observablePerson.haveBreakfast();
        }
    }
}
