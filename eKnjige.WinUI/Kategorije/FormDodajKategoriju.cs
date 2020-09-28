using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Kategorije
{
    public partial class FormDodajKategoriju : Form
    {
        private readonly APIService kategorijaservice = new APIService("Kategorija");
        public FormDodajKategoriju()
        {
            InitializeComponent();
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            var insert = new Model.Requests.KategorijaInertRequest()
            {
                Naziv = txtNaziv.Text

        };

            await kategorijaservice.Insert<Model.Requests.KategorijaInertRequest>(insert);

            MessageBox.Show("Operacija uspjesna");
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
