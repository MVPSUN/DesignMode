using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObserverPerson : IObserver
    {
        public void update(string context)
        {
            Console.WriteLine("观察者收到卧底发来的消息!");
        }
    }
}
