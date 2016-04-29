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
            Console.WriteLine();

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.description + " $" + beverage2.cost());
            Console.WriteLine();

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.description + " $" + beverage3.cost());
            Console.WriteLine();

            Beverage beverage4 = new HouseBlend();
            beverage4.size = Beverage.Size.GRANDE;
            Console.WriteLine("Setting size to: {0}", beverage4.size);
            beverage4 = new Soy(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);
            Console.WriteLine(beverage4.description + " $" + beverage4.cost());
            Console.WriteLine();

            Beverage beverage5 = new HouseBlend();
            beverage5.size = Beverage.Size.TALL;
            Console.WriteLine("Setting size to: {0}", beverage5.size);
            beverage5 = new Soy(beverage5);
            beverage5 = new Mocha(beverage5);
            beverage5 = new Whip(beverage5);
            Console.WriteLine(beverage5.description + " $" + beverage5.cost());
            Console.WriteLine();

            Beverage beverage6 = new HouseBlend();
            beverage6.size = Beverage.Size.VENTI;
            Console.WriteLine("Setting size to: {0}", beverage6.size);
            beverage6 = new Soy(beverage6);
            beverage6 = new Mocha(beverage6);
            beverage6 = new Whip(beverage6);
            Console.WriteLine(beverage6.description + " $" + beverage6.cost());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
