using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Vegetarian { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }
    }
}
