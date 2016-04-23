using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            // rubber duckie squeak
            Console.WriteLine("Squeak");
        }
    }
}
