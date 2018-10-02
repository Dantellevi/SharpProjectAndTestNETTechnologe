using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculateService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "CalculateService" в коде и файле конфигурации.
    public class CalculateService : ISummator, IMultiplexor
    {
        public int GetMultiply(int x, int y)
        {
            return x * y;
        }

        public int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
