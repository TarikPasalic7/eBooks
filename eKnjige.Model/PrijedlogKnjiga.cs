using System;


namespace eKnjige.Model
{
    public class PrijedlogKnjiga
    {


        public int PrijedlogKnjigeID { get; set; }

        public DateTime Datum { get; set; }
       
        public bool Odgovoren { get; set; }
        public bool PogledaoKorisnik { get; set; }
        public string Naziv { get; set; }

        public string Opis { get; set; }


        public int KlijentID { get; set; }

     

        

      

     

       
    }
}
