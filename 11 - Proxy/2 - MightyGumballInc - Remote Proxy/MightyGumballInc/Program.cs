using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ServiceModel;
using System.ServiceModel.Description;

using MightyGumballLib.Model;

namespace MightyGumballLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8000/GumballMachineInc/");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(GumballMachine), baseAddress);

            try
            {
                // Step 3 Add a service endpoint.
                // Adding a service endpoint is optional when using .NET Framework 4 or later. 
                // In these versions, if no endpoints are added in code or configuration, WCF adds one default endpoint for each combination of base address and contract implemented by the service. 
                //selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
            catch (TimeoutException te)
            {
                Console.WriteLine("An exception occurred: {0}", te.Message);
                selfHost.Abort();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred: {0}", e.Message);
                selfHost.Abort();
                throw;
            }
        }
    }
}
