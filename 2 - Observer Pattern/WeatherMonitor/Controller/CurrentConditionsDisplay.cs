using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;

namespace WeatherMonitor.Controller
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            // Although _weatherData isn't currently being used, it is being referenced in a field in order to be able to unsubscribe in the future.
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }


        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature.ToString("N1") + "F degrees and " + _humidity.ToString("N1") + "% humidity.");
        }
    }
}
