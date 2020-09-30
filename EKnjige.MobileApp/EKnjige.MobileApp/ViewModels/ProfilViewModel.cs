using eKnjige.Model;
using EKnjige.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    class ProfilViewModel:BaseViewModel
    {

        private readonly APIService _serviceknjige = new APIService("EKnjiga");
        private readonly APIService _serviceKategorije = new APIService("Kategorija");
        private readonly APIService _serviceEknjigaKategorija = new APIService("EknjigaKategorija");
        private readonly APIService _serviceKnjigeAutor = new APIService("EKnjigaAutor");
        private readonly APIService _serviceKupovinaKnjige = new APIService("KupovinaKnjige");
        private readonly APIService _serviceAutori = new APIService("Autor");
        private readonly APIService _service = new APIService("Klijenti");
        private string _ImePrezime;
        private string _KorisnickoIme;


        public ProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<EknjigaMobile> KnjigaList { get; set; } = new ObservableCollection<EknjigaMobile>();

        public string ImePrezime
        {
            get { return _ImePrezime; }
            set { SetProperty(ref _ImePrezime, value); }
        }

        public string KorisnickoIme
        {
            get { return _KorisnickoIme; }
            set { SetProperty(ref _KorisnickoIme, value); }
        }

      




        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
          
                var eknjigakupovina = await _serviceKupovinaKnjige.get<List<KupovinaKnjige>>(null);
            var eknjigaKategorija = await _serviceEknjigaKategorija.get<List<EKnjigaKategorija>>(null);
            KnjigaList.Clear();
           
                var eknjigaautorilist = await _serviceKnjigeAutor.get<List<EKnjigeAutor>>(null);

                List<EknjigaMobile> knjigamobileList = await _serviceknjige.get<List<EknjigaMobile>>(null);


            Klijent korisnik = await _service.getbyId<Klijent>(APIService.PrijavljeniKorisnik.KlijentID);
            ImePrezime = korisnik.Ime + " "+ korisnik.Prezime;
            KorisnickoIme = korisnik.KorisnickoIme;

            foreach (var e in knjigamobileList)
                {
                    //e.Kategorije = null;
                    //e.Kategorije = new List<Kategorija>();
                    foreach (var kk in eknjigaKategorija)
                    {

                        if (kk.EKnjigaID == e.EKnjigaID)
                        {
                            var kategorija = await _serviceKategorije.getbyId<Kategorija>(kk.KategorijaID);

                            e.Kategorije += kategorija.Naziv;
                            e.Kategorije += "  ";
                        }
                    }


                }
                foreach (var e in knjigamobileList)
                {
                    //e.Autori = null;
                    //e.Autori = new List<Autor>();
                    foreach (var ea in eknjigaautorilist)
                    {

                        if (ea.EKnjigaID == e.EKnjigaID)
                        {
                            var autor = await _serviceAutori.getbyId<Autor>(ea.AutorID);

                            e.Autori += autor.Ime + " " + autor.Prezime + ",";
                        }
                    }


                }




            foreach (var e in knjigamobileList)
            {
                
                foreach (var kk in eknjigakupovina)
                {

                    if (APIService.PrijavljeniKorisnik.KlijentID == kk.KlijentID && e.EKnjigaID == kk.EKnjigaID)
                    {
                        e.OcjenaKnjige = (float)Math.Round(e.OcjenaKnjige * 10f) / 10f;
                        KnjigaList.Add(e);

                    }
                }

               
            }

        }

        
    }
}
