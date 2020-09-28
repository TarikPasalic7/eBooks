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
    public partial class ProfilPage : ContentPage
    {

        private ProfilViewModel model = null;
        public ProfilPage()
        {
           
            InitializeComponent();
            BindingContext = model = new ProfilViewModel();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as EknjigaMobile;
            await Navigation.PushAsync(new ProfilKnjigaPage(item));
        }
    }
}