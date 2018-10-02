using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OneWayService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IOneWayService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IOneWayService
    {
        [OperationContract]
        void RequestOperation();


        [OperationContract]
        void RequestOperationException();

        [OperationContract(IsOneWay =true)]
        void OneWayOperation();

        [OperationContract(IsOneWay = true)]
        void OneWayOperationException();

    }
}
