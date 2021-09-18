namespace controle_Borde_Admin
{
    partial class Gérer_les_Medcin
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
            this.passe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(125, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 27;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // bu
            // 
            this.bu.BackColor = System.Drawing.Color.DodgerBlue;
            this.bu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bu.Location = new System.Drawing.Point(20, 245);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(99, 40);
            this.bu.TabIndex = 28;
            this.bu.Text = "Save";
            this.bu.UseVisualStyleBackColor = false;
            this.bu.Click += new System.EventHandler(this.bu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(381, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 226);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Laste Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(125, 97);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 31;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prenom.TextChanged += new System.EventHandler(this.prenom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "User Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(125, 145);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(200, 27);
            this.user.TabIndex = 33;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // bde
            // 
            this.bde.BackColor = System.Drawing.Color.IndianRed;
            this.bde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bde.Location = new System.Drawing.Point(125, 245);
            this.bde.Name = "bde";
            this.bde.Size = new System.Drawing.Size(106, 40);
            this.bde.TabIndex = 34;
            this.bde.Text = "Delete";
            this.bde.UseVisualStyleBackColor = false;
            this.bde.Click += new System.EventHandler(this.bde_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bc.Location = new System.Drawing.Point(237, 245);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(120, 40);
            this.bc.TabIndex = 35;
            this.bc.Text = "Cancel";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bs
            // 
            this.bs.BackColor = System.Drawing.Color.DarkKhaki;
            this.bs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bs.Location = new System.Drawing.Point(677, 49);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(85, 34);
            this.bs.TabIndex = 36;
            this.bs.Text = "Searche";
            this.bs.UseVisualStyleBackColor = false;
            this.bs.Click += new System.EventHandler(this.bs_Click);
            // 
            // searche
            // 
            this.searche.Location = new System.Drawing.Point(381, 49);
            this.searche.Multiline = true;
            this.searche.Name = "searche";
            this.searche.Size = new System.Drawing.Size(290, 34);
            this.searche.TabIndex = 37;
            this.searche.TextChanged += new System.EventHandler(this.searche_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "User Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // passe
            // 
            this.passe.Location = new System.Drawing.Point(125, 196);
            this.passe.Multiline = true;
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(200, 27);
            this.passe.TabIndex = 39;
            this.passe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passe.TextChanged += new System.EventHandler(this.passe_TextChanged);
            // 
            // Gérer_les_Medcin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controle_Borde_Admin.Properties.Resources._71ArbyVQLNL__AC_SX355_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 348);
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
            this.Name = "Gérer_les_Medcin";
            this.Text = "Gérer_les_Medcin";
            this.Load += new System.EventHandler(this.Gérer_les_Medcin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox passe;
    }
}