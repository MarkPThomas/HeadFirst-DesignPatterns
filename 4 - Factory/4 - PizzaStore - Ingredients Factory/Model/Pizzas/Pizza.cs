using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model.Ingredients;

namespace PizzaFanchise.Model.Pizzas
{
    public abstract class Pizza
    {
        public string name { get; set; }

        protected Dough _dough;
        protected Sauce _sauce;
        protected Veggie[] _veggies;
        protected Cheese _cheese;
        protected Pepperoni _pepperoni;
        protected Clam _clams;


        public abstract void Prepare();
        

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
