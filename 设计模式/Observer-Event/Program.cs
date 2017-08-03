using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver observerPersonWangWu = new ObserverPersonWangWu();
            IObserver observerPersonZhangSan = new ObserverPersonZhangSan();
            ObservablePerson observablePerson = new ObservablePerson();
            observablePerson.addObserver(observerPersonWangWu);
            observablePerson.addObserver(observerPersonZhangSan);
            observablePerson.haveBreakfast();
        }
    }
}
