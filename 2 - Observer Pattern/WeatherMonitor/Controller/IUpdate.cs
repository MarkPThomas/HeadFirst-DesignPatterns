using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor.Controller
{
    interface IUpdate
    {
        void Update(double temp, double humidity, double pressure);
    }
}
