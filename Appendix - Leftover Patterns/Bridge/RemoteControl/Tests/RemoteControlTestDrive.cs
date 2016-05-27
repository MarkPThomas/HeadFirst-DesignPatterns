using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemoteControlTV.Model;

namespace RemoteControlTV.Tests
{
    public class RemoteControlTestDrive
    {
        public static void Run()
        {
            TV rca = new RCA();
            RemoteControl remoteRCA = new ConcreteRemote(rca);

            remoteRCA.On();
            remoteRCA.SetChannel(10);
            remoteRCA.Off();

            Console.WriteLine("\nI got a new TV! Time to reprogram the remote ...");
            TV sony = new Sony();
            ConcreteRemote sonyRemote = remoteRCA as ConcreteRemote;
            sonyRemote.ProgramToNewTV(sony);

            sonyRemote.On();
            sonyRemote.SetChannel(10);
            sonyRemote.NextChannel();
            sonyRemote.NextChannel();
            sonyRemote.PreviousChannel();
            sonyRemote.Off();
        }
    }
}
