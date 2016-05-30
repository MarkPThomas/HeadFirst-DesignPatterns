using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse.Model
{
    public class Alarm
    {
        private const int TIME_TO_WAKE_MINUTES = 15;

        private FatherTime _fatherTime;

        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public bool IsAM { get; private set; }

        private bool _isRinging;
        public bool IsRinging { get { return CheckIfRinging(); } }

        public Alarm()
        {
            Set(4, 30, true);
        }

        private bool CheckIfRinging()
        {
            if (_fatherTime.IsAM == IsAM &&
                _fatherTime.Hour >= Hour &&
                _fatherTime.Minute >= Minute &&
                (_fatherTime.Minute <= (Minute + TIME_TO_WAKE_MINUTES)))
            {
                if (!_isRinging)
                {
                    _isRinging = true;
                    OnAlarmRing(new EventArgs());
                }
                return true;
            }
            else
            {
                _isRinging = false;
                return false;
            }
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
            string currentMin = Minute.ToString().PadLeft(2, '0');
            string currentHr = Hour.ToString().PadLeft(2);
            Console.WriteLine("Setting {0} to {1}:{2} {3}", GetType().Name, currentHr, currentMin, am);
        }

        public void On()
        {
            Console.WriteLine("Turning {0} on ...", GetType().Name);
        }

        public void Off()
        {
            Console.WriteLine("Turning {0} off ...", GetType().Name);
        }


        public void Reset()
        {
            Console.WriteLine("Resetting {0} ...", GetType().Name);
        }

        #region Events

        public event EventHandler AlarmRing;

        protected virtual void OnAlarmRing(EventArgs e)
        {
            Console.WriteLine("Alarm is ringing.");
            AlarmRing?.Invoke(this, e);
        }
        #endregion
    }
}
