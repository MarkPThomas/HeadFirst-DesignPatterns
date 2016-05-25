using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MightyGumballInc.Model
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IGumballMachineService
    {
        int Count
        {
            [OperationContract]
            get;
        }

        string Location
        {
            [OperationContract]
            get;
        }

        //IState State
        //{
        //    [OperationContract]
        //    get;
        //}
    }
}
