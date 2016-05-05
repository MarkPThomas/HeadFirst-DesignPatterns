using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    public class RemoteControl
    {
        public int numberOfSlots { get; private set; }

        Command[] OnCommands;
        Command[] OffCommands;

        public RemoteControl()
        {
            numberOfSlots = 7;

            OnCommands = new Command[numberOfSlots];
            OffCommands = new Command[numberOfSlots];

            Command noCommand = new NoCommand();
            for (int i = 0; i < numberOfSlots; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command OnCommand, Command OffCommand)
        {
            OnCommands[slot] = OnCommand;
            OffCommands[slot] = OffCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < OnCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + OnCommands[i].GetType().Name.PadRight(27) +
                                    "     " + OffCommands[i].GetType().Name + "\n");
            }

            return stringBuff.ToString();
        }
    }
}
