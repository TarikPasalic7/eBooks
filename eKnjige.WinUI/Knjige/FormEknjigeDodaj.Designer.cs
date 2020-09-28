namespace eKnjige.WinUI.Knjige
{
    partial class FormEknjigeDodaj
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
            this.label3 = new System.Windows.Forms.Label();
            this.textOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOcjena = new System.Windows.Forms.TextBox();
            this.NazivKnjige = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxMP3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPdf = new System.Windows.Forms.CheckBox();
            this.buttonKategorijeKnjige = new System.Windows.Forms.Button();
            this.buttonmp3file = new System.Windows.Forms.Button();
            this.buttonpdffile = new System.Windows.Forms.Button();
            this.openFileDialogmp3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogpdf = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewAutori = new System.Windows.Forms.DataGridView();
            this.dataGridViewKategorije = new System.Windows.Forms.DataGridView();
            this.buttonAutoriDodaj = new System.Windows.Forms.Button();
            this.buttonKomentari = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dodaj = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AutorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodajKategoriju = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KategorijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Opis";
            // 
            // textOpis
            // 
            this.textOpis.Location = new System.Drawing.Point(23, 271);
            this.textOpis.Multiline = true;
            this.textOpis.Name = "textOpis";
            this.textOpis.Size = new System.Drawing.Size(359, 120);
            this.textOpis.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cijena";
            // 
            // textCijena
            // 
            this.textCijena.Location = new System.Drawing.Point(23, 143);
            this.textCijena.Name = "textCijena";
            this.textCijena.Size = new System.Drawing.Size(100, 20);
            this.textCijena.TabIndex = 14;
            this.textCijena.Validating += new System.ComponentModel.CancelEventHandler(this.textCijena_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ocjena";
            // 
            // textOcjena
            // 
            this.textOcjena.Location = new System.Drawing.Point(23, 81);
            this.textOcjena.Name = "textOcjena";
            this.textOcjena.Size = new System.Drawing.Size(100, 20);
            this.textOcjena.TabIndex = 12;
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.AutoSize = true;
            this.NazivKnjige.Location = new System.Drawing.Point(158, 30);
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.Size = new System.Drawing.Size(34, 13);
            this.NazivKnjige.TabIndex = 11;
            this.NazivKnjige.Text = "Naziv";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(23, 23);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(100, 20);
            this.textNaziv.TabIndex = 10;
            this.textNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textNaziv_Validating);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSnimi.Location = new System.Drawing.Point(1196, 537);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(155, 56);
            this.btnSnimi.TabIndex = 18;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1166, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(1011, 33);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(135, 20);
            this.txtSlikaInput.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(946, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Slika";
            // 
            // btnSlika
            // 
            this.btnSlika.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSlika.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSlika.Location = new System.Drawing.Point(1067, 78);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(79, 30);
            this.btnSlika.TabIndex = 22;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = false;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxMP3
            // 
            this.checkBoxMP3.AutoSize = true;
            this.checkBoxMP3.Location = new System.Drawing.Point(23, 462);
            this.checkBoxMP3.Name = "checkBoxMP3";
            this.checkBoxMP3.Size = new System.Drawing.Size(48, 17);
            this.checkBoxMP3.TabIndex = 23;
            this.checkBoxMP3.Text = "MP3";
            this.checkBoxMP3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPdf
            // 
            this.checkBoxPdf.AutoSize = true;
            this.checkBoxPdf.Location = new System.Drawing.Point(198, 462);
            this.checkBoxPdf.Name = "checkBoxPdf";
            this.checkBoxPdf.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPdf.TabIndex = 24;
            this.checkBoxPdf.Text = "PDF";
            this.checkBoxPdf.UseVisualStyleBackColor = true;
            // 
            // buttonKategorijeKnjige
            // 
            this.buttonKategorijeKnjige.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKategorijeKnjige.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKategorijeKnjige.Location = new System.Drawing.Point(774, 253);
            this.buttonKategorijeKnjige.Name = "buttonKategorijeKnjige";
            this.buttonKategorijeKnjige.Size = new System.Drawing.Size(75, 33);
            this.buttonKategorijeKnjige.TabIndex = 25;
            this.buttonKategorijeKnjige.Text = "Kategorije";
            this.buttonKategorijeKnjige.UseVisualStyleBackColor = false;
            this.buttonKategorijeKnjige.Click += new System.EventHandler(this.buttonKategorijeKnjige_Click);
            // 
            // buttonmp3file
            // 
            this.buttonmp3file.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonmp3file.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonmp3file.Location = new System.Drawing.Point(23, 508);
            this.buttonmp3file.Name = "buttonmp3file";
            this.buttonmp3file.Size = new System.Drawing.Size(75, 23);
            this.buttonmp3file.TabIndex = 29;
            this.buttonmp3file.Text = "MP3 file";
            this.buttonmp3file.UseVisualStyleBackColor = false;
            this.buttonmp3file.Click += new System.EventHandler(this.buttonmp3file_Click);
            // 
            // buttonpdffile
            // 
            this.buttonpdffile.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonpdffile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonpdffile.Location = new System.Drawing.Point(186, 508);
            this.buttonpdffile.Name = "buttonpdffile";
            this.buttonpdffile.Size = new System.Drawing.Size(75, 23);
            this.buttonpdffile.TabIndex = 30;
            this.buttonpdffile.Text = "PDF file";
            this.buttonpdffile.UseVisualStyleBackColor = false;
            this.buttonpdffile.Click += new System.EventHandler(this.buttonpdffile_Click);
            // 
            // openFileDialogmp3
            // 
            this.openFileDialogmp3.FileName = "openFileDialogmp3";
            // 
            // openFileDialogpdf
            // 
            this.openFileDialogpdf.FileName = "openFileDialogpdf";
            // 
            // dataGridViewAutori
            // 
            this.dataGridViewAutori.AllowUserToAddRows = false;
            this.dataGridViewAutori.AllowUserToDeleteRows = false;
            this.dataGridViewAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dodaj,
            this.AutorID,
            this.Ime,
            this.Prezime});
            this.dataGridViewAutori.Location = new System.Drawing.Point(504, 347);
            this.dataGridViewAutori.Name = "dataGridViewAutori";
            this.dataGridViewAutori.Size = new System.Drawing.Size(345, 246);
            this.dataGridViewAutori.TabIndex = 31;
            this.dataGridViewAutori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAutori_CellContentClick);
            // 
            // dataGridViewKategorije
            // 
            this.dataGridViewKategorije.AllowUserToAddRows = false;
            this.dataGridViewKategorije.AllowUserToDeleteRows = false;
            this.dataGridViewKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DodajKategoriju,
            this.KategorijaID,
            this.Naziv});
            this.dataGridViewKategorije.Location = new System.Drawing.Point(504, 40);
            this.dataGridViewKategorije.Name = "dataGridViewKategorije";
            this.dataGridViewKategorije.Size = new System.Drawing.Size(246, 246);
            this.dataGridViewKategorije.TabIndex = 32;
            this.dataGridViewKategorije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategorije_CellContentClick);
            // 
            // buttonAutoriDodaj
            // 
            this.buttonAutoriDodaj.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAutoriDodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAutoriDodaj.Location = new System.Drawing.Point(877, 560);
            this.buttonAutoriDodaj.Name = "buttonAutoriDodaj";
            this.buttonAutoriDodaj.Size = new System.Drawing.Size(75, 33);
            this.buttonAutoriDodaj.TabIndex = 33;
            this.buttonAutoriDodaj.Text = "Autori";
            this.buttonAutoriDodaj.UseVisualStyleBackColor = false;
            this.buttonAutoriDodaj.Click += new System.EventHandler(this.buttonAutoriDodaj_Click);
            // 
            // buttonKomentari
            // 
            this.buttonKomentari.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKomentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKomentari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKomentari.Location = new System.Drawing.Point(1160, 317);
            this.buttonKomentari.Name = "buttonKomentari";
            this.buttonKomentari.Size = new System.Drawing.Size(191, 60);
            this.buttonKomentari.TabIndex = 34;
            this.buttonKomentari.Text = "Komentari";
            this.buttonKomentari.UseVisualStyleBackColor = false;
            this.buttonKomentari.Click += new System.EventHandler(this.buttonKomentari_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Dodaj
            // 
            this.Dodaj.HeaderText = "Dodaj";
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Width = 101;
            // 
            // AutorID
            // 
            this.AutorID.DataPropertyName = "AutorID";
            this.AutorID.HeaderText = " AutorID";
            this.AutorID.Name = "AutorID";
            this.AutorID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // DodajKategoriju
            // 
            this.DodajKategoriju.HeaderText = "Dodaj";
            this.DodajKategoriju.Name = "DodajKategoriju";
            this.DodajKategoriju.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DodajKategoriju.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DodajKategoriju.TrueValue = "";
            // 
            // KategorijaID
            // 
            this.KategorijaID.DataPropertyName = "KategorijaID";
            this.KategorijaID.HeaderText = "KategorijaID";
            this.KategorijaID.Name = "KategorijaID";
            this.KategorijaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // FormEknjigeDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1514, 638);
            this.Controls.Add(this.buttonKomentari);
            this.Controls.Add(this.buttonAutoriDodaj);
            this.Controls.Add(this.dataGridViewKategorije);
            this.Controls.Add(this.dataGridViewAutori);
            this.Controls.Add(this.buttonpdffile);
            this.Controls.Add(this.buttonmp3file);
            this.Controls.Add(this.buttonKategorijeKnjige);
            this.Controls.Add(this.checkBoxPdf);
            this.Controls.Add(this.checkBoxMP3);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOcjena);
            this.Controls.Add(this.NazivKnjige);
            this.Controls.Add(this.textNaziv);
            this.Name = "FormEknjigeDodaj";
            this.Text = "FormEknjigeDodaj";
            this.Load += new System.EventHandler(this.FormEknjigeDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOcjena;
        private System.Windows.Forms.Label NazivKnjige;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxMP3;
        private System.Windows.Forms.CheckBox checkBoxPdf;
        private System.Windows.Forms.Button buttonKategorijeKnjige;
        private System.Windows.Forms.Button buttonmp3file;
        private System.Windows.Forms.Button buttonpdffile;
        private System.Windows.Forms.OpenFileDialog openFileDialogmp3;
        private System.Windows.Forms.OpenFileDialog openFileDialogpdf;
        private System.Windows.Forms.DataGridView dataGridViewAutori;
        private System.Windows.Forms.DataGridView dataGridViewKategorije;
        private System.Windows.Forms.Button buttonAutoriDodaj;
        private System.Windows.Forms.Button buttonKomentari;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DodajKategoriju;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}