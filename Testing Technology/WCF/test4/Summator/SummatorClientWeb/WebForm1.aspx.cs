using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummatorClientWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var xValue = int.Parse(TextBox1.Text);
            var yValue = int.Parse(TextBox2.Text);
            
            //создаем экземпляр проксикласса
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            Label1.Text = client.GetSum(xValue, yValue).ToString();
            client.Close();
        }
    }
}