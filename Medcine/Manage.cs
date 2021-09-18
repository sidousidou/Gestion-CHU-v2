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
    public partial class Manage : Form
    { int ID=0;
        int o;
        public interfaceShowPation1 p;
        public Manage(interfaceShowPation1 e1, int e)
        {
            InitializeComponent();
            o = e;
            p = e1;
            GridFull();
        }
        void GridFull()
        {


            DataTable a = p.showtimefree(o);
            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;





        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bu_Click(object sender, EventArgs e)
        {
                bool b = p.addtimefree(o, temp.Text.Trim(), tent.Text.Trim());
                if (b)
                {
                    MessageBox.Show("Succefely !!");
                }
                else
                {
                    MessageBox.Show("not Succefely !!");
                }
                GridFull();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                temp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tent.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                bde.Enabled = Enabled;
            }
        }

        private void bde_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Select one tuple !!");
            }
            else
            {
                bool b = p.deletetimefree(ID);
                if (b)
                {
                    MessageBox.Show("Succefely !!");
                }
                else
                {
                    MessageBox.Show("not Succefely !!");
                }
                GridFull();
            }
        }
    }
}
