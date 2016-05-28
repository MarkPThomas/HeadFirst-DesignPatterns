using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBuilder.Model
{
    public class TravelAgent
    {
        public Planner ConstructPlanner(AbstractBuilder builder)
        {
            // Create first day
            builder.BuildDay(new DateTime(2008, 3, 4, 0, 0, 0));
            builder.AddHotel("Grand Facadian");
            builder.AddReservation("Mark", 100, 2);
            builder.AddSpecialEvent("Patterns On Ice");
            builder.AddTickets("Patterns On Ice tickets");

            // Create second day
            builder.BuildDay(new DateTime(2008, 3, 5, 0, 0, 0));
            builder.AddSpecialEvent("Ranger Rick campfire");
            builder.AddHotel("Hippy Hostel");
            builder.AddReservation("Char", 30, 2);

            // Create third day
            builder.BuildDay(new DateTime(2008, 3, 6, 9, 0, 0));

            //  Create special event that has a ticket.
            builder.AddSpecialEvent("Barnum & Bailey's Circus").AddTickets("Barnum & Bailey's Circus tickets");

            //  Create hotel with reservation & special event 
            builder.AddHotel("The Hilton").AddReservation("Mark", 60, 2);
            builder.AddHotel("The Hilton").AddSpecialEvent("Sigfried & Roy");

            // Add item back to day 2
            builder.SetDay(new DateTime(2008, 3, 5, 0, 0, 0));
            builder.AddTickets("The Book of Mormon on Broadway");

            // Add ticket to second day special event
            builder.AddSpecialEvent("Ranger Rick campfire").AddTickets("Ranger Rick tickets");

            return builder.GetVacationPlanner();
        }
    }
}
