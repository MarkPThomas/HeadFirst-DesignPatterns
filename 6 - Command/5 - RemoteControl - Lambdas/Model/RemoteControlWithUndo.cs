using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class RemoteControlWithUndo
    {
        public int numberOfSlots { get; private set; }

        public Action[] onCommands { get; private set; }
        public Action[] offCommands { get; private set; }

        public RemoteControlWithUndo()
        {
            numberOfSlots = 7;

            onCommands = new Action[numberOfSlots];
            offCommands = new Action[numberOfSlots];
            
            for (int i = 0; i < numberOfSlots; i++)
            {
                onCommands[i] = (Action)(() => { });
                offCommands[i] = (Action)(() => {  });
            }
        }

        public void SetCommand(int slot, Action OnCommand, Action OffCommand) 
        {
            onCommands[slot] = OnCommand;
            offCommands[slot] = OffCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot]();
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot]();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                //stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name.PadRight(27) +
                //                    "     " + offCommands[i].GetType().Name + "\n");
            }

            return stringBuff.ToString();
        }
    }
}
