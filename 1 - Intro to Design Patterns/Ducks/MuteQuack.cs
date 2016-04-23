using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            // do nothing - can't quack!
            Console.WriteLine("<< Silence >>");
        }
    }
}
