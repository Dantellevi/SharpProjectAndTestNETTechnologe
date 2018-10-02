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
            var xval = int.Parse(textBox1.Text);
            var yVal = int.Parse(textBox2.Text);

            var client = new CalcService.MultiplexorClient("NetTcpBinding_IMultiplexor");
            label1.Text=client.GetMultiply(xval, yVal).ToString();

            client.Close();

        }
    }
}
