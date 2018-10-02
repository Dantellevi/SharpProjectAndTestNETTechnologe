using System;
using System.Collections.Generic;
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

        }

        protected void ButtonSet_Click(object sender, EventArgs e)
        {
            var id = int.Parse(TextBox1.Text);
            var Vendor = TextBox2.Text;
            var Model = TextBox3.Text;
            var Year = int.Parse(TextBox4.Text);

            client.SetCar(new ServiceCAR.Car { Id = id, Vendor = Vendor, Model = Model, Year = Year });


        }

        protected void ButtonGet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(TextBox1.Text);
            var car=client.GetCar(Id);
            TextBox2.Text = car.Vendor;
            TextBox3.Text = car.Model;
            TextBox4.Text = car.Year.ToString();
        }
    }
}