using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
   public interface IEKnjigaService
    {

        public List<Model.EKnjiga> Get(Model.Requests.eKnjigeSearchRequest search);
        public Model.EKnjiga getById(int id);

        public Model.EKnjiga Insert(Model.Requests.EKnjigaInsertRequest request);

        public Model.EKnjiga Update(int id, Model.Requests.EKnjigaInsertRequest request);

        bool Remove(int id);

    }
}
