using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Model
{
    public class BeatModel : IBeatModel, IMetaEventListener
    {
        /// <summary>
        /// The object that knows how to generate the real beats (that you can hear!)
        /// </summary>
        private Sequencer _sequencer;
        private List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        private List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();

        private int _bpm = 90;
        public int BPM
        {
            get
            {
                return _bpm;
            }

            set
            {
                _bpm = value;
                _sequencer.SetTempoInBPM(BPM);
                NotifyBPMObservers();
            }
        }


        public void Initialize()
        {
            SetUpMidi();
        }

        public void Off()
        {
            BPM = 0;
            _sequencer.Stop();
        }

        public void On()
        {
            Console.WriteLine("Starting the sequencer.");
            SetUpMidi();
            _sequencer.Start();
        }

        public void BeatEvent()
        {
            NotifyBeatObservers();
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

        private void SetUpMidi()
        {
            try
            {
                _sequencer = new Sequencer();
                _sequencer.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Odub - Offwidth.mp3"); 
                _sequencer.AddMetaEventListener(this);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}
