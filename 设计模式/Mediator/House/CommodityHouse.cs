using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.House
{
    public class CommodityHouse : House
    {
        private string _Type = "商品房";
        public override string Type
        {
            get
            {
                return _Type;
            }
        }
    }
}
