using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFanchise.Model
{
    public abstract class Pizza
    {
        protected string _dough;
        protected string _sauce;
        protected List<string> _toppings = new List<string>();

        protected string _name;
        public string name { get { return _name; } }


        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");

            foreach (string topping in _toppings)
            {
                Console.WriteLine("     " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 F.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in offical PizzaStore box.");
        }
    }
}
