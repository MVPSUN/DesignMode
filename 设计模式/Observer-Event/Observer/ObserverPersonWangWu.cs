﻿using Observer_Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Event
{
    public class ObserverPersonWangWu : IObserver
    {
        public void update(object sender, EventArgs observerEventArgs)
        {
            var args = (ObserverEventArgs)observerEventArgs;
            Console.WriteLine("观察者ObserverPersonWangWu:" + args.Context);
        }
    }
}
