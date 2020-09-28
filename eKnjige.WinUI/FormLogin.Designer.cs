namespace eKnjige.WinUI
{
    partial class FormLogin
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
            this.buttonlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonlogin.Location = new System.Drawing.Point(348, 208);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(122, 38);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime";
            // 
            // textKorisnickoIme
            // 
            this.textKorisnickoIme.Location = new System.Drawing.Point(121, 71);
            this.textKorisnickoIme.Name = "textKorisnickoIme";
            this.textKorisnickoIme.Size = new System.Drawing.Size(169, 20);
            this.textKorisnickoIme.TabIndex = 2;
            // 
            // textLozinka
            // 
            this.textLozinka.Location = new System.Drawing.Point(121, 143);
            this.textLozinka.Name = "textLozinka";
            this.textLozinka.PasswordChar = '*';
            this.textLozinka.Size = new System.Drawing.Size(169, 20);
            this.textLozinka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 282);
            this.Controls.Add(this.textLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonlogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKorisnickoIme;
        private System.Windows.Forms.TextBox textLozinka;
        private System.Windows.Forms.Label label2;
    }
}