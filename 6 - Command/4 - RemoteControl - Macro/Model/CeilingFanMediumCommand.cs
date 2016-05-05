using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlAPI.Model
{
    internal class CeilingFanMediumCommand : ICommand
    {
        private CeilingFan.eSpeed _prevSpeed;
        CeilingFan _ceilingFan;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }


        public void execute()
        {
            _prevSpeed = _ceilingFan.speed;
            _ceilingFan.Medium();
        }

        public void undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.eSpeed.OFF:
                    _ceilingFan.Off();
                    break;
                case CeilingFan.eSpeed.LOW:
                    _ceilingFan.Low();
                    break;
                case CeilingFan.eSpeed.MEDIUM:
                    _ceilingFan.Medium();
                    break;
                case CeilingFan.eSpeed.HIGH:
                    _ceilingFan.High();
                    break;
                default:
                    break;
            }
        }
    }
}
