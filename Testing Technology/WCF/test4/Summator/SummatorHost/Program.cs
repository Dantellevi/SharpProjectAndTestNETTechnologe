using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace SummatorHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(Summator.Summator)))
            {
                host.Open();

                Console.WriteLine("Сервер запущен..........");
                Console.ReadKey();
            }
        }
    }
}
