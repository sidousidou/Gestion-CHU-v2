using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medcine
{
    public partial class Descrtion : Form
    {
        int o;
        public interfaceShowPation1 p;
        public Descrtion(interfaceShowPation1 e1,int e)
        {
            InitializeComponent();
            o = e;
            p = e1;
            GridFull();
        }
        void GridFull()
        {


            DataTable a = p.showallpationdescriptionwitheid(o);
            dataGridView1.DataSource = a;
            dataGridView1.Columns[1].Visible = false;




        }

        private void Descrtion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bu_Click(object sender, EventArgs e)
        {
            bool b=p.adddescreption(o, des.Text.Trim(), Int32.Parse(temp.Text.Trim()), Int32.Parse(tent.Text.Trim()));
            if (b)
            {
                MessageBox.Show("your adding was succesfully !!!!");
            }else
            {
                MessageBox.Show("your adding was't succesfully !!!!");
            }
            GridFull();
        }
    }
}
