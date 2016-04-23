using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Tests;

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
