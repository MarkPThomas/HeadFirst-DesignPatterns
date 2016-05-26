using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    public class RedheadDuck : IQuackable
    {
        private Observable _observable;

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
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
            return GetType().Name;
        }
    }
}
