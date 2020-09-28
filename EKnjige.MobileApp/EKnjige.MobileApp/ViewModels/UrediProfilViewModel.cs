using eKnjige.Model;
using EKnjige.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
   public class UrediProfilViewModel :BaseViewModel
    {

        private readonly APIService _service = new APIService("Klijenti");
      

        public UrediProfilViewModel()
        {

            //initCommand = new Command(async () => await Init());
           SnimiCommand = new Command(async () =>
            {
                await Snimi();

            });
        }

        public ObservableCollection<Klijent> klijentilist { get; set; } = new ObservableCollection<Klijent>();




        string korisnickoime = string.Empty;
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

        string lozinkaprovjera = string.Empty;
        public string LozinkaProvjera
        {
            get { return lozinkaprovjera; }
            set { SetProperty(ref lozinkaprovjera, value); }
        }

        public ICommand initCommand { get; set; }

        public ICommand SnimiCommand { get; set; }

        async Task Snimi()
        {

            int id=APIService.PrijavljeniKorisnik.KlijentID;
            Klijent korisnikrequest = await _service.getbyId<Klijent>(id);
            
            
                if (!string.IsNullOrEmpty(lozinka) && !string.IsNullOrEmpty(lozinkaprovjera))
                {
                if (string.IsNullOrEmpty(korisnickoime))
                {
                    korisnickoime = korisnikrequest.KorisnickoIme;
                }

                    var request = new KlijentInsertRequest
                    {


                        DatumRodenja = korisnikrequest.DatumRodenja,
                        SpolID = korisnikrequest.SpolID,
                        Email = korisnikrequest.Email,
                        Ime = korisnikrequest.Ime,
                        Prezime = korisnikrequest.Prezime,
                        KorisnickoIme = korisnickoime,
                        LozinkaHash = lozinka,
                        LozinkaProvjera = lozinkaprovjera,
                        GradID = korisnikrequest.GradID,
                        UlogaId = 2,




                    };
                    if (lozinka != lozinkaprovjera)
                    {
                        await App.Current.MainPage.DisplayAlert("Obavijest", "Lozinke nisu iste", "OK");
                    }
                    else
                    {
                    await _service.UpdateProfie<Klijent>(request,"UpdateProfile");
                    APIService.password = lozinka;
                    APIService.username = korisnickoime;
                    await App.Current.MainPage.DisplayAlert("Obavijest", "Uspjesno ste promjenili lozinku", "OK");
                }
                }
            else
            {
                var request = new KlijentInsertRequest
                {


                    DatumRodenja = korisnikrequest.DatumRodenja,
                    SpolID = korisnikrequest.SpolID,
                    Email = korisnikrequest.Email,
                    Ime = korisnikrequest.Ime,
                    Prezime = korisnikrequest.Prezime,
                    KorisnickoIme = korisnickoime,
                    GradID = korisnikrequest.GradID,
                    UlogaId = 2,




                };

                await _service.Update<Klijent>(id, request);
                APIService.username = korisnickoime;
                await App.Current.MainPage.DisplayAlert("Obavijest", "Uspjesno ste promijenili korisnicko ime", "OK");

            }

            
          

            

           

                Application.Current.MainPage = new MainPage();
           

        }



    }
}
