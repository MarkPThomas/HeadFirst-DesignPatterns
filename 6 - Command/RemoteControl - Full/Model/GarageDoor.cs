using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class GarageDoor
    {
        public string location { get; private set; }

        public GarageDoor(string location)
        {
            this.location = location;
        }

        public void Up()
        {
            Console.WriteLine("Garage door is opening.");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is closing.");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is stopped.");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light is on.");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light is off.");
        }
    }
}
