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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CitireAn.Text = "2021";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(CitireAn.Text);
            this.membriiTableAdapter.Inscriere_2k(this.clubDataSet.Membrii, a);
            DataTable dt = this.clubDataSet.Membrii;
            richTextBox1.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Prenume"].ToString().Trim(' ') + "  " + dt.Rows[i]["Nume"].ToString().Trim(' ') + "  " + dt.Rows[i]["Data_inscriere"].ToString().Substring(0, dt.Rows[i]["Data_inscriere"].ToString().Length - 12) + "\n" + "\n";

        }

        private void Membrii_Load(object sender, EventArgs e)
        {
            
            this.membriiTableAdapter.Fill(this.clubDataSet.Membrii);
            // TODO: This line of code loads data into the 'clubDataSet.Biciclete' table. You can move, or remove it, as needed.
            this.bicicleteTableAdapter.Fill(this.clubDataSet.Biciclete);
            this.clubDataSet.EnforceConstraints = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            
        }

        private void bicicleteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bicicleteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubDataSet);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.membriiTableAdapter.DoarMembrii(this.clubDataSet.Membrii);
            DataTable dt = this.clubDataSet.Membrii;
            richTextBox1.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Prenume"].ToString().Trim(' ') + "  " + dt.Rows[i]["Nume"].ToString().Trim(' ') + "  " + dt.Rows[i]["Data_inscriere"].ToString().Substring(0,dt.Rows[i]["Data_inscriere"].ToString().Length-12) + "\n" + "\n";
        }

        private void CitireAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.membriiTableAdapter.Cel_mai_batran(this.clubDataSet.Membrii);
            DataTable dt = this.clubDataSet.Membrii;
            richTextBox1.Clear();
            richTextBox1.Text += dt.Rows[0]["Prenume"].ToString().Trim(' ') + "  " + dt.Rows[0]["Nume"].ToString().Trim(' ') + "  " + dt.Rows[0]["Data_inscriere"].ToString().Substring(0, dt.Rows[0]["Data_inscriere"].ToString().Length - 12);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
