using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectvilleDinerIngredients.Model
{
    public interface IIngredient
    {
        string IngredientName { get; }
        HealthRating HealthRating { get; }
        int Calories { get; }
        int Protein { get; }
        int Carbs { get; }
    }
}
