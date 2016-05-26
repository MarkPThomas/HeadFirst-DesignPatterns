using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using DJ.Controller;
using DJ.Model;

namespace DJ.View
{
    /// <summary>
    /// Interaction logic for DJViewControl.xaml
    /// </summary>
    public partial class DJViewControl : Window
    {
        IController _controller;

        public DJViewControl(IController controller, IBeatModel model)
        {
            InitializeComponent();

            _controller = controller;
            txtBxBPM.Text = model.BPM.ToString();
        }

        public void EnableStopMenuItem()
        {
            mItemStop.IsEnabled = true;
        }
        public void DisableStopMenuItem()
        {
            mItemStop.IsEnabled = false;
        }

        public void EnableStartMenuItem()
        {
            mItemStart.IsEnabled = true;
        }
        public void DisableStartMenuItem()
        {
            mItemStart.IsEnabled = false;
        }

        public void SetTextBox(string text)
        {
            txtBxBPM.Text = text;
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            int bpm;
            bool res = int.TryParse(txtBxBPM.Text, out bpm);
            if (res)
            {
                _controller.SetBPM(bpm);
            }
            else
            {
                txtBxBPM.Text = bpm.ToString();
                MessageBox.Show("Please enter an integer value.");
            }
        }

        private void btnDecreaseBPM_Click(object sender, RoutedEventArgs e)
        {
            _controller.DecreaseBPM();
        }

        private void btnIncreaseBPM_Click(object sender, RoutedEventArgs e)
        {
            _controller.IncreaseBPM();
        }

        private void mItemStart_Click(object sender, RoutedEventArgs e)
        {
            _controller.Start();
        }

        private void mItemStop_Click(object sender, RoutedEventArgs e)
        {
            _controller.Stop();
        }

        private void mItemQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _controller.Stop();
        }
    }
}
