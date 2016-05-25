using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GumballClient.Model;
using GumballClient.Tests;

namespace GumballClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMonitorTestDrive.Run(args);
            Console.ReadKey();
        }
    }
}
