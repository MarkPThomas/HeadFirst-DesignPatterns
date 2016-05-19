using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkeyDucks.Model
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.fly();
            }
        }

        public void quack()
        {
            _turkey.gobble();
        }
    }
}
