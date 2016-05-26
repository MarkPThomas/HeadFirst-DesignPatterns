using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Model
{
    public interface IBeatModel
    {
        int BPM { get; set; }

        // These are the methods the controller will use to direct the model based on user interaction.
        void Initialize();
        void On();
        void Off();

        // These methods allow the view and the controller to get state and to become observers.
        void RegisterObserver(IBeatObserver o);
        void RemoveObserver(IBeatObserver o);

        void RegisterObserver(IBPMObserver o);
        void RemoveObserver(IBPMObserver o);
    }
}
