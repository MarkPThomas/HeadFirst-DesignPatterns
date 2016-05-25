using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    /// <summary>
    /// Composite Pattern.
    /// </summary>
    public class Flock : IQuackable
    {
        private List<IQuackable> _quackers = new List<IQuackable>();
        private Observable _observable;

        public Flock()
        {
            _observable = new Observable(this);
        }

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            // Iterator Pattern
            IEnumerator<IQuackable> iterator = _quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current;
                quacker.Quack();
            }

            // Condensed, standard implementation for this action:
            //foreach (IQuackable quacker in _quackers)
            //{
            //    quacker.Quack();
            //    NotifyObservers();
            //}
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            _observable.RegisterObserver(observer);
            foreach (IQuackable quacker in _quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }
    }
}
