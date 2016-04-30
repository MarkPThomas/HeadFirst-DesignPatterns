using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model;
using PizzaFanchise.Tests;

namespace PizzaFanchise
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTestDrive.Run();

            Console.ReadKey();
        }
    }
}
