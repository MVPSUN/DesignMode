using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖倒置.Card
{
    public class BcCard : ICard
    {
        public void Run()
        {
            Console.WriteLine("BcRun");
        }
    }
}
