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

            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Ejecting quarter ...");
            gumballMachine.EjectQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();
            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();
            Console.WriteLine("Ejecting quarter ...");
            gumballMachine.EjectQuarter();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();
            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();
            Console.WriteLine("Inserting quarter ...");
            gumballMachine.InsertQuarter();
            Console.WriteLine("Turning crank ...");
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
        }
    }
}
