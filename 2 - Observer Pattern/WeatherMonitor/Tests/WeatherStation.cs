using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Controller;
using WeatherMonitor.Model;

namespace WeatherMonitor.Tests
{
    public class WeatherStation
    {
        public WeatherStation()
        {

        }

        public static void Run()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndex heatIndex = new HeatIndex(weatherData);

            // Simulate new weather measurements
            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(82, 70, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.WriteLine();
        }
    }
}
