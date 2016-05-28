using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBuilder.Model
{
    public class VacationBuilder : AbstractBuilder
    {
        private Planner _vacationPlanner;

        public VacationBuilder()
        {
            _vacationPlanner = new Planner();
        }
        
        public override void BuildDay(DateTime date)
        {
            _vacationPlanner.AddDay(date);
        }

        public override void SetDay(DateTime date)
        {
            _vacationPlanner.SetDay(date);
        }

        public override TripItem AddHotel(string name)
        {
            TripItem item = new TripItem(HOTEL, name, "", 0, 0);
            return _vacationPlanner.AddTripItem(item);
        }

        public override TripItem AddReservation(string reservationHolder, decimal cost, int number)
        {
            TripItem item = new TripItem(RESERVATION, "", reservationHolder, cost, number);
            return _vacationPlanner.AddTripItem(item);
        }

        public override TripItem AddSpecialEvent(string name)
        {
            TripItem item = new TripItem(SPECIAL_EVENT, name, "", 0, 0);
            return _vacationPlanner.AddTripItem(item);
        }

        public override TripItem AddTickets(string name)
        {
            TripItem item = new TripItem(TICKETS, name, "", 0, 0);
            return _vacationPlanner.AddTripItem(item);
        }

        public override Planner GetVacationPlanner()
        {
            return _vacationPlanner;
        }
    }
}
