using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlTV.Tests;

namespace RemoteControlTV
{
    public class Program
    {
        static void Main(string[] args)
        {
            RemoteControlTestDrive.Run();
            Console.ReadKey();
        }
    }
}
