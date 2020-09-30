using eKnjige.Model;
using EKnjige.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    public class LoginViewModel :BaseViewModel
    {

        private readonly APIService _service = new APIService("Klijenti");
        public LoginViewModel()
        {
            LoginCommand = new Command(async() =>
              {
                  await Login();

              });

           RegistracijaCommand = new Command(async () =>
            {
                await Registracija();

            });
        }

      

        string korisnickoime= string.Empty;
        public string KorisnickoIme
        {
            get { return korisnickoime; }
            set { SetProperty(ref korisnickoime, value); }
        }

        string lozinka = string.Empty;
        public string Lozinka
        {
            get { return lozinka; }
            set { SetProperty(ref lozinka, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegistracijaCommand { get; set; }
         async Task Registracija()
        {

             Application.Current.MainPage = new RegistracijaPage();

        }
        async Task Login()
        {
            IsBusy = true;
            APIService.username = KorisnickoIme;
            APIService.password = Lozinka;
            try
            {

                APIService.PrijavljeniKorisnik = await _service.get<Klijent>(null, "Profil");
                   if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Korisnik")
                {
                    await App.Current.MainPage.DisplayAlert("Obavijest", "Dobro došli", "OK");
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Obavijest", "Unijeli ste pogrešnu lozinku ili korisnicko ime", "OK");
                    throw new Exception("Unos nije ispravan");
                }
                
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Obavijest", "Unijeli ste pogrešnu lozinku ili korisnicko ime", "OK");
            }
        }
    }
}
