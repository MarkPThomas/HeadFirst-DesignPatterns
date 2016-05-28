using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TripBuilder.Model;

namespace TripBuilder.Tests
{
    public class TripPlannerTestDrive
    {
        public static void Run()
        {
            // Concrete Builder
            VacationBuilder builder = new VacationBuilder();

            // Director
            TravelAgent travelAgent = new TravelAgent();
            travelAgent.ConstructPlanner(builder);

            // Getting product ...
            Planner trip = builder.GetVacationPlanner();
            trip.Print();
        }
    }
}
