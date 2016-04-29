using Demo.Contracts;
using System.ServiceModel;

namespace Demo.Proxies
{
    public class ProcessClient : ClientBase<IContract>, IContract
    {
        public string DoSomething(string input)
        {
            return Channel.DoSomething(input);
        }
    }
}
