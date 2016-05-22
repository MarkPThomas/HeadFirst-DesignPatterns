using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Lib;

namespace Menus.Model
{
    public class MenuItem : MenuComponent
    {
        public override string Name { get { return _name; } }
        public override string Description { get { return _description; } }
        public override bool Vegetarian { get { return _vegetarian; } }
        public override double Price { get { return _price; } }

        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override void Print()
        {
            string message = "  " + Name;
            if (Vegetarian) { message += "(v)"; }
            message += ", " + Price + "\n     -- " + Description;

            Console.WriteLine(message);
        }

        public override IIterator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }
    }
}
