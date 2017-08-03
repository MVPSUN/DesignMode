using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Event
{
   public interface IObserver
    {
        void update(object sender, EventArgs ObserverEventArgs);
    }
}
