using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.IO;

namespace DiskInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IDiskInfo> factory =
            new ChannelFactory<IDiskInfo>(new WSHttpBinding(),
            new EndpointAddress("http://localhost:8081/DiskInfo"));
            IDiskInfo channel = factory.CreateChannel();
            string address = @"D:\";
            string[] results = channel.GetDiskInfo(address);
            Console.WriteLine("Содержимое папки {0}", address);
            if (results != null)
            {
                foreach (var result in results)
                {
                    Console.WriteLine("{0} ", result);
                }
            }
            else
            {
                Console.WriteLine("Папка не найдена!");
            }
            Console.WriteLine("Для завершения нажмите < ENTER >\n");
            Console.ReadLine();
            factory.Close();
        }
    }
}