using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverages.Model
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            return (answer.ToLower().StartsWith("y"));
        }

        private string GetUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            
            try
            {
                answer = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("IO error trying to read your answer.");
            }

            if (answer == null)
            {
                return "no";
            }
            return answer;
        }
    }
}
