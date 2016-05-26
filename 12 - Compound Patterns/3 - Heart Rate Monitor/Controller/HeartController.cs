using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DJ.Model;
using DJ.View;

namespace DJ.Controller
{
    public class HeartController : IController
    {
        IHeartModel _model;
        private DJViewModel _viewModel;
        private DJViewControl _viewControl;

        public HeartController(IHeartModel model)
        {
            _model = model;

            // Normally both the model and controller would be sent to a view, but in this case a separate view is created for each component.
            _viewModel = new DJViewModel(new HeartAdapter(model));
            _viewModel.Show();

            _viewControl = new DJViewControl(this, new HeartAdapter(model));
            _viewControl.Show();
            _viewControl.DisableStopMenuItem();
            _viewControl.EnableStartMenuItem();
        }

        public void DecreaseBPM()
        {
            // No action.
        }

        public void IncreaseBPM()
        {
            // No action.
        }

        public void SetBPM(int bpm)
        {
            // No action.
        }

        public void Start()
        {
            // No action.
        }

        public void Stop()
        {
            // No action.
        }
    }
}
