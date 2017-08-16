using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.House
{
    public class ResidentialHouse : House
    {
        public string _Type = "住宅房";
        public override string Type
        {
            get
            {
                return _Type;
            }
        }
    }
}
