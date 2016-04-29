using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        string DoSomething();
    }
}
