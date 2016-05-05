using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class CeilingFanOnLowCommand : Command
    {
        CeilingFan _ceilingFan;

        public CeilingFanOnLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }


        public void execute()
        {
            _ceilingFan.Low();
        }
    }
}
