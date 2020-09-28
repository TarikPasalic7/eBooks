using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKnjige.Model
{
    public class KlijentUpdateRequest
    {


        public int KlijentID { get; set; }

        public string Ime { get; set; }

        
        public string Prezime { get; set; }

       
        public string KorisnickoIme { get; set; }

      

        public string Email { get; set; }


        public DateTime DatumRodenja { get; set; }


       
        public int SpolID { get; set; }

        
        public int GradID { get; set; }

        public int UlogaId { get; set; }


    }
}
