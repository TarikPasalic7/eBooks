using eKnjige.WebaAPI.Database;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKnjige.WebaAPI
{
    public class Klijent
    {
        [Key]
        public int KlijentID { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public string Email { get; set; }

     

        public DateTime DatumRodenja { get; set; }


        [ForeignKey("Spol")]
        public int SpolID { get; set; }

        public Spol Spol { get; set; }

        [ForeignKey("Grad")]
        public int GradID { get; set; }

        public Grad Grad { get; set; }


        
       

        public Uloga Uloga { get; set; }

        public int UlogaID { get; set; }



    }
}
