using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class CeilingFanOffCommand : Command
    {
        CeilingFan _ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }


        public void execute()
        {
            _ceilingFan.Off();
        }
    }
}
