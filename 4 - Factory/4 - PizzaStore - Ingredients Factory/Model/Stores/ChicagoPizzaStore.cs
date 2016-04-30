using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model.Pizzas;
using PizzaFanchise.Model.Ingredients;

namespace PizzaFanchise.Model.Stores
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.name = "Chicago Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.name = "Chicago Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.name = "Chicago Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.name = "Chicago Style Veggie Pizza";
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
