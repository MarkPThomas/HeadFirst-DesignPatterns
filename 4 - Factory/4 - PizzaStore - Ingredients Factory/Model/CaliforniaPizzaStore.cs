using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFanchise.Model
{
    class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CaliforniaStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new CaliforniaStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new CaliforniaStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new CaliforniaStyleVeggiePizza();
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
