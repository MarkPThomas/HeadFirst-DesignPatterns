
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
        DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu,
                        DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine();

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            }
        }
    }
}
