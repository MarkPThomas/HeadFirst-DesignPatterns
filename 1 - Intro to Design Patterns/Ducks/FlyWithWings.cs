using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            // implements duck flying
            Console.WriteLine("I'm flying!!");
        }
    }
}
