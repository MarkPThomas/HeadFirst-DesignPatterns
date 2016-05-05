using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlAPI.Model;

namespace RemoteControlAPI.Tests
{
    public class RemoteWithMacro
    {
        public static void Run()
        {
            // Invoker
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            // Receivers
            Light livingRoomLight = new Light("Living Room");
            TV tv = new TV("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub("Outside");    

            // Commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            TVOnCommand tvOn = new TVOnCommand(tv);
            TVOffCommand tvOff = new TVOffCommand(tv);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            HottubOnCommand hottubOn = new HottubOnCommand(hottub);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            // Set Macro
            ICommand[] partyOn = { livingRoomLightOn, stereoOnWithCD, tvOn, hottubOn };
            ICommand[] partyOff = { livingRoomLightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            // Set Commands
            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            // Invoke Commands
            Console.WriteLine("==================================================");
            Console.WriteLine("============= Pressing Macro Buttons =============");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine(remoteControl);
            Console.WriteLine();
            for (int i = 0; i < remoteControl.numberOfSlots; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                if (!(remoteControl.onCommands[i] is NoCommand))
                {
                    Console.WriteLine();
                }
                remoteControl.OffButtonWasPushed(i);

                if (!(remoteControl.onCommands[i] is NoCommand))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("----- Undo -----");
            int undoSize = remoteControl.undoCommands.Count;
            for (int i = 0; i < undoSize; i++)
            {
                remoteControl.UndoButtonWasPushed();
            }
        }
    }
}
