using System;
using System.Windows;
using System.Windows.Threading;
using System.ComponentModel;
using System.Threading;

using DJ.Model;

namespace DJ.View
{
    /// <summary>
    /// Interaction logic for DJView.xaml
    /// </summary>
    public partial class DJViewModel : Window, IBeatObserver, IBPMObserver
    {
        IBeatModel _model;

        public int status;

        private bool _ticked;

        public DJViewModel(IBeatModel model)
        {
            InitializeComponent();

            _model = model;
            _model.RegisterObserver((IBeatObserver)this);
            _model.RegisterObserver((IBPMObserver)this);

            _ticked = false;
        }


        public void UpdateBPM()
        {
            if (_model.BPM == 0)
            {
                lblCurrentBPM.Content = "Offline";
            }
            else
            {
                lblCurrentBPM.Content = _model.BPM;
            }
        }

        public void UpdateBeat()
        {
            _ticked = !_ticked;

            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate ()
            {
                if (_ticked)
                {
                    beatBar.Value = 100;
                }
                else
                {
                    beatBar.Value = 0;
                }
            }));
        }
    }
}
