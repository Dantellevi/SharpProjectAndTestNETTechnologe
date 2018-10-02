using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SvcTest
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerSession,ConcurrencyMode =ConcurrencyMode.Single)]
    public class Service1 : IService1
    {
        
        public void Lock1()
        {
            Console.WriteLine("Thread {0} has start Lock1()", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Thread {0} has Complite Lock1()", Thread.CurrentThread.ManagedThreadId);
        }

        public void Lock2()
        {
            Console.WriteLine("Thread {0} has start Lock2()", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Thread {0} has Complite Lock2()", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
