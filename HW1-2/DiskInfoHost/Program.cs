using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace DiskInfoHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost serviceHost = new ServiceHost(typeof(DiskInfo));
            ServiceMetadataBehavior behavior;
            behavior = serviceHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (behavior==null)
            {
                behavior = new ServiceMetadataBehavior();
                serviceHost.Description.Behaviors.Add(behavior);
            }
            serviceHost.AddServiceEndpoint(typeof(IDiskInfo), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            serviceHost.Open();
            Console.WriteLine("Для завершения нажмите < ENTER >\n");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}