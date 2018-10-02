using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace OneWayService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "OneWayService" в коде и файле конфигурации.
    public class OneWayService : IOneWayService
    {
        public void OneWayOperation()
        {
            Thread.Sleep(5000);
        }

        public void OneWayOperationException()
        {
            throw new NotImplementedException();
        }

        public void RequestOperation()
        {
            Thread.Sleep(5000);
        }

        public void RequestOperationException()
        {
            throw new NotImplementedException();
        }
    }
}
