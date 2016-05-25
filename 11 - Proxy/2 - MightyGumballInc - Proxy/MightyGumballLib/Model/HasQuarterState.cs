using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MightyGumballInc.Model
{
    [DataContract]
    public class HasQuarterState : IState
    {
        private Random _randomWinner = new Random(DateTime.Now.Millisecond);
        private GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned.");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned ...");

            int winner = _randomWinner.Next(10);
            if ((winner == 0) && (_gumballMachine.Count > 1))
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }

        public override string ToString()
        {
            return "Machine is waiting for crank to be pulled.";
        }

        public void Refill()
        {
            // Do Nothing
        }
    }
}
