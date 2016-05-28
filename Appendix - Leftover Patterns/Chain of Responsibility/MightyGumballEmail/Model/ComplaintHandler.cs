using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballEmail.Model
{
    public class ComplaintHandler : Handler
    {
        public ComplaintHandler(Handler successor) : base(successor)
        {
        }

        public override void HandleRequest(Email email)
        {
            if (email.Type == EmailType.Complaint)
            {
                Console.WriteLine("Complaint Handler is handling the following message ...");
                Console.WriteLine("Sending to the legal department ...");
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
