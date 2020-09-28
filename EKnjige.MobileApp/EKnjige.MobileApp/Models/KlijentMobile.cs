using eKnjige.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EKnjige.MobileApp.Models
{
    class KlijentMobile
    {

        public int KlijentID { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public string Email { get; set; }

     

        public DateTime DatumRodenja { get; set; }


       
        public int SpolID { get; set; }

        public Spol Spol { get; set; }

       
        public int GradID { get; set; }

        public Grad Grad { get; set; }





        public Uloga Uloga { get; set; }

        public int UlogaID { get; set; }

    }
}
