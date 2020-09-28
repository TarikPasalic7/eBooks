namespace eKnjige.WinUI.Drzave
{
    partial class FormDodajDrzavu
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
            this.buttonDrzavaSnimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textDrzavaNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDrzavaSnimi
            // 
            this.buttonDrzavaSnimi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDrzavaSnimi.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDrzavaSnimi.Location = new System.Drawing.Point(233, 154);
            this.buttonDrzavaSnimi.Name = "buttonDrzavaSnimi";
            this.buttonDrzavaSnimi.Size = new System.Drawing.Size(141, 49);
            this.buttonDrzavaSnimi.TabIndex = 0;
            this.buttonDrzavaSnimi.Text = "Dodaj";
            this.buttonDrzavaSnimi.UseVisualStyleBackColor = false;
            this.buttonDrzavaSnimi.Click += new System.EventHandler(this.buttonDrzavaSnimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // textDrzavaNaziv
            // 
            this.textDrzavaNaziv.Location = new System.Drawing.Point(32, 76);
            this.textDrzavaNaziv.Name = "textDrzavaNaziv";
            this.textDrzavaNaziv.Size = new System.Drawing.Size(143, 20);
            this.textDrzavaNaziv.TabIndex = 2;
            // 
            // FormDodajDrzavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 256);
            this.Controls.Add(this.textDrzavaNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDrzavaSnimi);
            this.Name = "FormDodajDrzavu";
            this.Text = "FormDodajDrzavu";
            this.Load += new System.EventHandler(this.FormDodajDrzavu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrzavaSnimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDrzavaNaziv;
    }
}