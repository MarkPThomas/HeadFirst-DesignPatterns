using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CDCovers.Model
{
    public class ImageComponent : PictureBox
    {
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }

            set
            {
                base.BackgroundImage = value;
            }
        }
        
        public ImageComponent(Image icon)
        {
            Image = icon;
        }

        public override void Refresh()
        {
            base.Refresh();
            
        }
    }
}
