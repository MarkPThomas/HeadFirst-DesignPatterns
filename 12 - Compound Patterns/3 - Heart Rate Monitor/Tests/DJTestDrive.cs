using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DJ.Model;
using DJ.Controller;

namespace DJ.Tests
{
    public class DJTestDrive
    {
        public static void Run()
        {
            IBeatModel model = new BeatModel();
            IController controller = new BeatController(model);
        }
    }
}
