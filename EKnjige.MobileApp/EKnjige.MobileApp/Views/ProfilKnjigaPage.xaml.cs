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

    public partial class ProfilKnjigaPage :  ContentPage
    {

        private ProfilKnjigaViewModel model = null;
        public ProfilKnjigaPage(EknjigaMobile eknjiga)
        {
            InitializeComponent();
            BindingContext = model = new ProfilKnjigaViewModel()
            {
                EKnjiga = eknjiga

            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (model.EKnjiga.Pdffile == null)
                pdf.IsVisible = false;
            if (model.EKnjiga.Mp3file == null)
            {
                play.IsVisible = false;
                stop.IsVisible = false;

            }

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as EknjigaMobile;
           
            await Navigation.PushAsync(new KnjigaDetailPage(item));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new KnjigaPDFPage(model.EKnjiga.Pdffile));
        }
    }
}