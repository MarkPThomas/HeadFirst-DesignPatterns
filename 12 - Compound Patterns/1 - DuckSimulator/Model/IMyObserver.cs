using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Model
{
    public interface IQuackObserver
    {
        void Update(IQuackObservable duck);
    }
}
