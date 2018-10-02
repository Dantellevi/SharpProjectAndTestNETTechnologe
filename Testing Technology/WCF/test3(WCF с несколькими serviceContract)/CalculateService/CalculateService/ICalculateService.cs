using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculateService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ICalculateService" в коде и файле конфигурации.
    [ServiceContract]
    public interface ISummator
    {
        [OperationContract]
        int GetSum(int x,int y);
    }


    [ServiceContract]
    public interface IMultiplexor
    {
        [OperationContract]
        int GetMultiply(int x, int y);
    }
}
