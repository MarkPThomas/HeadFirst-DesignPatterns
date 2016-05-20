
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
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(_pancakeHouseMenu);

            Console.WriteLine();

            Console.WriteLine("\nLUNCH");
            PrintMenu(_dinerMenu);
        }

        private void PrintMenu(IEnumerable<MenuItem> iterator)
        {
            foreach (MenuItem menuItem in iterator)
            {
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            }
        }
    }
}
