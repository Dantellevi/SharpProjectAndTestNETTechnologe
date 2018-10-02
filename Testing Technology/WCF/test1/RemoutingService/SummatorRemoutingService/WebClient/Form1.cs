using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SummatorRemoutingService;

namespace WebClient
{
    public partial class Form1 : Form
    {
        private ISumattorRemouteService _instance;
        public Form1()
        {
            InitializeComponent();
            var channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel,false);

            _instance = (ISumattorRemouteService)Activator.GetObject(typeof(ISumattorRemouteService), "tcp://localhost:51495/Summator");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _instance.GetSum(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();


        }
    }
}
