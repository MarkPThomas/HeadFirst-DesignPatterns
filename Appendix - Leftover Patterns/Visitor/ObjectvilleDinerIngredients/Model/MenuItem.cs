using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Lib;
using ObjectvilleDinerIngredients.Model;

namespace Menus.Model
{
    public class MenuItem : MenuComponent
    {
        private List<MenuIngredient> _ingredients = new List<MenuIngredient>();

        public override string Name { get { return _name; } }
        public override string Description { get { return _description; } }
        public override bool Vegetarian { get { return _vegetarian; } }
        public override double Price { get { return _price; } }
        public override HealthRating HealthRating { get { return _healthRating; } }
        public override int Calories { get { return _calories; } }
        public override int Protein { get { return _protein; } }
        public override int Carbs { get { return _carbs; } }


        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public MenuItem(string name,
                 string description,
                 bool vegetarian,
                 double price,
                 List<MenuIngredient> ingredients)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
            _ingredients = ingredients;

            CalculateIngredientStats();
        }

        private void CalculateIngredientStats()
        {
            int totalRating = 0;
            foreach (MenuIngredient ingredient in _ingredients)
            {
                _calories += ingredient.Calories;
                _carbs += ingredient.Carbs;
                _protein += ingredient.Protein;
                totalRating += (int)ingredient.HealthRating;
            }
            _healthRating = (HealthRating)(totalRating / _ingredients.Count);
        }

        public override void Print()
        {
            string message = "  " + Name;
            if (Vegetarian) { message += "(v)"; }
            message += ", " + Price + "\n     -- " + Description;

            Console.WriteLine(message);
        }

        public override IIterator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }

        public override void Accept(IVisitor visitor)
        {
            base.Accept(visitor);
            foreach (MenuIngredient item in _ingredients)
            {
                item.Accept(visitor);
            }
        }
    }
}
