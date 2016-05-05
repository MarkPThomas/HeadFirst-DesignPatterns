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

        public ICommand[] onCommands { get; private set; }
        public ICommand[] offCommands { get; private set; }
        ICommand undoCommand;

        public RemoteControlWithUndo()
        {
            numberOfSlots = 7;

            onCommands = new ICommand[numberOfSlots];
            offCommands = new ICommand[numberOfSlots];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < numberOfSlots; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand OnCommand, ICommand OffCommand)
        {
            onCommands[slot] = OnCommand;
            offCommands[slot] = OffCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name.PadRight(27) +
                                    "     " + offCommands[i].GetType().Name + "\n");
            }

            return stringBuff.ToString();
        }
    }
}
