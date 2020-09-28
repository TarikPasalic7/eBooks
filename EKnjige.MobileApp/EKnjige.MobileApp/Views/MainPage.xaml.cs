using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EKnjige.MobileApp.Models;
using eKnjige.Model;

namespace EKnjige.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }
        private readonly APIService _service = new APIService("PrijedlogKnjige");
        protected async override void OnAppearing()
        {
             

            base.OnAppearing();
        var prijedlozi =await _service.get<List<PrijedlogKnjiga>>(null);
            int korisnikid = APIService.PrijavljeniKorisnik.KlijentID;
            
            foreach(var p in prijedlozi)
            {
                if(korisnikid==p.KlijentID && p.Odgovoren==true && p.PogledaoKorisnik==false)
                {
                    await App.Current.MainPage.DisplayAlert("Obavijest", p.Opis, "OK");
                    var request = new PrijedlogKnjigaRequest()
                    {
                        Datum = p.Datum,
                        Naziv = p.Naziv,
                        KlijentID = p.KlijentID,
                        Odgovoren = p.Odgovoren,
                        Opis = p.Opis,
                        PrijedlogKnjigeID = p.PrijedlogKnjigeID,
                        PogledaoKorisnik = true

                    };
                    await _service.Update<PrijedlogKnjiga>(p.PrijedlogKnjigeID, request);
                }


            }

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
             
                    case (int)MenuItemType.Knjige:
                        MenuPages.Add(id, new NavigationPage(new KnjigePage()));
                        break;
                    case (int)MenuItemType.PredloziKnjigu:
                        MenuPages.Add(id, new NavigationPage(new  PrijedlogKnjigePage()));
                        break;
                    case (int)MenuItemType.KorisnickiProfil:
                        MenuPages.Add(id, new NavigationPage(new ProfilPage()));
                        break;
                    case (int)MenuItemType.UrediProfil:
                        MenuPages.Add(id, new NavigationPage(new UrediProfilPage()));
                        break;
                    case (int)MenuItemType.Logout:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}