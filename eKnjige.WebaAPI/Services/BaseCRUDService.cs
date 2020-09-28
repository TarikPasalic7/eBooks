using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUptade> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUptade> where TDatabase:class
    {
        public BaseCRUDService(Data.AppContext _db, IMapper m) : base(_db, m)
        {
        }

    

        public virtual TModel Insert(TInsert request)
        {
            
         var  entity = mapper.Map<TDatabase>(request);


            //db.Set<TDatabase>().Add(k);
            db.Add(entity);
            db.SaveChanges();
            return mapper.Map<TModel>(entity);
        }

        public bool Remove(int id)
        {
            var entity = db.Set<TDatabase>().Find(id);
            if (entity != null)
            {
                db.Set<TDatabase>().Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public virtual TModel Update(int id, TUptade request)
        {
            var entity = db.Set<TDatabase>().Find(id);
            mapper.Map(request,entity);

            //db.Set<TDatabase>().Attach(entity);
            //db.Set<TDatabase>().Update(entity);

            //if (!string.IsNullOrWhiteSpace(request.Lozinka))
            //{
            //    if (request.Lozinka != request.LozinkaProvjera)
            //    {

            //        throw new System.Exception("Lozinke se ne slažu");
            //    }


            //}

            db.SaveChanges();
            //mapper.Map(request, entity);



           
            return mapper.Map<TModel>(entity);
        }
    }
}
