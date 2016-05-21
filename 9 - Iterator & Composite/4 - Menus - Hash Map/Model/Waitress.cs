
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    class Waitress
    {
        List<IMenu> _menus;

        public Waitress(List<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            Console.WriteLine("MENU\n----");
            foreach (IMenu item in _menus)
            {
                Console.WriteLine("\n{0}", item.GetType().Name);
                PrintMenu(item);
                Console.WriteLine();
            }
        }

        private void PrintMenu(IMenu iterator)
        {
            foreach (MenuItem menuItem in iterator)
            {
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + " -- " + menuItem.Description);
            }
        }
    }
}
