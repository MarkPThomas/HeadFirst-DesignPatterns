using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectvilleDinerIngredients.Model
{
    public class Visitor : IVisitor
    {
        public void VisitIngredients(IIngredient ingredient)
        {
            if (ingredient.HealthRating == HealthRating.NotRated || 
                ingredient.Calories == 0) { return; }

            string padding = "";
            if (string.IsNullOrEmpty(ingredient.IngredientName))
            {
                Console.WriteLine("--- Item {0} ---", ingredient.GetType().Name);
            }
            else
            {
                Console.WriteLine("   --- Ingredient {0} ---", ingredient.IngredientName);
                padding = "        ";
            }
            Console.WriteLine(padding + "Health Rating: {0}", ingredient.HealthRating);
            Console.WriteLine(padding + "Calories: {0}", ingredient.Calories);
            Console.WriteLine(padding + "Carbs: {0}", ingredient.Carbs);
            Console.WriteLine(padding + "Protein: {0}", ingredient.Protein);
            Console.WriteLine();
        }
    }
}
