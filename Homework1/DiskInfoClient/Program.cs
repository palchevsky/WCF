using DiskInfoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DiskInfoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IDiskInfo> factory = new ChannelFactory<IDiskInfo>(
                  new BasicHttpBinding(),
                  new EndpointAddress("http://localhost:8081/DiskInfoLibrary"));
            IDiskInfo channel = factory.CreateChannel();
            string address =@"H:\Projects";
            string[] results = channel.GetDiskInfo(address);
            Console.WriteLine("Содержимое папки {0}", address);
            foreach (var result in results)
            {
                Console.WriteLine("{0} ",result);
            }
            Console.WriteLine("Для завершения нажмите <ENTER>\n");
            Console.ReadLine();
            factory.Close();

        }
    }
}
