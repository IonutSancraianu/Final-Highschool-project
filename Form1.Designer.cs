namespace Gestiunea_unui_club_de_ciclism
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bicicleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDataSet = new Gestiunea_unui_club_de_ciclism.ClubDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bicicleteTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.BicicleteTableAdapter();
            this.tableAdapterManager = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TableAdapterManager();
            this.membriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membriiTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.MembriiTableAdapter();
            this.registruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registruTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.RegistruTableAdapter();
            this.traseeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traseeTableAdapter = new Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TraseeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).BeginInit();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sala principala\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bun venit la ScoTTy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(923, 81);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(643, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Informatiile despre club si membrii acestuia le gasiti\r\nin camerele a caror buto" +
    "ane se gasesc mai jos\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(308, 434);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 90);
            this.button2.TabIndex = 6;
            this.button2.Text = "Camera bicletelor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(45, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 90);
            this.button3.TabIndex = 7;
            this.button3.Text = "Atelier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(308, 579);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 90);
            this.button4.TabIndex = 8;
            this.button4.Text = "Registrul Traseelor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(1205, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 80);
            this.button5.TabIndex = 9;
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
            this.tableAdapterManager.MembriiTableAdapter = null;
            this.tableAdapterManager.RegistruTableAdapter = null;
            this.tableAdapterManager.TraseeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestiunea_unui_club_de_ciclism.ClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // registruBindingSource
            // 
            this.registruBindingSource.DataMember = "Registru";
            this.registruBindingSource.DataSource = this.clubDataSet;
            // 
            // registruTableAdapter
            // 
            this.registruTableAdapter.ClearBeforeFill = true;
            // 
            // traseeBindingSource
            // 
            this.traseeBindingSource.DataMember = "Trasee";
            this.traseeBindingSource.DataSource = this.clubDataSet;
            // 
            // traseeTableAdapter
            // 
            this.traseeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1306, 701);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClubDataSet clubDataSet;
        private System.Windows.Forms.BindingSource bicicleteBindingSource;
        private ClubDataSetTableAdapters.BicicleteTableAdapter bicicleteTableAdapter;
        private ClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource membriiBindingSource;
        private ClubDataSetTableAdapters.MembriiTableAdapter membriiTableAdapter;
        private System.Windows.Forms.BindingSource registruBindingSource;
        private ClubDataSetTableAdapters.RegistruTableAdapter registruTableAdapter;
        private System.Windows.Forms.BindingSource traseeBindingSource;
        private ClubDataSetTableAdapters.TraseeTableAdapter traseeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

