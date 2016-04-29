using Demo.Contracts;
using System.ServiceModel;

namespace Demo.Proxies
{
    public class ProcessClient2 : ClientBase<IContract2>, IContract2
    {
        public string DoSomethingElse()
        {
            return Channel.DoSomethingElse();
        }
    }
}
