using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SummatorRemoutingService;

namespace SummatorHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new TcpChannel(51495);
            ChannelServices.RegisterChannel(channel);

            var service = new SummatorRemoutingService.SummatorWebService();
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(SummatorRemoutingService.SummatorWebService), "Summator", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Сервер запущен...........");
            Console.ReadKey();

        }
    }
}
