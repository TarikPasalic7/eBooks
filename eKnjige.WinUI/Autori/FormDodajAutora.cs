using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Autori
{
    public partial class FormDodajAutora : Form
    {
        private readonly APIService autorservice = new APIService("Autor");
        public FormDodajAutora()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var insert = new Model.Autor
                {

                    Ime = txtAutorIme.Text,
                    Prezime = txtAutorPrezime.Text,
                    Godiste = dateAutor.Value
                };
                await autorservice.Insert<Model.Autor>(insert);

                MessageBox.Show("Operacija uspjesna");
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void txtAutorIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAutorIme.Text))
            {

                errorProvider.SetError(txtAutorIme, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAutorIme, null);
            }
        }

        private void txtAutorPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAutorPrezime.Text))
            {

                errorProvider.SetError(txtAutorPrezime, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAutorPrezime, null);
            }
        }
    }
}
