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
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clam CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggie[] CreateVeggies()
        {
            Veggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };

            return veggies;
        }
    }
}
