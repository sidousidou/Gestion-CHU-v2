using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using System.Windows.Forms;

namespace Infermier
{
    public partial class Form2 : Form
    {
        interfaceInfermier p;
        int ID   = 0;
        public Form2(interfaceInfermier e,string s)
        {
            InitializeComponent();
            p = e;
            Class2 c = p.getInfermier(s);
            Nominf.Text = c.Name;
            nomt.Text = c.Prename;
            GridFull();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void GridFull()
        {


            DataTable a = p.showallpation();
            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;




        }

        private void bs_Click(object sender, EventArgs e)
        {
            DataTable a = p.showallpationwitheid(searche.Text.Trim());

            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                user.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                passe.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
               
                bde.Enabled = Enabled;
            }
        }

        private void bde_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("select a tuple !!!");

            }else
            {
                Rendevot r = new Rendevot(p, ID);
                r.Show();
            }
        }
    }
}
