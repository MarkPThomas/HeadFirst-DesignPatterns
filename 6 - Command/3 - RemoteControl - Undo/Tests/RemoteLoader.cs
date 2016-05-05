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
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

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

            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorDown = new GarageDoorCloseCommand(garageDoor);



            // Set Commands
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanLow, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(4, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(5, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(6, stereoOnWithCD, stereoOff);

            // Invoke Commands
            Console.WriteLine("==================================================");
            Console.WriteLine("============= Testing Remote Loader  =============");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine(remoteControl);
            Console.WriteLine();
            for (int i = 0; i < remoteControl.numberOfSlots; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);

                if (!(remoteControl.onCommands[i] is NoCommand))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("----- Undo -----");
            remoteControl.UndoButtonWasPushed();
        }
    }
}
