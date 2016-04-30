using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PizzaFanchise.Model.Ingredients;

namespace PizzaFanchise.Model.Pizzas
{
    class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _clams = _ingredientFactory.CreateClams();
        }
    }
}
