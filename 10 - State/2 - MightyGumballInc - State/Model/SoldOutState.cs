using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballInc.Model
{
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs.");
        }

        public override string ToString()
        {
            return "Machine is sold out.";
        }

        public void Refill()
        {           
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }
    }
}
