using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// See: https://msdn.microsoft.com/en-us/library/ms731835.aspx

namespace GettingStartedLib
{
    
    //This contract defines an online calculator.Notice the ICalculator interface is marked with the ServiceContractAttribute attribute. 
    //This attribute defines a namespace that is used to disambiguate the contract name. 
    //Each calculator operation is marked with the OperationContractAttribute attribute.
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
    }
}
