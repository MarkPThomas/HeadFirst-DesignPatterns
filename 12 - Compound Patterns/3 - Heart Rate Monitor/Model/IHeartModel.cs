using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Model
{
    public interface IHeartModel
    {
        int HeartRate { get; set; }

        void RegisterObserver(IBeatObserver o);
        void RemoveObserver(IBeatObserver o);

        void RegisterObserver(IBPMObserver o);
        void RemoveObserver(IBPMObserver o);
    }
}
