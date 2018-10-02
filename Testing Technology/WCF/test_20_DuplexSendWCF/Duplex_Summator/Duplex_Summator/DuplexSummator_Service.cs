using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Duplex_Summator
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "DuplexSummator_Service" в коде и файле конфигурации.
    public class DuplexSummator_Service : IDuplexSummator_Service
    {
        
        public void GetSum(int x, int y)
        {
            OperationContext.Current.GetCallbackChannel<IDuplexSumatorCallback>().SendResult(x + y);
        }
    }
}
