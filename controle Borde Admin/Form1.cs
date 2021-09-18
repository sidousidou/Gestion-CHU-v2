using interfaceMedcin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_Borde_Admin
{
    public partial class Form1 : Form
    {
        public interfaceMedcinAdmin T;
        public Form1(interfaceMedcinAdmin e)
        {
            InitializeComponent();
            T = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


             /*   TcpChannel c = new TcpChannel();
                System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(c, false);
                interfaceMedcinAdmin p = (interfaceMedcinAdmin)Activator.GetObject(typeof(interfaceMedcinAdmin), "tcp://127.0.0.1:1234/med");
                */
                Gérer_les_Medcin m = new Gérer_les_Medcin(T);
                m.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection probleme");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

/*
                TcpChannel c = new TcpChannel();
                System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(c, false);
                interfaceMedcinAdmin p = (interfaceMedcinAdmin)Activator.GetObject(typeof(interfaceMedcinAdmin), "tcp://127.0.0.1:1234/med");
                */
                infermierre f = new infermierre(T);
                f.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection probleme");
            }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pation f = new pation(T);
            f.Show();
        }
    }
}
