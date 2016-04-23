using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor.Model
{
    public class WeatherInfo
    {
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public WeatherInfo() { }

        public WeatherInfo(double temp, double humidity, double pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
