using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;

namespace WeatherMonitor.Controller
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _pastPressure;
        private double _currentPressure;
        private string _forecastMessage;
        private ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _pastPressure = _currentPressure;
            _currentPressure = pressure;

            GetForecast();
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: " + _forecastMessage);
        }

        private void GetForecast()
        {
            double pressureChange = _currentPressure - _pastPressure;

            if (pressureChange > 0)
            {
                _forecastMessage = "Improving weather on the way!";
            }
            else if (pressureChange < 0)
            {
                _forecastMessage = "Watch out for cooler, rainy weather.";
            }
            else
            {
                _forecastMessage = "More of the same.";
            }
        }
    }
}
