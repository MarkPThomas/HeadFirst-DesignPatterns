using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Beverages.Model;

namespace Beverages.Tests
{
    public static class BeverageTestDrive
    {
        public static void Run()
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();
        }
    }
}
