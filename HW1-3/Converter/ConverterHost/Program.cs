using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConverterHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(Converter));
            ServiceMetadataBehavior behavior;
            behavior = serviceHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (behavior == null)
            {
                behavior = new ServiceMetadataBehavior();
                serviceHost.Description.Behaviors.Add(behavior);
            }
            serviceHost.AddServiceEndpoint(typeof(IConverter), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            serviceHost.Open();
            Console.WriteLine("Для завершения нажмите < ENTER >\n");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
