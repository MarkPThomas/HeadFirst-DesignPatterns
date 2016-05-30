using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoHouse.Model
{
    public class Mediator
    {
        private FatherTime _fatherTime;
        private MotherNature _motherNature = new MotherNature();
        private bool _isWeatherNice;

        private Alarm _alarm;
        private Calendar _calendar;
        private CoffeePot _coffeePot;
        private Sprinkler _sprinkler;

        private CalendarEventArgs _currentDayProps;


        public Mediator(Alarm alarm, Calendar calendar, CoffeePot coffeePot, Sprinkler sprinkler)
        {
            _calendar = calendar;
            _calendar.CalendarEvent += _calendar_CalendarEvent;

            _fatherTime = new FatherTime(_motherNature, _calendar);

            _alarm = alarm;
            _alarm.SyncTime(_fatherTime);
            _alarm.AlarmRing += _alarm_AlarmRing;

            _coffeePot = coffeePot;
            _coffeePot.SyncTime(_fatherTime);
            _coffeePot.CoffeePotBrew += _coffeePot_CoffeePotBrew;

            _sprinkler = sprinkler;
            _sprinkler.SyncTime(_fatherTime);
            _sprinkler.SprinklerEvent += _sprinkler_SprinklerEvent;
        }

        public void Start()
        {
            _calendar.NextDay(true);
        }

        #region Alarm Methods
        private void DoAlarm()
        {
            while (!_alarm.IsRinging)
            {
                if (Math.Abs(_fatherTime.Hour - _alarm.Hour) > 1)
                {
                    _fatherTime.IncrementHour();
                }
                else
                {
                    _fatherTime.IncrementMinute();
                }
            }
            Console.WriteLine("Alarm clock is ringing ...");
            while (_alarm.IsRinging)
            {
                _fatherTime.IncrementMinute();
            }
            Console.WriteLine("I'm awake!");
        }

        private void CheckAlarm()
        {
            _alarm.Set(9, 00, true);
            foreach (CalendarEventTypes dayEvent in _currentDayProps.DayEvents)
            {
                switch (dayEvent)
                {
                    case CalendarEventTypes.None:
                        break;
                    case CalendarEventTypes.MorningWorkout:
                        _alarm.Set(5,00,true);
                        _coffeePot.Set(5, 30, true);
                        break;
                    case CalendarEventTypes.EveningConference:
                        break;
                    case CalendarEventTypes.TrashPickup:
                        _alarm.Set(6, 00, true);
                        _coffeePot.Set(6, 30, true);
                        break;
                    case CalendarEventTypes.Work:
                        _alarm.Set(7, 00, true);
                        _coffeePot.Set(7, 30, true);
                        break;
                    case CalendarEventTypes.DrAppt:
                        break;
                    case CalendarEventTypes.HomeRepairAppt:
                        break;
                    default:
                        break;
                }
            }
        }

        private void ResetAlarm()
        {
            if (_currentDayProps.Day == DayOfWeek.Friday)
            {
                _alarm.Off();
            }
            else if (_currentDayProps.Day == DayOfWeek.Sunday)
            {
                _alarm.On();
            }
            else
            {
                _alarm.Reset();
            }
        }
        #endregion

        #region Calendar Methods
        private void CheckDayOfWeek()
        {
            Console.WriteLine("Let's see what we have in store for today ...");
            if (_currentDayProps.IsTrashDay)
            {
                Console.WriteLine("It's trash day ...");
                ResetAlarm();
            }
            if (_currentDayProps.IsWeekend)
            {
                CheckWeather();
                if (_isWeatherNice)
                {
                    Console.WriteLine("It looks like nice weather this weekend!");
                }
                else
                {
                    Console.WriteLine("An indoor weekend ... :-(");
                }
            }
            else
            {
                Console.WriteLine("Just another weekday");
            }

            foreach (CalendarEventTypes dayEvent in _currentDayProps.DayEvents)
            {
                switch (dayEvent)
                {
                    case CalendarEventTypes.None:
                        break;
                    case CalendarEventTypes.MorningWorkout:
                        Console.WriteLine("Morning workout today ...");
                        break;
                    case CalendarEventTypes.EveningConference:
                        Console.WriteLine("Evening conference today ...");
                        break;
                    case CalendarEventTypes.TrashPickup:
                        Console.WriteLine("Trash pickup today ...");
                        break;
                    case CalendarEventTypes.Work:
                        Console.WriteLine("A work day today ...");
                        break;
                    case CalendarEventTypes.DrAppt:
                        Console.WriteLine("Dr. appointment today ...");
                        break;
                    case CalendarEventTypes.HomeRepairAppt:
                        Console.WriteLine("I have a home repair appointment today ...");
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region CoffeePost Methods
        private void DoCoffee()
        {
            while (!_coffeePot.IsBrewing)
            {
                if (Math.Abs(_fatherTime.Hour - _coffeePot.Hour) > 1)
                {
                    _fatherTime.IncrementHour();
                }
                else
                {
                    _fatherTime.IncrementMinute();
                }
            }
            Console.WriteLine("Waiting for coffee ...");
            while (_coffeePot.IsBrewing)
            {
                _fatherTime.IncrementMinute();
            }
            Console.WriteLine("Time for some morning joe!");
        }

        private void StartCoffee()
        {
            _coffeePot.On();
        }
        #endregion

        #region Sprinkler Methods
        private void DoSprinkler()
        {
            while (!_sprinkler.IsRunning)
            {
                if (Math.Abs(_fatherTime.Hour - _sprinkler.Hour) > 1)
                {
                    _fatherTime.IncrementHour();
                }
                else
                {
                    _fatherTime.IncrementMinute();
                }
            }
            Console.WriteLine("Sprinklers have started ...");
            while (_sprinkler.IsRunning)
            {
                _fatherTime.IncrementMinute();
            }
            Console.WriteLine("Sprinklers have stopped ...");
        }

        private void CheckSprinkler()
        {
            _sprinkler.On();
            foreach (CalendarEventTypes dayEvent in _currentDayProps.DayEvents)
            {
                switch (dayEvent)
                {
                    case CalendarEventTypes.None:
                        break;
                    case CalendarEventTypes.MorningWorkout:
                        break;
                    case CalendarEventTypes.EveningConference:
                        break;
                    case CalendarEventTypes.TrashPickup:
                        Console.WriteLine("Turning off the sprinklers to avoid spraying trash pickup.");
                        _sprinkler.Off();
                        break;
                    case CalendarEventTypes.Work:
                        break;
                    case CalendarEventTypes.DrAppt:
                        break;
                    case CalendarEventTypes.HomeRepairAppt:
                        Console.WriteLine("Turning off the sprinkers to avoid spraying the home repair person.");
                        _sprinkler.Off();
                        break;
                    default:
                        break;
                }
                if (_sprinkler.IsSetOn)
                {
                    _sprinkler.Set(4, 30, true);
                }
            }
        }

        private void CheckShower()
        {
            if (_motherNature.Showers)
            {
                Console.WriteLine("It looks like it's going to rain today!");
            }
            else
            {
                Console.WriteLine("Clear skies ...");
            }

            if (_sprinkler.IsSetOn && 
                _motherNature.Showers)
            {
                _sprinkler.Off();
            }
        }

        private void CheckTemp()
        {
            Console.WriteLine("Today will be {0} F", _motherNature.Temperature);
            if (_sprinkler.IsSetOn &&
                _motherNature.Temperature < 40)
            {
                Console.WriteLine("Turning off the sprinklers so that they don't freeze ...");
                _sprinkler.Off();
            }
            else if (_sprinkler.IsSetOn)
            {
                if (_motherNature.Temperature > 85)
                {
                    Console.WriteLine("Increasing watering time due to the heat!");
                    _sprinkler.DurationTimeMinutes = 60;
                }
                else
                {
                    _sprinkler.DurationTimeMinutes = 30;
                }
            }
        }

        private void CheckWeather()
        {
            _isWeatherNice = ((65 < _motherNature.Temperature && _motherNature.Temperature < 85) &&
                              !_motherNature.Showers);
        }
        #endregion

        #region Events

        private void _calendar_CalendarEvent(object sender, CalendarEventArgs e)
        {
            _currentDayProps = e;
            _fatherTime.SetDay(e.Day);

            CheckDayOfWeek();

            DoSprinkler();
            DoAlarm();
            DoCoffee();

            _fatherTime.IncrementDay();
        }


        private void _sprinkler_SprinklerEvent(object sender, EventArgs e)
        {
            // No action. It is automated!
            //CheckShower();
            //CheckTemp();
        }
        
        private void _alarm_AlarmRing(object sender, EventArgs e)
        {
            CheckSprinkler();
            CheckShower();
            CheckTemp();

            StartCoffee();
        }

        private void _coffeePot_CoffeePotBrew(object sender, EventArgs e)
        {
            CheckAlarm();
        }
        #endregion

    }
}
