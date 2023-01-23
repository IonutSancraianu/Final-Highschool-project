namespace Gestiunea_unui_club_de_ciclism
{
    partial class Form5
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.traseeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDataSet = new Gestiunea_unui_club_de_ciclism.ClubDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.traseeTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TraseeTableAdapter();
            this.tableAdapterManager = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TableAdapterManager();
            this.registruTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.RegistruTableAdapter();
            this.registruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membriiTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.MembriiTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membriiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(569, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(710, 371);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrul Traseelor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afisati toate traseele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(75, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Traseele parcurse in anul selectat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBox1.Location = new System.Drawing.Point(385, 427);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(75, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 104);
            this.button3.TabIndex = 5;
            this.button3.Text = "Persoanele care au parcurs un anumit traseu in anul respectiv";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // traseeBindingSource
            // 
            this.traseeBindingSource.DataMember = "Trasee";
            this.traseeBindingSource.DataSource = this.clubDataSet;
            // 
            // clubDataSet
            // 
            this.clubDataSet.DataSetName = "ClubDataSet";
            this.clubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 80);
            this.button4.TabIndex = 7;
            this.button4.Text = "Inapoi in sala principala";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1197, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 90);
            this.button5.TabIndex = 8;
            this.button5.Text = "Inchide aplicatia";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(385, 536);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019"});
            this.comboBox3.Location = new System.Drawing.Point(385, 584);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Traseul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Anul";
            // 
            // traseeTableAdapter
            // 
            this.traseeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BicicleteTableAdapter = null;
            this.tableAdapterManager.MembriiTableAdapter = null;
            this.tableAdapterManager.RegistruTableAdapter = this.registruTableAdapter;
            this.tableAdapterManager.TraseeTableAdapter = this.traseeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registruTableAdapter
            // 
            this.registruTableAdapter.ClearBeforeFill = true;
            // 
            // registruBindingSource
            // 
            this.registruBindingSource.DataMember = "Registru";
            this.registruBindingSource.DataSource = this.clubDataSet;
            // 
            // membriiBindingSource
            // 
            this.membriiBindingSource.DataMember = "Membrii";
            this.membriiBindingSource.DataSource = this.clubDataSet;
            // 
            // membriiTableAdapter
            // 
            this.membriiTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(867, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "Aici membrii clubului pot accesa datele privind faimoasele noastre trasee\r\nsi dat" +
    "e temporale ale excursiilor facute de pasionatii nostri";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(75, 651);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 90);
            this.button7.TabIndex = 15;
            this.button7.Text = "Numarul traseelor parcurse in anul selectat";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBox4.Location = new System.Drawing.Point(385, 687);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 16;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1314, 753);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membriiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private ClubDataSet clubDataSet;
        private System.Windows.Forms.BindingSource traseeBindingSource;
        private ClubDataSetTableAdapters.TraseeTableAdapter traseeTableAdapter;
        private ClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ClubDataSetTableAdapters.RegistruTableAdapter registruTableAdapter;
        private System.Windows.Forms.BindingSource registruBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource membriiBindingSource;
        private ClubDataSetTableAdapters.MembriiTableAdapter membriiTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}