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
    public class CaliforniaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new GoatCheese();
        }

        public Clam CreateClams()
        {
            return new Calamari();
        }

        public Dough CreateDough()
        {
            return new VeryThinCrust();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new BruschettaSauce();
        }

        public Veggie[] CreateVeggies()
        {
            Veggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };

            return veggies;
        }
    }
}
