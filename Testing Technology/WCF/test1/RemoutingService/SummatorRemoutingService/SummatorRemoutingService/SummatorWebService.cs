using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummatorRemoutingService
{
    public class SummatorWebService : MarshalByRefObject, ISumattorRemouteService
    {
        public int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
