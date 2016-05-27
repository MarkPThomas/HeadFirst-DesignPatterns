using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CDCovers.Model;

namespace CDCovers.View
{
    public partial class CDCoverViewer : Form
    {
        private Dictionary<string, string> _cds = new Dictionary<string, string>();
        private PictureBox imageComponent = new PictureBox();
        ImageProxy icon;

        public CDCoverViewer(Dictionary<string, string> cds)
        {
            InitializeComponent();

            _cds = cds;
            CreateMyMenu();
            
            string url = _cds.Values.First();
            icon = new ImageProxy(url);

            CreatePictureBox();
        }

        public void CreateMyMenu()
        {
            // Create a main menu object.
            MainMenu mainMenu1 = new MainMenu();

            // Create empty menu item objects.
            MenuItem topMenuItem = new MenuItem();

            // Set the caption of the menu items.
            topMenuItem.Text = "&Favorite CDs";
            foreach (string name in _cds.Keys)
            {
                MenuItem menuItem = new MenuItem(name, new EventHandler(menuItem_Click));
                topMenuItem.MenuItems.Add(menuItem);
            }

            // Add the menu items to the main menu.
            mainMenu1.MenuItems.Add(topMenuItem);

            // Assign mainMenu1 to the form.
            Menu = mainMenu1;
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            string cdName = menuItem.Text;
            string url = _cds[cdName];
            icon = new ImageProxy(url);
            imageComponent.Refresh();
        }

        public void CreatePictureBox()
        {
                        // Dock the PictureBox to the form and set its background to white.
            imageComponent.Dock = DockStyle.Fill;
            imageComponent.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            imageComponent.Paint += new PaintEventHandler(imageComponent_Paint);

            // Add the PictureBox control to the Form.
            Controls.Add(imageComponent);
        }

        private void imageComponent_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            // Draw a string on the PictureBox.
            icon.PaintIcon(ref imageComponent, ref g, icon.PixelWidth, icon.PixelHeight);
        }
    }
}
