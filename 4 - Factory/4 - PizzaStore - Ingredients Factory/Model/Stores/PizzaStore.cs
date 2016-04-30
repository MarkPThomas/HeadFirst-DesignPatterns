using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model.Pizzas;

namespace PizzaFanchise.Model.Stores
{
    public abstract class PizzaStore
    {
        
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
