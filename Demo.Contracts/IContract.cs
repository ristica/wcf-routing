using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface IContract
    {
        /// <summary>
        /// "xxx" will play the crucial role in the
        /// later added CustomFilter :-)
        /// </summary>
        /// <param name="xxx"></param>
        /// <returns></returns>
        [OperationContract]
        string DoSomething(string xxx);
    }
}
