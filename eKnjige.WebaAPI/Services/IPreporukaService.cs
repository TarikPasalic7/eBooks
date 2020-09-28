using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
   public interface IPreporukaService
    {

        List<Model.EKnjiga> GetPreporuceneKnjige();
    }
}
