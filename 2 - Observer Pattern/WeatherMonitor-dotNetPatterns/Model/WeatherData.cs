using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Controller;

namespace WeatherMonitor.Model
{
    public class WeatherData : IObservable<WeatherInfo>
    {
        private List<IObserver<WeatherInfo>> _observers;

        public WeatherInfo _weatherInfo { get; private set; }

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherInfo>>();
            _weatherInfo = new WeatherInfo();
        }

        /// <summary>
        /// This method gets called whenever the weather measurements have been updated.
        /// </summary>
        public void MeasurementsChanged()
        {
            foreach (var observer in _observers)
                observer.OnNext(_weatherInfo);
        }

        public void SetMeasurements(double temperature, double humitidy, double pressure)
        {
            _weatherInfo = new WeatherInfo(temperature, humitidy, pressure);

            MeasurementsChanged();
        }

        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber<WeatherInfo>(_observers, observer);
        }

        internal class Unsubscriber<WeatherInfo> : IDisposable
        {
            private List<IObserver<WeatherInfo>> _observers;
            private IObserver<WeatherInfo> _observer;

            internal Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
