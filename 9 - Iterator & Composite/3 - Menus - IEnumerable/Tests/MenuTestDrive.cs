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
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }

    }
}
