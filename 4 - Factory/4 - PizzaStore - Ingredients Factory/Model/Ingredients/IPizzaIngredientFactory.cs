using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFanchise.Model.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggie[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clam CreateClams();
    }
}
