using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
   public  interface IKlijentService
    {
        //public List<Model.Klijent> Get();

        public List<Model.Klijent> Get(Model.Requests.KlijentiSearchRequest search);
        public Model.Klijent GetbyId(int id);

        public Model.Klijent Insert(Model.KlijentInsertRequest request);

        public Model.Klijent Update(int id, Model.KlijentUpdateRequest request);

        public Model.Klijent Authenticiraj(string username, string pass);

        public Model.Klijent Profil();

       public Model.Klijent UpdateProfile(Model.KlijentInsertRequest request);
    }
}
