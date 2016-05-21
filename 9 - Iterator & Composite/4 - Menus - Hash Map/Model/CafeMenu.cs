using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class CafeMenu : IMenu
    {
        private Dictionary<string, MenuItem> _menuItems { get; } = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
                    "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                    true,
                    3.99);

            AddItem("Soup of the Day",
                    "A cup of the soup of the day, with a side salad.",
                    false,
                    3.69);

            AddItem("Burrito",
                    "A large burrito, with whole pinto beans, salsa, guacamole.",
                    true,
                    4.29);
        }

        public void AddItem(string name,
                            string description,
                            bool vegetarian,
                            double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem.Name, menuItem);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }
    }
}
