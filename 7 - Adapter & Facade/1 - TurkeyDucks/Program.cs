using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TurkeyDucks.Model;
using TurkeyDucks.Tests;

namespace TurkeyDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckTestDrive.Run();
            Console.ReadKey();
        }
    }
}
