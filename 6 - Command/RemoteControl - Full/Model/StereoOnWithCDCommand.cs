using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class StereoOnWithCDCommand : Command
    {
        Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }
    }
}
