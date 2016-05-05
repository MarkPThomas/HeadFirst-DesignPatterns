using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlAPI.Model;

namespace RemoteControlAPI.Tests
{
    // Client
    class RemoteLoader
    {
        public static void Run()
        {
            // Invoker
            RemoteControl remoteControl = new RemoteControl();

            // Receivers
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");
            
            // Commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            CeilingFanOnLowCommand ceilingFanOnLow = new CeilingFanOnLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorDown = new GarageDoorCloseCommand(garageDoor);



            // Set Commands
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, stereoOnWithCD, stereoOff);
            remoteControl.SetCommand(3, ceilingFanOnLow, ceilingFanOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);

            Console.WriteLine(remoteControl);

            // Invoke Commands
            for (int i = 0; i < remoteControl.numberOfSlots; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);
            }
        }
    }
}
