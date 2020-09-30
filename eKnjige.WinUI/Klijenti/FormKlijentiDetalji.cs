using eKnjige.Model;
using eKnjige.WinUI.Gradovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Klijenti
{
    public partial class FormKlijentiDetalji : Form
    {

        private readonly APIService service=new APIService("Klijenti");
        private readonly APIService servicegrad = new APIService("Grad");
        private readonly APIService serviceSpol = new APIService("Spol");
        private readonly APIService serviceUloga = new APIService("Uloga");

        private int? id = null;
        public FormKlijentiDetalji(int? klijentId =null)
        {
            InitializeComponent();

            id = klijentId;
            this.AutoValidate = AutoValidate.Disable;
        }

       

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {

                var request = new KlijentInsertRequest();

                request.Ime = textIme.Text;
                request.Prezime = textPrezime.Text;
                request.KorisnickoIme = textKorisnickoIme.Text;
                request.Email = textEmail.Text;
                //request.DatumRodenja = DateTime.Now;
                request.LozinkaHash = textPassword.Text;
                request.LozinkaProvjera = textPasswordPotvrda.Text;
                request.DatumRodenja = dateDatum.Value;
               
                request.GradID = (cmbGradovi.SelectedItem as Model.Grad).Id;
                request.SpolID = (cmbSpol.SelectedItem as Model.Spol).SpolID;
                request.UlogaId = (cmbUloga.SelectedItem as Model.Uloga).UlogaId;



                var klijenti = await service.get<List<Klijent>>(null);


                if (id.HasValue)
                {
                    var klijent = await service.getbyId<Klijent>(id);
                    bool greska = false;
                    bool greska2 = false;



                    foreach (var k in klijenti)
                    {

                        if (k.Email == textEmail.Text && k.Email != klijent.Email)
                        {
                            greska = true;
                            break;

                        }
                        if (k.KorisnickoIme == textKorisnickoIme.Text && k.KorisnickoIme != klijent.KorisnickoIme)
                        {
                            greska2 = true;
                            break;

                        }

                    }
                    if (greska == true)
                    {
                        MessageBox.Show("Email je vec iskorišten");
                        return;

                    }
                    if (greska2 == true)
                    {
                        MessageBox.Show("Korisnicko ime je vec iskorišteno");
                        return;

                    }

                    await service.Update<Model.Klijent>(id, request);
                    MessageBox.Show("Operacija uspjesna");
                    Close();



                }
                else
                {
                    bool greska = false;
                    bool greska2 = false;



                    foreach (var k in klijenti)
                    {

                        if (k.Email == textEmail.Text)
                        {
                            greska = true;
                            break;

                        }
                        if (k.KorisnickoIme == textKorisnickoIme.Text)
                        {
                            greska2 = true;
                            break;

                        }

                    }
                    if (greska == true)
                    {
                        MessageBox.Show("Email je vec iskorišten");
                        return;

                    }
                    if (greska2 == true)
                    {
                        MessageBox.Show("Korisnicko ime je vec iskorišteno");
                        return;

                    }


                    await service.Insert<Model.Klijent>(request);
                    MessageBox.Show("Operacija uspjesna");
                    Close();
                }

            }




        }
        private async void FormKlijentiDetalji_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {


                var klijent = await service.getbyId<Model.Klijent>(id);
                textKorisnickoIme.Text = klijent.KorisnickoIme;
                textIme.Text = klijent.Ime;
                textPrezime.Text = klijent.Prezime;
               
                textEmail.Text = klijent.Email;
                textPassword.Hide();
                textPasswordPotvrda.Hide();
                labelPassword.Hide();
                labelPasswordPotvrda.Hide();
                await LoadSpol();
                await LoadGradovi();
                await LoadUloga();

                foreach (Model.Grad item in cmbGradovi.Items)
                {
                    if (item.Id == klijent.GradID)
                        cmbGradovi.SelectedItem = item;

                }
                foreach (Model.Uloga item in cmbUloga.Items)
                {
                    if (item.UlogaId == klijent.UlogaId)
                        cmbUloga.SelectedItem = item;

                }
                foreach (Model.Spol item in cmbSpol.Items)
                {
                    if (item.SpolID == klijent.SpolID)
                        cmbSpol.SelectedItem = item;

                }

            }
            else
            {

                await LoadSpol();
                await LoadGradovi();
                await LoadUloga();



            }





        }

        private async Task LoadGradovi()
        {

            
            var result = await servicegrad.get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "Id";
            cmbGradovi.DataSource = result;
            
        }




    

        private async Task LoadSpol()
        {


            var result = await serviceSpol.get<List<Model.Spol>>(null);
            result.Insert(0, new Model.Spol());
            cmbSpol.DisplayMember = "Tip";
            cmbSpol.ValueMember = "SpolID ";

            cmbSpol.DataSource = result;
        }

        private async Task LoadUloga()
        {


            var result = await serviceUloga.get<List<Model.Uloga>>(null);
            result.Insert(0, new Model.Uloga());
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "UlogaId ";

            cmbUloga.DataSource = result;
        }


        private void textIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textIme.Text))
            {

                errorProvider.SetError(textIme, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textIme, null);
            }
        }

     

        private void textPrezime_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textPrezime.Text))
            {

                errorProvider.SetError(textPrezime, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textPrezime, null);
            }

        }

        private void textKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textKorisnickoIme.Text))
            {

                errorProvider.SetError(textKorisnickoIme, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textKorisnickoIme, null);
            }
        }

       

        private async void buttonGrad_Click(object sender, EventArgs e)
        {
            FormDodajGrad form = new FormDodajGrad();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await LoadGradovi();
            }


        }

 

        private void textPassword_Validating(object sender, CancelEventArgs e)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (id == null)
            {
                if (string.IsNullOrWhiteSpace(textPassword.Text))
                {

                    errorProvider.SetError(textPassword, "Obavezno Polje");
                    e.Cancel = true;
                }
                else
                {
                    if (hasNumber.IsMatch(textPassword.Text) && hasUpperChar.IsMatch(textPassword.Text) && hasMinimum8Chars.IsMatch(textPassword.Text))
                    {
                        errorProvider.SetError(textPassword, null);
                    }
                    else
                    {
                        errorProvider.SetError(textPassword, "Lozinka mora imati brojeve,velika slova i minimum 8 karaktera");
                        e.Cancel = true;

                    }
                }


            }

        }

        private void textPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (id == null)
            {
                if (string.IsNullOrWhiteSpace(textPasswordPotvrda.Text) && id == null)
                {

                    errorProvider.SetError(textPasswordPotvrda, "Obavezno Polje");
                    e.Cancel = true;
                }
                else
                {
                    if (textPassword.Text == textPasswordPotvrda.Text && id == null)
                    {
                        errorProvider.SetError(textPasswordPotvrda, null);
                    }
                    else
                    {
                        errorProvider.SetError(textPasswordPotvrda, "Lozinke se ne slazu ");
                        e.Cancel = true;
                    }

                }

            }

        }

        private void cmbGradovi_Validating(object sender, CancelEventArgs e)
        {

            if (cmbGradovi.SelectedValue==null)
            {

                errorProvider.SetError(cmbGradovi, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbGradovi, null);
            }

        }

        private void cmbSpol_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSpol.SelectedValue == null)
            {

                errorProvider.SetError(cmbSpol, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbSpol, null);
            }
        }

        private void cmbUloga_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUloga.SelectedValue == null)
            {

                errorProvider.SetError(cmbUloga, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbUloga, null);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {

                errorProvider.SetError(textEmail, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {

                errorProvider.SetError(textEmail, null);

            }
        }
    }
}
