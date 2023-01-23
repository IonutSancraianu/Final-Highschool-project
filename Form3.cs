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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Text = " ".ToString();
            comboBox2.Text = " ".ToString();
            comboBox3.Text = " ".ToString();
            comboBox4.Text = " ".ToString();
            richTextBox1.Text = "Cadru  " + "  Roti   " + "Tip frane  " + "Nr. suspensii" + "\n" + "\n" + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bicicleteTableAdapter.BicicletaDupaNume(this.clubDataSet.Biciclete,comboBox5.Text);
            DataTable dt = this.clubDataSet.Biciclete;
            richTextBox1.Clear();
            richTextBox1.Text = "Cadru  " + "  Roti   " + "Tip frane  " + "Nr. suspensii" + "\n" + "\n" + "\n";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Cadru"].ToString().Substring(0,dt.Rows[i]["Cadru"].ToString().Length - 2) + "  " + dt.Rows[i]["Dimensiune_roti"].ToString() + "  " + dt.Rows[i]["Tip_frane"].ToString() + "  " + dt.Rows[i]["Nr_suspensii"].ToString() + "\n" + "\n";
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'clubDataSet.Membrii' table. You can move, or remove it, as needed.
            this.membriiTableAdapter.Fill(this.clubDataSet.Membrii);
            // TODO: This line of code loads data into the 'clubDataSet.Biciclete' table. You can move, or remove it, as needed.
            this.bicicleteTableAdapter.Fill(this.clubDataSet.Biciclete);
            this.clubDataSet.EnforceConstraints = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == " ")
            {
                richTextBox1.Text = "Mai incearca".ToString();
                if (textBox1.Text == "bicla".ToString() && comboBox1.Text.ToString() != "")
                {
                    Form4 Form4 = new Form4();
                    Form4.Show();
                    textBox1.Clear();
                }
                else
                    textBox1.Clear();
            }
            else
            {
                int p;
                p=int.Parse(comboBox4.Text);
                this.membriiTableAdapter.Joculet(this.clubDataSet.Membrii,comboBox1.Text,comboBox2.Text,comboBox3.Text,p);
                DataTable dt = this.clubDataSet.Membrii;
                richTextBox1.Clear();
                richTextBox1.Text += "Prenume " + " Nume ";
                for (int i = 0; i < dt.Rows.Count; i++)
                    richTextBox1.Text += "\n" + "\n" + "\n" + dt.Rows[i]["Prenume"].ToString().Trim(' ') + "  " + dt.Rows[i]["Nume"].ToString().Trim(' ') + "\n" + "\n";
            }
            if (richTextBox1.Text == "Prenume  Nume ")
                richTextBox1.Text = "Date inexisente. Mai incercati!";
          
        } 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bicicleteTableAdapter.BicicleteMembrii(this.clubDataSet.Biciclete);
            DataTable dt = this.clubDataSet.Biciclete;
            richTextBox1.Clear();
            richTextBox1.Text = " Prenume  " + " Nume " + "  Cadru  " + "  Roti   " + "Tip frane  " + "Nr. suspensii" + "\n" + "\n" + "\n";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Nume"].ToString().Trim(' ')+ "   " + dt.Rows[i]["Prenume"].ToString().Trim(' ')+ "   " + dt.Rows[i]["Cadru"].ToString().Substring(0, dt.Rows[i]["Cadru"].ToString().Length - 2) + "  " + dt.Rows[i]["Dimensiune_roti"].ToString() + "  " + dt.Rows[i]["Tip_frane"].ToString() + "  " + dt.Rows[i]["Nr_suspensii"].ToString() + "\n" + "\n";
     
        }

  
    }
}
