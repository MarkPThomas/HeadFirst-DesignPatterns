using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumballEmail.Model
{
    public abstract class Handler
    {
        protected Handler _successor;

        public Handler(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(Email email);
    }
}
