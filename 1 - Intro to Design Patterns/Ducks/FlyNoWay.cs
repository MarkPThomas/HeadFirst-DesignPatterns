using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            // do nothing - can't fly!
            Console.WriteLine("I can't fly.");
        }
    }
}
