using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor.Controller
{
    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }
}
