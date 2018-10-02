using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Xml.Linq;
using System.Globalization;

namespace CarService
{
    //[ErrorHandlerBehavior(typeof(MainErrorHandler))]
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single,IncludeExceptionDetailInFaults =true)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "CarService" в коде и файле конфигурации.
    public class CarService : ICarService
    {
        
        public Car GetCar(int id)
        {
            
            var file = ConfigurationManager.AppSettings["fileCar"]; //xml файл для считывания
            Car result;// объект запроса

            var doc = XDocument.Load(file);// загрузка данных

            var element = doc.Descendants("Car").FirstOrDefault(x => x.Attribute("Id").Value == id.ToString());// из объекта Car  считываем индификатор 
            var type = element.Attribute("Type").Value;//определяем тип
            switch (type)
            {
                case "Truck":
                    {
                        result = new TruckCar();
                        long val = long.Parse(element.Element("Capasity").Value);
                        ((TruckCar)result).Capasity = val;//получаем значение из поля Capasity
                        break;
                    }
                case "Passeger":
                    {
                        result = new PassegerCar();
                        ((PassegerCar)result).Passegers = int.Parse(element.Element("Passegers").Value, CultureInfo.GetCultureInfo("en-US"));//получаем значение из поля Passeger
                        break;
                    }
                default:
                    {
                        result = new Car();
                        break;
                    }
            }

            result.Id = int.Parse(element.Attribute("Id").Value);
            result.Vendor = element.Element("Vendor").Value;
            result.Model = element.Element("Model").Value;
            result.Year = int.Parse(element.Element("Year").Value);
            /*
             * if(MailEge==Null)
             * {
             var fault = new NullElementFault()
             {
                 Id=result.Id,
                 Vendor=result.Vendor,
                 Model=result.Model,
                 Year=result.Year
             };
             throw FaultException<NullElementFault>(fault,"Element","MileEge Not found!!",new faultCode("NullElementException"));

              }
              */
            return result;
        }

        public void SetCar(Car c)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];

            var element = new XElement("Car", new XAttribute("Id", c.Id), new XElement("Vendor", c.Vendor), new XElement("Model", c.Model), new XElement("Year", c.Year));
            if (c is TruckCar)
            {
                element.Add(new XAttribute("Type", "Truck"), new XElement("Capasity", ((TruckCar)c).Capasity.ToString(CultureInfo.GetCultureInfo("en-US"))));
            }
            else
            {
                element.Add(new XAttribute("Type", "Passeger"), new XElement("Passegers", ((PassegerCar)c).Passegers.ToString(CultureInfo.GetCultureInfo("en-US"))));
            }
            var doc = XDocument.Load(file);

            doc.Root.Add(element);

            doc.Save(file);
        }
    }
}
