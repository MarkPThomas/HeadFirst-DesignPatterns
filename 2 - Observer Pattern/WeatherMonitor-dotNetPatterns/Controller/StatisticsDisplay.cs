using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;
using WeatherMonitor.Tools;

namespace WeatherMonitor.Controller
{
    public class StatisticsDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private List<double> _temperatures;
        private double _tempAverage;
        private double _tempMax;
        private double _tempMin;
        private IDisposable _unsubscribe;

        public StatisticsDisplay(IObservable<WeatherInfo> weatherData)
        {
            _temperatures = new List<double>();
            Subscribe(weatherData);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + _tempAverage.ToString("N1") + "/" + _tempMax.ToString("N1") + "/" + _tempMin.ToString("N1"));
        }    

        private double ComputeMaxTemperature(List<double> temperatures)
        {
            return Statistics.Max(temperatures);
        }

        private double ComputeMinTemperature(List<double> temperatures)
        {
            return Statistics.Min(temperatures);
        }

        private double ComputeAverageTemperature(List<double> temperatures)
        {
            return Statistics.Average(temperatures);
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
            _temperatures.Add(value.Temperature);

            _tempMax = ComputeMaxTemperature(_temperatures);
            _tempMin = ComputeMinTemperature(_temperatures);
            _tempAverage = ComputeAverageTemperature(_temperatures);

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
