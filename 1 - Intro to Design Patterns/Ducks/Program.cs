using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ducks.Tests;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniDuckSimulator.Run(args);

            Console.ReadKey();
        }
    }
}
