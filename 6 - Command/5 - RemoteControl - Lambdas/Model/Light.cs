using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class Light
    {
        public string location { get; private set; }

        private bool _isOn;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            _isOn = true;
            WriteStatus();
        }

        public void Off()
        {
            _isOn = false;
            WriteStatus();
        }

        private void WriteStatus()
        {
            string state;
            if (_isOn)
            {
                state = "on";
            }
            else
            {
                state = "off";
            }

            Console.WriteLine("{0} light is {1}.", location, state);
        }
    }
}
