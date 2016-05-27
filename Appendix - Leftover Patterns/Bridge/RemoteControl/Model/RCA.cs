using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTV.Model
{
    public class RCA : TV
    {
        public override void TuneChannel(int channel)
        {
            Console.WriteLine("RCA TV set to channel " + channel);
        }
    }
}
