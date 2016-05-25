using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DuckSimulator.Tests;

namespace DuckSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            DuckSimulatorTests.Run();
            Console.ReadKey();
        }
    }
}
