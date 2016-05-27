using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MightyGumballLib.Model
{
    [DataContract]
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter.");
        }

        public override string ToString()
        {
            return "Machine is waiting for a quarter.";
        }

        public void Refill()
        {
            // Do Nothing
        }
    }
}
