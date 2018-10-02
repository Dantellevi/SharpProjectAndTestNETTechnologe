using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWayClient
{
    public partial class Form1 : Form
    {
        private OneWayService.OneWayServiceClient _client;
        public Form1()
        {
            InitializeComponent();
            _client = new OneWayService.OneWayServiceClient("NetTcpBinding_IOneWayService");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                _client.RequestOperation();
                button1.Enabled = true;
            }
            catch(Exception esa)
            {
                MessageBox.Show(esa.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = false;
                _client.RequestOperationException();
                button2.Enabled = true;
            }
            catch (Exception esa)
            {
                MessageBox.Show(esa.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Enabled = false;
                _client.OneWayOperation();
                button3.Enabled = true;
            }
            catch (Exception esa)
            {
                MessageBox.Show(esa.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Enabled = false;
                _client.OneWayOperationException();
                button4.Enabled = true;
            }
            catch (Exception esa)
            {
                MessageBox.Show(esa.Message);
            }
        }
    }
}
