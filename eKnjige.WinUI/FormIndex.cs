using eKnjige.WinUI.Autori;
using eKnjige.WinUI.Kategorije;
using eKnjige.WinUI.Klijenti;
using eKnjige.WinUI.Knjige;
using eKnjige.WinUI.Komentari;
using eKnjige.WinUI.Prijedlozi;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI
{
    public partial class FormIndex : Form
    {
        private int childFormNumber = 0;

        public FormIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormKlijenti klijent = new FormKlijenti();
            //klijent.MdiParent= this;
            klijent.Show();
              

        }

        private void noviKlijentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormKlijentiDetalji form = new FormKlijentiDetalji();
            form.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKnjige form = new FormKnjige();
            form.Show();
        }

        private void kategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormDodajKategoriju form = new FormDodajKategoriju();
            form.Show();
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodajAutora form = new FormDodajAutora();
            form.Show();
        }

     

        private void komentariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKomentari form = new FormKomentari();
            form.Show();
        }

        private void prijedloziKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrijedlozi form = new FormPrijedlozi();
            form.Show();
        }

        private void buttonKorisnik_Click(object sender, EventArgs e)
        {
            FormKlijenti form = new FormKlijenti();
            form.Show();
        }

        private void buttonEKnjige_Click(object sender, EventArgs e)
        {
            FormKnjige form = new FormKnjige();
            form.Show();
        }

        private void buttonPrijedlozi_Click(object sender, EventArgs e)
        {
            FormPrijedlozi form = new FormPrijedlozi();
            form.Show();
        }

      
    }
}
