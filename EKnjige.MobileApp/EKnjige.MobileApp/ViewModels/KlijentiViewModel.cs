using eKnjige.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    public class KlijentiViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijenti");
        private readonly APIService _servicegrad = new APIService("Grad");

        public KlijentiViewModel()
        {
            initCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Klijent> klijentilist { get; set; } = new ObservableCollection<Klijent>();
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();


        Grad _SelectedGrad = null;
        public Grad SelectedGrad
        {
            get { return _SelectedGrad; }
            set { SetProperty(ref _SelectedGrad, value);
                if (value != null)
                {
                    initCommand.Execute(null);
                }
                
            }
        }

        public ICommand initCommand { get; set; }

        public async Task Init()
        {
            //var klijenti = await _service.get<IEnumerable<Klijent>>(null);
            //klijentilist.Clear();
            //foreach(var klijent in klijenti)
            //{

            //    klijentilist.Add(klijent);
            //}
            
            if (GradoviList.Count == 0)
            {
                var gradovilist = await _servicegrad.get<List<Grad>>(null);
                foreach (var grad in gradovilist)
            {

                GradoviList.Add(grad);
            }
                   }
          
            if(SelectedGrad != null)
            {
                eKnjige.Model.Requests.KlijentiSearchRequest search = new eKnjige.Model.Requests.KlijentiSearchRequest();
                search.GradID = SelectedGrad.Id;

                var klijenti = await _service.get<IEnumerable<Klijent>>(search);
                klijentilist.Clear();
                foreach (var klijent in klijenti)
                {
                    klijentilist.Add(klijent);
                }

            }
           
            

           
        }
    }
}
