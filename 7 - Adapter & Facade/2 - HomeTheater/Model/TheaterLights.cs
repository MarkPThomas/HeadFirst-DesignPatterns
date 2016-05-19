using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater.Model
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater Ceiling lights on.");
        }

        public void Off()
        {
            Console.WriteLine("Theater Ceiling lights off.");
        }

        public void Dim(int level)
        {
            Console.WriteLine("Theater Ceiling lights dimming to {0}%.", level);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
