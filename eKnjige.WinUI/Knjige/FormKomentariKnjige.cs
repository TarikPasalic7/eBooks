using eKnjige.Model;
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
    public partial class FormKomentariKnjige : Form
    {

        private readonly APIService _apiservice = new APIService("komentar");
        private readonly APIService _apiservicekorisnik = new APIService("Klijenti");
        private readonly APIService _apiserviceknjige = new APIService("eknjiga");
        private int? id = null;
        public FormKomentariKnjige(int? knjigeId = null)
        {
            InitializeComponent();
           dgvKomentari.AutoGenerateColumns = false;
            id = knjigeId;
            dugme();
        }

        public async void dugme()
        {
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Izbrisi";
            deletebutton.Name = "Izbrisi";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Izbrisi";
            deletebutton.Width = 70;

            DataGridViewTextBoxColumn korisnik = new DataGridViewTextBoxColumn();
            korisnik.Name = "Korisnik";
            korisnik.HeaderText = "Korisnik";
            DataGridViewTextBoxColumn knjiga = new DataGridViewTextBoxColumn();
            knjiga.Name = "Knjiga";
            knjiga.HeaderText = "Knjiga";

            if (dgvKomentari.Columns.Contains(deletebutton.Name = "Izbrisi"))
            {

            }
            else
            {

                dgvKomentari.Columns.Add(korisnik);
                dgvKomentari.Columns.Add(knjiga);
                dgvKomentari.Columns.Add(deletebutton);
            }

        }
        private async void btnTrazi_Click(object sender, EventArgs e)
        {

            string trazi = txtTrazi.Text;
            var result = await _apiservice.get<List<Model.Komentar>>(null);
            var result2 = new List<Model.Komentar>();
            foreach (var r in result)
            {
                if (r.EKnjigaID == id)
                {
                    result2.Add(r);
                }
            }

            List<Model.Komentar> temp = new List<Model.Komentar>();
            if (!string.IsNullOrWhiteSpace(trazi))
            {
                foreach (var item in result2)
                {
                    if (item.komentar.Contains(trazi))
                    {

                        temp.Add(item);
                    }


                }
                dgvKomentari.DataSource = temp;
            }
            else
            {
                dgvKomentari.DataSource = result2;
            }

            foreach (DataGridViewRow item in dgvKomentari.Rows)
            {


                foreach (var r in result)
                {
                    int komentarid = int.Parse(item.Cells[0].Value.ToString());
                    if (r.KomentarId == komentarid)
                    {
                        var k = await _apiservicekorisnik.getbyId<Klijent>(r.KlijentID);
                        var ek = await _apiserviceknjige.getbyId<EKnjiga>(r.EKnjigaID);
                        item.Cells[3].Value = k.KorisnickoIme;
                        item.Cells[4].Value = ek.Naziv;
                    }

                }



            }

        }

        private async void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int komentarid;
            if (e.ColumnIndex == 5)
            {
                komentarid = Convert.ToInt32(dgvKomentari.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Da li zaista zelite izbrisati komentar", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _apiservice.Remove(komentarid);
                    dugme();

                    string trazi = txtTrazi.Text;
                    var res = await _apiservice.get<List<Model.Komentar>>(null);
                    var res2 = new List<Model.Komentar>();
                    dgvKomentari.DataSource = null;
                    foreach (var r in res)
                    {
                        if (r.EKnjigaID == id)
                        {
                            res2.Add(r);
                        }
                    }

                    List<Model.Komentar> temp = new List<Model.Komentar>();
                    if (!string.IsNullOrWhiteSpace(trazi))
                    {
                        foreach (var item in res2)
                        {
                            if (item.komentar.Contains(trazi))
                            {

                                temp.Add(item);
                            }


                        }
                        dgvKomentari.DataSource = temp;
                    }
                    else
                    {
                        dgvKomentari.DataSource = res2;
                    }



                    foreach (DataGridViewRow item in dgvKomentari.Rows)
                    {
                        var re = await _apiservice.get<List<Model.Komentar>>(null);

                        foreach (var r in re)
                        {
                            int komid = int.Parse(item.Cells[0].Value.ToString());
                            if (r.KomentarId == komid)
                            {
                                var k = await _apiservicekorisnik.getbyId<Klijent>(r.KlijentID);
                                var ek = await _apiserviceknjige.getbyId<EKnjiga>(r.EKnjigaID);
                                item.Cells[3].Value = k.KorisnickoIme;
                                item.Cells[4].Value = ek.Naziv;
                            }

                        }



                    }

                    MessageBox.Show("Uspjesno ste izbrisali komentar");
                }
                else if (result == DialogResult.No)
                {
                    return;

                }

            }
        }
    }
}
