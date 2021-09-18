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
    public partial class auto : Form
    {
        public interfaceMedcinAdmin p;
        public auto()
        {
            InitializeComponent();
            TcpChannel c = new TcpChannel();
            System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(c, false);
            p = (interfaceMedcinAdmin)Activator.GetObject(typeof(interfaceMedcinAdmin), "tcp://127.0.0.1:1234/med");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("asdzjkzjkajdaz");



            bool b = p.auto(texteuser.Text.Trim(), textpasse.Text.Trim());

            if (b == true)
            {
                Form1 f = new Form1(p);
                f.Show();
            }
            else
            {
                MessageBox.Show("inaccicible");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void texteuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
