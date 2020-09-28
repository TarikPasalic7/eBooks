using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eKnjige.Model
{
    public class Klijent
    {


        public int KlijentID { get; set; }

        [Required]
        public string Ime { get; set; }


        [Required]
        public string Prezime { get; set; }


        [Required]
        public string KorisnickoIme { get; set; }


        [Required]
        public string Email { get; set; }

   

        public DateTime DatumRodenja { get; set; }

       

        public int SpolID { get; set; }

      


        public int GradID { get; set; }

        public int UlogaId { get; set; }

        public Uloga  Uloga { get; set; }





    }
}
