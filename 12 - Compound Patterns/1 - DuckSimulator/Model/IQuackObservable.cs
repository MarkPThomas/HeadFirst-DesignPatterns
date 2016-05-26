using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    /// <summary>
    /// Observer Pattern.
    /// </summary>
    public interface IQuackObservable
    {
        void RegisterObserver(IQuackObserver observer);
        void NotifyObservers();
    }
}
