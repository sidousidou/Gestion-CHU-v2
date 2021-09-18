namespace Medcine
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
            this.passe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searche = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bde = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bu = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nominf = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passe
            // 
            this.passe.Location = new System.Drawing.Point(143, 225);
            this.passe.Multiline = true;
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(188, 27);
            this.passe.TabIndex = 98;
            this.passe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passe.TextChanged += new System.EventHandler(this.passe_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Sex : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // searche
            // 
            this.searche.Location = new System.Drawing.Point(399, 18);
            this.searche.Multiline = true;
            this.searche.Name = "searche";
            this.searche.Size = new System.Drawing.Size(278, 34);
            this.searche.TabIndex = 96;
            this.searche.TextChanged += new System.EventHandler(this.searche_TextChanged);
            // 
            // bs
            // 
            this.bs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bs.Location = new System.Drawing.Point(695, 18);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(73, 34);
            this.bs.TabIndex = 95;
            this.bs.Text = "Searche";
            this.bs.UseVisualStyleBackColor = false;
            this.bs.Click += new System.EventHandler(this.bs_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.Color.Silver;
            this.bc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bc.Location = new System.Drawing.Point(269, 282);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(108, 40);
            this.bc.TabIndex = 94;
            this.bc.Text = "Current State";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bde
            // 
            this.bde.BackColor = System.Drawing.Color.Red;
            this.bde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bde.Location = new System.Drawing.Point(153, 282);
            this.bde.Name = "bde";
            this.bde.Size = new System.Drawing.Size(94, 40);
            this.bde.TabIndex = 93;
            this.bde.Text = "Manage Free Slot";
            this.bde.UseVisualStyleBackColor = false;
            this.bde.Click += new System.EventHandler(this.bde_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(143, 174);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(188, 27);
            this.user.TabIndex = 92;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Age : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(153, 131);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(88, 20);
            this.prenom.TabIndex = 90;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prenom.TextChanged += new System.EventHandler(this.prenom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Laste Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 226);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // bu
            // 
            this.bu.BackColor = System.Drawing.Color.RoyalBlue;
            this.bu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bu.Location = new System.Drawing.Point(33, 282);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(87, 40);
            this.bu.TabIndex = 87;
            this.bu.Text = "Add description";
            this.bu.UseVisualStyleBackColor = false;
            this.bu.Click += new System.EventHandler(this.bu_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(143, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 20);
            this.name.TabIndex = 86;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.DoubleClick += new System.EventHandler(this.name_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Nom : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Medcine.Properties.Resources._71ArbyVQLNL__AC_SX355_;
            this.pictureBox2.Location = new System.Drawing.Point(2, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(885, 362);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nomt
            // 
            this.nomt.AutoSize = true;
            this.nomt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomt.Location = new System.Drawing.Point(111, 49);
            this.nomt.Name = "nomt";
            this.nomt.Size = new System.Drawing.Size(44, 23);
            this.nomt.TabIndex = 122;
            this.nomt.Text = "vide";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 121;
            this.label7.Text = "Nom :";
            // 
            // Nominf
            // 
            this.Nominf.AutoSize = true;
            this.Nominf.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nominf.Location = new System.Drawing.Point(111, 9);
            this.Nominf.Name = "Nominf";
            this.Nominf.Size = new System.Drawing.Size(44, 23);
            this.Nominf.TabIndex = 120;
            this.Nominf.Text = "vide";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 119;
            this.label5.Text = "Prenom :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 346);
            this.Controls.Add(this.nomt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Nominf);
            this.Controls.Add(this.label5);
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
            this.Name = "Form2";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searche;
        private System.Windows.Forms.Button bs;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bde;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bu;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Nominf;
        private System.Windows.Forms.Label label5;
    }
}