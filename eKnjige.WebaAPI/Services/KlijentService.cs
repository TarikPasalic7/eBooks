
using AutoMapper;
using eKnjige.Model;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class KlijentService :IKlijentService
    {

        private readonly AppContext db;
        private readonly IMapper mapper;

        public KlijentService(AppContext _db, IMapper map)
        {
            db = _db;
            mapper = map;

        }


        public  List<Model.Klijent> Get(KlijentiSearchRequest search)
        {
            var query = db.Set<Klijent>().AsQueryable();


            if (!string.IsNullOrWhiteSpace(search.Ime))
            {

                query = query.Where(x => x.Ime.StartsWith(search.Ime));
            }



            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {

                query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
            }


            var list = query.ToList();
            return mapper.Map<List<Model.Klijent>>(list);


        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return System.Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = System.Convert.FromBase64String(salt);
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA512");
            byte[] inArray = algorithm.ComputeHash(dst);
            return System.Convert.ToBase64String(inArray);
        }

        public Model.Klijent Authenticiraj(string username, string pass)
        {
            var user = db.Klijenti.Include(x=>x.Uloga).Include(x=>x.Grad.Drzava).FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return mapper.Map<Model.Klijent>(user);
                }
            }
            return null;
        }




        public Model.Klijent GetbyId(int id)
        {
            var k = db.Klijenti.Find(id);

            return mapper.Map<Model.Klijent>(k);
        }

        //public List<Model.Klijent> Get(KlijentiSearchRequest search)
        //{
        //    var query = db.Klijenti.AsQueryable();

        //    if (!string.IsNullOrWhiteSpace(search.Ime))
        //    {

        //        query = query.Where(x => x.Ime.StartsWith(search.Ime));
        //    }



        //    if (!string.IsNullOrWhiteSpace(search.Prezime))
        //    {

        //        query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
        //    }


        //    var list = query.ToList();
        //    return mapper.Map<List<Model.Klijent>>(list);
        //}

        //***************************************//
        public Model.Klijent Insert(Model.KlijentInsertRequest request)
        {

            var k = mapper.Map<Klijent>(request);


            db.Add(k);


            if (request.LozinkaHash != request.LozinkaProvjera)
            {
                throw new System.Exception("Lozinka i potvrda se ne slažu");
            }

            k.LozinkaSalt = GenerateSalt();
            k.LozinkaHash = GenerateHash(k.LozinkaSalt, k.LozinkaHash);

            db.SaveChanges();




            return mapper.Map<Model.Klijent>(k);
        }



        //***************************************//

        public Model.Klijent Update(int id, KlijentUpdateRequest request)
        {
            var k = db.Klijenti.Find(id);


            //db.Klijenti.Attach(k);
            //db.Klijenti.Update(k);

            //mapper.Map(k, request);
            k.Ime = request.Ime;
            k.KorisnickoIme = request.KorisnickoIme;
            k.Prezime = request.Prezime;
            k.SpolID = request.SpolID;
            k.GradID = request.GradID;
            k.UlogaID = request.UlogaId;
            
            k.Email = request.Email;
            
            //k = mapper.Map<Klijent>(request);


            db.SaveChanges();
            return mapper.Map<Model.Klijent>(k);

        }

        public Model.Klijent Profil()
        {
            var query = db.Klijenti.AsQueryable();


            
            query = query.Where(x => x.KlijentID==Security.BasicAuthenticationHandler.PrijavljeniKlijent.KlijentID);

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.Uloga);

            var entity = query.FirstOrDefault();

            return mapper.Map<Model.Klijent>(entity);
        }

      

        public Model.Klijent UpdateProfile(KlijentInsertRequest request)
        {
            int KlijentId = Security.BasicAuthenticationHandler.PrijavljeniKlijent.KlijentID;

            var entity = db.Klijenti.Where(x => x.KlijentID == KlijentId).FirstOrDefault();

            //db.Klijenti.Attach(entity);
            //db.Klijenti.Update(entity);

            if (!string.IsNullOrEmpty(request.LozinkaHash))
            {
                if (request.LozinkaHash != request.LozinkaProvjera)
                {
                    throw new System.Exception("Lozinke se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.LozinkaHash);
            }

            entity.KorisnickoIme = request.KorisnickoIme;
           

            db.SaveChanges();

            return mapper.Map<Model.Klijent>(entity);
        }
    }
}
