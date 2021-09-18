using interfaceMedcin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_Borde_Admin
{
    public partial class infermierre : Form
    {
        public interfaceMedcinAdmin p;
        public int ID = 0;
        public infermierre(interfaceMedcinAdmin e)
        {
            InitializeComponent();

            p = e;
            GridFull();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string ConnectionString = @"Server=127.0.0.1;Database=hopitale;Uid=root;Pwd=sidouhaha;";
        void GridFull()
        {
            DataTable a = p.showallinfermier();

            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
           /* dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;*/


        }

        private void bu_Click(object sender, EventArgs e)
        {

        }

        private void bu_Click_1(object sender, EventArgs e)
        {

            if (bu.Text == "Update")
            {
                infermier m = new infermier();
                m.Id = ID;
                m.Nom = name.Text.Trim();
                m.Prenom = prenom.Text.Trim();
                m.Passe = passe.Text.Trim();
                m.User = user.Text.Trim();

                bool b = p.Updateinfermier(m);
                if (b)
                {
                    MessageBox.Show("Medcine is Update succesfuly !!!");
                }
                else
                {
                    MessageBox.Show("Medcine is not update succesfuly !!!");
                }

            }
            else
            {

                infermier m = new infermier();
                m.Id = ID;
                m.Nom = name.Text.Trim();
                m.Prenom = prenom.Text.Trim();
                m.Passe = passe.Text.Trim();
                m.User = user.Text.Trim();

                bool b = p.addinfermier(m);
                if (b)
                {
                    MessageBox.Show("Medcine is add succesfuly !!!");
                }
                else
                {
                    MessageBox.Show("Medcine is not add succesfuly !!!");
                }
            }

            GridFull();

        }
       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Clear()
        {
            name.Text = prenom.Text = user.Text = passe.Text = searche.Text = "";
            name.Clear();
            bu.Text = "Save";
            bde.Enabled = false;
            GridFull();

        }
        private void bc_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bs_Click(object sender, EventArgs e)
        {
            DataTable a = p.searcheinfermier(searche.Text.Trim());

            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
          /*  dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;*/
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
                bu.Text = "Update";
                bde.Enabled = Enabled;
            }
        }

        private void bde_Click(object sender, EventArgs e)
        {
            Boolean b = p.deleteinfermier(ID);
            if (b == true)
            {
                MessageBox.Show("Deleted Succesfully !");
            }
            else
            {
                MessageBox.Show("Not Deleted Succesfully !");
            }


            Clear();
        }

        private void passe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searche_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
