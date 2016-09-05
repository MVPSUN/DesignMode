using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖倒置.Person
{
    public class driver
    {
        public void Driver(ICard card)
        {
            Console.WriteLine("准备开车。");
            card.Run();
        }
    }
}
