namespace controle_Borde_Admin
{
    partial class auto
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textpasse = new System.Windows.Forms.TextBox();
            this.texteuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(147, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(12, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textpasse
            // 
            this.textpasse.ForeColor = System.Drawing.Color.Black;
            this.textpasse.Location = new System.Drawing.Point(101, 101);
            this.textpasse.Name = "textpasse";
            this.textpasse.Size = new System.Drawing.Size(100, 20);
            this.textpasse.TabIndex = 7;
            this.textpasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textpasse.TextChanged += new System.EventHandler(this.textpasse_TextChanged);
            // 
            // texteuser
            // 
            this.texteuser.Location = new System.Drawing.Point(101, 43);
            this.texteuser.Name = "texteuser";
            this.texteuser.Size = new System.Drawing.Size(100, 20);
            this.texteuser.TabIndex = 6;
            this.texteuser.TextChanged += new System.EventHandler(this.texteuser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpasse);
            this.Controls.Add(this.texteuser);
            this.Controls.Add(this.label1);
            this.Name = "auto";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpasse;
        private System.Windows.Forms.TextBox texteuser;
        private System.Windows.Forms.Label label1;
    }
}