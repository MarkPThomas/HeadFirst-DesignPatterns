using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFanchise.Model
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
