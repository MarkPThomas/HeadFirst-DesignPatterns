using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Model
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }


        public void execute()
        {
            _garageDoor.Up();
        }
    }
}
