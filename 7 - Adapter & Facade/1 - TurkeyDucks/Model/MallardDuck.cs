using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkeyDucks.Model
{
    public class MallardDuck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
