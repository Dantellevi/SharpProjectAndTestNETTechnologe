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
using WinClient.ServiceCar;

namespace WinClient
{
    public partial class Form1 : Form
    {
        private ServiceCar.CarServiceClient _client;
        public Form1()
        {
            InitializeComponent();
            _client = new CarServiceClient("BasicHttpBinding_ICarService");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            catch(FaultException fl)
            {
                MessageBox.Show("Ошибка: " + fl.Message);
            }
            /*
             * catch(FaultException<NullElementFault> fl)
            {
                MessageBox.Show(string.Format("{0}-{1}\n{2}\n{3}",exception.Code.Name,exception.Messege,exception.Detail),"ERROR");
            }
             * 
             * */

        }
    }
}
