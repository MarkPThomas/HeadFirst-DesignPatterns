using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Starbuzz.Model;

namespace Starbuzz.Tests
{
    public class StarbuzzCoffeeTester
    {
        public static void Run()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.description + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.description + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.description + " $" + beverage3.cost());

            Console.ReadKey();
        }
    }
}
