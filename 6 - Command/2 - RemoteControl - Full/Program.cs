using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlAPI.Model;
using RemoteControlAPI.Tests;

namespace RemoteControlAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteLoader.Run();
            Console.ReadKey();
        }
    }
}
