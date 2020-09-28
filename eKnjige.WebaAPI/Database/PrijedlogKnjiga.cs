using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKnjige.WebaAPI
{
    public class PrijedlogKnjiga
    {

        [Key]

        public int PrijedlogKnjigeID { get; set; }

        public DateTime Datum { get; set; }
        
        public bool Odgovoren { get; set; }
        public bool PogledaoKorisnik { get; set; }
        public string Naziv { get; set; }

        public string Opis { get; set; }





        public Klijent Klijent { get; set; }
        public int KlijentID { get; set; }


      

       
    }
}
