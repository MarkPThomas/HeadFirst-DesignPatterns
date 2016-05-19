using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverages.Model
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        /// <summary>
        /// This is a 'hook' method. 
        /// It currently does nothing but is in place in case any inheriting classes want to interject additional logic here.
        /// </summary>
        /// <returns></returns>
        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void AddCondiments();


        public abstract void Brew();


        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }


        public void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }
    }
}
