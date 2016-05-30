using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoHouse.Model;

namespace AutoHouse.Tests
{
    public class AutoHouseTests
    {
        public static void Run()
        {
            Mediator mediator = new Mediator(new Alarm(), new Calendar(DayOfWeek.Sunday), new CoffeePot(), new Sprinkler());
            mediator.Start();
        }
    }
}
