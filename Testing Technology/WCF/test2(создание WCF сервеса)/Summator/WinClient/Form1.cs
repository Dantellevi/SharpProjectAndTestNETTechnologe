using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xVal = int.Parse(textBox1.Text);
            var yVal = int.Parse(textBox2.Text);

            var client = new Summator.SummatorClient("NetTcpBinding_ISummator");
            label1.Text= client.GetSum(xVal, yVal).ToString();
            client.Close();
        }
    }
}
