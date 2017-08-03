using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Event
{
    public class ObserverEventArgs : EventArgs
    {
        private string keyChar;
        public ObserverEventArgs(string keyChar) : base()
        {
            this.keyChar = keyChar;
        }

        public string Context
        {
            get
            {
                return keyChar;
            }
        }
    }
}
