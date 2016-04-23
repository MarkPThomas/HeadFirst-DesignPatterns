using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Controller;

namespace WeatherMonitor.Model
{
    class WeatherData
    {
        private CurrentConditionsDisplay currentConditionsDisplay;
        private ForecastDisplay forecastDisplay;
        private StatisticsDisplay statisticsDisplay;

        public readonly double Temperature;
        public readonly double Humidity;
        public readonly double Pressure;

        public void WeatherMonitor()
        {
            currentConditionsDisplay = new CurrentConditionsDisplay();
            forecastDisplay = new ForecastDisplay();
            statisticsDisplay = new StatisticsDisplay();
        }

        public double GetTemperature()
        {
            return Temperature;
        }

        public double GetHumidity()
        {
            return Humidity;
        }

        public double GetPressure()
        {
            return Pressure;
        }

        /// <summary>
        /// This method gets called whenever the weather measurements have been updated.
        /// </summary>
        public void MeasurementsChanged()
        {
            double temp = GetTemperature();
            double humidity = GetHumidity();
            double pressure = GetPressure();

            currentConditionsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
        }
    }
}
