﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MightyGumballInc.Model;

namespace MightyGumballInc.Tests
{
    public class GumballMachineTestDrive
    {
        public static void Run(string[] args)
        {
            int count = 0;

            if (args.Length < 2)
            {
                Console.WriteLine("GumballMachine <name> <inventory>");
                Environment.Exit(1);
            }

            count = int.Parse(args[1]);
            GumballMachine gumballMachine = new GumballMachine(args[0], count);

            GumballMonitor monitor = new GumballMonitor(gumballMachine);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Refill(3);
            Console.WriteLine();

            Console.WriteLine(gumballMachine);
           
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();           
            gumballMachine.TurnCrank();         
            gumballMachine.EjectQuarter();
            Console.WriteLine();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            Console.WriteLine(gumballMachine);

            gumballMachine.Refill(3);

            monitor.Report();
        }
    }
}
