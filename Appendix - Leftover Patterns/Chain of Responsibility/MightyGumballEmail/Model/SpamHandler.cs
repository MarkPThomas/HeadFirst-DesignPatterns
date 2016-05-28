using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballEmail.Model
{
    public class SpamHandler : Handler
    {
        public SpamHandler(Handler successor) : base(successor)
        {
        }

        public override void HandleRequest(Email email)
        {
            if (email.Type == EmailType.Spam)
            {
                Console.WriteLine("Spam Handler is handling the following message ...");
                Console.WriteLine("Deleting the following e-mail ...");
                Console.WriteLine(email.Message);
                Console.WriteLine();
            }
            else if(_successor != null)
            {
                _successor.HandleRequest(email);
            }
        }
    }
}
