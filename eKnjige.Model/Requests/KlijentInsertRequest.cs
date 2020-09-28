using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKnjige.Model
{
    public class KlijentInsertRequest
    {

        public int KlijentID { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaProvjera { get; set; }

        [Required]
        public string Email { get; set; }

     

        public DateTime DatumRodenja { get; set; }


       
        public int SpolID { get; set; }

        
        public int GradID { get; set; }

        public int UlogaId { get; set; }


    }
}
