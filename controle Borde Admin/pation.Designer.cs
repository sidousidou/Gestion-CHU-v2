namespace controle_Borde_Admin
{
    partial class pation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.bu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.bde = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.Button();
            this.searche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::controle_Borde_Admin.Properties.Resources.téléchargement;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // passe
            // 
            this.passe.Location = new System.Drawing.Point(117, 182);
            this.passe.Multiline = true;
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(188, 27);
            this.passe.TabIndex = 82;
            this.passe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nom : ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(117, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 20);
            this.name.TabIndex = 70;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bu
            // 
            this.bu.BackColor = System.Drawing.Color.Blue;
            this.bu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bu.Location = new System.Drawing.Point(12, 231);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(87, 40);
            this.bu.TabIndex = 71;
            this.bu.Text = "Save";
            this.bu.UseVisualStyleBackColor = false;
            this.bu.Click += new System.EventHandler(this.bu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 226);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Laste Name";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(117, 83);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(88, 20);
            this.prenom.TabIndex = 74;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Age : ";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(117, 131);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(188, 27);
            this.user.TabIndex = 76;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bde
            // 
            this.bde.BackColor = System.Drawing.Color.Red;
            this.bde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bde.Location = new System.Drawing.Point(117, 231);
            this.bde.Name = "bde";
            this.bde.Size = new System.Drawing.Size(94, 40);
            this.bde.TabIndex = 77;
            this.bde.Text = "Delete";
            this.bde.UseVisualStyleBackColor = false;
            this.bde.Click += new System.EventHandler(this.bde_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.Color.Silver;
            this.bc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bc.Location = new System.Drawing.Point(229, 231);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(108, 40);
            this.bc.TabIndex = 78;
            this.bc.Text = "Cancel";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bs
            // 
            this.bs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bs.Location = new System.Drawing.Point(669, 35);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(73, 34);
            this.bs.TabIndex = 79;
            this.bs.Text = "Searche";
            this.bs.UseVisualStyleBackColor = false;
            this.bs.Click += new System.EventHandler(this.bs_Click);
            // 
            // searche
            // 
            this.searche.Location = new System.Drawing.Point(373, 35);
            this.searche.Multiline = true;
            this.searche.Name = "searche";
            this.searche.Size = new System.Drawing.Size(278, 34);
            this.searche.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Sex : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::controle_Borde_Admin.Properties.Resources._71ArbyVQLNL__AC_SX355_;
            this.pictureBox2.Location = new System.Drawing.Point(-33, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(885, 362);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 345);
            this.Controls.Add(this.passe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searche);
            this.Controls.Add(this.bs);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bde);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bu);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "pation";
            this.Text = "pation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button bu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button bde;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bs;
        private System.Windows.Forms.TextBox searche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}