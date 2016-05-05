using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Model
{
    public class SimpleRemoteControl
    {
        Command _slot;

        public SimpleRemoteControl() { }

        public void SetCommand(Command command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.execute();
        }
    }
}
