
using eKnjige.Model;
using eKnjige.Model.Requests;
using EKnjige.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace EKnjige.MobileApp.ViewModels
{
    public interface IAudioService
    {
        void PlayAudioFile(string fileName);
        void StopAudioFile(string fileName);
    }
    class ProfilKnjigaViewModel:BaseViewModel
    {

        readonly APIService _serviceOcjenaEknjige = new APIService("EKnjigaOcjena");
        readonly APIService _service = new APIService("EKnjiga");
        readonly APIService _servicePreporuka = new APIService("Preporuka");
        #region stars

        private Star _star1;
        public Star Star1
        {
            get { return _star1; }
            set { SetProperty(ref _star1, value); }
        }
        private Star _star2;
        public Star Star2
        {
            get { return _star2; }
            set { SetProperty(ref _star2, value); }
        }
        private Star _star3;
        public Star Star3
        {
            get { return _star3; }
            set { SetProperty(ref _star3, value); }
        }
        private Star _star4;
        public Star Star4
        {
            get { return _star4; }
            set { SetProperty(ref _star4, value); }
        }
        private Star _star5;
        public Star Star5
        {
            get { return _star5; }
            set { SetProperty(ref _star5, value); }
        }
        #endregion

        public ObservableCollection<EknjigaMobile> PreporuceneKnjigeList { get; set; } = new ObservableCollection<EknjigaMobile>();

        public ProfilKnjigaViewModel()
        {
            OcijeniStarCommand = new Command<string>(async (Ocjena) => await OcijeniStar(Ocjena));
            PlayCommand = new Command(async () => await Play());
            StopCommand = new Command(async () => await Stop());

            Star1 = new Star();
            Star2 = new Star();
            Star3 = new Star();
            Star4 = new Star();
            Star5 = new Star();
        }
        public EknjigaMobile EKnjiga { get; set; }
        public int Ocjena { get; set; }
        public ICommand OcijeniStarCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand PlayCommand { get; set; }
        public ICommand StopCommand { get; set; }


        public async Task Play()
        {

            DependencyService.Get<IAudioService>().PlayAudioFile(EKnjiga.Mp3file);

        }
        public async Task Stop()
        {

            DependencyService.Get<IAudioService>().StopAudioFile(EKnjiga.Mp3file);

        }

        private async Task OcijeniStar(string _ocjena)
        {
            int OcjenaBroj = int.TryParse(_ocjena, out int value) ? value : 0;
            if (OcjenaBroj >= 1 && OcjenaBroj <= 5)
            {
                float sum = 0;
                int count = 0;
                var ocjena =await  _serviceOcjenaEknjige.get<List<KlijentKnjigaOcjena>>(null);
                int ocjenaID = 0;
                foreach (var o in ocjena)
                {
                    if (o.EKnjigaID == EKnjiga.EKnjigaID && o.KlijentID==APIService.PrijavljeniKorisnik.KlijentID)
                    {
                        ocjenaID = o.KlijentKnjigaOcijenaID;

                    }


                }
                var ocjenarequest = new KlijentKnjigaOcjena()
                {
                    EKnjigaID = EKnjiga.EKnjigaID,
                    KlijentID = APIService.PrijavljeniKorisnik.KlijentID,
                    DatumOcijene = DateTime.Now,
                    Ocjena = OcjenaBroj
                };
                if (ocjenaID != 0)
                {
                    ocjenarequest.KlijentKnjigaOcijenaID = ocjenaID;
                    await _serviceOcjenaEknjige.Update<KlijentKnjigaOcijenaRequest>(ocjenaID, ocjenarequest);
                    
                }
                else
                {
                    await _serviceOcjenaEknjige.Insert<KlijentKnjigaOcijenaRequest>(ocjenarequest);

                }
                var ocjena2 = await _serviceOcjenaEknjige.get<List<KlijentKnjigaOcjena>>(null);
                foreach (var o2 in ocjena2)
                {
                    if (o2.EKnjigaID == EKnjiga.EKnjigaID)
                    {
                        sum += o2.Ocjena;
                        count++;

                    }


                }
                float prosjek = sum / count;
                var request = new EKnjigaInsertRequest()
                {
                    Slika = EKnjiga.Slika,
                    Cijena = EKnjiga.Cijena,
                    OcjenaKnjige = prosjek,
                    Opis = EKnjiga.Opis,
                    PDFDodan = EKnjiga.PDFDodan,
                    MP3Dodan = EKnjiga.MP3Dodan,
                    Mp3file = EKnjiga.Mp3file,
                    Pdffile = EKnjiga.Pdffile,
                    Naziv = EKnjiga.Naziv
                };
                

             

                Ocjena = OcjenaBroj;
                 await _service.Update<EKnjigaInsertRequest>(EKnjiga.EKnjigaID, request);

              await  App.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste ocjenili knjigu", "OK");
                UpdateStar();

                
            }
        }

        private void UpdateStar()
        {
            var star_emptyinside = new Star { Slika = "star_empty.png" };
            var Star_Filled = new Star { Slika = "star_filled.png" };

            Star1 = star_emptyinside;
            Star2 = star_emptyinside;
            Star3 = star_emptyinside;
            Star4 = star_emptyinside;
            Star5 = star_emptyinside;

            if (Ocjena >= 1)
                Star1 = Star_Filled;
            if (Ocjena >= 2)
                Star2 = Star_Filled;
            if (Ocjena >= 3)
                Star3 = Star_Filled;
            if (Ocjena >= 4)
                Star4 = Star_Filled;
            if (Ocjena == 5)
                Star5 = Star_Filled;
        }
        public async Task Init()
        {
            

            UpdateStar();
            List<EknjigaMobile> listknjge = await _servicePreporuka.get<List<EknjigaMobile>>(null, "GetPreporuceneKnjige");

            PreporuceneKnjigeList.Clear();
            foreach (var item in listknjge)
            {
                PreporuceneKnjigeList.Add(item);
            }

        }

    }
}
