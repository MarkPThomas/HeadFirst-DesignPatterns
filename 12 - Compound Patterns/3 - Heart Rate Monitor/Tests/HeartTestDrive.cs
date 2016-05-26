using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DJ.Model;
using DJ.Controller;

namespace DJ.Tests
{
    public class HeartTestDrive
    {
        public static void Run()
        {
            HeartModel heartModel = new HeartModel();
            IController controller = new HeartController(heartModel);
        }
    }
}
