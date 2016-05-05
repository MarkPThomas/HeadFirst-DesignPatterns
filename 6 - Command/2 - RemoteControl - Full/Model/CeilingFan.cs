using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class CeilingFan
    {
        public string speed { get; private set; }

        public string location { get; private set; }

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void High()
        {
            speed = "high";
            WriteStatus();
        }

        public void Medium()
        {
            speed = "high";
            WriteStatus();
        }

        public void Low()
        {
            speed = "low";
            WriteStatus();
        }

        public void Off()
        {
            speed = "off";
            WriteStatus();
        }

        private void WriteStatus()
        {
            Console.WriteLine("The {0} ceiling fan is turned to {1}.", location, speed);
        }
    }
}
