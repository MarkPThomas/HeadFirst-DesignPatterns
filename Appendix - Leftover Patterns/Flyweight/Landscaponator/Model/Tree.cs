using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landscaponator.Model
{
    public class Tree
    {
        public void Display(double x, double y, int age)
        {
            Console.WriteLine("Drawing a {0} year old tree at x = {1} px, y = {2} px ...", age, x, y);
        }
    }
}
