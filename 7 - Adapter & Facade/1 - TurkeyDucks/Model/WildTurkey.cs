using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkeyDucks.Model
{
    public class WildTurkey : ITurkey
    {
        public void fly()
        {
            Console.WriteLine("I'm flying a short distance ...");
        }

        public void gobble()
        {
            Console.WriteLine("Gobble gobble ...");
        }
    }
}
