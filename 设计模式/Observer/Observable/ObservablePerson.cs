using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObservablePerson : IObservable
    {
        private List<IObserver> observerList = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            observerList.Add(observer);
        }
        public void deleteObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void notifyObserver(string context)
        {
            foreach (var observer in observerList)
            {
                observer.update(context);
            }
        }
        public void haveBreakfast()
        {
            Console.WriteLine("被观察的敌人在吃饭!");
            this.notifyObserver("卧底通知：被观察的敌人在吃饭!");
        }
    }
}
