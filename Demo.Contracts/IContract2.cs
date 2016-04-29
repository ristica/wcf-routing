using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface IContract2
    {
        [OperationContract]
        string DoSomethingElse();
    }
}
