using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Model
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";
        public virtual string description { get { return _description; } }


        public Beverage()
        {
        
        }

        public abstract double cost();
    }
}
