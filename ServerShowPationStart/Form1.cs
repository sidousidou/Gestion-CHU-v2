using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerShowPationStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Runtime.Remoting.Channels.Tcp.TcpChannel serveur = new System.Runtime.Remoting.Channels.Tcp.TcpChannel(1235);
                ChannelServices.RegisterChannel(serveur, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(implshowAllPation1), "pation", WellKnownObjectMode.SingleCall);
                MessageBox.Show("Server Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server have a probleme !");
            }
        }
    }
}
