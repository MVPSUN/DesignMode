using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractHouse = Mediator.House.House;

namespace Mediator
{
    public abstract class AbstractHouseMediator
    {
        private AbstractHouse house;
        private List<string> houseList = new List<string>();
        public virtual void AddHouse(AbstractHouse houseParam)
        {
            house = houseParam;
            if (house != null)
            {
                houseList.Add(house.Type);
            }
        }
        // public abstract void AddHouse(AbstractHouse houseParam);
        public virtual void FindHouse(string houseType)
        {
            if (houseList.Any())
            {
                if (houseList.Contains(houseType))
                {
                    Console.WriteLine("发现你需求的房子，是否购买!");
                }

            }
        }

    }
}
