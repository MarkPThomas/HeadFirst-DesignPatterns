
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBuilder.Model
{
    public abstract class AbstractBuilder
    {
        protected const string HOTEL = "Hotel";
        protected const string RESERVATION = "Reservation";
        protected const string SPECIAL_EVENT = "Special Event";
        protected const string TICKETS = "Tickets";

        public virtual void BuildDay(DateTime date) { }

        public virtual void SetDay(DateTime date) { }

        public virtual TripItem AddHotel(string name) { return new TripItem("", "", "", 0, 0); }

        public virtual TripItem AddReservation(string reservationHolder, decimal cost, int number) { return new TripItem("", "", "", 0, 0); }


        public virtual TripItem AddSpecialEvent(string name) { return new TripItem("", "", "", 0, 0); }


        public virtual TripItem AddTickets(string name) { return new TripItem("", "", "", 0, 0); }

        public virtual TripItem AddItemChild(TripItem tripItem) { return new TripItem("", "", "", 0, 0); }

        public virtual Planner GetVacationPlanner() { return new Planner(); }
    }
}
