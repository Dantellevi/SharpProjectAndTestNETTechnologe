using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceCAR.CarServiceClient client = new ServiceCAR.CarServiceClient("BasicHttpBinding_ICarService");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DDCarType.SelectedIndex = 0;
            }
        }

        protected void ButtonSet_Click(object sender, EventArgs e)
        {
            var id = int.Parse(TextBox1.Text);
            var Vendor = TextBox2.Text;
            var Model = TextBox3.Text;
            var Year = int.Parse(TextBox4.Text);

            ServiceCAR.Car car;
            switch(DDCarType.SelectedIndex)
            {
                case 0:
                    {
                        car = new ServiceCAR.TruckCar();
                        ((ServiceCAR.TruckCar)car).Capasity = double.Parse(CapasityField.Text, CultureInfo.GetCultureInfo("en-US"));

                        break;
                    }
                case 1:
                    {
                        car =new ServiceCAR.PassegerCar();
                        ((ServiceCAR.PassegerCar)car).Passegers = int.Parse(PassegerField.Text, CultureInfo.GetCultureInfo("en-US"));
                        break;
                    }
                default:
                    {
                        car = new ServiceCAR.Car();
                        break;
                    }
            }

            car.Id = id;
            car.Vendor = Vendor;
            car.Model = Model;
            car.Year = Year;

            client.SetCar(car);


        }

        protected void ButtonGet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(TextBox1.Text);
            var car=client.GetCar(Id);
            TextBox2.Text = car.Vendor;
            TextBox3.Text = car.Model;
            TextBox4.Text = car.Year.ToString();

            if(car is ServiceCAR.TruckCar)
            {
                CapasityField.Text = ((ServiceCAR.TruckCar)car).Capasity.ToString(CultureInfo.GetCultureInfo("en-US"));
                DDCarType.SelectedIndex = 0;
                trCapasity.Visible = true;
                trPasseger.Visible = false;
            }
            else
            {
                PassegerField.Text = ((ServiceCAR.PassegerCar)car).Passegers.ToString(CultureInfo.GetCultureInfo("en-US"));
                DDCarType.SelectedIndex = 0;
                trCapasity.Visible = false;
                trPasseger.Visible = true;
            }
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(DDCarType.SelectedIndex)
            {
                case 0:
                    {
                        trCapasity.Visible = true;
                        trPasseger.Visible = false;
                        break;
                    }
                case 1:
                    {
                        trCapasity.Visible = false;
                        trPasseger.Visible = true;
                        break;
                    }
            }
        }
    }
}