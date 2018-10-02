using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CarService;

namespace ConsoleHOST
{
    class Program
    {
        static void Main(string[] args)
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
