using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Model
{
    public class HeartAdapter : IBeatModel
    {
        IHeartModel _heart;

        public HeartAdapter(IHeartModel heart)
        {
            _heart = heart;
        }

        public int BPM
        {
            get
            {
               return _heart.HeartRate;
            }

            set
            {
                // No action.
            }
        }

        public void Initialize()
        {
            // No action.
        }

        public void Off()
        {
            // No action.
        }

        public void On()
        {
            // No action.
        }

        public void RegisterObserver(IBPMObserver o)
        {
            _heart.RegisterObserver(o);
        }

        public void RegisterObserver(IBeatObserver o)
        {
            _heart.RegisterObserver(o);
        }

        public void RemoveObserver(IBPMObserver o)
        {
            _heart.RemoveObserver(o);
        }

        public void RemoveObserver(IBeatObserver o)
        {
            _heart.RemoveObserver(o);
        }
    }
}
