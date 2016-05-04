using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Model
{
    public interface Command
    {
        void execute();
    }
}
