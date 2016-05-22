
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Lib;

namespace Menus.Model
{
    class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IIterator<MenuComponent> iterator = _allMenus.CreateIterator();

            // Print() is only called on MenuItems, never composites.
            // Otherwise, all menu items will be prined since the composite is composed of items that will interally recursively print themselves.
            // MenuItems are leafs, so they will only print themselves.
            Console.WriteLine("\nVEGETARIAN MENU\n------------------------");

            //do
            while(iterator.HasNext())
            {
                // Iterate through every element of the composite
                MenuComponent menuComponent = iterator.Next();
                if (menuComponent == null)
                {
                    Console.WriteLine("oops");
                }
                try
                {
                    // call each element's Vegetarian property, and if true, we call its Print() method.
                    if (menuComponent != null && menuComponent.Vegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException)
                {
                    // No action.
                    // We implemented Vegetarian() on the menus to always throw an exception.
                    // If that happens, we catch the exception, but continue our iteration.
                }
            }
        }
    }
}
