using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.SummatorWebService;
namespace WebClient
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new SummatorWebServiceSoapClient();
            Label1.Text = client.GetSum(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text)).ToString();

        }
    }
}