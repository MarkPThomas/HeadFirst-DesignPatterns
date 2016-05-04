using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControl.Model;
using RemoteControl.Tests;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlTest.Run();
            Console.ReadKey();
        }
    }
}
