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

namespace eKnjige.WinUI.Komentari
{
    public partial class FormKomentari : Form
    {

        private readonly APIService _apiservice = new APIService("komentar");
        private readonly APIService _apiservicekorisnik = new APIService("Klijenti");
        private readonly APIService _apiserviceknjige = new APIService("eknjiga");
        public FormKomentari()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dugme();
        }

        private async void btntrazi_Click(object sender, EventArgs e)
        {

            string trazi = txtTrazi.Text;
            var result = await _apiservice.get<List<Model.Komentar>>(null);




            var temp = new List<Model.Komentar>();
            if (!string.IsNullOrWhiteSpace(trazi))
            {
                foreach (var item in result)
                {
                    if (item.komentar.Contains(trazi))
                    {

                        temp.Add(item);
                    }


                }
                dataGridView1.DataSource = temp;


            }
            else
            {
                dataGridView1.DataSource = result;
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
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
        public async void dugme()
        {
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            DataGridViewTextBoxColumn korisnik = new DataGridViewTextBoxColumn();
            korisnik.Name = "Korisnik";
            korisnik.HeaderText = "Korisnik";
            DataGridViewTextBoxColumn knjiga = new DataGridViewTextBoxColumn();
            knjiga.Name = "Knjiga";
            knjiga.HeaderText = "Knjiga";


            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Izbrisi";
            deletebutton.Name = "Izbrisi";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Izbrisi";


            deletebutton.Width = 70;

            if (dataGridView1.Columns.Contains(deletebutton.Name = "Izbrisi"))
            {

            }
            else
            {

                dataGridView1.Columns.Add(korisnik);
                dataGridView1.Columns.Add(knjiga);
                dataGridView1.Columns.Add(deletebutton);


            }

        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 5)
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Da li zaista zelite izbrisati komentar", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _apiservice.Remove(id);
                    dugme();
                    dataGridView1.DataSource = null;
                    string trazi = txtTrazi.Text;
                    var re = await _apiservice.get<List<Model.Komentar>>(null);




                    var temp = new List<Model.Komentar>();
                    if (!string.IsNullOrWhiteSpace(trazi))
                    {
                        foreach (var item in re)
                        {
                            if (item.komentar.Contains(trazi))
                            {

                                temp.Add(item);
                            }


                        }
                        dataGridView1.DataSource = temp;


                    }
                    else
                    {
                        dataGridView1.DataSource = re;
                    }

                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {

                        foreach (var r in re)
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
