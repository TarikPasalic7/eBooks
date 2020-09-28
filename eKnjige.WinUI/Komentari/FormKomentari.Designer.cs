namespace eKnjige.WinUI.Komentari
{
    partial class FormKomentari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KomentarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKomentara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntrazi = new System.Windows.Forms.Button();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KomentarId,
            this.komentar,
            this.DatumKomentara});
            this.dataGridView1.Location = new System.Drawing.Point(42, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(629, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KomentarId
            // 
            this.KomentarId.DataPropertyName = "KomentarId";
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
            this.DatumKomentara.DataPropertyName = "DatumKomentara";
            this.DatumKomentara.HeaderText = "DatumKomentara";
            this.DatumKomentara.Name = "DatumKomentara";
            this.DatumKomentara.ReadOnly = true;
            // 
            // btntrazi
            // 
            this.btntrazi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btntrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntrazi.Location = new System.Drawing.Point(66, 51);
            this.btntrazi.Name = "btntrazi";
            this.btntrazi.Size = new System.Drawing.Size(100, 31);
            this.btntrazi.TabIndex = 1;
            this.btntrazi.Text = "Traži";
            this.btntrazi.UseVisualStyleBackColor = false;
            this.btntrazi.Click += new System.EventHandler(this.btntrazi_Click);
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(199, 51);
            this.txtTrazi.Multiline = true;
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(199, 31);
            this.txtTrazi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(45, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Komentari";
            // 
            // FormKomentari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.btntrazi);
            this.Name = "FormKomentari";
            this.Text = "FormKomentari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntrazi;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KomentarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKomentara;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}