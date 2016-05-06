using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlAPI.Model;

namespace RemoteControlAPI.Tests
{
    // Client
    class RemoteLoaderLambdas
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
            
            // Set Commands           
            remoteControl.SetCommand(0, () => { livingRoomLight.On(); }, () => { livingRoomLight.Off(); });
            remoteControl.SetCommand(1, () => { kitchenLight.On(); }, () => { kitchenLight.Off(); });
            remoteControl.SetCommand(2, () => { ceilingFan.Low(); }, () => { ceilingFan.Off(); });
            remoteControl.SetCommand(3, () => { ceilingFan.Medium(); }, () => { ceilingFan.Off(); });
            remoteControl.SetCommand(4, () => { ceilingFan.High(); }, () => { ceilingFan.Off(); });
            remoteControl.SetCommand(5, () => { garageDoor.Up(); }, () => { garageDoor.Down(); });

            Action stereoOnWithCD = () => { stereo.On(); stereo.SetCd(); stereo.SetVolume(11); };
            remoteControl.SetCommand(6, stereoOnWithCD, () => { stereo.Off(); });

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
            }
        }
    }
}
