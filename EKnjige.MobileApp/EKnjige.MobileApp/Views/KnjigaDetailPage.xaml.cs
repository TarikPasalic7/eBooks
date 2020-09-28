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
    public partial class KnjigaDetailPage : ContentPage
    {
        private KnjigaDetailViewModel model=null;
        public KnjigaDetailPage(EknjigaMobile eknjiga) 
        {
            InitializeComponent();
            BindingContext = model = new KnjigaDetailViewModel(this.Navigation)
            {
                EKnjiga = eknjiga
                
            };
            
        }

        protected async override void OnAppearing()
        {
            
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var button = sender as Button;
            var komentar = button?.BindingContext as Komentar;

            await model.Obrisi(komentar);

        }
    }
}