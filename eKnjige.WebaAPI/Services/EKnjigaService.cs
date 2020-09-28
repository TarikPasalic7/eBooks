using AutoMapper;
using eKnjige.Model;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class EKnjigaService : IEKnjigaService
    {
        private readonly AppContext db;
        private readonly IMapper mapper;

        public EKnjigaService(AppContext _db,IMapper map)
        {
            db = _db;
            mapper = map;

        }
  

        public List<Model.EKnjiga> Get(eKnjigeSearchRequest search)
        {
            var query = db.Set<EKnjiga>().AsQueryable();


            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {

                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }



            var list = query.ToList();
            return mapper.Map<List<Model.EKnjiga>>(list);

        }

        public Model.EKnjiga getById(int id)
        {
            var eknjiga = db.EKnjige.Find(id);

            return mapper.Map<Model.EKnjiga>(eknjiga);
        }

        public Model.EKnjiga Insert( Model.Requests.EKnjigaInsertRequest request)
        {
            var eknjiga = mapper.Map<EKnjiga>(request);
            db.EKnjige.Add(eknjiga);
            db.SaveChanges();
            return mapper.Map<Model.EKnjiga>(eknjiga);
        }

        public bool Remove(int id)
        {
           var entity = db.EKnjige.Where(x => x.EKnjigaID == id).FirstOrDefault();
            if (entity != null)
            {
                db.EKnjige.Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Model.EKnjiga Update(int id, EKnjigaInsertRequest request)
        {
            var entity = db.EKnjige.Where(x => x.EKnjigaID == id).FirstOrDefault();

            //db.EKnjige.Attach(entity);
            //db.EKnjige.Update(entity);

            //entity = mapper.Map(request, entity);

            entity.Cijena = request.Cijena;
            entity.Naziv = request.Naziv;
            entity.OcjenaKnjige = request.OcjenaKnjige;

            entity.Slika = request.Slika;
            entity.Opis = request.Opis;
            if (request.PDFDodan == true)
            {
                entity.PDFDodan = true;
                entity.Pdffile = request.Pdffile;

            }
            if (request.MP3Dodan == true)
            {
                entity.MP3Dodan = true;
                entity.Mp3file = request.Mp3file;

            }

            db.SaveChanges();

            return mapper.Map<Model.EKnjiga>(entity);
        }
    }
}
