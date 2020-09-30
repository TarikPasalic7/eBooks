using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Knjige
{
    public partial class FormKnjige : Form
    {
        private readonly APIService _apiservice = new APIService("eknjiga");
        public FormKnjige()
        {
            
            InitializeComponent();
            dgvKnjige.AutoGenerateColumns = false;
        }

     

        private async void buttonPrikazi_Click(object sender, EventArgs e)
        {
            var search = new Model.Requests.eKnjigeSearchRequest();
            search.Naziv = textPrikazi.Text;
            var result = await _apiservice.get<List<Model.EKnjiga>>(search);
            foreach (var r in result)
            {

                r.OcjenaKnjige = (float)Math.Round(r.OcjenaKnjige * 10f) / 10f;

            }
            dgvKnjige.DataSource = result;
        }

     
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormEknjigeDodaj form = new FormEknjigeDodaj();
            form.Show();
            

        }

        private void dgvKnjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvKnjige.SelectedRows[0].Cells[0].Value;

            FormEknjigeDodaj form = new FormEknjigeDodaj(int.Parse(id.ToString()));
            form.Show();
        }
    }
}
