using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    /// <summary>
    /// Decorator pattern.
    /// </summary>
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private Observable _observable;
        
        public static int NumberOfQuacks { get; private set; }

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _duck.Quack();
            NumberOfQuacks++;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return _duck.GetType().Name;
        }
    }
}
