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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bicicleteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bicicleteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3= new Form3();
            Form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }

    }
}
