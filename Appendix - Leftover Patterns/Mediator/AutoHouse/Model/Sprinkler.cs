using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse.Model
{
    public class Sprinkler
    {
        private const int DEFAULT_TIME_MINUTES = 30;

        private FatherTime _fatherTime;

        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public bool IsAM { get; private set; }
        public int DurationTimeMinutes { get; set; } = DEFAULT_TIME_MINUTES;
        public bool IsSetOn { get; private set; }

        private bool _isRunning;
        public bool IsRunning { get { return CheckIfRunning(); } }

        private bool CheckIfRunning()
        {
            if (_fatherTime.IsAM == IsAM &&
                _fatherTime.Hour >= Hour &&
                _fatherTime.Minute >= Minute &&
                (_fatherTime.Minute <= (Minute + DEFAULT_TIME_MINUTES)))
            {
                if (!_isRunning)
                {
                    _isRunning = true;
                    OnSprinklerOnEvent(new EventArgs());
                }
                return true;
            }
            else
            {
                if (_isRunning)
                {
                    _isRunning = false;
                    OnSprinklerOffEvent(new EventArgs());
                }
                return false;
            }
        }

        public Sprinkler()
        {
            Set(4, 30, true);
            IsSetOn = true;
        }

        public void SyncTime(FatherTime fatherTime)
        {
            _fatherTime = fatherTime;
        }

        public void Set(int hour, int minute, bool isAm)
        {
            Hour = hour;
            Minute = minute;
            IsAM = isAm;

            string am;
            if (IsAM)
            {
                am = "A.M.";
            }
            else
            {
                am = "P.M.";
            }
            IsSetOn = true;
            string currentMin = Minute.ToString().PadLeft(2);
            string currentHr = Hour.ToString().PadLeft(2);
            Console.WriteLine("Setting {0} to {1}:{2} {3}", GetType().Name, currentHr, currentMin, am);
        }

        public void On()
        {
            IsSetOn = true;
            Console.WriteLine("Turning {0} on ...", GetType().Name);
        }

        public void Off()
        {
            IsSetOn = false;
            Console.WriteLine("Turning {0} off ...", GetType().Name);
        }

        public void Reset()
        {
            IsSetOn = true;
            DurationTimeMinutes = DEFAULT_TIME_MINUTES;
            Console.WriteLine("Resetting {0} ...", GetType().Name);
        }

        #region Events
        public event EventHandler SprinklerEvent;

        protected virtual void OnSprinklerOnEvent(EventArgs e)
        {
            Console.WriteLine("Sprinkler has turned on");
            SprinklerEvent?.Invoke(this, e);
        }

        protected virtual void OnSprinklerOffEvent(EventArgs e)
        {
            Console.WriteLine("Sprinkler has turned off");
            SprinklerEvent?.Invoke(this, e);
        }
        #endregion
    }
}
