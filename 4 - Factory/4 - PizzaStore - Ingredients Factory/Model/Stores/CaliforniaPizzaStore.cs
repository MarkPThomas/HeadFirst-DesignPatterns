using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model.Pizzas;
using PizzaFanchise.Model.Ingredients;

namespace PizzaFanchise.Model.Stores
{
    class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new CaliforniaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.name = "California Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.name = "California Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.name = "California Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.name = "California Style Veggie Pizza";
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
