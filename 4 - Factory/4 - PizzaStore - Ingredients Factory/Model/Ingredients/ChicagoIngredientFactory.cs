using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaFanchise.Model.Ingredients.Cheeses;
using PizzaFanchise.Model.Ingredients.Clams;
using PizzaFanchise.Model.Ingredients.Doughs;
using PizzaFanchise.Model.Ingredients.Pepperonis;
using PizzaFanchise.Model.Ingredients.Sauces;
using PizzaFanchise.Model.Ingredients.Veggies;

namespace PizzaFanchise.Model.Ingredients
{
    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Clam CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggie[] CreateVeggies()
        {
            Veggie[] veggies = { new BlackOlives(), new Spinache(), new EggPlant()};

            return veggies;
        }
    }
}
