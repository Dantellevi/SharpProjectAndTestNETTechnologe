using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace CalculateHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(CalculateService.CalculateService)))
            {
                host.Open();
                Console.WriteLine("Сервер запущен...........");
                Console.ReadKey();
            }
        }
    }
}
