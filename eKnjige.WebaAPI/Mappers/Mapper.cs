using AutoMapper;
using eKnjige.Model;
using eKnjige.WebaAPI.Database;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Mappers
{
    public class Mapper:Profile
    {

        public Mapper()
        {

            CreateMap<Klijent, Model.Klijent>().ReverseMap();
            CreateMap<Kategorija, Model.Kategorija>().ReverseMap();
            CreateMap<Kategorija, Model.Requests.KategorijaInertRequest>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloga>().ReverseMap();
            CreateMap<Database.Uloga, Model.UlogeRequest>().ReverseMap();
            CreateMap<Klijent, Model.KlijentInsertRequest>().ReverseMap();
            CreateMap<Klijent, Model.KlijentUpdateRequest>().ReverseMap();
            CreateMap<Autor, Model.Autor>().ReverseMap();
            CreateMap<Autor, Model.AutorSearchRequest>().ReverseMap();
            CreateMap<EKnjiga, Model.EKnjiga>().ReverseMap();
            CreateMap<EKnjiga, Model.Requests.EKnjigaInsertRequest>().ReverseMap();
            CreateMap<Grad, Model.Grad>().ReverseMap();
            CreateMap<Spol, Model.Spol>();
            CreateMap<Drzava, Model.DrzavaRequest>().ReverseMap();
            CreateMap<Drzava, Model.Drzava>().ReverseMap();
            CreateMap<EKnjiga, Model.Requests.eKnjigeSearchRequest>().ReverseMap();
            CreateMap<EKnjigaKategorija, Model.EKnjigaKategorija>().ReverseMap();
            CreateMap<EKnjigaKategorija, Model.EKnjigaKategorijaRequest>().ReverseMap();
            
            CreateMap<EKnjigeAutor, Model.EKnjigeAutor>().ReverseMap();
            CreateMap<EKnjigeAutor, Model.EKnjigeAutorRequest>().ReverseMap();
            CreateMap<PrijedlogKnjiga, Model.PrijedlogKnjiga>().ReverseMap();
            CreateMap<PrijedlogKnjiga, Model.PrijedlogKnjigaRequest>().ReverseMap();
            CreateMap<KupovinaKnjige, Model.KupovinaKnjige>().ReverseMap();
            CreateMap<KupovinaKnjige, Model.KupovinaKnjigeRequest>().ReverseMap();
            CreateMap<Komentar, Model.Komentar>().ReverseMap();
            CreateMap<Komentar, Model.KomentarRequest>().ReverseMap();
            CreateMap<KlijentKnjigaOcjena, Model.KlijentKnjigaOcjena>().ReverseMap();
            CreateMap<KlijentKnjigaOcjena, Model.KlijentKnjigaOcijenaRequest>().ReverseMap();

        }
    }
}
