using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infermier
{
    public partial class FinisheInscription : Form
    {
        interfaceInfermier p;
        int ID = 0;
        int idpation;
        int iddoct;
        public FinisheInscription(interfaceInfermier e, int s,int idd)
        {
            InitializeComponent();
            p = e;
            idpation = s;
            iddoct = idd;
            GridFull();
        }
        void GridFull()
        {


            DataTable a = p.showtimefree(iddoct);
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

                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                bde.Enabled = Enabled;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void bde_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Select a tuple !!!");
            }
            else
            {
                bool b = p.validerRendivous(ID);
                bool b2 = p.ajouterRendiveaux(idpation, iddoct);
                if (b && b2)
                {
                    MessageBox.Show("add succesfuly!!!");
                }else
                {
                    MessageBox.Show("not add succesfuly!!!");
                }
                GridFull();
            }
        }
    }
}
