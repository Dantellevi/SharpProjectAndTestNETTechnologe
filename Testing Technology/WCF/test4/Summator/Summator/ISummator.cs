﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Summator
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ISummator" в коде и файле конфигурации.
    [ServiceContract]
    public interface ISummatorOLD
    {
        [OperationContract]
        int GetSum(int x, int y);
    }


    [ServiceContract(Name ="ISummator")]
    public interface ISummatorNEW
    {
        [OperationContract(Name ="GetSum")]
        int Getmul(int x, int y);
    }
}
