
using eKnjige.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    class PrijedlogKnjigeViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("PrijedlogKnjige");

        public PrijedlogKnjigeViewModel()
        {

            DodajCommand = new Command(async () => await DodajPrijedlog());
            

        }
        string _Autor = null;

        public string Autor
        {
            get { return _Autor; }
            set
            {
                SetProperty(ref _Autor, value);


            }
        }

        string _Naziv= null;

        public string Naziv
        {
            get { return _Naziv; }
            set
            {
                SetProperty(ref _Naziv, value);


            }
        }

        

     

        public ICommand DodajCommand { get; set; }
     

    

        public async  Task DodajPrijedlog()
        {
            if (string.IsNullOrEmpty(Autor) || string.IsNullOrEmpty(Naziv))
            {
                await App.Current.MainPage.DisplayAlert("Obavijest", "Morate popuniti sva polja", "OK");
                return;

            }


            PrijedlogKnjigaRequest request = new PrijedlogKnjigaRequest()
            {

                Datum = DateTime.Now,
                KlijentID = APIService.PrijavljeniKorisnik.KlijentID,
                Naziv = "Autor:" + Autor + "|  Naziv Knjige:" + Naziv,
                Odgovoren = false,
                PogledaoKorisnik=false


            };
            await App.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste poslali vaš prijedlog", "OK");
            await _service.Insert<PrijedlogKnjiga>(request);
            Autor = null;
            Naziv = null;



        }

    }
}
