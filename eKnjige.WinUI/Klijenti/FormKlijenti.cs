using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKnjige.Model;
using eKnjige.Model.Requests;
using Flurl;
using Flurl.Http;

namespace eKnjige.WinUI.Klijenti
{
    public partial class FormKlijenti : Form
    {
        private readonly APIService _apiservicekomentari = new APIService("komentar");
        private readonly APIService _apiservice = new APIService("klijenti");
        private readonly APIService _apiservicekupovina = new APIService("KupovinaKnjige");
        private readonly APIService _apiserviceprijedlogknjige = new APIService("prijedlogknjige");
        private readonly APIService _apiserviceeknjigaocjena = new APIService("eknjigaocjena");
        public FormKlijenti()
        {
            InitializeComponent();
            dgvKlijenti.AutoGenerateColumns = false;
            dugme();
        }

        public async void dugme()
        {
            var result = await _apiservice.get<List<Model.Komentar>>(null);

           dgvKlijenti.DataSource = result;
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            DataGridViewButtonColumn uredibutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.HeaderText = "Izbrisi";
            deletebutton.Name = "Izbrisi";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Izbrisi";
            deletebutton.Width = 70;



            uredibutton.FlatStyle = FlatStyle.Popup;
            uredibutton.HeaderText = "Uredi";
            uredibutton.Name = "Uredi";
            uredibutton.UseColumnTextForButtonValue = true;
            uredibutton.Text = "Uredi";
            uredibutton.Width = 70;

            if (dgvKlijenti.Columns.Contains(deletebutton.Name = "Izbrisi"))
            {

            }
            else
            {
                dgvKlijenti.Columns.Add(deletebutton);
            }

            if (dgvKlijenti.Columns.Contains(uredibutton.Name = "Uredi"))
            {

            }
            else
            {
                dgvKlijenti.Columns.Add(uredibutton);
            }


        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var search = new KlijentiSearchRequest();
            search.Ime = txtPretraga.Text;
            var result = await _apiservice.get<List<Model.Klijent>>(search);

            dgvKlijenti.DataSource = result;
          
        }

      

     

        private async void dgvKlijenti_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvKlijenti.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("Da li zaista zelite izbrisati korisnika", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var kupobinalist = await _apiservicekupovina.get<List<KupovinaKnjige>>(null);
                    var komentarilist = await _apiservicekomentari.get<List<Komentar>>(null);
                    var prijedlogknjige = await _apiserviceprijedlogknjige.get<List<PrijedlogKnjiga>>(null);
                    var eknjigaocjenalist = await _apiserviceeknjigaocjena.get<List<KlijentKnjigaOcjena>>(null);
                    if (kupobinalist != null)
                    {
                        foreach (var ku in kupobinalist)
                        {
                            if (ku.KlijentID == id)
                            {
                                await _apiservicekupovina.Remove(ku.KupovinaKnjigeID);
                            }
                        }
                    }
                    if (komentarilist != null)
                    {
                        foreach (var ku in komentarilist)
                        {
                            if (ku.KlijentID == id)
                            {
                                await _apiservicekomentari.Remove(ku.KomentarId);
                            }
                        }
                    }
                    if (prijedlogknjige != null)
                    {
                        foreach (var ku in prijedlogknjige)
                        {
                            if (ku.KlijentID == id)
                            {
                                await _apiserviceprijedlogknjige.Remove(ku.PrijedlogKnjigeID);
                            }
                        }
                    }
                    if (eknjigaocjenalist != null)
                    {
                        foreach (var ku in eknjigaocjenalist)
                        {
                            if (ku.KlijentID == id)
                            {
                                await _apiserviceeknjigaocjena.Remove(ku.KlijentKnjigaOcijenaID);
                            }
                        }
                    }


                    await _apiservice.Remove(id);
                    var search = new KlijentiSearchRequest();
                    search.Ime = txtPretraga.Text;
                    var res = await _apiservice.get<List<Model.Klijent>>(search);

                    dgvKlijenti.DataSource = null;
                    dgvKlijenti.DataSource = res;
                    dugme();
                    MessageBox.Show("Uspjesno ste izbrisali korisnika");
                }
                else if (result == DialogResult.No)
                {
                    return;

                }

            }
            if (e.ColumnIndex == 7)
            {

                FormKlijentiDetalji form = new FormKlijentiDetalji(int.Parse(id.ToString()));
                form.Show();

            }
        }
    }
}
