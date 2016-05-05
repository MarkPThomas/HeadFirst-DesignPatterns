using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    internal class GarageDoorCloseCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }


        public void execute()
        {
            _garageDoor.Down();
        }

        public void undo()
        {
            _garageDoor.Up();
        }
    }
}
