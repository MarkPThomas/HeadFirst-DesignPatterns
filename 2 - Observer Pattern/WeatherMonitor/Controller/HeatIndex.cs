using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Model;

namespace WeatherMonitor.Controller
{
    class HeatIndex : IObserver, IDisplayElement
    {
        private double _heatIndex;
        private ISubject _weatherData;

        public HeatIndex(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        
        public void Update(double temp, double humidity, double pressure)
        {
            _heatIndex = ComputeHeatIndex(temp, humidity);
            Display();
        }


        public void Display()
        {
            Console.WriteLine("Heat index is " + _heatIndex.ToString("N5"));
        }

        /// <summary>
        /// Calculates the heat index, which is the perceived temperature due to the effects of humidity.
        /// </summary>
        /// <param name="t">Temperature, [F]</param>
        /// <param name="rh">Relative Humdity, [%]</param>
        private double ComputeHeatIndex(double t, double rh)
        {
            double heatIndex = 
                16.923 
                + 1.85212E-1  * t
                + 5.37941     * rh
                - 1.00254E-1  * (t * rh)
                + 9.41695E-3  * (Math.Pow(t,2))
                + 7.28898E-3  * (Math.Pow(rh, 2))
                + 3.45372E-4  * (Math.Pow(t, 2) * rh) 
                - 8.14971E-4  * (t * Math.Pow(rh, 2)) 
                + 1.02102E-5  * (Math.Pow(t, 2) * Math.Pow(rh, 2)) 
                - 3.86460E-5  * (Math.Pow(t, 3)) 
                + 2.91583E-5  * (Math.Pow(rh, 3))
                + 1.42721E-6  * (Math.Pow(t, 3) * rh) 
                + 1.97483E-7  * (t * Math.Pow(rh, 3))
                - 2.18429E-8  * (Math.Pow(t, 3) * Math.Pow(rh, 2)) 
                + 8.43296E-10 * (Math.Pow(t, 2) * Math.Pow(rh, 3)) 
                - 4.81975E-11 * (Math.Pow(t, 3) * Math.Pow(rh, 3));

            return heatIndex;
        }
    }
}
