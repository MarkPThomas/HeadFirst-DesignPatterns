using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class Stereo
    {
        public enum eSetting
        {
            CD,
            DVD,
            Radio,
        }

        public bool isOn { get; private set; }

        public int volume { get; private set; }

        public eSetting setting { get; private set; }

        public string location { get; private set; }

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On()
        {
            isOn = true;
            WriteOnOffStatus();
        }

        public void Off()
        {
            isOn = false;
            WriteOnOffStatus();
        }

        public void SetCd()
        {
            setting = eSetting.CD;
            WriteSettingStatus();
        }

        public void SetDvd()
        {
            setting = eSetting.DVD;
            WriteSettingStatus();
        }

        public void SetRadio()
        {
            setting = eSetting.Radio;
            WriteSettingStatus();
        }

        public void SetVolume(int volumeLevel)
        {
            volume = volumeLevel;
            WriteVolumeStatus();
        }

        private void WriteOnOffStatus()
        {
            string state;
            if (isOn)
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
            Console.WriteLine("{0} stereo set to {1}.", location, setting.ToString());
        }

        private void WriteVolumeStatus()
        {
            Console.WriteLine("{0} stereo volume is set to {1}.", location, volume);
        }
    }
}
