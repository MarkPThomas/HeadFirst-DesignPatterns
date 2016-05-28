using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballEmail.Model
{
    public class NewLocHandler : Handler
    {
        public NewLocHandler(Handler successor) : base(successor)
        {
        }

        public override void HandleRequest(Email email)
        {
            if (email.Type == EmailType.Unclassified)
            {
                Console.WriteLine("New Location Handler is handling the following message ...");
                Console.WriteLine("Sending to business development ...");
                Console.WriteLine(email.Message);
                Console.WriteLine();
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(email);
            }
        }
    }
}
