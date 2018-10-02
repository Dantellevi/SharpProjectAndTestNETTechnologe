using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CarService;
using System.ServiceModel.Description;

namespace ConsoleHOST
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CarService.CarService)))
            {
                var mexBehavior = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };

                host.Description.Behaviors.Add(new MainErrorHandlerBehavior());
                host.Description.Behaviors.Add(mexBehavior);
                host.AddServiceEndpoint(typeof(ICarService), new BasicHttpBinding(), "CarService");
                //host.Description.Behaviors.Add(new MainErrorHandlerBehavior(typeof(MainErrorHandler)));
                host.Open();
                Console.WriteLine("Сервер запущен......");

                Console.ReadKey();

            }
        }
    }
}
