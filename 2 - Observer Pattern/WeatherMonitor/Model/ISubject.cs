using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherMonitor.Controller;

namespace WeatherMonitor.Model
{
    public interface ISubject
    {
        void RegisterObserver(IObserver obj);
        void RemoveObserver(IObserver obj);
        void NotifyObservers();
    }
}
