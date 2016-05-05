using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class GarageDoorOpenCommand : ICommand
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

        public void undo()
        {
            _garageDoor.Down();
        }
    }
}
