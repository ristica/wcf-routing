using System.ServiceModel;
using System.ServiceModel.Routing;

namespace Demo.Host.Routing
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "ROUTING HOST";
            System.Console.WriteLine("### Routing Host ###");
            System.Console.WriteLine("");

            var routingHost = new ServiceHost(typeof (RoutingService));
            routingHost.Open();

            System.Console.WriteLine("Routing is running...");
            System.Console.WriteLine("Pres <Enter> to exit...");
            System.Console.WriteLine("");
            System.Console.Read();

            routingHost.Close();
        }
    }
}
