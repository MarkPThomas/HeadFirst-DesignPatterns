using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBuilder.Model
{
    public class Planner
    {
        private DateTime _baseDate = new DateTime();
        private DateTime _currentDate;
        
        public Dictionary<DateTime, List<TripItem>> Vacation { get; private set; } = new Dictionary<DateTime, List<TripItem>>();

        public Planner()
        {
            _currentDate = _baseDate;
        }

        public void AddDay(DateTime date)
        {
            if (!Vacation.ContainsKey(date))
            {
                Vacation.Add(date, new List<TripItem>());
                _currentDate = date;
            }
        }

        public void SetDay(DateTime date)
        {
            if (!Vacation.ContainsKey(date))
            {
                Console.WriteLine("Please use a currently added day, or begin building the current day: " + _currentDate);
            }
            else
            {
                _currentDate = date;
            }
        }

        public TripItem AddTripItem(TripItem tripItem)
        {
            if (!DaySet()) { return null; }
            
            if (CurrentDayContainsChild(tripItem.Type, tripItem.Name))
            {
                return GetCurrentDayChild(tripItem.Type, tripItem.Name);
            }
            else
            {
                List<TripItem> currentDay = Vacation[_currentDate];
                currentDay.Add(tripItem);
                return tripItem;
            }
        }

        public void Print()
        {
            int dayCount = 1;
            foreach (DateTime day in Vacation.Keys)
            {
                Console.WriteLine("====== Day {0}: {1} ======", dayCount, day.ToShortDateString());
                foreach (TripItem item in Vacation[day])
                {
                    item.Print();
                }
                Console.WriteLine();
                dayCount++;
            }
        }


        private bool DaySet()
        {
            if (Vacation.Keys.Count == 0 || _currentDate == _baseDate)
            {
                Console.WriteLine("Please add a day to add items to first.");
                return false;
            }
            else if (!Vacation.ContainsKey(_currentDate))
            {
                Console.WriteLine("Please use a currently added day, or begin building the current day: " + _currentDate);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CurrentDayContainsChild(string type, string name)
        {
            foreach (TripItem item in Vacation[_currentDate])
            {
                if (string.Compare(item.Type, type) == 0 &&
                    string.Compare(item.Name, name) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private TripItem GetCurrentDayChild(string type, string name)
        {
            foreach (TripItem item in Vacation[_currentDate])
            {
                if (string.Compare(item.Type, type) == 0 &&
                    string.Compare(item.Name, name) == 0)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
