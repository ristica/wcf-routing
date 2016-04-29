using System;
using Demo.Contracts;
using System.ServiceModel;

namespace Demo.Wcf
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class DemoManager2 : IContract2
    {
        public string DoSomethingElse()
        {
            Console.WriteLine("DemoManager.DoSomethingElse() called...");
            return "success";
        }
    }
}
