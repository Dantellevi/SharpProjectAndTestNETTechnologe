using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using OneWayService;
namespace HostMain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(OneWayService.OneWayService)))
            {
                host.Open();
                Console.WriteLine("Хост включен.....");
                Console.ReadKey();
            }
        }
    }
}
