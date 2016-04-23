using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;
using WeatherMonitor.Tools;

namespace WeatherMonitor.Controller
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private List<double> _temperatures;
        private double _tempAverage;
        private double _tempMax;
        private double _tempMin;
        private ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);

            _temperatures = new List<double>();
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperatures.Add(temp);

            _tempMax = ComputeMaxTemperature(_temperatures);
            _tempMin = ComputeMinTemperature(_temperatures);
            _tempAverage = ComputeAverageTemperature(_temperatures);

            Display();
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
    }
}
