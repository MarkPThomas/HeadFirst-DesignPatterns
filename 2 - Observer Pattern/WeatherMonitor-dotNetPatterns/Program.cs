using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Tests;

// See: https://msdn.microsoft.com/en-us/library/ee850490(v=vs.110).aspx

namespace WeatherMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation.Run();
            Console.ReadKey();
        }
    }
}
