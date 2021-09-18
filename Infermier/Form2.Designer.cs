namespace Infermier
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
            this.Nominf = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passe
            // 
            this.passe.Location = new System.Drawing.Point(66, 235);
            this.passe.Multiline = true;
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(188, 27);
            this.passe.TabIndex = 114;
            this.passe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-72, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Sex : ";
            // 
            // searche
            // 
            this.searche.Location = new System.Drawing.Point(271, 27);
            this.searche.Multiline = true;
            this.searche.Name = "searche";
            this.searche.Size = new System.Drawing.Size(278, 34);
            this.searche.TabIndex = 112;
            // 
            // bs
            // 
            this.bs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bs.Location = new System.Drawing.Point(567, 27);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(73, 34);
            this.bs.TabIndex = 111;
            this.bs.Text = "Searche";
            this.bs.UseVisualStyleBackColor = false;
            this.bs.Click += new System.EventHandler(this.bs_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.Color.Silver;
            this.bc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bc.Location = new System.Drawing.Point(126, 279);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(108, 40);
            this.bc.TabIndex = 110;
            this.bc.Text = "Cancel";
            this.bc.UseVisualStyleBackColor = false;
            // 
            // bde
            // 
            this.bde.BackColor = System.Drawing.Color.Red;
            this.bde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bde.Location = new System.Drawing.Point(8, 279);
            this.bde.Name = "bde";
            this.bde.Size = new System.Drawing.Size(94, 40);
            this.bde.TabIndex = 109;
            this.bde.Text = "prendere RDV";
            this.bde.UseVisualStyleBackColor = false;
            this.bde.Click += new System.EventHandler(this.bde_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(66, 173);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(188, 27);
            this.user.TabIndex = 108;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-72, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Age : ";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(91, 87);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(88, 20);
            this.prenom.TabIndex = 106;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-72, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Laste Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 226);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // bu
            // 
            this.bu.BackColor = System.Drawing.Color.Blue;
            this.bu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bu.Location = new System.Drawing.Point(-90, 223);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(87, 40);
            this.bu.TabIndex = 103;
            this.bu.Text = "Save";
            this.bu.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(91, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 20);
            this.name.TabIndex = 102;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nom : ";
            // 
            // Nominf
            // 
            this.Nominf.AutoSize = true;
            this.Nominf.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nominf.Location = new System.Drawing.Point(122, 9);
            this.Nominf.Name = "Nominf";
            this.Nominf.Size = new System.Drawing.Size(52, 27);
            this.Nominf.TabIndex = 116;
            this.Nominf.Text = "vide";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 115;
            this.label5.Text = "Prenom :";
            // 
            // nomt
            // 
            this.nomt.AutoSize = true;
            this.nomt.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomt.Location = new System.Drawing.Point(122, 49);
            this.nomt.Name = "nomt";
            this.nomt.Size = new System.Drawing.Size(52, 27);
            this.nomt.TabIndex = 118;
            this.nomt.Text = "vide";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 27);
            this.label7.TabIndex = 117;
            this.label7.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Sexe : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 121;
            this.label8.Text = "Age : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Laste Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 119;
            this.label10.Text = "Nom : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-126, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(885, 362);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-102, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
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
            this.Text = "inf2";
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
        private System.Windows.Forms.Label Nominf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nomt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}