using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model.Pizzas;
using PizzaFanchise.Model.Ingredients;

namespace PizzaFanchise.Model.Stores
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.name = "New York Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.name = "New York Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.name = "New York Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.name = "New York Style Veggie Pizza";
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
