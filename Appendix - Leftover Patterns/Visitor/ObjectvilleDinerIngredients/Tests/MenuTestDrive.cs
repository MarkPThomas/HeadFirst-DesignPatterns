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
            // Create Pancake House Menu
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "BreakFast");
            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs, and toast.",
                    true,
                    2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage.",
                    false,
                    2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
                    "Pancakes made with fresh blueberries.",
                    true,
                    3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
                    "Waffles, with your choice of blueberries or strawberries.",
                    true,
                    3.59));

            // Create Diner Menu
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            dinerMenu.Add(new MenuItem("Vegetarian BLT",
                    "(Fakin') Bacon with lettuce & tomato on whole wheat.",
                    true,
                    2.99));
            dinerMenu.Add(new MenuItem("BLT",
                    "Bacon with lettuce & tomato on whole wheat.",
                    false,
                    2.99));
            dinerMenu.Add(new MenuItem("Soup of the Day",
                    "Soup of the day, with a side of potato salad.",
                    false,
                    3.29));
            dinerMenu.Add(new MenuItem("Hotdog",
                    "A hot dog with saurkraut, relish, onions, topped with cheese.",
                    false,
                    3.05));
            dinerMenu.Add(new MenuItem("Steamed Veggies and Brown Rice",
                    "Steamed vegetables over brown rice.",
                    true,
                    3.99));
            dinerMenu.Add(new MenuItem("Pasta",
                    "Spaghetti with Marinara Sauce, and a slice of sourdough bread.",
                    true,
                    3.89));

            // Create Cafe Menu
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
                    "Veggie burger on a whole wheat bun, lettuce, tomato, and fries.",
                    true,
                    3.99));
            cafeMenu.Add(new MenuItem("Soup of the Day",
                    "A cup of the soup of the day, with a side salad.",
                    false,
                    3.69));
            cafeMenu.Add(new MenuItem("Burrito",
                    "A large burrito, with whole pinto beans, salsa, guacamole.",
                    true,
                    4.29));

            // Create Dessert Menu
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert, of course!");
            dessertMenu.Add(new MenuItem("Apple Pie",
                    "Apple pie with flakey crust, topped with vanilla ice cream.",
                    true,
                    1.59));
            dessertMenu.Add(new MenuItem("Cheesecake",
                    "Creamy New York cheesecake, with a chocolate graham crust..",
                    true,
                    1.99));
            dessertMenu.Add(new MenuItem("Sorbet",
                    "A scoop of raspberry and a scoop of lime.",
                    true,
                    1.89));

            // Combine Menus
            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined.");

            allMenus.Add(pancakeHouseMenu);

            allMenus.Add(dinerMenu);
            dinerMenu.Add(dessertMenu);

            allMenus.Add(cafeMenu);

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();

            waitress.PrintVegetarianMenu();
        }

    }
}
