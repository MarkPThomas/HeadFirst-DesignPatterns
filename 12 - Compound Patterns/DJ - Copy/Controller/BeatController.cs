using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DJ.Model;
using DJ.View;

namespace DJ.Controller
{
    public class BeatController : IController
    {
        private IBeatModel _model;
        private DJViewModel _viewModel;
        private DJViewControl _viewControl;

        public BeatController(IBeatModel model)
        {
            _model = model;

            // Normally both the model and controller would be sent to a view, but in this case a separate view is created for each component.
            _viewModel = new DJViewModel(model);
            _viewModel.Show();

            _viewControl = new DJViewControl(this, model);
            _viewControl.Show();
            _viewControl.DisableStopMenuItem();
            _viewControl.EnableStartMenuItem();

            _model.Initialize();
        }

        public void DecreaseBPM()
        {
            _model.BPM -= 1;
            _viewControl.SetTextBox(_model.BPM.ToString());
        }

        public void IncreaseBPM()
        {
            _model.BPM += 1;
            _viewControl.SetTextBox(_model.BPM.ToString());
        }

        public void SetBPM(int bpm)
        {
            _model.BPM = bpm;
        }

        public void Start()
        {
            _model.On();
            _viewControl.EnableStopMenuItem();
            _viewControl.DisableStartMenuItem();

        }

        public void Stop()
        {
            _model.Off();
            _viewControl.DisableStopMenuItem();
            _viewControl.EnableStartMenuItem();

        }
    }
}
