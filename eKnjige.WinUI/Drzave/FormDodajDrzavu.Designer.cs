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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajDrzavu));
            this.buttonDrzavaSnimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textDrzavaNaziv = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrzavaSnimi
            // 
            this.buttonDrzavaSnimi.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDrzavaSnimi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDrzavaSnimi.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDrzavaSnimi.Location = new System.Drawing.Point(232, 122);
            this.buttonDrzavaSnimi.Name = "buttonDrzavaSnimi";
            this.buttonDrzavaSnimi.Size = new System.Drawing.Size(118, 49);
            this.buttonDrzavaSnimi.TabIndex = 0;
            this.buttonDrzavaSnimi.Text = "Dodaj";
            this.buttonDrzavaSnimi.UseVisualStyleBackColor = false;
            this.buttonDrzavaSnimi.Click += new System.EventHandler(this.buttonDrzavaSnimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // textDrzavaNaziv
            // 
            this.textDrzavaNaziv.Location = new System.Drawing.Point(21, 73);
            this.textDrzavaNaziv.Name = "textDrzavaNaziv";
            this.textDrzavaNaziv.Size = new System.Drawing.Size(176, 20);
            this.textDrzavaNaziv.TabIndex = 2;
            this.textDrzavaNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textDrzavaNaziv_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormDodajDrzavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 201);
            this.Controls.Add(this.textDrzavaNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDrzavaSnimi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDodajDrzavu";
            this.Text = "Nova Drzava";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrzavaSnimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDrzavaNaziv;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}