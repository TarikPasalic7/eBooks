namespace eKnjige.WinUI.Prijedlozi
{
    partial class FormPrijedlozi
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
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.textBoxTrazi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrijedlozi = new System.Windows.Forms.DataGridView();
            this.PrijedlogKnjigeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odgovoren = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijedlozi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTrazi.Location = new System.Drawing.Point(12, 34);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(106, 34);
            this.buttonTrazi.TabIndex = 1;
            this.buttonTrazi.Text = "Trazi";
            this.buttonTrazi.UseVisualStyleBackColor = false;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // textBoxTrazi
            // 
            this.textBoxTrazi.Location = new System.Drawing.Point(149, 42);
            this.textBoxTrazi.Name = "textBoxTrazi";
            this.textBoxTrazi.Size = new System.Drawing.Size(146, 20);
            this.textBoxTrazi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPrijedlozi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(34, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijedlozi";
            // 
            // dgvPrijedlozi
            // 
            this.dgvPrijedlozi.AllowUserToAddRows = false;
            this.dgvPrijedlozi.AllowUserToOrderColumns = true;
            this.dgvPrijedlozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijedlozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrijedlogKnjigeID,
            this.Naziv,
            this.Datum,
            this.Odgovoren});
            this.dgvPrijedlozi.Location = new System.Drawing.Point(21, 37);
            this.dgvPrijedlozi.Name = "dgvPrijedlozi";
            this.dgvPrijedlozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrijedlozi.Size = new System.Drawing.Size(668, 260);
            this.dgvPrijedlozi.TabIndex = 0;
            this.dgvPrijedlozi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrijedlozi_CellContentClick);
            // 
            // PrijedlogKnjigeID
            // 
            this.PrijedlogKnjigeID.DataPropertyName = "PrijedlogKnjigeID";
            this.PrijedlogKnjigeID.HeaderText = "PrijedlogKnjigeID";
            this.PrijedlogKnjigeID.Name = "PrijedlogKnjigeID";
            this.PrijedlogKnjigeID.ReadOnly = true;
            this.PrijedlogKnjigeID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Odgovoren
            // 
            this.Odgovoren.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Odgovoren.DataPropertyName = "Odgovoren";
            this.Odgovoren.HeaderText = "Odgovoren";
            this.Odgovoren.Name = "Odgovoren";
            this.Odgovoren.ReadOnly = true;
            this.Odgovoren.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Odgovoren.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormPrijedlozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxTrazi);
            this.Controls.Add(this.buttonTrazi);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormPrijedlozi";
            this.Text = "FormPrijedlozi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijedlozi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.TextBox textBoxTrazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPrijedlozi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijedlogKnjigeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odgovoren;
    }
}