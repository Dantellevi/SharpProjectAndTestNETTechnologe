using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;


namespace Client_test20
{
    public partial class Form1 : Form,SumService.IDuplexSummator_ServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SendResult(int sum)
        {
            label1.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var instanceContext = new InstanceContext(this);
            var client = new SumService.DuplexSummator_ServiceClient(instanceContext, "NetTcpBinding_IDuplexSummator_Service");
            var x = int.Parse(textBox1.Text);
            var y = int.Parse(textBox2.Text);
            client.GetSum(x, y);

        }
    }
}
