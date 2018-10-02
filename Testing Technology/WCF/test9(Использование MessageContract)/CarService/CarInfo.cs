using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CarService
{
    [MessageContract(IsWrapped =true,WrapperName ="CarInfoWrapper",WrapperNamespace ="http://inclickDomain.com")]
  public class CarInfo
  {
        public CarInfo()
        {

        }

        public CarInfo(Car Instance)
        {
            Id = Instance.Id;
            Vendor = Instance.Vendor;
            Model = Instance.Model;
            Year = Instance.Year;

        }

       [MessageBodyMember]
        public int Id { get; set; }
        [MessageBodyMember]
        public string Vendor { get; set; }
        [MessageBodyMember]
        public string Model { get; set; }
        [MessageBodyMember]
        public int Year { get; set; }
    }
}
