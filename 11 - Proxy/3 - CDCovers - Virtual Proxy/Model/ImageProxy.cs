using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
//using System.Windows.Controls;
//using System.Windows.Media.Imaging;
//using System.Windows;

// For 'volatile' modifier, see: http://www.dotnetperls.com/volatile

namespace CDCovers.Model
{
    public class ImageProxy
    {
        private volatile Image _imageIcon;
        public Uri UriSource { get; set; }

        private bool _retrieving = false;

        private readonly object syncLock = new object();

        private Font _font = new Font(new FontFamily("Arial"), 10);
        private Brush _brush = new SolidBrush(Color.Blue);

        public ImageProxy(string url)
        {
            UriSource = new Uri(url);
        }


        public int PixelHeight
        {
            get
            {
                if (_imageIcon != null)
                {
                    return _imageIcon.Height;
                }
                else
                {
                    return 600;
                }
            }
        }

        public int PixelWidth
        {
            get
            {
                if (_imageIcon != null)
                {
                    return _imageIcon.Width;
                }
                else
                {
                    return 800;
                }
            }
        }


        private void SetImageIcon(Image imageIcon)
        {
            lock (syncLock)
            {
                _imageIcon = imageIcon;
            }
        }

        public void PaintIcon(ref PictureBox component, ref Graphics g, int x, int y)
        {
            if (_imageIcon != null)
            {
                g.DrawImage(_imageIcon, x, y);
            }
            else
            {
                g.DrawString("Loading CD cover, please wait...", _font, _brush, x, y);

                if (!_retrieving)
                {
                    _retrieving = true;

                    Task _retrievalThread = new Task(() => run(UriSource, component));
                    try
                    {
                        _retrievalThread.Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.StackTrace);
                    }
                }
            }          
        }

        private void run(Uri url, PictureBox component)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] bytes = wc.DownloadData(url);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    _imageIcon = Image.FromStream(ms);
                    SetImageIcon(_imageIcon);
                    //component.Refresh();
                }
            }
        }
    }
}
