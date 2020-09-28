namespace eKnjige.WinUI.Gradovi
{
    partial class FormDodajGrad
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
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodajDrzavu = new System.Windows.Forms.Button();
            this.buttonSnimiGrad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(39, 103);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(100, 20);
            this.textNaziv.TabIndex = 1;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(39, 188);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(121, 21);
            this.cmbDrzava.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Država";
            // 
            // buttonDodajDrzavu
            // 
            this.buttonDodajDrzavu.Location = new System.Drawing.Point(205, 188);
            this.buttonDodajDrzavu.Name = "buttonDodajDrzavu";
            this.buttonDodajDrzavu.Size = new System.Drawing.Size(97, 23);
            this.buttonDodajDrzavu.TabIndex = 4;
            this.buttonDodajDrzavu.Text = "Dodaj Drzavu";
            this.buttonDodajDrzavu.UseVisualStyleBackColor = true;
            this.buttonDodajDrzavu.Click += new System.EventHandler(this.buttonDodajDrzavu_Click);
            // 
            // buttonSnimiGrad
            // 
            this.buttonSnimiGrad.Location = new System.Drawing.Point(416, 228);
            this.buttonSnimiGrad.Name = "buttonSnimiGrad";
            this.buttonSnimiGrad.Size = new System.Drawing.Size(101, 39);
            this.buttonSnimiGrad.TabIndex = 5;
            this.buttonSnimiGrad.Text = "Snimi";
            this.buttonSnimiGrad.UseVisualStyleBackColor = true;
            this.buttonSnimiGrad.Click += new System.EventHandler(this.buttonSnimiGrad_Click);
            // 
            // FormDodajGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 295);
            this.Controls.Add(this.buttonSnimiGrad);
            this.Controls.Add(this.buttonDodajDrzavu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajGrad";
            this.Text = "FormDodajGrad";
            this.Load += new System.EventHandler(this.FormDodajGrad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodajDrzavu;
        private System.Windows.Forms.Button buttonSnimiGrad;
    }
}