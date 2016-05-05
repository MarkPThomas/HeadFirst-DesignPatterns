using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControl.Model;

namespace RemoteControl.Tests
{
    // Client
    public class RemoteControlTest
    {
        public static void Run()
        {
            // Invoker
            SimpleRemoteControl remote = new SimpleRemoteControl();

            // Receiver
            Light light = new Light();

            // Command
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();


            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
