using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Model
{
    public class LightOnCommand : Command
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void execute()
        {
            _light.On();
        }
    }
}
