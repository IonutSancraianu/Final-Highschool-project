using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestiunea_unui_club_de_ciclism
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.clubDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'clubDataSet.Biciclete' table. You can move, or remove it, as needed.
            this.bicicleteTableAdapter.Fill(this.clubDataSet.Biciclete);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            this.bicicleteTableAdapter.CodulSecret(this.clubDataSet.Biciclete);
            DataTable dt = this.clubDataSet.Biciclete;
            richTextBox1.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Tip_frane"].ToString().Trim(' ') + "  " + dt.Rows[i]["Cadru"].ToString().Trim(' ') + "  " + dt.Rows[i]["Dimensiune_roti"].ToString() + "  " + dt.Rows[i]["Nr_suspensii"].ToString() + "\n";
        }

        private void bicicleteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bicicleteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubDataSet);

        }
    }
}
