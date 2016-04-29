using System;
using Demo.Contracts;
using System.ServiceModel;

namespace Demo.Wcf
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class DemoManager : IContract
    {
        public string DoSomething(string input)
        {
            Console.WriteLine("DemoManager.DoSomething() called...");
            return input;
        }
    }
}
