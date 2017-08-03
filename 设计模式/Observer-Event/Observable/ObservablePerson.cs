using Observer_Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Event
{
    public class ObservablePerson : IObservable
    {
        public delegate void observerEvent(object sender, EventArgs ObserverEventArgs);
        public event observerEvent observerEventHandler;

        public void addObserver(IObserver observer)
        {
            observerEventHandler += new observerEvent(observer.update);
        }
        public void deleteObserver(IObserver observer)
        {
            observerEventHandler -= new observerEvent(observer.update);
        }

        public void notifyObserver(string context)
        {
            if (observerEventHandler != null)
            {
                observerEventHandler(this, new ObserverEventArgs(context));
            }
        }
        public void haveBreakfast()
        {
            Console.WriteLine("被观察的敌人在吃饭!");
            this.notifyObserver("卧底通知：被观察的敌人在吃饭!");
        }
    }
}
