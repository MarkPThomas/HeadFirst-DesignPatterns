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
    public class NoCommand : Command
    {
        public void execute() { }
    }
}
