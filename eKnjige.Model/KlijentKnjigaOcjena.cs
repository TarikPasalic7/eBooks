using System;


namespace eKnjige.Model
{
    public class KlijentKnjigaOcjena
    {
     
        public int KlijentKnjigaOcijenaID { get; set; }

        public DateTime DatumOcijene { get; set; }

        public float Ocjena { get; set; }

       
        public int KlijentID { get; set; }

        public Klijent Klijent { get; set; }

      

        public int EKnjigaID { get; set; }

        public EKnjiga Eknjiga { get; set; }

    }
}
