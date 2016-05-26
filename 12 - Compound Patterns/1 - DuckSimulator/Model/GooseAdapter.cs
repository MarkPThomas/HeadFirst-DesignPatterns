using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    /// <summary>
    /// Adapter pattern.
    /// </summary>
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;
        private Observable _observable;
        
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _goose.Honk();
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
            return _goose.GetType().Name + " pretending to be a Duck ";
        }
    }
}
