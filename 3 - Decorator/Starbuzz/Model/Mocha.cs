using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Model
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public override string description
        {
            get
            {
                return _beverage.description + ", Mocha";
            }
        }

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            _description = beverage.description;
        }


        public override double cost()
        {
            return _beverage.cost() + 0.20;
        }
    }
}
