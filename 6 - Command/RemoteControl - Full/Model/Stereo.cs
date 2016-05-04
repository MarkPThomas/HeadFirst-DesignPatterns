using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class Stereo
    {
        private bool _isOn;

        private int _volume;

        private string _setting;

        public string location { get; private set; }

        public Stereo(string location)
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

        public void SetCd()
        {
            _setting = "CD";
            WriteSettingStatus();
        }

        public void SetDvd()
        {
            _setting = "DVD";
            WriteSettingStatus();
        }

        public void SetRadio()
        {
            _setting = "Radio";
            WriteSettingStatus();
        }

        public void SetVolume(int volumeLevel)
        {
            _volume = volumeLevel;
            WriteVolumeStatus();
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

            Console.WriteLine("{0} stereo is {1}.", location, state);
        }

        private void WriteSettingStatus()
        {
            Console.WriteLine("{0} stereo set to {1}.", location, _setting);
        }

        private void WriteVolumeStatus()
        {
            Console.WriteLine("{0} stereo volume is set to {1}.", location, _volume);
        }
    }
}
