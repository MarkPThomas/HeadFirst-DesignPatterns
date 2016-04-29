using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Model
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string description { get; }
    }
}
