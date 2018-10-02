using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace CarHost
{
    class Program
    {
        static void Main()
        {

            using (var host = new ServiceHost(typeof(CarService.CarService)))
            {
                host.Open();
                Console.WriteLine("Сервер запущен......");

                Console.ReadKey();

            }

        }
    }
}
