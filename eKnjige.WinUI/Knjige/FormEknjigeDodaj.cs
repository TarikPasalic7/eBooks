using eKnjige.WinUI.Autori;
using eKnjige.WinUI.Drzave;
using eKnjige.WinUI.Kategorije;
using eKnjige.WinUI.Komentari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace eKnjige.WinUI.Knjige
{
    public partial class FormEknjigeDodaj : Form
    {
        
        private readonly APIService _apiservice = new APIService("eknjiga");
        private readonly APIService _Kategorijaapiservice = new APIService("kategorija");
        private readonly APIService _Autorapiservice = new APIService("autor");
        private readonly  APIService _kategorijaKnjigaservice = new APIService("eknjigakategorija");
        private readonly APIService _autorKnjigaservice = new APIService("eknjigaautor");
        private readonly APIService _EknjigaTip = new APIService("eknjigatipfajla");
     

        private int? id = null;
        public FormEknjigeDodaj(int? knjigeId = null)
        {
            
            InitializeComponent();
            dataGridViewAutori.AutoGenerateColumns = false;
            dataGridViewKategorije.AutoGenerateColumns = false;
            id = knjigeId;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FormEknjigeDodaj_Load(object sender, EventArgs e)
        {

            if (id.HasValue)
            {
                await EknjigeUcitaj();



              
              

            }
            else
            {
                buttonKomentari.Hide();
                await LoadAutori();
                await LoadKategorije();
            }
            
           ;

        }


        private async Task LoadKategorije()
        {
            var result = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);

            if (dataGridViewKategorije.DataSource == null)
            {

                dataGridViewKategorije.DataSource = result;
            }



            foreach (DataGridViewRow item in dataGridViewKategorije.Rows)
            {

                if (item.Cells[0].Value == null)
                {
                    item.Cells[0].Value = false;

                }


            }


        }

        private async Task LoadAutori()
        {


            var result = await _Autorapiservice.get<List<Model.Autor>>(null);

            if (dataGridViewAutori.DataSource == null)
            {
                dataGridViewAutori.DataSource = result;

            }
            
            foreach(DataGridViewRow item in dataGridViewAutori.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    item.Cells[0].Value = false;

                }
                

            }

        }

     

        private async Task EknjigeUcitaj()
        {
            var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);
            var knjigaautori = await _autorKnjigaservice.get<List<Model.EKnjigeAutor>>(null);
            var autori = await _Autorapiservice.get<List<Model.Autor>>(null);
            var knjigakategorije = await _kategorijaKnjigaservice.get<List<Model.EKnjigaKategorija>>(null);
            var kategorije = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);
           

            if (knjiga.MP3Dodan == true)
            {
                checkBoxMP3.Checked=true;
                buttonmp3file.Hide();

            }
            if (knjiga.PDFDodan == true)
            {
                checkBoxPdf.Checked=true;
                buttonpdffile.Hide();

            }

            dataGridViewAutori.DataSource = autori;
            dataGridViewKategorije.DataSource = kategorije;
        

            foreach(DataGridViewRow r in dataGridViewAutori.Rows)
            {
                bool dodan=false;
                foreach(var a in knjigaautori)
                {
                    var v = int.Parse(r.Cells[1].Value.ToString());

                    if (a.EKnjigaID==knjiga.EKnjigaID && a.AutorID==v)
                    {
                        dodan= true;
                    }
                   


                }
                if (dodan == true) {
                    r.Cells[0].Value = true;
                    

                }
                else
                {
                    r.Cells[0].Value = false;

                }


            }
            foreach (DataGridViewRow r in dataGridViewKategorije.Rows)
            {
                bool dodan = false;
                foreach (var k in knjigakategorije)
                {
                    var v = int.Parse(r.Cells[1].Value.ToString());

                    if (k.EKnjigaID == knjiga.EKnjigaID && k.KategorijaID == v)
                    {
                        dodan = true;
                    }



                }
                if (dodan == true)
                {
                    r.Cells[0].Value = true;


                }
                else
                {
                    r.Cells[0].Value = false;

                }


            }

            textNaziv.Text = knjiga.Naziv;
            textCijena.Text = knjiga.Cijena.ToString();
            textOcjena.Text = knjiga.OcjenaKnjige.ToString();
            textOpis.Text = knjiga.Opis;

            byte[] image = knjiga.Slika;
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);





        }
        Model.Requests.EKnjigaInsertRequest request = new Model.Requests.EKnjigaInsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {





            request.Naziv = textNaziv.Text;
                request.Cijena = float.Parse(textCijena.Text);
                request.OcjenaKnjige = float.Parse(textOcjena.Text);
                request.AdministratorID = APIService.PrijavljeniKorisnik.KlijentID;
                request.Opis = textOpis.Text;
            

           

            if (id.HasValue)
            {
                var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);

                request.Slika = knjiga.Slika;
               
                var knjigaautori = await _autorKnjigaservice.get<List<Model.EKnjigeAutor>>(null);
                foreach (var item in Alist)
                {
                    bool tacan = false;

                    foreach(var item2 in  knjigaautori )
                    if (item2.EKnjigaID==knjiga.EKnjigaID && item2.AutorID==item.AutorID)
                    {

                            tacan = true;
                            break;
                    }

                    if (tacan == false)
                    {

                        Model.EKnjigeAutorRequest autor = new Model.EKnjigeAutorRequest()
                        {
                            AutorID = item.AutorID,
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _autorKnjigaservice.Insert<Model.EKnjigeAutor>(autor);
                    }

                }

                var knjigakategorije = await _kategorijaKnjigaservice.get<List<Model.EKnjigaKategorija>>(null);

                foreach (var item in Klist)
                {
                    bool tacan = false;

                    foreach (var item2 in knjigakategorije)
                        if (  item2.EKnjigaID == knjiga.EKnjigaID && item2.KategorijaID == item.KategorijaID)
                        {

                            tacan = true;
                            break;
                        }

                    if (tacan == false )
                    {

                        Model.EKnjigaKategorijaRequest kategorija= new Model.EKnjigaKategorijaRequest()
                        {
                            KategorijaID = item.KategorijaID,
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _kategorijaKnjigaservice.Insert<Model.EKnjigaKategorija>(kategorija);
                    }

                }


                await _apiservice.Update<Model.EKnjiga>(id, request);
            }
            else
            {
                
                if (checkBoxMP3.Checked == true)
                {
                    request.MP3Dodan = true;
                }
                if (checkBoxPdf.Checked == true)
                {
                    request.PDFDodan = true;
                }

                var knjiga =await _apiservice.Insert<Model.EKnjiga>(request);
              
                foreach(var item in Alist)
                {
                   

                        Model.EKnjigeAutorRequest autor = new Model.EKnjigeAutorRequest()
                        {
                            AutorID = item.AutorID,
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _autorKnjigaservice.Insert<Model.EKnjigeAutor>(autor);
                    
                  

                }

                foreach (var item in Klist)
                {
                    

                        Model.EKnjigaKategorijaRequest kategorija = new Model.EKnjigaKategorijaRequest()
                        {
                            KategorijaID=item.KategorijaID,
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _kategorijaKnjigaservice.Insert<Model.EKnjigaKategorija>(kategorija);
                    


                }

       


              


            }
            MessageBox.Show("Operacija uspjesna");
            DialogResult = DialogResult.OK;
            Close();

            


    }

        private  void btnSlika_Click(object sender, EventArgs e)
        {

            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                var filename = openFileDialog1.FileName;
                var file = File.ReadAllBytes(filename);
                request.Slika = file;
                txtSlikaInput.Text = filename;
                Image image = Image.FromFile(filename);
                pictureBox1.Image = image;

            }

        }

        private async void buttonKategorijeKnjige_Click(object sender, EventArgs e)
        {
            FormDodajKategoriju form = new FormDodajKategoriju();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listKategorija = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);
                dataGridViewKategorije.DataSource = listKategorija;

                if (id != null)
                {
                    var kategorijeknjigelist = await _kategorijaKnjigaservice.get<List<Model.EKnjigaKategorija>>(null);
                    var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);
                    foreach (DataGridViewRow item in dataGridViewKategorije.Rows)
                    {
                        bool tacan = false;
                        foreach (var ka in kategorijeknjigelist)
                        {
                            int autorid = int.Parse(item.Cells[1].Value.ToString());
                            if (ka.EKnjigaID == knjiga.EKnjigaID && autorid == ka.KategorijaID)
                            {
                                tacan = true;
                                break;
                            }

                        }
                        if (tacan)
                        {
                            item.Cells[0].Value = true;
                        }
                        else
                        {
                            item.Cells[0].Value = false;
                        }


                    }
                }
                else
                {
                    foreach (DataGridViewRow item in dataGridViewKategorije.Rows)
                    {

                        item.Cells[0].Value = false;

                    }
                }
            }
          
        }

       

        private void buttonmp3file_Click(object sender, EventArgs e)
        {
            var result = openFileDialogmp3.ShowDialog();
            if (result == DialogResult.OK)
            {

                var filename = openFileDialogmp3.FileName;
              
                string[] f = filename.Split('\\');
              
                string fn = f[(f.Length) - 1];
                string startuppath = Path.GetDirectoryName(Application.ExecutablePath).Replace("eKnjige.WinUI\\bin\\Debug", string.Empty); ;
                string filepath = "EKnjige.MobileApp\\EKnjige.MobileApp.UWP\\bin\\x86\\Debug\\AppX\\Assets\\";


                string dest = startuppath + filepath + fn;


                File.Copy(filename, dest, true);
                request.Mp3file= fn;
                checkBoxMP3.Checked = true;

            }
        }

        private void buttonpdffile_Click(object sender, EventArgs e)
        {

            var result = openFileDialogpdf.ShowDialog();
            if (result == DialogResult.OK)
            {

                var filename = openFileDialogpdf.FileName;
               
                string[] f = filename.Split('\\');
             
                string fn = f[(f.Length) - 1];
                string startuppath = Path.GetDirectoryName(Application.ExecutablePath).Replace("eKnjige.WinUI\\bin\\Debug", string.Empty); ;
                string filepath = "EKnjige.MobileApp\\EKnjige.MobileApp.UWP\\bin\\x86\\Debug\\AppX\\Assets\\";

                
                string dest=startuppath + filepath + fn;
               
                request.Pdffile = fn;
                File.Copy(filename, dest, true);
                checkBoxPdf.Checked = true;
             
            }

        }
     

        private async void buttonAutoriDodaj_Click(object sender, EventArgs e)
        {
            FormDodajAutora form = new FormDodajAutora();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listaautora = await _Autorapiservice.get<List<Model.Autor>>(null);
                dataGridViewAutori.DataSource = listaautora;
                if (id != null)
                {
                    var autoriknjigelist = await _autorKnjigaservice.get<List<Model.EKnjigeAutor>>(null);
                    var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);
                    foreach (DataGridViewRow item in dataGridViewAutori.Rows)
                    {
                        bool tacan = false;
                        foreach(var ka in autoriknjigelist)
                        { int autorid = int.Parse(item.Cells[1].Value.ToString());
                            if (ka.EKnjigaID==knjiga.EKnjigaID && autorid==ka.AutorID)
                            {
                                tacan = true;
                                break;
                            }

                        }
                        if(tacan)
                        {
                          item.Cells[0].Value = true;
                        }
                        else
                        {
                            item.Cells[0].Value = false;
                        }
                      

                    }
                }
                else
                {
                    foreach (DataGridViewRow item in dataGridViewAutori.Rows)
                    {

                        item.Cells[0].Value = false;

                    }
                }
               
            }
        }

        private void buttonKomentari_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                FormKomentariKnjige form = new FormKomentariKnjige(id);
                form.Show();
            }
           
        }

        private void textNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNaziv.Text))
            {

                errorProvider.SetError(textNaziv, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textNaziv, null);
            }
        }

        private void textCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCijena.Text))
            {

                errorProvider.SetError(textCijena, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textCijena, null);
            }
        }

        List<Model.Kategorija> Klist = new List<Model.Kategorija>();
        private async void  dataGridViewKategorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int id;
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dataGridViewKategorije.Rows[e.RowIndex].Cells[1].Value.ToString());
               var tacan=bool.Parse(dataGridViewKategorije.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (tacan != true)
                {
                    var kategorija = await _Kategorijaapiservice.getbyId<Model.Kategorija>(id);
                    Klist.Add(kategorija);
                    dataGridViewKategorije.Rows[e.RowIndex].Cells[0].Value = true;
                }
              
                   
                
               

            }

        }
        List<Model.Autor> Alist = new List<Model.Autor>();

        private async void dataGridViewAutori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dataGridViewAutori.Rows[e.RowIndex].Cells[1].Value.ToString());
                var tacan = bool.Parse(dataGridViewAutori.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (tacan != true)
                {
                    var autori = await _Autorapiservice.getbyId<Model.Autor>(id);
                    Alist.Add(autori);
                    dataGridViewAutori.Rows[e.RowIndex].Cells[0].Value = true;
                }





            }
        }

        private void dataGridViewKategorije_Validating(object sender, CancelEventArgs e)
        {
            if (dataGridViewKategorije.SelectedRows == null)
            {

                errorProvider.SetError(dataGridViewKategorije, "Obavezno dodati barem jednu kategoriju");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dataGridViewKategorije, null);
            }
        }

        private void dataGridViewAutori_Validating(object sender, CancelEventArgs e)
        {
            if (dataGridViewAutori.SelectedRows == null)
            {

                errorProvider.SetError(dataGridViewAutori, "Obavezno dodati barem jednog autora");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dataGridViewAutori, null);
            }
        }
    }
}
