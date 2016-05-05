using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class TV
    {
        private bool _isOn;

        private int _volume;

        private int _channel;

        public string location { get; private set; }

        public TV(string location)
        {
            this.location = location;
        }

        public void On()
        {
            _isOn = true;
            WriteOnOffStatus();
        }

        public void Off()
        {
            _isOn = false;
            WriteOnOffStatus();
        }

        public void SetVolume(int volumeLevel)
        {
            _volume = volumeLevel;
            WriteVolumeStatus();
        }

        public void SetInputChannel(int channel)
        {
            _channel = channel;
            WriteChannel();
        }

        private void WriteOnOffStatus()
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

            Console.WriteLine("{0} TV is {1}.", location, state);
        }

        private void WriteVolumeStatus()
        {
            Console.WriteLine("{0} TV volume is set to {1}.", location, _volume);
        }

        private void WriteChannel()
        {
            Console.WriteLine("{0} TV channel is set to {1}.", location, _channel);
        }
    }
}
