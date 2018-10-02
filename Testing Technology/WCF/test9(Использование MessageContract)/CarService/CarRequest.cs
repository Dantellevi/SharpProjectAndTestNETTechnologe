using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CarService
{
    [MessageContract(IsWrapped = true, WrapperName = "CarRequest", WrapperNamespace = "http://inclickDomain.com")]
    public class CarRequest
    {
        [MessageBodyMember(Namespace ="http://inclickDomain.com")]
        public int Id { get; set; }
        [MessageHeader(Namespace = "http://inclickDomain.com")]
        public string LicenseKey { get; set; }

    }
}
