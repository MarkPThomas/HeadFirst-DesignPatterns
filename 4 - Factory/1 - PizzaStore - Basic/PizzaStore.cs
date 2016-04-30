using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaStore
    {
        public PizzaStore()
        {
           
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            // Problem is that this needs to be modified every time a new pizza class is created.
            // Modified here and anywhere else that instantiates a pizza class.
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                default:
                    pizza = new CrustPizza();
                    break;
            }
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
