using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Model;

namespace Menus.Tests
{
    public class MenuTestDrive
    {
        public static void Run()
        {
            List<IMenu> menus = new List<IMenu>() {new PancakeHouseMenu(),
                                                   new DinerMenu(),
                                                   new CafeMenu()};

            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }

    }
}
