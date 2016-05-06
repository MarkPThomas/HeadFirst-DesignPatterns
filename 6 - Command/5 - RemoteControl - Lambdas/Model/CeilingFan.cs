using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class CeilingFan
    {
        public enum eSpeed
        {
            OFF = 0,
            LOW = 1,
            MEDIUM = 2,
            HIGH = 3,
        }

        public eSpeed speed { get; private set; }

        public string location { get; private set; }

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void High()
        {
            speed = eSpeed.HIGH;
            WriteStatus();
        }

        public void Medium()
        {
            speed = eSpeed.MEDIUM;
            WriteStatus();
        }

        public void Low()
        {
            speed = eSpeed.LOW;
            WriteStatus();
        }

        public void Off()
        {
            speed = eSpeed.OFF;
            WriteStatus();
        }

        private void WriteStatus()
        {
            Console.WriteLine("The {0} ceiling fan is turned to {1}.", location, speed.ToString().ToLower());
        }
    }
}
