using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.HomeBuyer
{
    public class HouseBuyer_Commodity : HouseBuyer
    {
        private string _Message = "商品房";
        public override string Message { get { return _Message; } set { _Message = value; } }
        //public override void BuyHouse(AbstractHouseMediator abstractHouseMediatorParam)
        //{
        //    if (abstractHouseMediatorParam != null)
        //    {
        //        abstractHouseMediatorParam.FindHouse(Message);
        //    }
        //}
    }
}
