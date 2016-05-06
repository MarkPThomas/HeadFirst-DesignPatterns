using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlAPI.Model;
using RemoteControlAPI.Tests;

namespace RemoteControlAPI
{
    /// <summary>
    /// This version of the program is more compact by forgoing command classes and instead using actions to delegate lambda functions.
    /// This results in far fewer classes and lighter weight coding.
    /// However, only one method can be called for the commands, and no state is stored, so this is not a good pattern to use if you want to support 'undo' capability.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            RemoteLoaderLambdas.Run();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
