using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace HostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Duplex_Summator.DuplexSummator_Service)))
            {
                host.Open();
                Console.WriteLine("Хост старт......");
                Console.ReadKey();
            }
        }
    }
}
