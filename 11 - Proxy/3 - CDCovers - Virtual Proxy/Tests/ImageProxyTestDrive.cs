using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

using CDCovers.Model;
using CDCovers.View;

namespace CDCovers.Tests
{
    public class ImageProxyTestDrive
    {
        public static void Run()
        {            
            Dictionary<string, string> cds = new Dictionary<string, string>();
            cds.Add("Buddha Bar", @"http://images.amazon.com/images/P/B00009XBYK.01.LZZZZZZZ.jpg");
            cds.Add("Ima", @"http://images.amazon.com/images/P/B000005IRM.01.LZZZZZZZ.jpg");
            cds.Add("Karma", @"http://images.amazon.com/images/P/B000005DCB.01.LZZZZZZZ.gif");
            cds.Add("MCMXC A.D.", @"http://images.amazon.com/images/P/B000002URV.01.LZZZZZZZ.jpg");
            cds.Add("Northern Exposure", @"http://images.amazon.com/images/P/B000003SFN.01.LZZZZZZZ.jpg");
            cds.Add("Selected Ambient Works, Vol. 2", @"http://images.amazon.com/images/P/B000002MNZ.01.LZZZZZZZ.jpg");

            CDCoverViewer frame = new CDCoverViewer(cds);
            frame.ShowDialog();
        }
    }
}
