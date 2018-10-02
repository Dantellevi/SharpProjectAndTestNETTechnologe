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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var xVal = int.Parse(TextBox1.Text);
            var yVal = int.Parse(TextBox2.Text);

            var client = new CalcService.SummatorClient("BasicHttpBinding_ISummator");
            Label1.Text = client.GetSum(xVal, yVal).ToString();

            client.Close();
        }
    }
}