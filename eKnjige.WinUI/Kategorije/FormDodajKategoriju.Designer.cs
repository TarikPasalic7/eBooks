namespace eKnjige.WinUI.Kategorije
{
    partial class FormDodajKategoriju
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
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDodajKategoriju.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(287, 148);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(94, 37);
            this.btnDodajKategoriju.TabIndex = 0;
            this.btnDodajKategoriju.Text = "Dodaj";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(48, 76);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 1;
            this.labelNaziv.Text = "Naziv";
            this.labelNaziv.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(51, 101);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(142, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // FormDodajKategoriju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 221);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Name = "FormDodajKategoriju";
            this.Text = "FormDodajKategoriju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}