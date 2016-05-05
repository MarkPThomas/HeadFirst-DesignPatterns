using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    class LightOffCommand : Command
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void execute()
        {
            _light.Off();
        }
    }
}
