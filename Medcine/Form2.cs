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
    public partial class Form2 : Form
    {
        public interfaceShowPation1 p;
        int ID = 0;
        MEDCIN c;
        public Form2(interfaceShowPation1 e,String s)
        {
            InitializeComponent();
            p = e;
            c = p.showMedcinInformation(s);
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

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bde_Click(object sender, EventArgs e)
        {
            Manage s = new Manage(p, c.Id);
            s.Show();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void bu_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("you Haven't select Patient");
            }else
            {
                Descrtion s = new Descrtion(p, ID);
                s.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bc_Click(object sender, EventArgs e)
        {

        }

        private void searche_TextChanged(object sender, EventArgs e)
        {

        }

        private void passe_TextChanged(object sender, EventArgs e)
        {

        }

        private void bs_Click(object sender, EventArgs e)
        {
            DataTable a = p.showallpationwitheid(searche.Text.Trim());

            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_DoubleClick(object sender, EventArgs e)
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

        private void name_DoubleClick(object sender, EventArgs e)
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
    }
}
