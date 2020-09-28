using EKnjige.MobileApp.UWP;
using EKnjige.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(PdfRender))]
namespace EKnjige.MobileApp.UWP
{
    public class PdfRender:IPdfService
    {


        public async void PdfFile(string fileName)

        {
            //StorageFile file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(@"file.pdf");

            StorageFolder AssetsFolder = await Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            StorageFile file = await AssetsFolder.GetFileAsync(fileName);
            await Windows.System.Launcher.LaunchFileAsync(file);

        }


    }
}
