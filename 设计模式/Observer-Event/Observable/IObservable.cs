using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Event
{
    public interface IObservable
    {
        void addObserver(IObserver observer);
        void deleteObserver(IObserver observer);
        void notifyObserver(string context);
    }
}
