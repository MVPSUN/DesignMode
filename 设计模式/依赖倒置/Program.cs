using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 依赖倒置.Person;
using 依赖倒置.Card;
using System.Resources;

namespace 依赖倒置
{
    class Program
    {
        static void Main(string[] args)
        {
            driver person = new driver();
            ICard card = new BcCard();
            person.Driver(card);
        }
    }
}
