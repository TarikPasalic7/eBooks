using AutoMapper;
using eKnjige.WebaAPI.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class BaseService<TModel, TSearch,TDatabase> : IService<TModel, TSearch> where TDatabase: class
    {

        protected readonly AppContext db;
        protected readonly IMapper mapper;
        public BaseService(AppContext _db, IMapper m)
        {
            db = _db;
            mapper = m;
        }
        public virtual  List<TModel> Get(TSearch search)
        {

            var list = db.Set<TDatabase>().ToList();


            return mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var model = db.Set<TDatabase>().Find(id);

            return mapper.Map<TModel>(model);
        }
    }
}
