using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFanchise.Model
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            _name = "NY Style Sauce and Cheese Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Grated Reggiano Cheese");
        }
    }
}
