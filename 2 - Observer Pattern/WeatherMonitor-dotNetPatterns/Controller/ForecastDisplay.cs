using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;

namespace WeatherMonitor.Controller
{
    public class ForecastDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private double _pastPressure;
        private double _currentPressure;
        private string _forecastMessage;
        private IDisposable _unsubscribe;

        public ForecastDisplay(IObservable<WeatherInfo> weatherData)
        {
            Subscribe(weatherData);
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

        public virtual void Subscribe(IObservable<WeatherInfo> provider)
        {
            _unsubscribe = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscribe.Dispose();
        }

        public void OnNext(WeatherInfo value)
        {
            _pastPressure = _currentPressure;
            _currentPressure = value.Pressure;

            GetForecast();
            Display();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
