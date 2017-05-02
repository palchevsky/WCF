using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(TicTacToeService));
                host.Open();
                Console.WriteLine("Серевр запущен. Для завершения работы нажмите Enter");
                //Thread thrChechUserTime = new Thread(TicTacService.CheckUserLastTime);
                //thrChechUserTime.IsBackground = true;
                //thrChechUserTime.Start();
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
