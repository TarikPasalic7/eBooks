using eKnjige.Model;
using EKnjige.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    class KnjigeViewModel :BaseViewModel
    {

        private readonly APIService _serviceknjige= new APIService("EKnjiga");
        private readonly APIService _serviceKategorije = new APIService("Kategorija");
        private readonly APIService _serviceKnjigeAutor = new APIService("EKnjigaAutor");
        private readonly APIService _serviceEknjigeKategorija = new APIService("EKnjigaKategorija");
        private readonly APIService _serviceAutori = new APIService("Autor");



        public KnjigeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<EknjigaMobile> KnjigaList { get; set; } = new ObservableCollection<EknjigaMobile>();
        public ObservableCollection<Kategorija> KategorijaList { get; set; } = new ObservableCollection<Kategorija>();

        Kategorija _selectedKategorija = null;

        public Kategorija SelectedKategorija
        {
            get { return _selectedKategorija; }
            set
            {
                SetProperty(ref _selectedKategorija, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if (KategorijaList.Count == 0)
            {
                var kategorijaList = await _serviceKategorije.get<List<Kategorija>>(null);

                foreach (var k in kategorijaList)
                {
                   KategorijaList.Add(k);
                }
            }

            if (SelectedKategorija != null)
            {


                var eknjigakategorijaList = await _serviceEknjigeKategorija.get<List<EKnjigaKategorija>>(null);
                KnjigaList.Clear();
                var kategotijalist= await _serviceKategorije.get<List<Kategorija>>(null);
                var eknjigaautorilist = await _serviceKnjigeAutor.get<List<EKnjigeAutor>>(null);

                List<EknjigaMobile> knjigamobileList = await _serviceknjige.get<List<EknjigaMobile>>(null);
                foreach(var e in knjigamobileList)
                {
                    //e.Kategorije = null;
                    //e.Kategorije = new List<Kategorija>();
                    foreach (var kk in eknjigakategorijaList)
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

                foreach(var m in knjigamobileList)
                {
                    foreach (var item in eknjigakategorijaList)
                    {
                        if (item.KategorijaID == SelectedKategorija.KategorijaID && m.EKnjigaID==item.EKnjigaID)
                        {
                          


                            KnjigaList.Add(m);
                        }


                    }

                }

               
            }
            else
            {
              
               

                var eknjigakategorijaList = await _serviceEknjigeKategorija.get<List<EKnjigaKategorija>>(null);
                KnjigaList.Clear();
                var kategotijalist = await _serviceKategorije.get<List<Kategorija>>(null);
                var eknjigaautorilist = await _serviceKnjigeAutor.get<List<EKnjigeAutor>>(null);

                List<EknjigaMobile> knjigamobileList = await _serviceknjige.get<List<EknjigaMobile>>(null);
                
                foreach (var e in knjigamobileList)
                {
                    //e.Kategorije = null;
                    //e.Kategorije = new List<Kategorija>();
                    foreach (var kk in eknjigakategorijaList)
                    {

                        if (kk.EKnjigaID == e.EKnjigaID )
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



                foreach (var item in knjigamobileList)
                {
                    
                        
                        KnjigaList.Add(item);
                    

                }

            }

        }



    }
}
