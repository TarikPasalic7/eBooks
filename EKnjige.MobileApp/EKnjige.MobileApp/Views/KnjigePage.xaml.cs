using eKnjige.Model;
using EKnjige.MobileApp.Models;
using EKnjige.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EKnjige.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigePage : ContentPage
    {

        KnjigeViewModel model = null;
        public KnjigePage()
        {
            InitializeComponent();
            BindingContext = model = new KnjigeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
          await  model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as EknjigaMobile;
            await Navigation.PushAsync(new KnjigaDetailPage(item));
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            APIService api = new APIService("eknjiga");
            APIService _serviceKnjigeAutor = new APIService("EKnjigaAutor");
            APIService _serviceEknjigeKategorija = new APIService("EKnjigaKategorija");
            APIService _serviceKategorije = new APIService("Kategorija");
            APIService _serviceAutori = new APIService("Autor");
            List<EknjigaMobile> list = new List<EknjigaMobile>(model.KnjigaList);
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                foreach (var k in list)
                {
                    if (!k.Naziv.Contains(e.NewTextValue))
                        model.KnjigaList.Remove(k);

                }

            }
            else
            {
                var klist = await api.get<List<EknjigaMobile>>(null);
                var eknjigaautorilist = await _serviceKnjigeAutor.get<List<EKnjigeAutor>>(null);
                var eknjigakategorijaList = await _serviceEknjigeKategorija.get<List<EKnjigaKategorija>>(null);
                foreach (var k in klist)
                {

                    foreach (var kk in eknjigakategorijaList)
                    {

                        if (kk.EKnjigaID == k.EKnjigaID)
                        {
                            var kategorija = await _serviceKategorije.getbyId<Kategorija>(kk.KategorijaID);

                            k.Kategorije += kategorija.Naziv;
                            k.Kategorije += "  ";
                        }
                    }


                }
                foreach (var k in klist)
                {

                    foreach (var ea in eknjigaautorilist)
                    {

                        if (ea.EKnjigaID == k.EKnjigaID)
                        {
                            var autor = await _serviceAutori.getbyId<Autor>(ea.AutorID);

                            k.Autori += autor.Ime + " " + autor.Prezime + ",";
                        }
                    }


                }

                foreach (var k in klist)
                {
                    k.OcjenaKnjige = (float)Math.Round(k.OcjenaKnjige * 10f) / 10f;
                    model.KnjigaList.Add(k);

                }
                //await model.Init();
            }
        }

    }
}