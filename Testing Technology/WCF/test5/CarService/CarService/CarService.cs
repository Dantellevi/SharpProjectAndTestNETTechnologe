using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Xml.Linq;

namespace CarService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "CarService" в коде и файле конфигурации.
    public class CarService : ICarService
    {
        public Car GetCar(int id)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];
            var result = new Car();

            var doc = XDocument.Load(file);

            var element = doc.Descendants("Car").FirstOrDefault(x => x.Attribute("Id").Value == id.ToString());
            result.Id = int.Parse(element.Attribute("Id").Value);
            result.Vendor = element.Element("Vendor").Value;
            result.Model = element.Element("Model").Value;
            result.Year = int.Parse(element.Element("Year").Value);

            return result;
        }

        public void SetCar(Car c)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];
            var doc = XDocument.Load(file);

            doc.Root.Add(new XElement("Car", new XAttribute("Id", c.Id), new XElement("Vendor", c.Vendor), new XElement("Model", c.Model), new XElement("Year", c.Year)));

            doc.Save(file);
        }
    }
}
