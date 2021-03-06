﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    internal class StereoOffCommand : ICommand
    {
        Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void execute()
        {
            _stereo.Off();
        }

        public void undo()
        {
            _stereo.On();
        }
    }
}
