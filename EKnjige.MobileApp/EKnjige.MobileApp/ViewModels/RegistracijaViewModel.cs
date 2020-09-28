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
    class RegistracijaViewModel: BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijenti");
        private readonly APIService _servicegrad = new APIService("Grad");
        private readonly APIService _serviceDrzava = new APIService("Drzava");
        private readonly APIService _serviceSpol = new APIService("Spol");

        public RegistracijaViewModel()
        {

            initCommand = new Command(async () => await Init());
            RegistracijaCommand = new Command(async () =>
            {
                await Registracija();

            });
        }

        public ObservableCollection<Klijent> klijentilist { get; set; } = new ObservableCollection<Klijent>();
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();

        public ObservableCollection<Spol> SpolList { get; set; } = new ObservableCollection<Spol>();


        string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        string ime = string.Empty;
        public string Ime
        {
            get { return ime; }
            set { SetProperty(ref ime, value); }
        }


        string prezime = string.Empty;
        public string Prezime
        {
            get { return prezime; }
            set { SetProperty(ref prezime, value); }
        }


        string jmbg = string.Empty;
        public string Jmbg
        {
            get { return jmbg; }
            set { SetProperty(ref jmbg, value); }
        }



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

        DateTime datumrodjenja ;
        public DateTime DatumRodenja
        {
            get { return datumrodjenja; }
            set { SetProperty(ref datumrodjenja, value); }
        }


        Grad _SelectedGrad = null;
        public Grad SelectedGrad
        {
            get { return _SelectedGrad; }
            set
            {
                SetProperty(ref _SelectedGrad, value);
                if (value != null)
                {
                    initCommand.Execute(null);
                }

            }
        }

        Spol _SelectedSpol = null;
        public Spol SelectedSpol
        {
            get { return _SelectedSpol; }
            set
            {
                SetProperty(ref _SelectedSpol, value);
                if (value != null)
                {
                    initCommand.Execute(null);
                }

            }
        }

        public ICommand initCommand { get; set; }

        public ICommand RegistracijaCommand { get; set; }

        async Task Registracija()
        {

            var request = new KlijentInsertRequest
            {
                DatumRodenja = datumrodjenja,
                SpolID = SelectedSpol.SpolID,
                Email = email,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoime,
                LozinkaHash = lozinka,
                LozinkaProvjera = lozinkaprovjera,
                GradID = SelectedGrad.Id,
                UlogaId=2,
                



            };

           var novikorisnik= await _service.Insert<Klijent>(request);

            if (novikorisnik != null)
            {
                await App.Current.MainPage.DisplayAlert("Obavijest", "Uspjesno ste se registrovali", "OK");
                APIService.PrijavljeniKorisnik = null;
                APIService.username = null;
                APIService.password = null;
                Application.Current.MainPage = new LoginPage();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Obavijest", "Registracija nije uspjela", "OK");
            }
           
        }



        public async Task Init()
        {
          

            if (GradoviList.Count == 0)
            {
                var gradovilist = await _servicegrad.get<List<Grad>>(null);
                foreach (var grad in gradovilist)
                {

                    GradoviList.Add(grad);
                }
            }

            if (SpolList.Count == 0)
            {
                var spollist = await _serviceSpol.get<List<Spol>>(null);
                foreach (var spol in spollist)
                {

                    SpolList.Add(spol);
                }
            }

           




        }
    }
}
