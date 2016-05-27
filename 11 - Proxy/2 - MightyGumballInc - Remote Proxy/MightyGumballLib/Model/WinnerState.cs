using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MightyGumballLib.Model
{
    [DataContract]
    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            bool noGumballs = false;

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You've got two gumballs for your quarter.");
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                }
                else
                {
                    noGumballs = true;
                }
            }
            else
            {
                noGumballs = true;
            }

            if (noGumballs)
            {
                Console.WriteLine("Oops, out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }   
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public override string ToString()
        {
            return "Machine has dispensed an extra gumball.";
        }

        public void Refill()
        {
            // Do Nothing
        }
    }
}
