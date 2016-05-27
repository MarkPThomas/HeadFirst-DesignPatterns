using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTV.Model
{
    public class Sony : TV
    {
        public override void TuneChannel(int channel)
        {
            Console.WriteLine("Sony TV set to channel " + channel);
        }
    }
}
