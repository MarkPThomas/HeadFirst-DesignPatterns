using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    internal class StereoOnWithCDCommand : ICommand
    {
        private int _priorVolume;

        private Stereo.eSetting _priorSetting;

        Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void execute()
        {
            _stereo.On();
            _priorSetting = _stereo.setting;
            _stereo.SetCd();
            _priorVolume = _stereo.volume;
            _stereo.SetVolume(11);
        }

        public void undo()
        {
            _stereo.On();
            switch (_priorSetting)
            {
                case Stereo.eSetting.CD:
                    _stereo.SetCd();
                    break;
                case Stereo.eSetting.DVD:
                    _stereo.SetDvd();
                    break;
                case Stereo.eSetting.Radio:
                    _stereo.SetRadio();
                    break;
                default:
                    break;
            }
            _stereo.SetVolume(_priorVolume);
        }
    }
}
