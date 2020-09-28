namespace eKnjige.WinUI.Autori
{
    partial class FormDodajAutora
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.Label();
            this.txtAutorIme = new System.Windows.Forms.TextBox();
            this.txtAutorPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateAutor = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDodaj.Location = new System.Drawing.Point(329, 212);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 43);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ime.Location = new System.Drawing.Point(30, 58);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(32, 18);
            this.Ime.TabIndex = 1;
            this.Ime.Text = "Ime";
            // 
            // txtAutorIme
            // 
            this.txtAutorIme.Location = new System.Drawing.Point(33, 85);
            this.txtAutorIme.Name = "txtAutorIme";
            this.txtAutorIme.Size = new System.Drawing.Size(100, 20);
            this.txtAutorIme.TabIndex = 2;
            // 
            // txtAutorPrezime
            // 
            this.txtAutorPrezime.Location = new System.Drawing.Point(33, 148);
            this.txtAutorPrezime.Name = "txtAutorPrezime";
            this.txtAutorPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtAutorPrezime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prezime";
            // 
            // dateAutor
            // 
            this.dateAutor.Location = new System.Drawing.Point(266, 145);
            this.dateAutor.Name = "dateAutor";
            this.dateAutor.Size = new System.Drawing.Size(200, 20);
            this.dateAutor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(266, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum Rođenja";
            // 
            // FormDodajAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateAutor);
            this.Controls.Add(this.txtAutorPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutorIme);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormDodajAutora";
            this.Text = "FormDodajAutora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox txtAutorIme;
        private System.Windows.Forms.TextBox txtAutorPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateAutor;
        private System.Windows.Forms.Label label2;
    }
}