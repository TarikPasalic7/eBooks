using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EKnjige.MobileApp.Views
{
    public interface IPdfService
    {
        void PdfFile(string fileName);

    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigaPDFPage : ContentPage
    {
        private string _file;
        public KnjigaPDFPage(string file)
        {
            InitializeComponent();
            _file = file;
        }

       

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<IPdfService>().PdfFile(_file);
          
        }
    }

}