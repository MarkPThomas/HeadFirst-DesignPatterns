using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Model
{
    public class Soy : CondimentDecorator
    {
        public override string description
        {
            get
            {
                return beverage.description + ", Soy";
            }
        }

        public Soy(Beverage beverage)
        {
            base.beverage = beverage;
        }


        public override double cost()
        {
            switch (size)
            {
                case Size.TALL:
                    return beverage.cost() + 0.10;
                case Size.GRANDE:
                    return beverage.cost() + 0.15;
                case Size.VENTI:
                    return beverage.cost() + 0.20;
                default:
                    return beverage.cost() + 0.15;
            }
        }
    }
}
