using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Duplex_Summator
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IDuplexSummator_Service" в коде и файле конфигурации.
    [ServiceContract(CallbackContract =typeof(IDuplexSumatorCallback))]
    public interface IDuplexSummator_Service
    {

        


        [OperationContract(IsOneWay =true)]
        void GetSum(int x,int y);


    }

    public interface IDuplexSumatorCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendResult(int sum);
    }
}
