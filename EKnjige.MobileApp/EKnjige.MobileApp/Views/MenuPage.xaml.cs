using EKnjige.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EKnjige.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
               
                new HomeMenuItem {Id = MenuItemType.Knjige, Title="Knjige" },
                new HomeMenuItem {Id = MenuItemType.PredloziKnjigu, Title="Predlozi Knjigu" },
                 new HomeMenuItem {Id = MenuItemType.KorisnickiProfil, Title="Korisnicki Profil" },
                   new HomeMenuItem {Id = MenuItemType.UrediProfil, Title="Uredi Profil" },
                  new HomeMenuItem {Id = MenuItemType.Logout, Title="Logout" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                if (id == (int)MenuItemType.Logout)
                {
                    APIService.PrijavljeniKorisnik = null;
                    APIService.username = null;
                    APIService.password = null;
                    Application.Current.MainPage = new LoginPage();
                    return;
                }
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}