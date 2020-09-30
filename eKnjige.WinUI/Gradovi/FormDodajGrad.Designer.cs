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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajGrad));
            this.label1 = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodajDrzavu = new System.Windows.Forms.Button();
            this.buttonSnimiGrad = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(39, 77);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(155, 20);
            this.textNaziv.TabIndex = 1;
            this.textNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textNaziv_Validating);
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(39, 170);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(155, 21);
            this.cmbDrzava.TabIndex = 2;
            this.cmbDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDrzava_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Država";
            // 
            // buttonDodajDrzavu
            // 
            this.buttonDodajDrzavu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDodajDrzavu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajDrzavu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDodajDrzavu.Location = new System.Drawing.Point(214, 160);
            this.buttonDodajDrzavu.Name = "buttonDodajDrzavu";
            this.buttonDodajDrzavu.Size = new System.Drawing.Size(118, 37);
            this.buttonDodajDrzavu.TabIndex = 4;
            this.buttonDodajDrzavu.Text = "Dodaj Drzavu";
            this.buttonDodajDrzavu.UseVisualStyleBackColor = false;
            this.buttonDodajDrzavu.Click += new System.EventHandler(this.buttonDodajDrzavu_Click);
            // 
            // buttonSnimiGrad
            // 
            this.buttonSnimiGrad.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSnimiGrad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSnimiGrad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSnimiGrad.Location = new System.Drawing.Point(364, 215);
            this.buttonSnimiGrad.Name = "buttonSnimiGrad";
            this.buttonSnimiGrad.Size = new System.Drawing.Size(101, 39);
            this.buttonSnimiGrad.TabIndex = 5;
            this.buttonSnimiGrad.Text = "Dodaj";
            this.buttonSnimiGrad.UseVisualStyleBackColor = false;
            this.buttonSnimiGrad.Click += new System.EventHandler(this.buttonSnimiGrad_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormDodajGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 271);
            this.Controls.Add(this.buttonSnimiGrad);
            this.Controls.Add(this.buttonDodajDrzavu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDodajGrad";
            this.Text = "Dodaj Grad";
            this.Load += new System.EventHandler(this.FormDodajGrad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}