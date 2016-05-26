using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Model
{
    public class HeartModel : IHeartModel
    {
        private List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        private List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();

        int _heartRate;
        public int HeartRate
        {
            get
            {
                return _heartRate;
            }

            set
            {
                _heartRate = value;
            }
        }


        #region Beat Observers

        private void NotifyBeatObservers()
        {
            foreach (IBeatObserver observer in _beatObservers)
            {
                observer.UpdateBeat();
            }
        }

        public void RegisterObserver(IBeatObserver o)
        {
            _beatObservers.Add(o);
        }

        public void RemoveObserver(IBeatObserver o)
        {
            _beatObservers.Remove(o);
        }
        #endregion

        #region BPM Observers
        private void NotifyBPMObservers()
        {
            foreach (IBPMObserver observer in _bpmObservers)
            {
                observer.UpdateBPM();
            }
        }

        public void RegisterObserver(IBPMObserver o)
        {
            _bpmObservers.Add(o);
        }


        public void RemoveObserver(IBPMObserver o)
        {
            _bpmObservers.Remove(o);
        }
        #endregion
    }
}
