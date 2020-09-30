namespace eKnjige.WinUI.Knjige
{
    partial class FormKomentariKnjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKomentariKnjige));
            this.Komentari = new System.Windows.Forms.GroupBox();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.KomentarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKomentara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.Komentari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // Komentari
            // 
            this.Komentari.Controls.Add(this.dgvKomentari);
            this.Komentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Komentari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Komentari.Location = new System.Drawing.Point(56, 91);
            this.Komentari.Name = "Komentari";
            this.Komentari.Size = new System.Drawing.Size(686, 308);
            this.Komentari.TabIndex = 0;
            this.Komentari.TabStop = false;
            this.Komentari.Text = "Komentari";
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.AllowUserToAddRows = false;
            this.dgvKomentari.AllowUserToDeleteRows = false;
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KomentarId,
            this.komentar,
            this.DatumKomentara});
            this.dgvKomentari.Location = new System.Drawing.Point(38, 30);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.ReadOnly = true;
            this.dgvKomentari.Size = new System.Drawing.Size(614, 251);
            this.dgvKomentari.TabIndex = 0;
            this.dgvKomentari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomentari_CellContentClick);
            // 
            // KomentarId
            // 
            this.KomentarId.DataPropertyName = "KomentarId ";
            this.KomentarId.HeaderText = "KomentarId";
            this.KomentarId.Name = "KomentarId";
            this.KomentarId.ReadOnly = true;
            this.KomentarId.Visible = false;
            // 
            // komentar
            // 
            this.komentar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.komentar.DataPropertyName = "komentar";
            this.komentar.HeaderText = "Komentar";
            this.komentar.Name = "komentar";
            this.komentar.ReadOnly = true;
            // 
            // DatumKomentara
            // 
            this.DatumKomentara.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumKomentara.DataPropertyName = "DatumKomentara";
            this.DatumKomentara.HeaderText = "DatumKomentara ";
            this.DatumKomentara.Name = "DatumKomentara";
            this.DatumKomentara.ReadOnly = true;
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(192, 32);
            this.txtTrazi.Multiline = true;
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(227, 33);
            this.txtTrazi.TabIndex = 1;
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrazi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrazi.Location = new System.Drawing.Point(56, 29);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(92, 36);
            this.btnTrazi.TabIndex = 2;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // FormKomentariKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.Komentari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKomentariKnjige";
            this.Text = "Komentari";
            this.Komentari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Komentari;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.DataGridViewTextBoxColumn KomentarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKomentara;
    }
}