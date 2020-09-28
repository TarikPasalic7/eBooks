using EKnjige.MobileApp.UWP;
using EKnjige.MobileApp.ViewModels;
using System;
using Windows.ApplicationModel;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioRender))]
namespace EKnjige.MobileApp.UWP
{
    public  class AudioRender:IAudioService
    {

        MediaPlayer player=null;
        public async void PlayAudioFile(string fileName)
        {
            StorageFolder AssetsFolder = await Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            StorageFile file = await AssetsFolder.GetFileAsync(fileName);
            if(player==null)
            {
                player = new MediaPlayer() { AutoPlay = false, Source = MediaSource.CreateFromStorageFile(file) };

                player.Play();
            }
           
            
        }
        public async void StopAudioFile(string fileName)
        {
          
            if(player !=null)
            {
                player.Pause();
                player = null;
            }
           
        }
    }
}
