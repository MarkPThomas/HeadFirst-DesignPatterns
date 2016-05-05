using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    /// <summary>
    /// 'Null object', which is useful when there is no meaningful object to return, yet you want to remove the responsibility for handling null from the client.
    /// </summary>
    internal class NoCommand : ICommand
    {
        public void execute() { }

        public void undo() { }
    }
}
