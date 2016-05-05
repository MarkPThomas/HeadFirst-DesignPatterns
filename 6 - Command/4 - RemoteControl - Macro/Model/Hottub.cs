using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class Hottub
    {
        private bool _isOn;

        private bool _isCirculating;

        private int _temperature;

        public string location { get; private set; }

        public Hottub(string location)
        {
            this.location = location;
        }

        public void JetsOn()
        {
            _isOn = true;
            WriteOnOffStatus();
        }

        public void JetsOff()
        {
            _isOn = false;
            WriteOnOffStatus();
        }

        public void Circulate()
        {
            if (!_isCirculating)
            {
                _isCirculating = true;
            }
            else
            {
                _isCirculating = false;
            }
            WriteCirculation();
        }

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
            WriteTemperature();
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

            Console.WriteLine("{0} hottub jets are {1}.", location, state);
        }

        private void WriteCirculation()
        {
            string state;
            if (_isCirculating)
            {
                state = "is";
            }
            else
            {
                state = "is not";
            }
            Console.WriteLine("{0} hottub {1} circulating.", location, state);
        }

        private void WriteTemperature()
        {
            Console.WriteLine("{0} hottub temperature is set to {1} F.", location, _temperature);
        }
    }
}
