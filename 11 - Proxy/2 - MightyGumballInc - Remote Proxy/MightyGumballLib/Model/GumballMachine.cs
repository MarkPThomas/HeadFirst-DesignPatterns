using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MightyGumballLib.Model
{
    [DataContract]
    public class GumballMachine : IGumballMachineService
    {
        [DataMember]
        public IState State { get; private set; }

        [DataMember]
        public int Count { get; private set; } = 0;

        [DataMember]
        public string Location { get; private set; }

        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        
        public GumballMachine(string location, int count)
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);

            Location = location;

            Count = count;
            if (Count > 0)
            {
                State = NoQuarterState;
            }
            else
            {
                State = SoldOutState;
            }
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Inserting quarter ...");
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting quarter ...");
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning crank ...");
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot.");
            if (Count != 0)
            {
                Count -= 1;
            }
        }

        public void Refill(int count)
        {
            Console.WriteLine("Refilling gumball machine ...");
            if (Count == 0)
            {
                Count += count;
                State.Refill();
                Console.WriteLine("The gumball machine was just refilled; its new count is: " + Count);
            }
            else
            {
                Console.WriteLine("The gumball machine cannot be refilled until it is empty. Its current count is: " + Count);
            }
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public override string ToString()
        {
            return "Mighty Gumball, Inc. \n" + 
                   "C#-Enabled Standing Gumball Model #2004\n" +
                   "Inventory: " + Count + " gumballs\n" + 
                   State.ToString() + "\n";
        }
    }
}
