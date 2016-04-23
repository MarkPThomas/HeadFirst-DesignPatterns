using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            // implements duck quacking
            Console.WriteLine("Quack.");
        }
    }
}
