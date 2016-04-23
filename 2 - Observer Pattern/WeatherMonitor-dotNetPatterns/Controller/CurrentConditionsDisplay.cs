using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;

namespace WeatherMonitor.Controller
{
    public class CurrentConditionsDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private IDisposable _unsubscribe;

        public CurrentConditionsDisplay(IObservable<WeatherInfo> weatherData)
        {
            Subscribe(weatherData);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature.ToString("N1") + "F degrees and " + _humidity.ToString("N1") + "% humidity.");
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
            _temperature = value.Temperature;
            _humidity = value.Humidity;
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
