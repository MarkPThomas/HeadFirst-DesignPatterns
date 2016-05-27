using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTV.Model
{
    public class ConcreteRemote : RemoteControl
    {
        private int _currentStation;

        public ConcreteRemote(TV implementor)
            : base(implementor)
        { }

        public override void SetChannel(int channel)
        {
            base.SetChannel(channel);
            _currentStation = channel;
        }

        public void NextChannel()
        {
            SetChannel(++_currentStation);
        }

        public void PreviousChannel()
        {
            SetChannel(--_currentStation);
        }

        public void ProgramToNewTV(TV implementor)
        {
            _implementor = implementor;
        }
    }
}
