using interfaceMedcin;
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
    public partial class pation : Form
    {
        public interfaceMedcinAdmin p;
        public int ID = 0;
        public pation(interfaceMedcinAdmin e)
        {
            InitializeComponent();
            p = e;
            GridFull();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void GridFull()
        {
            DataTable a = p.showallpation();

            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
            /* dataGridView1.Columns[5].Visible = false;
             dataGridView1.Columns[6].Visible = false;*/


        }
        void Clear()
        {
            name.Text = prenom.Text = user.Text = passe.Text = searche.Text = "";
            name.Clear();
            bu.Text = "Save";
            bde.Enabled = false;
            GridFull();

        }

        private void bu_Click(object sender, EventArgs e)
        {

            if (bu.Text == "Update")
            {
              interfaceMedcin.pation m = new interfaceMedcin.pation();
                m.Id = ID;
                m.Nom = name.Text.Trim();
                m.Prenom = prenom.Text.Trim();
                m.Sex = passe.Text.Trim();
                m.Age = Int32.Parse(user.Text.Trim());

                bool b = p.Updatepation(m);
                if (b)
                {
                    MessageBox.Show("the Pation is Update succesfuly !!!");
                }
                else
                {
                    MessageBox.Show("the Pation is not update succesfuly !!!");
                }

            }
            else
            {

                interfaceMedcin.pation m = new interfaceMedcin.pation();
                m.Id = ID;
                m.Nom = name.Text.Trim();
                m.Prenom = prenom.Text.Trim();
                m.Sex = passe.Text.Trim();
                m.Age = Int32.Parse(user.Text.Trim());

                bool b = p.addpation(m);
                if (b)
                {
                    MessageBox.Show("the Pation is add succesfuly !!!");
                }
                else
                {
                    MessageBox.Show("the Pation is not add succesfuly !!!");
                }
            }

            GridFull();

        }

        private void bc_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bde_Click(object sender, EventArgs e)
        {
            Boolean b = p.deletepation(ID);
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

        private void bs_Click(object sender, EventArgs e)
        {
            DataTable a = p.searchepation(searche.Text.Trim());

            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
