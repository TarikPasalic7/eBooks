
using AutoMapper;
using eKnjige.WebaAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly AppContext _context;

        private readonly IMapper _mapper;

        private int pozitivnaOcjena = 3;
        private int brojRezultata = 3;

        public PreporukaService(AppContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.EKnjiga> GetPreporuceneKnjige()
        {
            int KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKlijent.KlijentID;

            try
            {
                if (KorisnikId == 0)
                {
                    throw new System.Exception();
                }

                List<KlijentKnjigaOcjena> listaOcjena = _context.KlijentKnjigaOcjene.Where(x => x.KlijentID == KorisnikId)
                    .Include(x=>x.Klijent)
                    .Include(x => x.Eknjiga)
                    .ToList();

                List<KlijentKnjigaOcjena> listaPozitivnihOcjena = listaOcjena
                    .Where(x => x.Ocjena >= pozitivnaOcjena)
                    .ToList();

                if (listaPozitivnihOcjena.Count() > 0)
                {
                    List<Kategorija> jedinstveneKategorije = new List<Kategorija>();
                    foreach (var item in listaPozitivnihOcjena)
                    {
                        var knjigaKategorije = _context.EKnjigaKategorije.Where(m => m.EKnjigaID == item.EKnjigaID)
                            .Select(g => g.Kategorija)
                            .ToList();

                        foreach (var Kategorija in knjigaKategorije)
                        {
                            
                            bool dodaj = true;
                            for (int i = 0; i < jedinstveneKategorije.Count; i++)
                            {
                                if (Kategorija.Naziv == jedinstveneKategorije[i].Naziv)
                                {
                                    dodaj = false;
                                }
                            }

                            if (dodaj)
                            {
                                jedinstveneKategorije.Add(Kategorija);
                            }
                        }
                    }

                    List<EKnjiga> konacnaLista = new List<EKnjiga>();
                    foreach (var item in jedinstveneKategorije)
                    {
                        var knjigeUKategoriji = _context.EKnjigaKategorije
                            .Where(g => g.KategorijaID == item.KategorijaID)
                            .Select(x => x.Eknjiga)
                            .ToList();

                        foreach (var knjiga in knjigeUKategoriji)
                        {
                            bool dodaj = true;
                            for (int i = 0; i < konacnaLista.Count; i++)
                            {
                                if (knjiga.Naziv == konacnaLista[i].Naziv)
                                {
                                    dodaj = false;
                                }

                            }

                            foreach (var ocjena in listaOcjena)
                            {
                                if (knjiga.Naziv == ocjena.Eknjiga.Naziv)
                                {
                                    dodaj = false;
                                }
                            }

                            if (dodaj)
                            {
                                konacnaLista.Add(knjiga);
                            }
                        }
                    }

                    konacnaLista = konacnaLista.OrderByDescending(x=>x.OcjenaKnjige).Take(brojRezultata).ToList();

                   
                    List<Model.EKnjiga> listaKnjiga = _mapper.Map<List<Model.EKnjiga>>(konacnaLista);
                   

                    return listaKnjiga;
                }
                throw new System.Exception();
            }
            catch
            {/*media => System.Guid.NewGuid()*/
                var lista = _context.EKnjige.OrderByDescending(x=>x.OcjenaKnjige).Take(brojRezultata).ToList();

                // ucitavanje slika za svaku igru
                List<Model.EKnjiga> listaKnjiga = _mapper.Map<List<Model.EKnjiga>>(lista);
             

                return listaKnjiga;
            }
        }

       
    }
}
