using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse.Model
{
    public class MotherNature
    {
        private Random random = new Random();

        public int Temperature { get; private set; }
        public bool Showers { get; private set; }
        
        public MotherNature()
        {
            Temperature = 60;
        }

        public void SetNextDay()
        {
            SetShowers();
            SetTemperature();
        }

        private void SetShowers()
        {
            int pop = random.Next(100);
            Showers = (pop > 55);
        }

        private void SetTemperature()
        {
            int tempIncrement = random.Next(10);
            int tempSlope = 1;
            if (random.Next(2) > 0)
            {
                tempSlope = -1;
            }

            Temperature += (tempSlope * tempIncrement);
        }
    }
}
