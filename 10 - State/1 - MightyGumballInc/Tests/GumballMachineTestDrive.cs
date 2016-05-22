using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MightyGumballInc.Model;

namespace MightyGumballInc.Tests
{
    public class GumballMachineTestDrive
    {
        public static void Run()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
        }
    }
}
