using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AutoHouse.Model
{
    public class FatherTime
    {
        private MotherNature _motherNature;
        private Calendar _calendar;

        public DayOfWeek Day { get; private set; }
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public bool IsAM { get; private set; } 

        public FatherTime(MotherNature motherNature, Calendar calendar)
        {
            _motherNature = motherNature;
            _calendar = calendar;
        }

        public void SetDay(DayOfWeek day)
        {
            Day = day;
            IsAM = true;
        }

        public void IncrementMinute()
        {
            bool _sameHour = true;
            Minute += 15;
            if (Minute == 60)
            {
                Minute = 0;
                _sameHour = false;
                IncrementHour();
            }
            if (_sameHour) { IncrementTime(); }
        }

        public void IncrementHour()
        {
            bool _sameDay = true;
            Minute = 0;
            if (!IsAM && Hour == 11)
            {
                _sameDay = false;
                IncrementDay();
            }
            else if (IsAM && Hour == 12)
            {
                Hour = 1;
            }
            else
            {
                if (IsAM && Hour == 11)
                {
                    IsAM = false;
                    Hour = 12;
                }
                else if(!IsAM && Hour == 12)
                {
                    Hour = 1;
                }
                else
                {
                    Hour++;
                }
            }
            if (_sameDay) { IncrementTime(); }
        }

        public void IncrementDay()
        {
            Minute = 0;
            Hour = 12;
            IsAM = true;
            _motherNature.SetNextDay();
            IncrementTime();

            _calendar.NextDay();
        }

        private void IncrementTime()
        {
            Thread.Sleep(500);
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
            Console.WriteLine("{0}:{1} {2} {3}", currentHr, currentMin, am, Day);
        }
    }
}
