using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CarService
{
    [KnownType(typeof(TruckCar))]
    [KnownType(typeof(PassegerCar))]
    [DataContract]
    public class Car:IExtensibleDataObject
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Vendor { get; set; }
        [DataMember]
        public string Model { get; set; }

        //объект хранит данные которых нет на сервере но которые передает клиент в данном случае поле Year
        public ExtensionDataObject ExtensionData { get; set; }  

        


        //[DataMember]
        //public int Year { get; set; }


       

    }
}
