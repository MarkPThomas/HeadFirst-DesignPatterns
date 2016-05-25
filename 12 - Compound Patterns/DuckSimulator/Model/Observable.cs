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
    public class Observable : IQuackObservable
    {
        List<IQuackObserver> _observers = new List<IQuackObserver>();
        IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void NotifyObservers()
        {
            foreach (IQuackObserver observer in _observers)
            {
                observer.Update(_duck);
            }
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
