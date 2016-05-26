using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace DJ.Model
{
    internal class Sequencer
    {
        private List<IMetaEventListener> _metaEventObservers = new List<IMetaEventListener>();
        private int _bpm;
        private static Timer _timer;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        internal void SetTempoInBPM(int bpm)
        {
            Console.WriteLine("Tempo changed to {0} bpm ...", bpm);
            _bpm = bpm;

            if (_bpm > 0)
            {
                bool restartTimer = false;
                if (_timer != null && _timer.Enabled)
                {
                    _timer.Stop();
                    restartTimer = true;
                }
                _timer = new Timer(60000 / _bpm / 2);
                _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
                if (restartTimer)
                {
                    _timer.Start();
                }
            }
        }

        internal void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }

        internal void Start()
        {
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);

            _timer.Start();
        }

        internal void Stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);

            _timer.Stop();
        }

        internal void AddMetaEventListener(IMetaEventListener metaEventListener)
        {
            _metaEventObservers.Add(metaEventListener);
        }


        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (IMetaEventListener metaEventListener in _metaEventObservers)
            {
                metaEventListener.BeatEvent();
            }
        }
    }
}