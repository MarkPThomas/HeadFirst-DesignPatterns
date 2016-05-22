using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballInc.Model
{
    public class GumballMachine
    {
        private IState _state;

        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        public int Count { get; private set; } = 0;

        public GumballMachine(int count)
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);

            Count = count;
            if (Count > 0)
            {
                _state = NoQuarterState;
            }
            else
            {
                _state = SoldOutState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot.");
            if (Count != 0)
            {
                Count -= 1;
            }
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public override string ToString()
        {
            return "Mighty Gumball, Inc. \n" + 
                   "C#-Enabled Standing Gumball Model #2004\n" +
                   "Inventory: " + Count + " gumballs\n" + 
                   _state.ToString() + "\n";
        }
    }
}
