namespace Gestiunea_unui_club_de_ciclism
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bicicleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDataSet = new Gestiunea_unui_club_de_ciclism.ClubDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CitireAn = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.bicicleteTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.BicicleteTableAdapter();
            this.tableAdapterManager = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TableAdapterManager();
            this.membriiTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.MembriiTableAdapter();
            this.membriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membriiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bicicleteBindingSource
            // 
            this.bicicleteBindingSource.DataMember = "Biciclete";
            this.bicicleteBindingSource.DataSource = this.clubDataSet;
            // 
            // clubDataSet
            // 
            this.clubDataSet.DataSetName = "ClubDataSet";
            this.clubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(12, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "Inapoi in sala principala";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(67, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afiseaza membrii in functie de anul inscrierii";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1072, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aici aveti acces la baza de date a membrilor clubului si la diferite informatii a" +
    "le acestora.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CitireAn
            // 
            this.CitireAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CitireAn.FormattingEnabled = true;
            this.CitireAn.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019"});
            this.CitireAn.Location = new System.Drawing.Point(323, 457);
            this.CitireAn.Name = "CitireAn";
            this.CitireAn.Size = new System.Drawing.Size(121, 27);
            this.CitireAn.TabIndex = 7;
            this.CitireAn.SelectedIndexChanged += new System.EventHandler(this.CitireAn_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(67, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 90);
            this.button3.TabIndex = 8;
            this.button3.Text = "Afiseaza toti membrii";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(67, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 90);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cel mai vechi membru";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(615, 284);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(416, 371);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(1216, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 90);
            this.button5.TabIndex = 10;
            this.button5.Text = "Inchide aplicatia";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bicicleteTableAdapter
            // 
            this.bicicleteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BicicleteTableAdapter = this.bicicleteTableAdapter;
            this.tableAdapterManager.MembriiTableAdapter = this.membriiTableAdapter;
            this.tableAdapterManager.RegistruTableAdapter = null;
            this.tableAdapterManager.TraseeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membriiTableAdapter
            // 
            this.membriiTableAdapter.ClearBeforeFill = true;
            // 
            // membriiBindingSource
            // 
            this.membriiBindingSource.DataMember = "Membrii";
            this.membriiBindingSource.DataSource = this.clubDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sala principala";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1306, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CitireAn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Sala principala";
            this.Load += new System.EventHandler(this.Membrii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membriiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClubDataSet clubDataSet;
        private System.Windows.Forms.BindingSource bicicleteBindingSource;
        private ClubDataSetTableAdapters.BicicleteTableAdapter bicicleteTableAdapter;
        private ClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ClubDataSetTableAdapters.MembriiTableAdapter membriiTableAdapter;
        private System.Windows.Forms.BindingSource membriiBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CitireAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}