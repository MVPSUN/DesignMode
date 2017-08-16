using Mediator.HomeBuyer;
using Mediator.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //卖家
            CommodityHouse commodityHouse = new CommodityHouse();
            ResidentialHouse residentialHouse = new ResidentialHouse();
            //中介添加卖家房子信息
            AbstractHouseMediator abstractHouseMediator = new HouseMediator();
            abstractHouseMediator.AddHouse(commodityHouse);
            abstractHouseMediator.AddHouse(residentialHouse);
            //买家通过中介买房子
            HouseBuyer houseBuyer = new HouseBuyer_Commodity();
            houseBuyer.BuyHouse(abstractHouseMediator);
        }
    }
}
