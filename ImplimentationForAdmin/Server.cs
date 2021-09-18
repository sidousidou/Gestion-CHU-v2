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

namespace ImplimentationForAdmin
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                System.Runtime.Remoting.Channels.Tcp.TcpChannel serveur = new System.Runtime.Remoting.Channels.Tcp.TcpChannel(1234);
                ChannelServices.RegisterChannel(serveur, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(impAdminMedcin), "med", WellKnownObjectMode.Singleton);
                MessageBox.Show("Server Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server have a probleme !");
            }
        }
    }
}
