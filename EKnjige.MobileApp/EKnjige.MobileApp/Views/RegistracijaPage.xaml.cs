using EKnjige.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EKnjige.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        private RegistracijaViewModel registracija= null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = registracija = new RegistracijaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ErrorLabel_Ime.IsVisible = false;
            ErrorLabel_Prezime.IsVisible = false;
            ErrorLabel_KorisnickoIme.IsVisible = false;
            ErrorLabel_Email.IsVisible = false;
            ErrorLabel_Datum.IsVisible = false;
            ErrorLabel_Lozinka.IsVisible = false;
            ErrorLabel_LozinkaProvjera.IsVisible = false;
           await registracija.Init();
        
        }
        private void ime_changed(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Ime.Text))
            {
                ErrorLabel_Ime.IsVisible = true;
                ErrorLabel_Ime.Text = "Ime ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Ime.IsVisible = false;

            }

        }

        private void ime_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Ime.Text))
            {
                ErrorLabel_Ime.IsVisible = true;
                ErrorLabel_Ime.Text = "Ime ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Ime.IsVisible = false;

            }
            //ErrorLabel_Ime.Unfocus();
            //ErrorLabel_Prezime.Focus();
            
        }

        private void prezime_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Prezime.Text))
            {
                ErrorLabel_Prezime.IsVisible = true;
                ErrorLabel_Prezime.Text = "Prezime ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Prezime.IsVisible = false;


            }
            //ErrorLabel_Ime.Unfocus();
            //ErrorLabel_Prezime.Focus();

        }
        private void prezime_changed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Prezime.Text))
            {
                ErrorLabel_Prezime.IsVisible = true;
                ErrorLabel_Prezime.Text = "Prezime ne moze biti prazno polje";
            }
            else
            {
               

                ErrorLabel_Prezime.IsVisible = false;

            }
     

        }

        private void korisnickoime_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(KorisnickoIme.Text))
            {
                ErrorLabel_KorisnickoIme.IsVisible = true;
                ErrorLabel_KorisnickoIme.Text = "KorisnickoIme ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_KorisnickoIme.IsVisible = false;


            }

        }
        private void korisnickoime_changed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(KorisnickoIme.Text))
            {
                ErrorLabel_KorisnickoIme.IsVisible = true;
                ErrorLabel_KorisnickoIme.Text = "KorisnickoIme ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_KorisnickoIme.IsVisible = false;

            }
          

        }

        private void email_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Email.Text))
            {
                ErrorLabel_Email.IsVisible = true;
                ErrorLabel_Email.Text = "Email ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Email.IsVisible = false;


            }

        }
        private void email_changed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Email.Text))
            {
                ErrorLabel_Email.IsVisible = true;
                ErrorLabel_Email.Text = "Email ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Email.IsVisible = false;

            }


        }

        private void datum_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Datum.Text))
            {
                ErrorLabel_Datum.IsVisible = true;
                ErrorLabel_Datum.Text = "Datum ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Datum.IsVisible = false;


            }

        }
        private void datum_changed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Datum.Text))
            {
                ErrorLabel_Datum.IsVisible = true;
                ErrorLabel_Datum.Text = "Datum ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Datum.IsVisible = false;

            }


        }
        private void lozinka_unfocused(object sender, System.EventArgs e)
        {
          

            if (string.IsNullOrEmpty(Lozinka.Text))
            {
                ErrorLabel_Lozinka.IsVisible = true;
                ErrorLabel_Lozinka.Text = "Lozinka ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_Lozinka.IsVisible = false;
            }
            

        }
        private void lozinka_changed(object sender, System.EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (string.IsNullOrEmpty(Lozinka.Text))
            {
                ErrorLabel_Lozinka.IsVisible = true;
                ErrorLabel_Lozinka.Text = "Lozinka ne moze biti prazno polje";
            }
            else if (!hasNumber.IsMatch(Lozinka.Text) || !hasUpperChar.IsMatch(Lozinka.Text) || !hasMinimum8Chars.IsMatch(Lozinka.Text))
            {


                ErrorLabel_Lozinka.IsVisible = true;
                ErrorLabel_Lozinka.Text = "Lozinka mora imati brojeve,velika slova i minimum 8 karaktera";
            }
            else
            {
                ErrorLabel_Lozinka.IsVisible = false;
            }


        }
        private void lozinkap_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Lozinkap.Text))
            {
                ErrorLabel_LozinkaProvjera.IsVisible = true;
                ErrorLabel_LozinkaProvjera.Text = "LozinkaProvjera ne moze biti prazno polje";
            }
            else
            {
                ErrorLabel_LozinkaProvjera.IsVisible = false;


            }

        }
        private void lozinkap_changed(object sender, System.EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (string.IsNullOrEmpty(Lozinkap.Text))
            {
                ErrorLabel_LozinkaProvjera.IsVisible = true;
                ErrorLabel_LozinkaProvjera.Text = "LozinkaProvjera ne moze biti prazno polje";
            }
            else if (!hasNumber.IsMatch(Lozinkap.Text) || !hasUpperChar.IsMatch(Lozinkap.Text) || !hasMinimum8Chars.IsMatch(Lozinkap.Text))
            {


                ErrorLabel_LozinkaProvjera.IsVisible = true;
                ErrorLabel_LozinkaProvjera.Text = "LozinkaProvjera mora imati brojeve,velika slova i minimum 8 karaktera";
            }
            else
            {
                ErrorLabel_LozinkaProvjera.IsVisible = false;
            }


        }


    }
}