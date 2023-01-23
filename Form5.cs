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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            comboBox1.Text = "2019";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = "2019";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.clubDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'clubDataSet.Membrii' table. You can move, or remove it, as needed.
            this.membriiTableAdapter.Fill(this.clubDataSet.Membrii);
            // TODO: This line of code loads data into the 'clubDataSet.Registru' table. You can move, or remove it, as needed.
            this.registruTableAdapter.Fill(this.clubDataSet.Registru);
            // TODO: This line of code loads data into the 'clubDataSet.Trasee' table. You can move, or remove it, as needed.
            this.traseeTableAdapter.Fill(this.clubDataSet.Trasee);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == " " && comboBox3.Text == " ")
            {
                richTextBox1.Text = "Mai incearca".ToString();
            }
            else
            {
                int b= int.Parse(comboBox3.Text);
                int a = int.Parse(comboBox2.Text);
                this.registruTableAdapter.UndeSiCand(this.clubDataSet.Registru,b,a);
                DataTable dt = this.clubDataSet.Registru;
                richTextBox1.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                    richTextBox1.Text += dt.Rows[i]["Prenume"].ToString().Trim(' ') + "  " + dt.Rows[i]["Nume"].ToString().Trim(' ') + "\n" + "\n";
            }

            if (richTextBox1.Text=="")
                richTextBox1.Text = "Mai incearca".ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a=int.Parse(comboBox1.Text);
            this.registruTableAdapter.Traseul_anului(this.clubDataSet.Registru,a);
            DataTable dt = this.clubDataSet.Registru;
            richTextBox1.Clear();
            richTextBox1.Text = "Nr. traseu " + " Mediu traseu  " + "  Lungime" + "  Dificultate" + "\n" +"\n";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += "    " + dt.Rows[i]["Idt"].ToString().Trim(' ') + "           " + dt.Rows[i]["Mediu"].ToString().Trim(' ') + "           " + dt.Rows[i]["Lungime"].ToString().Trim(' ') + "         " + dt.Rows[i]["Dificultate"].ToString().Trim(' ') + "\n" + "\n";
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.traseeTableAdapter.DoarTrasee(this.clubDataSet.Trasee);
            DataTable dt = this.clubDataSet.Trasee;
            richTextBox1.Clear();
            richTextBox1.Text = "Nr. traseu " + " Mediu traseu  " + "  Lungime" + "  Dificultate" + "\n" + "\n";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += "    " + dt.Rows[i]["Idt"].ToString().Trim(' ') + "           " + dt.Rows[i]["Mediu"].ToString().Trim(' ') + "           " + dt.Rows[i]["Lungime"].ToString().Trim(' ') + "         " + dt.Rows[i]["Dificultate"].ToString().Trim(' ') + "\n" + "\n";
        }

        private void traseeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traseeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubDataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = int.Parse(comboBox4.Text);
            this.registruTableAdapter.NumarTrasee(a);
            DataTable dt = this.clubDataSet.Registru;
            richTextBox1.Clear();
            richTextBox1.Text ="Numarul de trasee parcurse este  " + this.registruTableAdapter.NumarTrasee(a).ToString();
        }

    }
}
