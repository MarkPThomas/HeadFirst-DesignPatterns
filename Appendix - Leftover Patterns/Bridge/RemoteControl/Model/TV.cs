using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTV.Model
{
    public abstract class TV
    {
        public virtual void On()
        {
            Console.WriteLine("TV is turned on.");
        }

        public virtual void Off()
        {
            Console.WriteLine("TV is turned off.");
        }

        public abstract void TuneChannel(int channel);
    }
}
