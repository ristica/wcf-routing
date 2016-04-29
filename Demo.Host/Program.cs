using Demo.Wcf;
using System.ServiceModel;

namespace Demo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "HOST - 1";
            System.Console.WriteLine("Starting the Service on host 1...");
            System.Console.WriteLine("");

            var host = new ServiceHost(typeof(DemoManager));
            host.Open();

            System.Console.WriteLine("Service started!");
            System.Console.WriteLine("");
            System.Console.WriteLine("Pres <Enter> to exit...");
            System.Console.WriteLine("");
            System.Console.Read();

            // housekeeping
            host.Close();
        }
    }
}
