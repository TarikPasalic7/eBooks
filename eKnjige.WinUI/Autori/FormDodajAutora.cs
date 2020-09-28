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
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
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
}
