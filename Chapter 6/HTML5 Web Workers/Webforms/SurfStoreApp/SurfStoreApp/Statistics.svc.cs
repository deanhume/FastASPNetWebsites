using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Threading;

namespace SurfStoreApp
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Statistics
    {
        [OperationContract]
        public string Update()
        {
            // Do something long running here
            Thread.Sleep(5000);

            return "Success";
        }
    }
}
