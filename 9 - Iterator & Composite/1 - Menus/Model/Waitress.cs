
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    class Waitress
    {
        PancakeHouseMenu _pancakeHouseMenu;
        List<MenuItem> _breakfastItems;

        DinerMenu _dinerMenu;
        MenuItem[] _lunchItems;

        public Waitress(PancakeHouseMenu pancakeHouseMenu,
                        DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;

            _breakfastItems = _pancakeHouseMenu.MenuItems;
            _lunchItems = _dinerMenu.MenuItems;
        }

        public void PrintMenu()
        {
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintDinerMenu();

            Console.WriteLine();

            Console.WriteLine("\nLUNCH");
            PrintLunchMenu();
        }

        private void PrintDinerMenu()
        {
            for (int i = 0; i < _breakfastItems.Count; i++)
            {
                MenuItem menuItem = _breakfastItems[i];
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            }

            //// Alternatively ...
            //foreach (MenuItem menuItem in _lunchItems)
            //{
            //if (menuItem != null)
            //{
            //   Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            //}
            //}
        }

        private void PrintLunchMenu()
        {
            for (int i = 0; i < _lunchItems.Length; i++)
            {
                MenuItem menuItem = _lunchItems[i];

                if (menuItem != null)
                {
                    Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
                }  
            }

            //// Alternatively ...
            //foreach (MenuItem menuItem in _lunchItems)
            //{
            //if (menuItem != null)
            //{
            //    Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            //}
            //}
        }
    }
}
