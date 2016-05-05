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

        public Stack<ICommand> undoCommands { get; private set; }

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

            undoCommands = new Stack<ICommand>();
        }

        public void SetCommand(int slot, ICommand OnCommand, ICommand OffCommand)
        {
            onCommands[slot] = OnCommand;
            offCommands[slot] = OffCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommands.Push(onCommands[slot]);
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommands.Push(offCommands[slot]);
        }

        public void UndoButtonWasPushed()
        {
            undoCommands.Pop().undo();
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
