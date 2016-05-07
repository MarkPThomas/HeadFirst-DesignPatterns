using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkeyDucks.Model
{
    public class DuckAdapter : ITurkey
    {
        IDuck _duck;
        Random _chanceOfFlying;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
            _chanceOfFlying = new Random();
        }

        public void fly()
        {
            if (_chanceOfFlying.Next(5) == 0)
            {
                _duck.fly();
            }                                                            
        }

        public void gobble()
        {
            _duck.quack();
        }
    }
}
