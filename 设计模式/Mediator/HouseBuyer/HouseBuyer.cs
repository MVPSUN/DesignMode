using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.HomeBuyer
{
    public abstract class HouseBuyer
    {
        public abstract string Message { get; set; }
        //  public abstract void BuyHouse(AbstractHouseMediator abstractHouseMediatorParam);
        public virtual void BuyHouse(AbstractHouseMediator abstractHouseMediatorParam)
        {
            if (abstractHouseMediatorParam != null)
            {
                abstractHouseMediatorParam.FindHouse(Message);
            }
        }
    }
}
