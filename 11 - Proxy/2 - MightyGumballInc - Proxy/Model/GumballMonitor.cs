using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballInc.Model
{
    public class GumballMonitor
    {
        private GumballMachine _machine;

        public GumballMonitor(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + _machine.Location);
            Console.WriteLine("Current Inventory: " + _machine.Count);
            Console.WriteLine("Current State: " + _machine.State);
        }
    }
}
