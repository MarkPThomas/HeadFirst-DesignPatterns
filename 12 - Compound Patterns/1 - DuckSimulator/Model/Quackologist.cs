using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    public class Quackologist : IQuackObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just quacked");
        }
    }
}
