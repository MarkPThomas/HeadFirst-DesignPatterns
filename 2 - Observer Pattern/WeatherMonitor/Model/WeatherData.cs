using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Controller;

namespace WeatherMonitor.Model
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;

        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        /// <summary>
        /// This method gets called whenever the weather measurements have been updated.
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void RegisterObserver(IObserver obj)
        {
            _observers.Add(obj);
        }

        public void RemoveObserver(IObserver obj)
        {
            if (_observers.Contains(obj))
            {
                _observers.Remove(obj);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void SetMeasurements(double temperature, double humitidy, double pressure)
        {
            Temperature = temperature;
            Humidity = humitidy;
            Pressure = pressure;

            MeasurementsChanged();
        }
    }
}
