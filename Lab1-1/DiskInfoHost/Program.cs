using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace DiskInfoHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new
            ServiceHost(typeof(DiskInfo));
            sh.AddServiceEndpoint(typeof(IDiskInfo), new WSHttpBinding(), "http://localhost:8081/DiskInfo");
            sh.Open();
            Console.WriteLine("Для завершения нажмите < ENTER >\n");
            Console.ReadLine();
            sh.Close();
        }
    }
}