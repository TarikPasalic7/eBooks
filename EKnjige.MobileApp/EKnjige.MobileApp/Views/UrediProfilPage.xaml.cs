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
    public partial class UrediProfilPage : ContentPage
    {
        public UrediProfilPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
           
            ErrorLabel_KorisnickoIme.IsVisible = false;
            ErrorLabel_Lozinka.IsVisible = false;
            ErrorLabel_LozinkaProvjera.IsVisible = false;
          
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
        private void lozinka_unfocused(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Lozinka.Text))
            {
                ErrorLabel_Lozinka.IsVisible = true;
                ErrorLabel_Lozinka.Text = "LozinkaProvjera ne moze biti prazno polje";
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