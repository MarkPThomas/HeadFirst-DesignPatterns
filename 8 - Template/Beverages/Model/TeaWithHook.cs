using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverages.Model
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea.");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            return (answer.ToLower().StartsWith("y"));
        }

        private string GetUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like lemon with your tea (y/n)? ");

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
