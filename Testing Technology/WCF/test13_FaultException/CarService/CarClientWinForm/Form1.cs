using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarClientWinForm.CARService;
using System.ServiceModel;

namespace CarClientWinForm
{
    public partial class Form1 : Form
    {

        private CarServiceClient _client;
        public Form1()
        {
            InitializeComponent();
            _client = new CarServiceClient("BasicHttpBinding_ICarService");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(textBox1.Text);
            Car responseCar;
            try
            {
                responseCar = _client.GetCar(Id);
                textBox2.Text = responseCar.Vendor;
                textBox3.Text = responseCar.Model;
                textBox4.Text = responseCar.Year.ToString();
            }
            catch(FaultException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
           

        }
    }
}
