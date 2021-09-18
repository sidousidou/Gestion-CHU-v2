using ClassLibrary3;
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

namespace Infermier
{
    public partial class Form1 : Form
    {
        interfaceInfermier p;
        public Form1()
        {
            InitializeComponent();
            TcpChannel c = new TcpChannel();
            System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(c, false);
            fabriqueInfermier e1 = (fabriqueInfermier)Activator.GetObject(typeof(fabriqueInfermier), "tcp://127.0.0.1:1236/infermier");
            p = e1.creer();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            

            bool b = p.autontificationPation(texteuser.Text.Trim(), textpasse.Text.Trim());
            if (b == true)
            {
              
                Form2 f = new Form2(p, texteuser.Text.Trim());
                f.Show();
            }
            else
            {
                MessageBox.Show("inaccessible");
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
