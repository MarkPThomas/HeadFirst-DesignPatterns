using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    internal class MacroCommand : ICommand
    {
        ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].execute();
            }
        }

        public void undo()
        {
            for (int i = _commands.Length-1; i >= 0; i--)
            {
                _commands[i].undo();
            }
        }
    }
}
